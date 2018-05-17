//
//  QDSApi.h
//  QDSApi
//
//  Created by QYS on 2018/4/24.
//  Copyright © 2018年 QYS. All rights reserved.
//

#ifndef QDSApi_h
#define QDSApi_h

/* The classes below are exported */
#pragma GCC visibility push(default)

// 导出类宏定义
#ifdef _WIN32
#define _CDECL         __cdecl
#ifdef PRJ_QDS_API
#define QDS_API_EXPORT __declspec(dllexport)
#else
#define QDS_API_EXPORT __declspec(dllimport)
#endif

#else
#define _CDECL
#define QDS_API_EXPORT
#ifndef __stdcall
#define __stdcall
#endif
#endif

#include "QDSDataType.h"

#ifndef __cplusplus
typedef int bool;
const bool true=1;
const bool false=0;

#if 0
typedef enum RetCode RetCode;
typedef enum MsgType MsgType;
#else
typedef int RetCode;
typedef int MsgType;
#endif
#endif

#ifdef __cplusplus
extern "C" {
#endif

QDS_API_EXPORT void CreateInstance();

/**
 警告：请勿在回调函数接口内执行耗时操作，如：复杂运算，写文件等；否则会堵塞数据的接收。
 建议处理方式：把接收到的数据放至队列，再由工作线程处理接收到的数据内容；
 */
#if 1
	typedef void * pOnData_t;
#else
	typedef char * pOnData_t;
#endif
typedef void (*funcOnData)(const pOnData_t pData);
QDS_API_EXPORT void setFuncOnData(MsgType msgType, funcOnData func);
	
QDS_API_EXPORT const char * QDSTimeToStr(unsigned long long us);
	
/// 注册行情服务器地址
/// @param  pIP         -- 服务器地址.
/// @param  uPort       -- 服务器端口.
/// @return RetCode     -- 错误代码
QDS_API_EXPORT RetCode RegisterService(const char* pIP, unsigned short uPort);

/// 连接行情服务器，发送用户认证信息，同步请求
/// @param  pUserName   -- 账号名称
/// @param  bWAN        -- 公网连接标志：true - 公网连接
/// @return RetCode     -- 错误代码
QDS_API_EXPORT RetCode Login2(const char* pUserName, bool bWAN);

/// 连接行情服务器，发送用户认证信息，同步请求
/// @param  publicKey   -- 用户公钥
/// @param  secretKey   -- 用户私钥
/// @param  bWAN        -- 公网连接标志：true - 公网连接
/// @return RetCode     -- 错误代码
QDS_API_EXPORT RetCode Login(const char *publicKey, const char *secretKey, bool bWAN);

/// 订阅行情，重复订阅同一个数据多次时取并集
/// @param  msgType     -- 需要订阅的数据类型
/// @param  pCodeList   -- 个股订阅列表，以“,”分割，末尾必须以\0结束，为NULL时订阅全市场
/// @return RetCode     -- 错误代码
QDS_API_EXPORT RetCode Subscribe(MsgType msgType, char* pCodeList);

/// 取消订阅
/// @param  msgType     -- 需要取消订阅的数据类型
/// @param  pCodeList   -- 取消个股列表，以“,”分割，末尾必须以\0结束，为NULL时取消所有代码
/// @return RetCode     -- 错误代码
QDS_API_EXPORT RetCode Unsubscribe(MsgType msgType, char* pCodeList);

/// 取消所有订阅信息
/// @return RetCode     -- 错误代码
QDS_API_EXPORT RetCode UnsubscribeAll();

/// 释放一个实例,该实例是通过CreateInstance生成的.
/// @param  pInstance   -- 实例对象指针.
QDS_API_EXPORT void ReleaseInstance();
	
#ifdef __cplusplus
}
#endif

#endif /* QDSApi_h */

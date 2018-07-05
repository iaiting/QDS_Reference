//
//  QDSApi.hpp
//  QDSApi
//
//  Copyright © 2017-2019 QYS. All rights reserved.
//

#ifndef QDSApi_
#define QDSApi_

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

#include "QDSApiCallbackBase.h"

#include <string>
using namespace std;

class QDSApi
{
public:
	QDS_API_EXPORT static QDSApi* CreateInstance(QDSApiCallbackBase& CallBack, bool bStdout = false);
	
	/// 注册行情服务器地址
	/// @param  pIP         -- 服务器地址.
	/// @param  uPort       -- 服务器端口.
	/// @return RetCode     -- 错误代码
	virtual RetCode RegisterService(const char* pIP, unsigned short uPort);
	
	/// 连接行情服务器，发送用户认证信息，同步请求
	/// @param  pUserName   -- 账号名称
	/// @param  bWAN        -- 公网连接标志：true - 公网连接
	/// @return RetCode     -- 错误代码
	virtual RetCode Login(const char* pUserName, bool bWAN=false);

	/// 连接行情服务器，发送用户认证信息，同步请求
	/// @param  publicKey   -- 用户公钥
	/// @param  secretKey   -- 用户私钥
	/// @param  bWAN        -- 公网连接标志：true - 公网连接
	/// @return RetCode     -- 错误代码
	virtual RetCode Login(const char *publicKey, const char *secretKey, bool bWAN);

	/// 订阅行情，重复订阅同一个数据多次时取并集
	/// @param  msgType     -- 需要订阅的数据类型
	/// @param  pCodeList   -- 个股订阅列表，以“,”分割，末尾必须以\0结束，为NULL时订阅全市场
	/// @return RetCode     -- 错误代码
	virtual RetCode Subscribe(MsgType msgType, char* pCodeList = NULL);
	
	/// 取消订阅
	/// @param  msgType     -- 需要取消订阅的数据类型
	/// @param  pCodeList   -- 取消个股列表，以“,”分割，末尾必须以\0结束，为NULL时取消所有代码
	/// @return RetCode     -- 错误代码
	virtual RetCode Unsubscribe(MsgType msgType, char* pCodeList = NULL);
	
	/// 取消所有订阅信息
	/// @return RetCode     -- 错误代码
	virtual RetCode UnsubscribeAll();
	
	/// 释放一个实例,该实例是通过CreateInstance生成的.
	/// @param  pInstance   -- 实例对象指针.
	QDS_API_EXPORT static void ReleaseInstance(QDSApi* pInstance);
	
	/// 取当前系统时间：返回从1970/1/1开始的微秒数
	QDS_API_EXPORT static unsigned long long GetMicroSeconds();

	QDS_API_EXPORT static string QDSTime2str(unsigned long long us);

	QDS_API_EXPORT void reportAppTime(unsigned long long QDSTime, unsigned long long callbackTime);
	
private:
	virtual RetCode Connect();
	void setAppDelayAver(unsigned long long v);

private:
	QDSApiCallbackBase *pCallBack;
};

#pragma GCC visibility pop

#endif

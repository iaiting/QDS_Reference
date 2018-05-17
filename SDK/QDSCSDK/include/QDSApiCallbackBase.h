//////////////////////////////////////////////////////////////////////////////
/// @file       QDSApiCallbackBase.h
/// @brief      QDS行情接口定义，按结构体返回数据，自动重连
/// @copyright  Copyright (C) 2018
//////////////////////////////////////////////////////////////////////////////
#ifndef QDSAPI_CALLBACKBASE_H
#define QDSAPI_CALLBACKBASE_H

#include "QDSDataType.h"
#include "QDSStruct.h"

/// 实时数据、连接状态回调接口，按结构体返回数据
class QDSApiCallbackBase
{
public:
    virtual ~QDSApiCallbackBase(){}
	
    /// 登陆状态返回
    /// @param  errCode  -- 失败原因(用户过期、重复登陆)用户需对这两个进行处理
    virtual void OnLoginState( RetCode errCode){}

    /// 连接状态返回，连接成功/失败
    /// @param  msgType      -- 消息类型
    /// @param  errCode     -- 失败原因，成功时返回0
    virtual void OnConnectionState(MsgType msgType, RetCode errCode){}

#if 0
    /// 上交所L1静态数据订阅数据实时回调接口
    /// @param  RealSSEL1Static     -- 实时数据
    virtual void OnSubscribe_SSEL1_Static(const SSEL1_Static& RealSSEL1Static){}

    /// 上交所L1实时行情订阅数据实时回调接口
    /// @param  RealSSEL1Quotation  -- 实时数据
    virtual void OnSubscribe_SSEL1_Quotation(const SSEL1_Quotation& RealSSEL1Quotation){}

    /// 上交所指数通数据订阅数据实时回调接口
    /// @param  RealSSEIndexPress  -- 实时数据
    virtual void OnSubscribe_SSE_IndexPress(const SSE_IndexPress& RealSSEIndexPress){}
#endif
	
    /// 上交所L2静态数据订阅数据实时回调接口
    /// @param  RealSSEL2Static     -- 实时数据
    virtual void OnSubscribe_SSEL2_Static(const SSEL2_Static& RealSSEL2Static){}

    /// 上交所L2实时行情快照订阅数据实时回调接口
    /// @param  RealSSEL2Quotation  -- 实时数据
    virtual void OnSubscribe_SSEL2_Quotation(const SSEL2_Quotation& RealSSEL2Quotation){}

    /// 上交所L2指数行情订阅数据实时回调接口
    /// @param  RealSSEL2Index      -- 实时数据
    virtual void OnSubscribe_SSEL2_Index(const SSEL2_Index& RealSSEL2Index){}

    /// 上交所L2逐笔成交订阅数据实时回调接口
    /// @param  RealSSEL2Transaction    -- 实时数据
    virtual void OnSubscribe_SSEL2_Transaction(const SSEL2_Transaction& RealSSEL2Transaction){}

    /// 上交所L2虚拟集合竞价订阅数据实时回调接口
    /// @param  RealSSEL2Auction    -- 实时数据
    virtual void OnSubscribe_SSEL2_Auction(const SSEL2_Auction& RealSSEL2Auction){}

    /// 上交所L2市场总览订阅数据实时回调接口
    /// @param  RealSSEL2Overview   -- 实时数据
    virtual void OnSubscribe_SSEL2_Overview(const SSEL2_Overview& RealSSEL2Overview){}

    /// 上交所个股期权静态数据订阅数据实时回调接口
    /// @param  RealSSEIOL1Static   -- 实时数据
    virtual void OnSubscribe_SSEIOL1_Static(const SSEIOL1_Static& RealSSEIOL1Static){}

    /// 上交所个股期权实时行情订阅数据实时回调接口
    /// @param  RealSSEIOL1Quotation    -- 实时数据
    virtual void OnSubscribe_SSEIOL1_Quotation(const SSEIOL1_Quotation& RealSSEIOL1Quotation){}

#if 0
    /// 深交所L1静态数据订阅数据实时回调接口
    /// @param  RealSZSEL1Static    -- 实时数据
    virtual void OnSubscribe_SZSEL1_Static(const SZSEL1_Static& RealSZSEL1Static){}

    /// 深交所L1实时行情订阅数据实时回调接口
    /// @param  RealSZSEL1Quotation -- 实时数据
    virtual void OnSubscribe_SZSEL1_Quotation(const SZSEL1_Quotation& RealSZSEL1Quotation){}

    /// 深交所L1公告信息回调接口
    /// @param  RealSZSEL1Bullet -- 实时数据
    virtual void OnSubscribe_SZSEL1_Bulletin(const SZSEL1_Bulletin& RealSZSEL1Bullet){}
#endif
	
    /// 深交所L2静态数据订阅数据实时回调接口
    /// @param  RealSZSEL2Static    -- 实时数据
    virtual void OnSubscribe_SZSEL2_Static(const SZSEL2_Static& RealSZSEL2Static){}

    /// 深交所L2实时行情订阅数据实时回调接口
    /// @param  RealSZSEL2Quotation -- 实时数据
    virtual void OnSubscribe_SZSEL2_Quotation(const SZSEL2_Quotation& RealSZSEL2Quotation){}

    /// 深交所L2证券状态订阅数据实时回调接口
    /// @param  RealSZSEL2Status    -- 实时数据
    virtual void OnSubscribe_SZSEL2_Status(const SZSEL2_Status& RealSZSEL2Status){}

    /// 深交所L2指数行情订阅数据实时回调接口
    /// @param  RealSZSEL2Index     -- 实时数据
    virtual void OnSubscribe_SZSEL2_Index(const SZSEL2_Index& RealSZSEL2Index){}

    /// 深交所L2逐笔委托订阅数据实时回调接口
    /// @param  RealSZSEL2Order     -- 实时数据
    virtual void OnSubscribe_SZSEL2_Order(const SZSEL2_Order& RealSZSEL2Order){}

    /// 深交所L2逐笔成交订阅数据实时回调接口
    /// @param  RealSZSEL2Transaction   -- 实时数据
    virtual void OnSubscribe_SZSEL2_Transaction(const SZSEL2_Transaction& RealSZSEL2Transaction){}
};

#endif // QDSAPI_CALLBACKBASE_H

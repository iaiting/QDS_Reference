from ctypes import *
from os import path

from QDSDataType import *
from QDSStruct import *

cdll.LoadLibrary(path.dirname(__file__) + "/libs/libzmq.dll")
cdll.LoadLibrary(path.dirname(__file__) + "/libs/zmqpp.dll")
cLib = cdll.LoadLibrary(path.dirname(__file__) + "/libs/wQDSApi.dll")


SSEL2_StaticFunc = CFUNCTYPE(None ,POINTER(SSEL2_Static))
SSEL2_QuotationFunc = CFUNCTYPE(None ,POINTER(SSEL2_Quotation))
SSEL2_IndexFunc = CFUNCTYPE(None ,POINTER(SSEL2_Index))
SSEL2_TransactionFunc = CFUNCTYPE(None ,POINTER(SSEL2_Transaction))
SSEL2_AuctionFunc = CFUNCTYPE(None ,POINTER(SSEL2_Auction))
SSEL2_OverviewFunc = CFUNCTYPE(None ,POINTER(SSEL2_Overview))
SSEL2_TransactionFunc = CFUNCTYPE(None ,POINTER(SSEL2_Transaction))
SZSEL2_StaticFunc = CFUNCTYPE(None ,POINTER(SZSEL2_Static))
SZSEL2_QuotationFunc = CFUNCTYPE(None ,POINTER(SZSEL2_Quotation))
SZSEL2_StatusFunc = CFUNCTYPE(None ,POINTER(SZSEL2_Status))
SZSEL2_IndexFunc = CFUNCTYPE(None ,POINTER(SZSEL2_Index))
SZSEL2_OrderFunc = CFUNCTYPE(None ,POINTER(SZSEL2_Order))
SZSEL2_TransactionFunc = CFUNCTYPE(None ,POINTER(SZSEL2_Transaction))


class QDSApiCallbackBaseDelegate:

    m_callbackBase = None

    subscribeFunc_SSEL2_Static = None
    subscribeFunc_SSEL2_Quotation = None
    subscribeFunc_SSEL2_Index = None
    subscribeFunc_SSEL2_Auction = None
    subscribeFunc_SSEL2_Overview = None
    subscribeFunc_SSEL2_Transaction = None
    subscribeFunc_SZSEL2_Static = None
    subscribeFunc_SZSEL2_Quotation = None
    subscribeFunc_SZSEL2_Status = None
    subscribeFunc_SZSEL2_Index = None
    subscribeFunc_SZSEL2_Order = None
    subscribeFunc_SZSEL2_Transaction = None


    @classmethod
    def OnSubscribe_SSEL2_Static(Obj, RealValuePtr):
        QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SSEL2_Static(RealValuePtr)

    @classmethod
    def OnSubscribe_SSEL2_Quotation(Obj, RealValuePtr):
        QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SSEL2_Quotation(RealValuePtr)

    @classmethod
    def OnSubscribe_SSEL2_Index(Obj, RealValuePtr):
        QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SSEL2_Index(RealValuePtr)

    @classmethod
    def OnSubscribe_SSEL2_Transaction(Obj, RealValuePtr):
        QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SSEL2_Transaction(RealValuePtr)

    @classmethod
    def OnSubscribe_SSEL2_Auction(Obj, RealValuePtr):
        QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SSEL2_Auction(RealValuePtr)

    @classmethod
    def OnSubscribe_SSEL2_Overview(Obj, RealValuePtr):
        QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SSEL2_Overview(RealValuePtr)

    @classmethod
    def OnSubscribe_SZSEL2_Static(Obj,RealValuePtr):
        QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SZSEL2_Static(RealValuePtr)

    @classmethod
    def OnSubscribe_SZSEL2_Quotation(Obj, RealValuePtr):
        QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SZSEL2_Quotation(RealValuePtr)

    @classmethod
    def OnSubscribe_SZSEL2_Status(Obj, RealValuePtr):
        QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SZSEL2_Status(RealValuePtr)

    @classmethod
    def OnSubscribe_SZSEL2_Index(Obj, RealValuePtr):
        QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SZSEL2_Index(RealValuePtr)

    @classmethod
    def OnSubscribe_SZSEL2_Order(Obj, RealValuePtr):
        QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SZSEL2_Order(RealValuePtr)

    @classmethod
    def OnSubscribe_SZSEL2_Transaction(Obj, RealValuePtr):
        QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SZSEL2_Transaction(RealValuePtr)

    @classmethod
    def BindCallBack(Obj, callBackbase):
        QDSApiCallbackBaseDelegate.m_callbackBase = callBackbase
        
        QDSApiCallbackBaseDelegate.subscribeFunc_SSEL2_Static = SSEL2_StaticFunc(QDSApiCallbackBaseDelegate.OnSubscribe_SSEL2_Static)
        QDSApiCallbackBaseDelegate.subscribeFunc_SSEL2_Quotation = SSEL2_QuotationFunc(QDSApiCallbackBaseDelegate.OnSubscribe_SSEL2_Quotation)
        QDSApiCallbackBaseDelegate.subscribeFunc_SSEL2_Index = SSEL2_IndexFunc(QDSApiCallbackBaseDelegate.OnSubscribe_SSEL2_Index)
        QDSApiCallbackBaseDelegate.subscribeFunc_SSEL2_Auction = SSEL2_AuctionFunc(QDSApiCallbackBaseDelegate.OnSubscribe_SSEL2_Auction)
        QDSApiCallbackBaseDelegate.subscribeFunc_SSEL2_Overview = SSEL2_OverviewFunc(QDSApiCallbackBaseDelegate.OnSubscribe_SSEL2_Overview)
        QDSApiCallbackBaseDelegate.subscribeFunc_SSEL2_Transaction = SSEL2_TransactionFunc(QDSApiCallbackBaseDelegate.OnSubscribe_SSEL2_Transaction)
        QDSApiCallbackBaseDelegate.subscribeFunc_SZSEL2_Static = SZSEL2_StaticFunc(QDSApiCallbackBaseDelegate.OnSubscribe_SZSEL2_Static)
        QDSApiCallbackBaseDelegate.subscribeFunc_SZSEL2_Quotation = SZSEL2_QuotationFunc(QDSApiCallbackBaseDelegate.OnSubscribe_SZSEL2_Quotation)
        QDSApiCallbackBaseDelegate.subscribeFunc_SZSEL2_Status = SZSEL2_StatusFunc(QDSApiCallbackBaseDelegate.OnSubscribe_SZSEL2_Status)
        QDSApiCallbackBaseDelegate.subscribeFunc_SZSEL2_Index = SZSEL2_IndexFunc(QDSApiCallbackBaseDelegate.OnSubscribe_SZSEL2_Index)
        QDSApiCallbackBaseDelegate.subscribeFunc_SZSEL2_Order = SZSEL2_OrderFunc(QDSApiCallbackBaseDelegate.OnSubscribe_SZSEL2_Order)
        QDSApiCallbackBaseDelegate.subscribeFunc_SZSEL2_Transaction = SZSEL2_TransactionFunc(QDSApiCallbackBaseDelegate.OnSubscribe_SZSEL2_Transaction)
        
        cLib.setFuncOnData(MsgType.Msg_SSEL2_Static.value, QDSApiCallbackBaseDelegate.subscribeFunc_SSEL2_Static)
        cLib.setFuncOnData(MsgType.Msg_SSEL2_Quotation.value, QDSApiCallbackBaseDelegate.subscribeFunc_SSEL2_Quotation)
        cLib.setFuncOnData(MsgType.Msg_SSEL2_Transaction.value, QDSApiCallbackBaseDelegate.subscribeFunc_SSEL2_Transaction)
        cLib.setFuncOnData(MsgType.Msg_SSEL2_Index.value, QDSApiCallbackBaseDelegate.subscribeFunc_SSEL2_Index)
        cLib.setFuncOnData(MsgType.Msg_SSEL2_Auction.value, QDSApiCallbackBaseDelegate.subscribeFunc_SSEL2_Auction)
        cLib.setFuncOnData(MsgType.Msg_SSEL2_Overview.value, QDSApiCallbackBaseDelegate.subscribeFunc_SSEL2_Overview)
        cLib.setFuncOnData(MsgType.Msg_SZSEL2_Static.value, QDSApiCallbackBaseDelegate.subscribeFunc_SZSEL2_Static)
        cLib.setFuncOnData(MsgType.Msg_SZSEL2_Quotation.value, QDSApiCallbackBaseDelegate.subscribeFunc_SZSEL2_Quotation)
        cLib.setFuncOnData(MsgType.Msg_SZSEL2_Status.value, QDSApiCallbackBaseDelegate.subscribeFunc_SZSEL2_Status)
        cLib.setFuncOnData(MsgType.Msg_SZSEL2_Index.value, QDSApiCallbackBaseDelegate.subscribeFunc_SZSEL2_Index)
        cLib.setFuncOnData(MsgType.Msg_SZSEL2_Order.value, QDSApiCallbackBaseDelegate.subscribeFunc_SZSEL2_Order)
        cLib.setFuncOnData(MsgType.Msg_SZSEL2_Transaction.value, QDSApiCallbackBaseDelegate.subscribeFunc_SZSEL2_Transaction)








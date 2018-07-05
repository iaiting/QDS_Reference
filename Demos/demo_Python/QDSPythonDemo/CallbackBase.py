# -*- coding: utf-8 -*-

import os
import sys
sys.path.append(os.path.dirname(__file__) + "/sdk")

from QDSApiCallbackBase import QDSApiCallbackBase
from concurrent.futures import ThreadPoolExecutor
from QDSStruct import *
from QDSDataType import *

class CallbackBase(QDSApiCallbackBase):
    def OnSubscribe_SSEL2_Static(self, RealValuePtr):
        #上交所L2静态数据
        self.OnSubscribe(MsgType.Msg_SSEL2_Static.value, RealValuePtr)

    def OnSubscribe_SSEL2_Quotation(self, RealValuePtr):
        #上交所L2实时行情
        self.OnSubscribe(MsgType.Msg_SSEL2_Quotation.value, RealValuePtr)

    def OnSubscribe_SSEL2_Index(self, RealValuePtr):
        #上交所L2指数行情
        self.OnSubscribe(MsgType.Msg_SSEL2_Index.value, RealValuePtr)

    def OnSubscribe_SSEL2_Transaction(self, RealValuePtr):
        #上交所L2逐笔成交
        self.OnSubscribe(MsgType.Msg_SSEL2_Transaction.value, RealValuePtr)

    def OnSubscribe_SSEL2_Auction(self, RealValuePtr):
        #上交所L2虚拟集合竞价
        self.OnSubscribe(MsgType.Msg_SSEL2_Auction.value, RealValuePtr)

    def OnSubscribe_SSEL2_Overview(self, RealValuePtr):
        #上交所L2市场总览
        self.OnSubscribe(MsgType.Msg_SSEL2_Overview.value, RealValuePtr)

    def OnSubscribe_SZSEL2_Static(self,RealValuePtr):
        #深交所L2静态数据
        self.OnSubscribe(MsgType.Msg_SZSEL2_Static.value, RealValuePtr)

    def OnSubscribe_SZSEL2_Quotation(self, RealValuePtr):
        #深交所L2实时行情
        self.OnSubscribe(MsgType.Msg_SZSEL2_Quotation.value, RealValuePtr)

    def OnSubscribe_SZSEL2_Status(self, RealValuePtr):
        #深交所L2证券状态
        self.OnSubscribe(MsgType.Msg_SZSEL2_Status.value, RealValuePtr)

    def OnSubscribe_SZSEL2_Index(self, RealValuePtr):
        #深交所L2指数行情
        self.OnSubscribe(MsgType.Msg_SZSEL2_Index.value, RealValuePtr)

    def OnSubscribe_SZSEL2_Order(self, RealValuePtr):
        #深交所L2逐笔委托
        self.OnSubscribe(MsgType.Msg_SZSEL2_Order.value, RealValuePtr)

    def OnSubscribe_SZSEL2_Transaction(self, RealValuePtr):
        #深交所L2逐笔成交
        self.OnSubscribe(MsgType.Msg_SZSEL2_Transaction.value, RealValuePtr)
  

    def OnSubscribe(self, msgType, RealValuePtr):
        if msgType == MsgType.Msg_SSEL2_Static.value:
            print ("MsgType: SSEL2_Static -- QDSTime:" + str(RealValuePtr.contents.QDSTime) + " Symbol:" + str(RealValuePtr.contents.Symbol) + " SecurityName" + str(RealValuePtr.contents.SecurityName) + " TradeDate" + str(RealValuePtr.contents.TradeDate))
        elif msgType == MsgType.Msg_SSEL2_Quotation.value:
            print ("MsgType: SSEL2_Quotation -- QDSTime:" + str(RealValuePtr.contents.QDSTime) + " Symbol:" + str(RealValuePtr.contents.Symbol))
        elif msgType == MsgType.Msg_SSEL2_Transaction.value:
            print ("MsgType: SSEL2_Transaction -- QDSTime:" + str(RealValuePtr.contents.QDSTime) + " Symbol:" + str(RealValuePtr.contents.Symbol))
        elif msgType == MsgType.Msg_SSEL2_Index.value:
            print ("MsgType: SSEL2_Index -- QDSTime:" + str(RealValuePtr.contents.QDSTime) + " Symbol:" + str(RealValuePtr.contents.Symbol))
        elif msgType == MsgType.Msg_SSEL2_Auction.value:
            print ("MsgType: SSEL2_Auction -- QDSTime:" + str(RealValuePtr.contents.QDSTime) + " Symbol:" + str(RealValuePtr.contents.Symbol))
        elif msgType == MsgType.Msg_SSEL2_Overview.value:
            print ("MsgType: SSEL2_Overview -- QDSTime:" + str(RealValuePtr.contents.QDSTime) + " Symbol:" + str(RealValuePtr.contents.Symbol))
        elif msgType == MsgType.Msg_SZSEL2_Static.value:
            print ("MsgType: SZSEL2_Static -- QDSTime:" + str(RealValuePtr.contents.QDSTime) + " Symbol:" + str(RealValuePtr.contents.Symbol) + " TradeDate" + str(RealValuePtr.contents.TradeDate) + " QualificationClass" + str(RealValuePtr.contents.QualificationClass))
        elif msgType == MsgType.Msg_SZSEL2_Quotation.value:
            print ("MsgType: SZSEL2_Quotation -- QDSTime:" + str(RealValuePtr.contents.QDSTime) + " Symbol:" + str(RealValuePtr.contents.Symbol) + " WtAvgRate:" + str(RealValuePtr.contents.WtAvgRate) + " WtAvgRateUpdown:" + str(RealValuePtr.contents.WtAvgRateUpdown) + " PreWtAvgRate" + str(RealValuePtr.contents.PreWtAvgRate))
        elif msgType == MsgType.Msg_SZSEL2_Transaction.value:
            print ("MsgType: SZSEL2_Transaction -- QDSTime:" + str(RealValuePtr.contents.QDSTime) + " Symbol:" + str(RealValuePtr.contents.Symbol))
        elif msgType == MsgType.Msg_SZSEL2_Index.value:
            print ("MsgType: SZSEL2_Index -- QDSTime:" + str(RealValuePtr.contents.QDSTime) + " Symbol:" + str(RealValuePtr.contents.Symbol))
        elif msgType == MsgType.Msg_SZSEL2_Order.value:
            print ("MsgType: SZSEL2_Order -- QDSTime:" + str(RealValuePtr.contents.QDSTime) + " Symbol:" + str(RealValuePtr.contents.Symbol))
        elif msgType == MsgType.Msg_SZSEL2_Status.value:
            print ("MsgType: SZSEL2_Status -- QDSTime:" + str(RealValuePtr.contents.QDSTime) + " Symbol:" + str(RealValuePtr.contents.Symbol))
        else:
            print ("Unknown MsgType!")

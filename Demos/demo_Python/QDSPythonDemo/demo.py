# -*- coding: utf-8 -*-

import os
import sys
sys.path.append(os.path.dirname(__file__) + "/sdk")

from QDSAPI import QDSAPI
from QDSApiCallbackBaseDelegate import QDSApiCallbackBaseDelegate
from CallbackBase import CallbackBase
from QDSDataType import *

import os
import time

#解析启动命令行参数
def PhaseArgs(argv):
    argDict = {}
    i = 0
    while (i < len(argv)):
        tmpStr = argv[i]
        if tmpStr == "-s" or tmpStr == "-p" or tmpStr == "-k" or tmpStr == "-K" or tmpStr == "-f":
            if i < len(argv) - 1 and argv[i+1][0] != "-":
                argDict[tmpStr] = argv[i + 1]
                i = i + 1
        elif tmpStr == "-w" or tmpStr == "-A":
            argDict[tmpStr] = ""
        else:
            pass
        i = i + 1
    return argDict


if __name__ == '__main__':

    allArgs = PhaseArgs(sys.argv)

    #创建基础接口及回调实例
    apiBase = QDSAPI.CreateInstance()
    callback = CallbackBase()
    QDSApiCallbackBaseDelegate.BindCallBack(callback)


    #连接ip地址、端口及登录公钥、私钥
    ip = (("-s" in allArgs) and [allArgs["-s"]] or ["222.186.50.178"])[0]
    port = (("-p" in allArgs) and [int(allArgs["-p"])] or [8889])[0]
    publicKey = (("-k" in allArgs) and [allArgs["-k"]] or ["Jt?Wb=3mDe64R9u@+HrL9.kPt?{x?:sbc*r3[G5s"])[0]
    secretKey = (("-K" in allArgs) and [allArgs["-K"]] or ["Gmz9m9HfgbVBT2-JRtj6v69nZJ3jbn[c@k1bLEJm"])[0]
    bWAN = "-w" in allArgs

    #连接
    QDSAPI.RegisterService(ip.encode(), port)

    #登录
    print ("start login\n")
    ret = 0
    while 1:
        ret = QDSAPI.Login(publicKey.encode() , secretKey.encode(), bWAN)
        if ret == RetCode.Ret_Success.value:
            break
        else:
            wait = 5
            print ("LoginX error=%d\n" % ret)
            print ("will retry after %d seconds\n" % wait)
            time.sleep(3)
            continue
    print ("login success\n")
    
    if "-A" in allArgs:
        #全部订阅
        QDSAPI.Subscribe(MsgType.Msg_SSEL2_Static.value, None);	 #上交所L2静态数据
        QDSAPI.Subscribe(MsgType.Msg_SSEL2_Quotation.value, None);	#上交所L2实时行情
        QDSAPI.Subscribe(MsgType.Msg_SSEL2_Transaction.value, None);		#上交所L2逐笔成交
        QDSAPI.Subscribe(MsgType.Msg_SSEL2_Index.value, None);	#上交所L2指数行情
        QDSAPI.Subscribe(MsgType.Msg_SSEL2_Auction.value, None);		#上交所L2虚拟集合竞价
        QDSAPI.Subscribe(MsgType.Msg_SSEL2_Overview.value, None);		#上交所L2时长总览
        QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Static.value, None);		#深交所L2静态数据
        QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Quotation.value, None);		#深交所L2实时行情
        QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Transaction.value, None);		#深交所L2逐笔成交
        QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Index.value, None);		#深交所L2逐笔成交
        QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Order.value, None);		#深交所L2逐笔委托
        QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Status.value, None);		#深交所L2逐笔成交
    else:
        #深交所L2实时行情
        symbols = "000063,000725,300104,000572,300101,002693,002160,300595"
        ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Quotation.value, symbols.encode())
        if ret != 0:
            print ("subscribe error:%d\n" % ret)
        print ("subscribe1 success\n")

        #深交所L2逐笔委托
        ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Order.value, symbols.encode())
        if ret != 0:
            print ("subscribe error:%d\n" % ret)
        print ("subscribe2 success\n")

        #深交所L2逐笔成交
        ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Transaction.value, symbols.encode())
        if ret != 0:
            print("subscribe error:%d\n" % ret)
        print ("subscribe3 success\n")

        #深交所L2证券状态
        ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Status.value, symbols.encode())
        if ret != 0:
            print("subscribe error:%d\n" % ret)
        print ("subscribe4 success\n")

        #深交所L2静态数据
        ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Static.value, symbols.encode())
        if ret != 0:
            print("subscribe error:%d\n" % ret)
        print ("subscribe5 success\n")

    #挂起当前线程，直至按下回车后取消订阅并结束程序
    input("press enter to unsunscribe:")

    #取消订阅所有
    ret = QDSAPI.UnsubscribeAll()
    if ret != RetCode.Ret_Success.value:
        print("subscribe error:%d\n" % ret)
    print ("UnsubscribeAll success\n")

    #删除实例
    QDSAPI.ReleaseInstance()
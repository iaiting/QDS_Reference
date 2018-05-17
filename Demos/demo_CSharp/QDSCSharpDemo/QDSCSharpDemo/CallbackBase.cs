using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QDSCSharpSDK;
using System.Runtime.InteropServices;

namespace QDS.Demo
{
    class CallbackBase : QDSApiCallbackBase
    {
        override public void OnSubscribe_SSEL2_Static(IntPtr RealValuePtr)
        {
            //上交所L2静态数据
            OnSubscribe(MsgType.Msg_SSEL2_Static, RealValuePtr);
        }

        override public void OnSubscribe_SSEL2_Quotation(IntPtr RealValuePtr)
        {
            //上交所L2实时行情
            OnSubscribe(MsgType.Msg_SSEL2_Quotation, RealValuePtr);
        }

        override public void OnSubscribe_SSEL2_Index(IntPtr RealValuePtr)
        {
            //上交所L2指数行情
            OnSubscribe(MsgType.Msg_SSEL2_Index, RealValuePtr);
        }

        override public void OnSubscribe_SSEL2_Transaction(IntPtr RealValuePtr)
        {
            //上交所L2逐笔成交
            OnSubscribe(MsgType.Msg_SSEL2_Transaction,RealValuePtr);
        }

        override public void OnSubscribe_SSEL2_Auction(IntPtr RealValuePtr)
        {
            //上交所L2虚拟集合竞价
            OnSubscribe(MsgType.Msg_SSEL2_Auction, RealValuePtr);
        }

        override public void OnSubscribe_SSEL2_Overview(IntPtr RealValuePtr)
        {
            //上交所L2市场总览
            OnSubscribe(MsgType.Msg_SSEL2_Overview, RealValuePtr);
        }

        override public void OnSubscribe_SZSEL2_Static(IntPtr RealValuePtr)
        {
            //深交所L2静态数据
            OnSubscribe(MsgType.Msg_SZSEL2_Static, RealValuePtr);
        }

        override public void OnSubscribe_SZSEL2_Quotation(IntPtr RealValuePtr)
        {
            //深交所L2实时行情
            OnSubscribe(MsgType.Msg_SZSEL2_Quotation, RealValuePtr);
        }

        override public void OnSubscribe_SZSEL2_Status(IntPtr RealValuePtr)
        {
            //深交所L2证券状态
            OnSubscribe(MsgType.Msg_SZSEL2_Status, RealValuePtr);
        }

        override public void OnSubscribe_SZSEL2_Index(IntPtr RealValuePtr)
        {
            //深交所L2指数行情
            OnSubscribe(MsgType.Msg_SZSEL2_Index, RealValuePtr);
        }

        override public void OnSubscribe_SZSEL2_Order(IntPtr RealValuePtr)
        {
            //深交所L2逐笔委托
            OnSubscribe(MsgType.Msg_SZSEL2_Order, RealValuePtr);
        }

        override public void OnSubscribe_SZSEL2_Transaction(IntPtr RealValuePtr)
        {
            //深交所L2逐笔成交
            OnSubscribe(MsgType.Msg_SZSEL2_Transaction, RealValuePtr);
        }

        private void OnSubscribe(MsgType msgType,IntPtr RealValuePtr)
        {
            string consoleStr = "";
            switch (msgType)
            {
                case MsgType.Msg_SSEL2_Static:
                    //上交所L2静态数据
                    SSEL2_Static SSEL2_StaticValue = (SSEL2_Static)Marshal.PtrToStructure(RealValuePtr, typeof(SSEL2_Static));
                    consoleStr += "MsgType: SSEL2_Static --";
                    consoleStr += " QDSTime:" + SSEL2_StaticValue.QDSTime;
                    consoleStr += " Symbol:" + SSEL2_StaticValue.Symbol;
                    break;
                case MsgType.Msg_SSEL2_Quotation:
                    //上交所L2实时行情
                    SSEL2_Quotation SSEL2_QuotationValue = (SSEL2_Quotation)Marshal.PtrToStructure(RealValuePtr, typeof(SSEL2_Quotation));
                    consoleStr += "MsgType: SSEL2_Quotation --";
                    consoleStr += " QDSTime:" + SSEL2_QuotationValue.QDSTime;
                    consoleStr += " Symbol:" + SSEL2_QuotationValue.Symbol;
                    break;
                case MsgType.Msg_SSEL2_Transaction:
                    //上交所L2逐笔成交
                    SSEL2_Transaction SSEL2_TransactionValue = (SSEL2_Transaction)Marshal.PtrToStructure(RealValuePtr, typeof(SSEL2_Transaction));
                    consoleStr += "MsgType: SSEL2_Transaction --";
                    consoleStr += " QDSTime:" + SSEL2_TransactionValue.QDSTime;
                    consoleStr += " Symbol:" + SSEL2_TransactionValue.Symbol;
                    break;
                case MsgType.Msg_SSEL2_Index:
                    //上交所L2指数行情
                    SSEL2_Index SSEL2_IndexValue = (SSEL2_Index)Marshal.PtrToStructure(RealValuePtr, typeof(SSEL2_Index));
                    consoleStr += "MsgType: SSEL2_Index --";
                    consoleStr += " QDSTime:" + SSEL2_IndexValue.QDSTime;
                    consoleStr += " Symbol:" + SSEL2_IndexValue.Symbol;
                    break;
                case MsgType.Msg_SSEL2_Auction:
                    //上交所L2虚拟集合竞价
                    SSEL2_Auction SSEL2_AuctionValue = (SSEL2_Auction)Marshal.PtrToStructure(RealValuePtr, typeof(SSEL2_Auction));
                    consoleStr += "MsgType: SSEL2_Index --";
                    consoleStr += " QDSTime:" + SSEL2_AuctionValue.QDSTime;
                    consoleStr += " Symbol:" + SSEL2_AuctionValue.Symbol;
                    break;
                case MsgType.Msg_SSEL2_Overview:
                    //上交所L2市场总览
                    SSEL2_Overview SSEL2_OverviewValue = (SSEL2_Overview)Marshal.PtrToStructure(RealValuePtr, typeof(SSEL2_Overview));
                    consoleStr += "MsgType: SSEL2_OverView --";
                    consoleStr += " QDSTime:" + SSEL2_OverviewValue.QDSTime;
                    consoleStr += " Symbol:" + SSEL2_OverviewValue.Symbol;
                    break;
                case MsgType.Msg_SZSEL2_Static:
                    //深交所L2静态数据
                    SZSEL2_Static SZSEL2_StaticValue = (SZSEL2_Static)Marshal.PtrToStructure(RealValuePtr, typeof(SZSEL2_Static));
                    consoleStr += "MsgType: SZSEL2_Static --";
                    consoleStr += " QDSTime:" + SZSEL2_StaticValue.QDSTime;
                    consoleStr += " Symbol:" + SZSEL2_StaticValue.Symbol;
                    break;
                case MsgType.Msg_SZSEL2_Quotation:
                    //深交所L2实时行情
                    SZSEL2_Quotation SZSEL2_QuotationValue = (SZSEL2_Quotation)Marshal.PtrToStructure(RealValuePtr, typeof(SZSEL2_Quotation));
                    consoleStr += "MsgType: SZSEL2_Quotation --";
                    consoleStr += " QDSTime:" + SZSEL2_QuotationValue.QDSTime;
                    consoleStr += " Symbol:" + SZSEL2_QuotationValue.Symbol;
                    break;
                case MsgType.Msg_SZSEL2_Transaction:
                    //深交所L2逐笔成交
                    SZSEL2_Transaction SZSEL2_TransactionValue = (SZSEL2_Transaction)Marshal.PtrToStructure(RealValuePtr, typeof(SZSEL2_Transaction));
                    consoleStr += "MsgType: SZSEL2_Transaction --";
                    consoleStr += " QDSTime:" + SZSEL2_TransactionValue.QDSTime;
                    consoleStr += " Symbol:" + SZSEL2_TransactionValue.Symbol;
                    break;
                case MsgType.Msg_SZSEL2_Index:
                    //深交所L2指数行情
                    SZSEL2_Index SZSEL2_IndexValue = (SZSEL2_Index)Marshal.PtrToStructure(RealValuePtr, typeof(SZSEL2_Index));
                    consoleStr += "MsgType: SZSEL2_Index --";
                    consoleStr += " QDSTime:" + SZSEL2_IndexValue.QDSTime;
                    consoleStr += " Symbol:" + SZSEL2_IndexValue.Symbol;
                    break;
                case MsgType.Msg_SZSEL2_Order:
                    //深交所L2逐笔委托
                    SZSEL2_Order SZSEL2_OrderValue = (SZSEL2_Order)Marshal.PtrToStructure(RealValuePtr, typeof(SZSEL2_Order));
                    consoleStr += "MsgType: SZSEL2_Order --";
                    consoleStr += " QDSTime:" + SZSEL2_OrderValue.QDSTime;
                    consoleStr += " Symbol:" + SZSEL2_OrderValue.Symbol;
                    break;
                case MsgType.Msg_SZSEL2_Status:
                    //深交所L2证券状态
                    SZSEL2_Status SZSEL2_StatusValue = (SZSEL2_Status)Marshal.PtrToStructure(RealValuePtr, typeof(SZSEL2_Status));
                    consoleStr += "MsgType: SZSEL2_Status --";
                    consoleStr += " QDSTime:" + SZSEL2_StatusValue.QDSTime;
                    consoleStr += " Symbol:" + SZSEL2_StatusValue.Symbol;
                    break;
                default:
                    consoleStr += "Unknown MsgType!";
                    break;
            }

            Console.WriteLine(consoleStr);    //输出到控制台

        }


    }
}

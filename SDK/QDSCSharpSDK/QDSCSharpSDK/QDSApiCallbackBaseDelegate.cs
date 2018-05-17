using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace QDSCSharpSDK
{
    public class QDSApiCallbackBaseDelegate
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FuncOnData(IntPtr RealValuePtr);

        static public FuncOnData SSEL2_StaticFuc = OnSubscribe_SSEL2_Static;
        static public FuncOnData SSEL2_QuotationFuc = OnSubscribe_SSEL2_Quotation;
        static public FuncOnData SSEL2_IndexFuc = OnSubscribe_SSEL2_Index;
        static public FuncOnData SSEL2_TransactionFuc = OnSubscribe_SSEL2_Transaction;
        static public FuncOnData SSEL2_AuctionFuc = OnSubscribe_SSEL2_Auction;
        static public FuncOnData SSEL2_OverviewFuc = OnSubscribe_SSEL2_Overview;
        static public FuncOnData SZSEL2_StaticFuc = OnSubscribe_SZSEL2_Static;
        static public FuncOnData SZSEL2_QuotationFuc = OnSubscribe_SZSEL2_Quotation;
        static public FuncOnData SZSEL2_StatusFuc = OnSubscribe_SZSEL2_Status;
        static public FuncOnData SZSEL2_IndexFuc = OnSubscribe_SZSEL2_Index;
        static public FuncOnData SZSEL2_OrderFuc = OnSubscribe_SZSEL2_Order;
        static public FuncOnData SZSEL2_TransactionFuc = OnSubscribe_SZSEL2_Transaction;

        static private QDSApiCallbackBase m_callbackBase;

        [DllImport("wQDSApi.dll", EntryPoint = "setFuncOnData")]
        private static extern void setFuncOnData(MsgType msgType, FuncOnData cSharpFunc);

        public static void Bind(QDSApiCallbackBase callbackBase)
        {
            m_callbackBase = callbackBase;

            setFuncOnData(MsgType.Msg_SSEL2_Static, SSEL2_StaticFuc);
            setFuncOnData(MsgType.Msg_SSEL2_Quotation, SSEL2_QuotationFuc);
            setFuncOnData(MsgType.Msg_SSEL2_Index, SSEL2_IndexFuc);
            setFuncOnData(MsgType.Msg_SSEL2_Transaction, SSEL2_TransactionFuc);
            setFuncOnData(MsgType.Msg_SSEL2_Auction, SSEL2_AuctionFuc);
            setFuncOnData(MsgType.Msg_SSEL2_Overview, SSEL2_OverviewFuc);

            setFuncOnData(MsgType.Msg_SZSEL2_Static, SZSEL2_StaticFuc);
            setFuncOnData(MsgType.Msg_SZSEL2_Quotation, SZSEL2_QuotationFuc);
            setFuncOnData(MsgType.Msg_SZSEL2_Status, SZSEL2_StatusFuc);
            setFuncOnData(MsgType.Msg_SZSEL2_Index, SZSEL2_IndexFuc);
            setFuncOnData(MsgType.Msg_SZSEL2_Order, SZSEL2_OrderFuc);
            setFuncOnData(MsgType.Msg_SZSEL2_Transaction, SZSEL2_TransactionFuc);
        }

        static public void OnSubscribe_SSEL2_Static(IntPtr RealValuePtr) {
            m_callbackBase.OnSubscribe_SSEL2_Static(RealValuePtr);
            GC.Collect();
        }

        static public void OnSubscribe_SSEL2_Quotation(IntPtr RealValuePtr) {
            m_callbackBase.OnSubscribe_SSEL2_Quotation(RealValuePtr);
            GC.Collect();
        }

        static public void OnSubscribe_SSEL2_Index(IntPtr RealValuePtr) {
            m_callbackBase.OnSubscribe_SSEL2_Index(RealValuePtr);
            GC.Collect();
        }

        static public void OnSubscribe_SSEL2_Transaction(IntPtr RealValuePtr) {
            m_callbackBase.OnSubscribe_SSEL2_Transaction(RealValuePtr);
            GC.Collect();
        }

        static public void OnSubscribe_SSEL2_Auction(IntPtr RealValuePtr) {
            m_callbackBase.OnSubscribe_SSEL2_Auction(RealValuePtr);
            GC.Collect();
        }

        static public void OnSubscribe_SSEL2_Overview(IntPtr RealValuePtr) {
            m_callbackBase.OnSubscribe_SSEL2_Overview(RealValuePtr);
            GC.Collect();
        }

        static public void OnSubscribe_SZSEL2_Static(IntPtr RealValuePtr) {
            m_callbackBase.OnSubscribe_SZSEL2_Static(RealValuePtr);
            GC.Collect();
        }

        static public void OnSubscribe_SZSEL2_Quotation(IntPtr RealValuePtr) {
            m_callbackBase.OnSubscribe_SZSEL2_Quotation(RealValuePtr);
            GC.Collect();
        }

        static public void OnSubscribe_SZSEL2_Status(IntPtr RealValuePtr) {
            m_callbackBase.OnSubscribe_SZSEL2_Status(RealValuePtr);
            GC.Collect();
        }

        static public void OnSubscribe_SZSEL2_Index(IntPtr RealValuePtr) {
            m_callbackBase.OnSubscribe_SZSEL2_Index(RealValuePtr);
            GC.Collect();
        }

        static public void OnSubscribe_SZSEL2_Order(IntPtr RealValuePtr) {
            m_callbackBase.OnSubscribe_SZSEL2_Order(RealValuePtr);
            GC.Collect();
        }

        static public void OnSubscribe_SZSEL2_Transaction(IntPtr RealValuePtr) {
            m_callbackBase.OnSubscribe_SZSEL2_Transaction(RealValuePtr);
            GC.Collect();
        }
    }
}

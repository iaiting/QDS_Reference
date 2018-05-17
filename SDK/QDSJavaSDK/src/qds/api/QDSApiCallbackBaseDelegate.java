package qds.api;

import qds.api.QDSDataType.*;

import com.sun.jna.Callback;
import com.sun.jna.Library;
import com.sun.jna.Native;
import com.sun.jna.Pointer;

//CallBack委托类，用于为C++调用java提供接口
public class QDSApiCallbackBaseDelegate {

	public interface CLibrary extends Library
    {
		interface funcOnData extends Callback
	    {
	      void CallBackFunc(Pointer pData);
	    }
		void setFuncOnData(int msgType, funcOnData func);
		
    }
	
	private static CLibrary lib = (CLibrary)Native.loadLibrary("wQDSApi.dll",CLibrary.class); 
	
	static CLibrary.funcOnData SSEL2_StaticFunc = null;
	static CLibrary.funcOnData SSEL2_QuotationFunc = null;
	static CLibrary.funcOnData SSEL2_IndexFunc = null;
	static CLibrary.funcOnData SSEL2_TransactionFunc = null;
	static CLibrary.funcOnData SSEL2_AuctionFunc = null;
	static CLibrary.funcOnData SSEL2_OverviewFunc = null;
	static CLibrary.funcOnData SZSEL2_StaticFunc = null;
	static CLibrary.funcOnData SZSEL2_QuotationFunc = null;
	static CLibrary.funcOnData SZSEL2_StatusFunc = null;
	static CLibrary.funcOnData SZSEL2_IndexFunc = null;
	static CLibrary.funcOnData SZSEL2_OrderFunc = null;
	static CLibrary.funcOnData SZSEL2_TransactionFunc = null;
	
	static QDSApiCallbackBase m_callbackBase = null;

	
	public static void Bind(QDSApiCallbackBase callbackBase)
	{
		m_callbackBase = callbackBase;
		
		QDSApiCallbackBaseDelegate.SSEL2_StaticFunc = new CLibrary.funcOnData()
		{
			public void CallBackFunc(Pointer pData)
			{
				QDSApiCallbackBaseDelegate.OnSubscribe_SSEL2_Static(pData);
			}
		};
		
		QDSApiCallbackBaseDelegate.SSEL2_QuotationFunc = new CLibrary.funcOnData()
		{
			public void CallBackFunc(Pointer pData)
			{
				QDSApiCallbackBaseDelegate.OnSubscribe_SSEL2_Quotation(pData);
			}
		};
		QDSApiCallbackBaseDelegate.SSEL2_IndexFunc = new CLibrary.funcOnData()
		{
			public void CallBackFunc(Pointer pData)
			{
				QDSApiCallbackBaseDelegate.OnSubscribe_SSEL2_Index(pData);
			}
		};
		QDSApiCallbackBaseDelegate.SSEL2_TransactionFunc = new CLibrary.funcOnData()
		{
			public void CallBackFunc(Pointer pData)
			{
				QDSApiCallbackBaseDelegate.OnSubscribe_SSEL2_Transaction(pData);
			}
		};
		QDSApiCallbackBaseDelegate.SSEL2_AuctionFunc = new CLibrary.funcOnData()
		{
			public void CallBackFunc(Pointer pData)
			{
				QDSApiCallbackBaseDelegate.OnSubscribe_SSEL2_Auction(pData);
			}
		};
		QDSApiCallbackBaseDelegate.SSEL2_OverviewFunc = new CLibrary.funcOnData()
		{
			public void CallBackFunc(Pointer pData)
			{
				QDSApiCallbackBaseDelegate.OnSubscribe_SSEL2_Overview(pData);
			}
		};
		QDSApiCallbackBaseDelegate.SZSEL2_StaticFunc = new CLibrary.funcOnData()
		{
			public void CallBackFunc(Pointer pData)
			{
				QDSApiCallbackBaseDelegate.OnSubscribe_SZSEL2_Static(pData);
			}
		};
		QDSApiCallbackBaseDelegate.SZSEL2_QuotationFunc = new CLibrary.funcOnData()
		{
			public void CallBackFunc(Pointer pData)
			{
				QDSApiCallbackBaseDelegate.OnSubscribe_SZSEL2_Quotation(pData);
			}
		};
		QDSApiCallbackBaseDelegate.SZSEL2_StatusFunc = new CLibrary.funcOnData()
		{
			public void CallBackFunc(Pointer pData)
			{
				QDSApiCallbackBaseDelegate.OnSubscribe_SZSEL2_Status(pData);
			}
		};
		QDSApiCallbackBaseDelegate.SZSEL2_IndexFunc = new CLibrary.funcOnData()
		{
			public void CallBackFunc(Pointer pData)
			{
				QDSApiCallbackBaseDelegate.OnSubscribe_SZSEL2_Index(pData);
			}
		};
		QDSApiCallbackBaseDelegate.SZSEL2_OrderFunc = new CLibrary.funcOnData()
		{
			public void CallBackFunc(Pointer pData)
			{
				QDSApiCallbackBaseDelegate.OnSubscribe_SZSEL2_Order(pData);
			}
		};
		QDSApiCallbackBaseDelegate.SZSEL2_TransactionFunc = new CLibrary.funcOnData()
		{
			public void CallBackFunc(Pointer pData)
			{
				QDSApiCallbackBaseDelegate.OnSubscribe_SZSEL2_Transaction(pData);
			}
		};
		
		lib.setFuncOnData(MsgType.Msg_SSEL2_Static, QDSApiCallbackBaseDelegate.SSEL2_StaticFunc);
		lib.setFuncOnData(MsgType.Msg_SSEL2_Quotation, QDSApiCallbackBaseDelegate.SSEL2_QuotationFunc);
		lib.setFuncOnData(MsgType.Msg_SSEL2_Index, QDSApiCallbackBaseDelegate.SSEL2_IndexFunc);
		lib.setFuncOnData(MsgType.Msg_SSEL2_Transaction, QDSApiCallbackBaseDelegate.SSEL2_TransactionFunc);
		lib.setFuncOnData(MsgType.Msg_SSEL2_Auction, QDSApiCallbackBaseDelegate.SSEL2_AuctionFunc);
		lib.setFuncOnData(MsgType.Msg_SSEL2_Overview, QDSApiCallbackBaseDelegate.SSEL2_OverviewFunc);
		lib.setFuncOnData(MsgType.Msg_SZSEL2_Static, QDSApiCallbackBaseDelegate.SZSEL2_StaticFunc);
		lib.setFuncOnData(MsgType.Msg_SZSEL2_Quotation, QDSApiCallbackBaseDelegate.SZSEL2_QuotationFunc);
		lib.setFuncOnData(MsgType.Msg_SZSEL2_Status, QDSApiCallbackBaseDelegate.SZSEL2_StatusFunc);
		lib.setFuncOnData(MsgType.Msg_SZSEL2_Index, QDSApiCallbackBaseDelegate.SZSEL2_IndexFunc);
		lib.setFuncOnData(MsgType.Msg_SZSEL2_Order, QDSApiCallbackBaseDelegate.SZSEL2_OrderFunc);
		lib.setFuncOnData(MsgType.Msg_SZSEL2_Transaction, QDSApiCallbackBaseDelegate.SZSEL2_TransactionFunc);
	}
	

	public static void OnSubscribe_SSEL2_Static(Pointer RealValuePtr) {
		QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SSEL2_Static(RealValuePtr);
	}

	public static void OnSubscribe_SSEL2_Quotation(Pointer RealValuePtr) {
		QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SSEL2_Quotation(RealValuePtr);
	}

	public static void OnSubscribe_SSEL2_Index(Pointer RealValuePtr) {
		QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SSEL2_Index(RealValuePtr);
	}

	public static void OnSubscribe_SSEL2_Transaction(Pointer RealValuePtr) {
		QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SSEL2_Transaction(RealValuePtr);
	}

	public static void OnSubscribe_SSEL2_Auction(Pointer RealValuePtr) {
		QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SSEL2_Auction(RealValuePtr);
	}

	public static void OnSubscribe_SSEL2_Overview(Pointer RealValuePtr) {
		QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SSEL2_Overview(RealValuePtr);
	}

	public static void OnSubscribe_SZSEL2_Static(Pointer RealValuePtr) {
		QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SZSEL2_Static(RealValuePtr);
	}

	public static void OnSubscribe_SZSEL2_Quotation(Pointer RealValuePtr) {
		QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SZSEL2_Quotation(RealValuePtr);
	}

	public static void OnSubscribe_SZSEL2_Status(Pointer RealValuePtr) {
		QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SZSEL2_Status(RealValuePtr);
	}

	public static void OnSubscribe_SZSEL2_Index(Pointer RealValuePtr) {
		QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SZSEL2_Index(RealValuePtr);
	}

	public static void OnSubscribe_SZSEL2_Order(Pointer RealValuePtr) {
		QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SZSEL2_Order(RealValuePtr);
	}

	public static void OnSubscribe_SZSEL2_Transaction(Pointer RealValuePtr) {
		QDSApiCallbackBaseDelegate.m_callbackBase.OnSubscribe_SZSEL2_Transaction(RealValuePtr);
	}
}

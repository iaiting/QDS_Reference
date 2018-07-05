package qds.demo;

import com.sun.jna.Pointer;

import qds.api.QDSApiCallbackBase;
import qds.api.QDSStruct.*;
import qds.api.QDSDataType.*;

public class CallBackBase extends QDSApiCallbackBase {
	public CallBackBase() {

	}

	public void OnSubscribe_SSEL2_Static(Pointer RealValuePtr) {
		//上交所L2静态数据
		OnSubscribe(MsgType.Msg_SSEL2_Static, RealValuePtr);
	}

	public void OnSubscribe_SSEL2_Quotation(Pointer RealValuePtr) {
		//上交所L2实时行情
		OnSubscribe(MsgType.Msg_SSEL2_Quotation, RealValuePtr);
	}

	public void OnSubscribe_SSEL2_Index(Pointer RealValuePtr) {
		//上交所L2指数行情
		OnSubscribe(MsgType.Msg_SSEL2_Index, RealValuePtr);
	}

	public void OnSubscribe_SSEL2_Transaction(Pointer RealValuePtr) {
		//上交所L2逐笔成交
		OnSubscribe(MsgType.Msg_SSEL2_Transaction, RealValuePtr);
	}

	public void OnSubscribe_SSEL2_Auction(Pointer RealValuePtr) {
		//上交所L2虚拟集合总价
		OnSubscribe(MsgType.Msg_SSEL2_Auction, RealValuePtr);
	}

	public void OnSubscribe_SSEL2_Overview(Pointer RealValuePtr) {
		//上交所L2市场总览
		OnSubscribe(MsgType.Msg_SSEL2_Overview, RealValuePtr);
	}

	public void OnSubscribe_SZSEL2_Static(Pointer RealValuePtr) {
		//深交所L2静态数据
		OnSubscribe(MsgType.Msg_SZSEL2_Static, RealValuePtr);
	}

	public void OnSubscribe_SZSEL2_Quotation(Pointer RealValuePtr) {
		//深交所L2实时行情
		OnSubscribe(MsgType.Msg_SZSEL2_Quotation, RealValuePtr);
	}

	public void OnSubscribe_SZSEL2_Status(Pointer RealValuePtr) {
		//深交所L2证券状态
		OnSubscribe(MsgType.Msg_SZSEL2_Status, RealValuePtr);
	}

	public void OnSubscribe_SZSEL2_Index(Pointer RealValuePtr) {
		//深交所L2指数行情
		OnSubscribe(MsgType.Msg_SZSEL2_Index, RealValuePtr);
	}

	public void OnSubscribe_SZSEL2_Order(Pointer RealValuePtr) {
		//深交所L2逐笔委托
		OnSubscribe(MsgType.Msg_SZSEL2_Order, RealValuePtr);
	}

	public void OnSubscribe_SZSEL2_Transaction(Pointer RealValuePtr) {
		//深交所L2逐笔成交
		OnSubscribe(MsgType.Msg_SZSEL2_Transaction, RealValuePtr);
	}

	//byte数组转String
	public static String ByteToString(byte[] bytes)
	{

	    StringBuilder strBuilder = new StringBuilder();
	    for (int i = 0; i <bytes.length ; i++) {
	        if (bytes[i]!=0){
	            strBuilder.append((char)bytes[i]);
	        }else {
	            break;
	        }

	    }
	    return strBuilder.toString();
	}

	//处理订阅内容
	private void OnSubscribe(int msgType ,Pointer RealValuePtr) {
		String consoleStr = "";
		if (msgType == MsgType.Msg_SSEL2_Static)
		{
			//上交所L2静态数据
			SSEL2_Static value = (SSEL2_Static) SSEL2_Static.newInstance(SSEL2_Static.class, RealValuePtr);
			value.read();
			consoleStr = consoleStr + "MsgType:SSEL2_Static -- QDSTime:" + value.QDSTime + " Symbol:" + ByteToString(value.Symbol)
				+" SecurityName" + value.SecurityName + " TradeDate" + value.TradeDate;
		}
		else if (msgType == MsgType.Msg_SSEL2_Quotation)
		{
			//上交所L2实时行情
			SSEL2_Quotation value = (SSEL2_Quotation) SSEL2_Quotation.newInstance(SSEL2_Quotation.class, RealValuePtr);
			value.read();
			consoleStr = consoleStr + "MsgType:SSEL2_Static -- QDSTime:" + value.QDSTime + " Symbol:" + ByteToString(value.Symbol);
		}
		else if (msgType == MsgType.Msg_SSEL2_Transaction)
		{
			//上交所L2逐笔成交
			SSEL2_Transaction value = (SSEL2_Transaction) SSEL2_Transaction.newInstance(SSEL2_Transaction.class, RealValuePtr);
			value.read();
			consoleStr = consoleStr + "MsgType:SSEL2_Transaction -- QDSTime:" + value.QDSTime + " Symbol:" + ByteToString(value.Symbol);
		}
		else if (msgType == MsgType.Msg_SSEL2_Index)
		{
			//上交所L2指数行情
			SSEL2_Index value = (SSEL2_Index) SSEL2_Index.newInstance(SSEL2_Index.class, RealValuePtr);
			value.read();
			consoleStr = consoleStr + "MsgType:SSEL2_Index -- QDSTime:" + value.QDSTime + " Symbol:" + ByteToString(value.Symbol);
		}
		else if (msgType == MsgType.Msg_SSEL2_Auction)
		{
			//上交所L2虚拟集合竞价
			SSEL2_Auction value = (SSEL2_Auction) SSEL2_Auction.newInstance(SSEL2_Auction.class, RealValuePtr);
			value.read();
			consoleStr = consoleStr + "MsgType:SSEL2_Auction -- QDSTime:" + value.QDSTime + " Symbol:" + ByteToString(value.Symbol);
		}
		else if (msgType == MsgType.Msg_SSEL2_Overview)
		{
			//上交所L2市场总览
			SSEL2_Overview value = (SSEL2_Overview) SSEL2_Overview.newInstance(SSEL2_Overview.class, RealValuePtr);
			value.read();
			consoleStr = consoleStr + "MsgType:SSEL2_Overview -- QDSTime:" + value.QDSTime + " Symbol:" + ByteToString(value.Symbol);
		}
		else if (msgType == MsgType.Msg_SZSEL2_Static)
		{
			//深交所L2静态数据
			SZSEL2_Static value = (SZSEL2_Static) SZSEL2_Static.newInstance(SZSEL2_Static.class, RealValuePtr);
			value.read();
			consoleStr = consoleStr + "MsgType:SZSEL2_Static -- QDSTime:" + value.QDSTime + " Symbol:" + ByteToString(value.Symbol)
				+ " TradeDate" + value.TradeDate + " QualificationClass" + ByteToString(value.QualificationClass);
		}
		else if (msgType == MsgType.Msg_SZSEL2_Quotation)
		{
			//深交所L2实时行情
			SZSEL2_Quotation value = (SZSEL2_Quotation) SZSEL2_Quotation.newInstance(SZSEL2_Quotation.class, RealValuePtr);
			value.read();
			consoleStr = consoleStr + "MsgType:SZSEL2_Quotation -- QDSTime:" + value.QDSTime + " Symbol:" + ByteToString(value.Symbol)
				+ " WtAvgRate" + value.WtAvgRate + " WtAvgRateUpdown" + value.WtAvgRateUpdown + " PreWtAvgRate" + value.PreWtAvgRate;
		}
		else if (msgType == MsgType.Msg_SZSEL2_Transaction)
		{
			//深交所L2逐笔成交
			SZSEL2_Transaction value = (SZSEL2_Transaction) SZSEL2_Transaction.newInstance(SZSEL2_Transaction.class, RealValuePtr);
			value.read();
			consoleStr = consoleStr + "MsgType:SZSEL2_Transaction -- QDSTime:" + value.QDSTime + " Symbol:" + ByteToString(value.Symbol);
		}
		else if (msgType == MsgType.Msg_SZSEL2_Index)
		{
			//深交所L2指数行情
			SZSEL2_Index value = (SZSEL2_Index) SZSEL2_Index.newInstance(SZSEL2_Index.class, RealValuePtr);
			value.read();
			consoleStr = consoleStr + "MsgType:SZSEL2_Transaction -- QDSTime:" + value.QDSTime + " Symbol:" + ByteToString(value.Symbol);
		}
		else if (msgType == MsgType.Msg_SZSEL2_Order)
		{
			//深交所L2逐笔委托
			SZSEL2_Order value = (SZSEL2_Order) SZSEL2_Order.newInstance(SZSEL2_Order.class, RealValuePtr);
			value.read();
			consoleStr = consoleStr + "MsgType:SZSEL2_Order -- QDSTime:" + value.QDSTime + " Symbol:" + ByteToString(value.Symbol);
		}
		else if (msgType == MsgType.Msg_SZSEL2_Status)
		{
			//深交所L2证券状态
			SZSEL2_Status value = (SZSEL2_Status) SZSEL2_Status.newInstance(SZSEL2_Status.class, RealValuePtr);
			value.read();
			consoleStr = consoleStr + "MsgType:SZSEL2_Status -- QDSTime:" + value.QDSTime + " Symbol:" + ByteToString(value.Symbol);
		}
		else
		{
			consoleStr = "Unknown MsgType！";
		}
		System.out.println(consoleStr);  //输出到控制台
	}
}

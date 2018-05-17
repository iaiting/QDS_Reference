package qds.api;

public class QDSDataType {
	static public class MsgType {
		public final static int Msg_Unknown = 0x00000000; /// < 错误的消息类型
		public final static int Msg_SSEL1_Static = 0x00101000; /// < 上交所L1静态数据
		public final static int Msg_SSEL1_Quotation = 0x00101001; /// < 上交所L1实时行情
		public final static int Msg_SSE_IndexPress = 0x0010100D; /// < 上交所指数通行情
		public final static int Msg_SSEL2_Static = 0x00102000; /// < 上交所L2静态数据
		public final static int Msg_SSEL2_Quotation = 0x00102001; /// < 上交所L2实时行情 UA3202
		public final static int Msg_SSEL2_Transaction = 0x00102002; /// < 上交所L2逐笔成交 UA3201
		public final static int Msg_SSEL2_Index = 0x00102003; /// < 上交所L2指数行情 UA3113
		public final static int Msg_SSEL2_Auction = 0x00102004; /// < 上交所L2虚拟集合竞价 UA3107
		public final static int Msg_SSEL2_Overview = 0x00102005; /// < 上交所L2市场总览 UA3115
		public final static int Msg_SSEIOL1_Static = 0x00103000; /// < 上交所个股期权静态数据
		public final static int Msg_SSEIOL1_Quotation = 0x00103001; /// < 上交所个股期权实时行情 UA9002
		public final static int Msg_SZSEL1_Static = 0x00201000; /// < 深交所L1静态数据
		public final static int Msg_SZSEL1_Quotation = 0x00201001; /// < 深交所L1实时行情
		public final static int Msg_SZSEL1_Bulletin = 0x0020100C; /// < 深交所L1公告
		public final static int Msg_SZSEL2_Static = 0x00202000; /// < 深交所L2静态数据 UA101
		public final static int Msg_SZSEL2_Quotation = 0x00202001; /// < 深交所L2实时行情 UA103
		public final static int Msg_SZSEL2_Transaction = 0x00202002; /// < 深交所L2逐笔成交 UA202
		public final static int Msg_SZSEL2_Index = 0x00202003; /// < 深交所L2指数行情 UA104
		public final static int Msg_SZSEL2_Order = 0x00202006; /// < 深交所L2逐笔委托 UA201
		public final static int Msg_SZSEL2_Status = 0x00202007; /// < 深交所L2证券状态 UA102
		public final static int Msg_CFFEXL2_Static = 0x00302000; /// < 中金所L2静态数据
		public final static int Msg_CFFEXL2_Quotation = 0x00302001; /// < 中金所L2实时行情
		public final static int Msg_SHFEL1_Static = 0x00401000; /// < 上期所静态数据
		public final static int Msg_SHFEL1_Quotation = 0x00401001; /// < 上期所实时行情
		public final static int sg_CZCEL1_Static = 0x00501000; /// < 郑商所静态数据
		public final static int Msg_CZCEL1_Quotation = 0x00501001; /// < 郑商所实时行情
		public final static int Msg_ESUNNY_Index = 0x00501003; /// < 易盛指数行情
		public final static int Msg_DCEL1_Static = 0x00601000; /// < 大商所L1静态数据
		public final static int Msg_DCEL1_Quotation = 0x00601001; /// < 大商所L1深度行情
		public final static int Msg_DCEL1_ArbiQuotation = 0x00601008; /// < 大商所L1套利深度行情
		public final static int Msg_DCEL2_Static = 0x00602000; /// < 大商所L2静态数据
		public final static int Msg_DCEL2_Quotation = 0x00602001; /// < 大商所L2最优深度行情
		public final static int Msg_DCEL2_ArbiQuotation = 0x00602008; /// < 大商所L2最优套利深度行情
		public final static int Msg_DCEL2_RealTimePrice = 0x00602009; /// < 大商所L2实时结算价
		public final static int Msg_DCEL2_OrderStatistic = 0x0060200A; /// < 大商所L2委托统计行情
		public final static int Msg_DCEL2_MarchPriceQty = 0x0060200B; /// < 大商所L2分价成交量行情

	}

	static public class RetCode {
		public final static int Ret_Error = -1; /// < 失败
		public final static int Ret_Success = 0; /// < 成功
		public final static int Ret_NoAddress = 1; /// < 请先设置行情服务器地址
		public final static int Ret_NoPermission = 2; /// < 没有权限，请联系客服
		public final static int Ret_ParamInvalid = 3; /// < 参数无效
		public final static int Ret_AccountError = 4; /// < 帐号或密码错误
		public final static int Ret_AccountOutDate = 5; /// < 帐号不在有效期内
		public final static int Ret_ConnectFail = 6; /// < 连接失败
		public final static int Ret_LoginRepeat = 7; /// < 帐号重复登录
		public final static int Ret_OutTime = 8; /// < 超时
		public final static int Ret_CloseConnect = 9; /// < 连接断开
		public final static int Ret_OutLimit = 10; /// < 代码订阅数超出上限
		public final static int Ret_LowVersion = 11; /// < 版本过低

	}
}

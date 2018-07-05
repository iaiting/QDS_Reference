using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QDSCSharpSDK
{
    public struct BuySellLevelInfo3
    {
        public double Price;                  // 价格,3位小数
        public UInt64 Volume;                 // 量
        public UInt32 TotalOrderNo;           // 委托笔数
    };

    public struct SZSE_BuySellLevelInfo3
    {
        public double Price;                  // 价格,6位小数
        public double Volume;                 // 量，2位小数
        public UInt64 TotalOrderNo;           // 委托笔数
    };

    public struct AuctionUpDown
    {
        double LimitUpRate;                     // 集合竞价上涨幅度，3位小数
        double LimitDownRate;                   // 集合竞价下跌幅度，3位小数
        double LimitUpAbsolute;                 // 集合竞价上涨限价，4位小数
        double LimitDownAbsolute;               // 集合竞价下跌限价，4位小数
        double AuctionUpDownRate;               // 集合竞价有效范围涨跌幅度，3位小数
        double AuctionUpDownAbsolute;           // 集合竞价有效范围涨跌价格，4位小数
    };

    public struct SSEL2_Static
    {
        public UInt64 QDSTime;                         // 数据接收时间: 从1970/1/1开始的微秒数
        public Int64 Reserved;                         // 保留
        public Int32 Time;                               // 数据生成时间，标识接口中本记录更新时间HHMMSSMMM
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Symbol;                 // 证券代码, 
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        public string ISINCode;                       // ISIN代码, 
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string SecurityName;    // 证券名称, 
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 24)]
        public string SecurityEN;        // 英文证券名称, 
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string SymbolUnderlying;       // 基础证券代码, 
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public string MarketType;                      // 市场种类, ‘ASHR’表示A股市场；‘BSHR’表示B股市场；‘CSHR‘表示国际版市场。
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public string CFICode;                         // 证券类别, ’ES'表示股票；‘EU’表示基金；‘D’表示债券；‘RWS’表示权证；‘FF’表示期货。
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public string SecuritySubType;                 // 证券子类别, 自定义详细证券类别
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string Currency;                        // 币种, CNY = 人民币，HKD = 港币
        public double ParValue;                           // 面值,债券当前面值，单位元，其他产品取0.000
        public Int64 TradableNo;                         // 可流通未上市数量, 预留
        public Int32 EndDate;                            // 最后交易日期,对于国债预发行产品，为最后交易日期，格式为YYYYMMDD
        public Int32 ListingDate;                        // 上市日期, 在上交所首日交易日期，YYYYMMDD
        public UInt32 SetNo;                              // 产品集编号, 取值范围从1到999,。用来表明产品的一种分组方式，用于在多主机间记性负载均衡分配。该值在一个交易日内不会变化。
        public UInt32 BuyVolumeUnit;                      // 买数量单位, 买订单的申报数量必须是该字段的整数倍。
        public UInt32 SellVolumeUnit;                     // 卖数量单位, 卖订单的申报数量必须是该字段的整数倍。
        public UInt32 DeclareVolumeFloor;                 // 申报量下限, 申报数量下限
        public UInt32 DeclareVolumeCeiling;               // 申报量上限, 申报数量上限
        public double PreClosePrice;                      // 昨收价, 3位小数；前收盘价格（如有除权除息，为除权除息后的收盘价）；对于货币市场基金实时申赎，取值为0.010
        public double TickSize;                           // 最小报价单位, 申报价格的最小变动单位
        public char UpDownLimitType;                    // 涨跌幅限制类型, ‘N’表示交易规则3.4.13规定的有涨跌幅限制类型或者权证管理办法第22条规定；‘R'表示交易规则3.4.15和3.4.16规定的无涨跌幅限制类型；’S‘表示回购涨跌幅控制类型。
        public double PriceUpLimit;                       // 涨幅价格, 对于N类型涨跌幅限制的产品，该字段当日不会更改，基于前收盘价（已首日上市交易产品为发行价）计算；对于R类型五涨跌幅限制的产品，该字段取开盘时基于参考价格计算的上限价格。
        public double PriceDownLimit;                     // 跌幅价格, 计算方式参考涨幅上限价格
        public double XRRatio;                            // 除权比例, 每股送股比例；对于国债预发行产品，为保证金比例。
        public double XDAmount;                           // 除息金额, 每股分红金额
        public char CrdBuyUnderlying;                   // 融资标的标志, ’T‘表示是融资标的证券；’F‘表示不是融资标的证券。
        public char CrdSellUnderlying;                  // 融券标的标志, ’T‘表示是融拳标的证券；’F‘表示不是融券标的证券。
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string SecurityStatus;                 // 产品状态标识, 第0位对应：‘N’表示首日上市；第1位对应：‘D’表示除权；第2位对应：‘R'表示除息；第3位对应：‘D‘表示国内主板正常交易产品，‘S’表示风险警示产品，‘P’表示退市整理产品。
        public UInt32 SampleNo;                           // 样本数量, 指数当前的样本数量
        public double SampleAvgPrice;                     // 样本均价, 指数当前样本的均价,市价总值/发行股本,若该指标不统计则输出 N/A
        public double TradeAmount;                        // 成交金额, 指数当前样本的当日成交金额（单位：亿元）
        public double AvgCapital;                         // 平均股本, 指数当前样本的平均股本,（算术平均，单位：亿股）,若该指标不统计则输出 N/A
        public double TotalMarketValue;                   // 总市值, 指数当前样本的总市值汇总 （算术和， 单位： 万亿元）,若该指标不统计则输出 N/A
        public double MarketValueRatio;                   // 占比%, 指数当前样本的总市值占上证综指全样本的总市值,百分比,若该指标不统计则输出 N/A
        public double StaticPERatio;                      // 静态市盈率, 指数当前样本的静态市盈率。公式：合计（人民币收盘价*发行量） /合计（每股收益*发行量）,若该指标未统计则输出 N/A
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string IndexLevelStatus;               // 指数级别标识, 前 5 位为指数排序数值，最后一位即指数级别信息：
                                                      // 1 为重点指数
                                                      // 2 为全貌指数
                                                      // 其他可根据需要扩展。
        public Int32 TradeDate;             //市场日期,交易日 YYYYMMDD
    };

    public struct SSEL2_Quotation
    {
        public UInt64 QDSTime;                         // 数据接收时间: 从1970/1/1开始的微秒数
        public Int64 Reserved;                         // 保留
        public Int32 Time;                   // 数据生成时间, 最新订单时间（毫秒）;143025001 表示 14:30:25.001
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Symbol;     // 证券代码, 
        public double PreClosePrice;          // 昨收价, 
        public double OpenPrice;              // 开盘价, 
        public double HighPrice;              // 最高价, 
        public double LowPrice;               // 最低价, 
        public double LastPrice;              // 现价, 
        public double ClosePrice;             // 今收盘价,
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public string TradeStatus;         // 当前品种交易状态,
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string SecurityPhaseTag;   // 当前品种状态
                                          // 该字段为8位字符串，左起每位表示特定的含义，无定义则填空格。
                                          // 第1位：‘S’表示启动（开市前）时段，‘C’表示集合竞价时段，‘T’表示连续交易时段，‘B’表示休市时段，‘E’表示闭市时段，‘P’表示产品停牌，‘M’表示可恢复交易的熔断时段（盘中集合竞价），‘N’表示不可恢复交易的熔断时段（暂停交易至闭市），‘D’表示集合竞价阶段结束到连续竞价阶段开始之前的时段（如有）。
                                          // 第2位：‘0’表示此产品不可正常交易，‘1’表示此产品可正常交易，无意义填空格。
                                          // 第3位：‘0’表示未上市，‘1’表示已上市。
                                          // 第4位：‘0’表示此产品在当前时段不接受进行新订单申报，‘1’ 表示此产品在当前时段可接受进行新订单申报。无意义填空格。
        public UInt64 TotalNo;                // 成交笔数, 
        public UInt64 TotalVolume;            // 成交总量, 股票：股;权证：份;债券：手
        public double TotalAmount;            // 成交总额, （元）
        public UInt64 TotalBuyOrderVolume;    // 委托买入总量, 股票：股;权证：份;债券：手
        public double WtAvgBuyPrice;          // 加权平均委买价, （元）
        public double BondWtAvgBuyPrice;      // 债券加权平均委买价, （元）
        public UInt64 TotalSellOrderVolume;   // 委托卖出总量, 
        public double WtAvgSellPrice;         // 加权平均委卖价, （元）
        public double BondWtAvgSellPrice;     // 债券加权平均委卖价, 
        public double IOPV;                   // ETF 净值估值, 
        public Int32 ETFBuyNo;               // ETF 申购笔数, 
        public Int64 ETFBuyVolume;           // ETF 申购量, 
        public double ETFBuyAmount;           // ETF 申购额, 
        public Int32 ETFSellNo;              // ETF 赎回笔数, 
        public Int64 ETFSellVolume;          // ETF 赎回量, 
        public double ETFSellAmount;          // ETF 赎回额, 
        public double YTM;                    // 债券到期收益率, 
        public Int64 TotalWarrantExecVol;    // 权证执行的总数量, 
        public double WarrantDownLimit;       // 权证跌停价格, （元）
        public double WarrantUpLimit;         // 权证涨停价格, （元）
        public Int32 WithdrawBuyNo;          // 买入撤单笔数, 
        public Int64 WithdrawBuyVolume;      // 买入撤单量, 
        public double WithdrawBuyAmount;      // 买入撤单额, 
        public Int32 WithdrawSellNo;         // 卖出撤单笔数, 
        public Int64 WithdrawSellVolume;     // 卖出撤单量, 
        public double WithdrawSellAmount;     // 卖出撤单额, 
        public Int32 TotalBuyNo;             // 买入总笔数, 
        public Int32 TotalSellNo;            // 卖出总笔数, 
        public Int32 MaxBuyDuration;         // 买入成交最大等待时间, 
        public Int32 MaxSellDuration;        // 卖出成交最大等待时间, 
        public Int32 BuyOrderNo;             // 买方委托价位数, 
        public Int32 SellOrderNo;            // 卖方委托价位数, 
        public UInt32 SellLevelNo;            // 卖盘价位数量, 10档行情，不足时补空

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public BuySellLevelInfo3[] SellLevel;          // 十档卖行情
        public UInt32 SellLevelQueueNo01;                 // 卖一档揭示委托笔数, 为 0 表示不揭示
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
        public UInt32[] SellLevelQueue;  // 卖1档队列, 高频数据保存，先存订单数量,只有一档有此数据，50档，不足时补空
        public UInt32 BuyLevelNo;                         // 买盘价位数量, 10档行情，不足时补空
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public BuySellLevelInfo3[] BuyLevel;           // 十档买行情
        public UInt32 BuyLevelQueueNo01;                  // 买一档揭示委托笔数, 为 0 表示不揭示
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
        public UInt32[] BuyLevelQueue;   // 买1档队列, 高频数据保存，先存订单数量,只有一档有此数据，50档，不足时补空
    };

    public struct SSEL2_Transaction
    {
        public UInt64 QDSTime;             // 数据接收时间: 从1970/1/1开始的微秒数
        public Int64 Reserved;                 // 保留
        public Int32 TradeTime;              // 成交时间(毫秒), 14302506 表示14:30:25.06
        public UInt32 RecID;                  // 业务索引, 从 1 开始，按 TradeChannel连续
        public Int32 TradeChannel;           // 成交通道, 
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Symbol;     // 证券代码, 
        public double TradePrice;             // 成交价格, 
        public UInt32 TradeVolume;            // 成交数量, 股票：股;权证：份;债券：张
        public double TradeAmount;            // 成交金额, 
        public Int64 BuyRecID;               // 买方订单号, 
        public Int64 SellRecID;              // 卖方订单号, 
        public char BuySellFlag;            // 内外盘标志, B – 外盘,主动买;S – 内盘,主动卖;N – 未知
    };

    public struct SSEL2_Index
    {
        public UInt64 QDSTime;             // 数据接收时间: 从1970/1/1开始的微秒数
        public Int64 Reserved;               // 保留
        public Int32 Time;                   // 数据生成时间(毫秒), 143025000 表示 14:30:25000
        public Int32 TradeTime;              // 成交时间(毫秒),
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Symbol;     // 证券代码, 
        public double PreClosePrice;          // 昨收价, 
        public double OpenPrice;              // 开盘价, 
        public double TotalAmount;            // 成交总额, 
        public double HighPrice;              // 最高价, 
        public double LowPrice;               // 最低价, 
        public double LastPrice;              // 现价, 
        public UInt64 TotalVolume;            // 成交总量, 手
        public double ClosePrice;             // 今收盘价, 
    };

    public struct SSEL2_Auction
    {
        public UInt64 QDSTime;             // 数据接收时间: 从1970/1/1开始的微秒数
        public Int64 Reserved;                 // 保留
        public Int32 Time;                   // 数据生成时间, 143025001 表示 14:30:25.001
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Symbol;     // 证券代码, 
        public double OpenPrice;              // 虚拟开盘参考价,
        public Int64 AuctionVolume;          // 虚拟匹配量,
        public Int64 LeaveVolume;            // 虚拟未匹配量,
        public char Side;                  // 买卖方向, 0=无未匹配量，买卖两边的未匹配量都为 0;1=买方有未匹配量，卖方未匹配量=0;2=卖方有未匹配量，买方未匹配量=0
    };

    public struct SSEL2_Overview
    {
        public UInt64 QDSTime;             // 数据接收时间: 从1970/1/1开始的微秒数
        public Int64 Reserved;                 // 保留
        public Int32 Time;                   // 数据生成时间, 143025001 表示 14:30:25.001
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Symbol;     // 证券代码, 
        public Int32 MarketTime;             // 市场时间, 百分之一秒
        public Int32 TradeDate;              // 市场日期,
    };

    public struct SZSEL2_Static
    {
        public UInt64 QDSTime;                         // 数据接收时间: 从1970/1/1开始的微秒数
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Symbol;     // 证券代码, 
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string SecurityName;                      // 证券名称，可能包含中文字符，表示最多 40个 UTF-8 字符
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string SymbolSource;        // 证券代码源，102 = 深圳证券交易所
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string SecurityEN;                        // 证券英文简称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        public string ISINCode;                          // ISIN 代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string SymbolUnderlying;                  // 基础证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string UnderlyingSecurityIDSource;         // 基础证券代码源
        public Int32 SecurityType;                         // 证券类别代码，1主板 A股； 2中小板股票；3创业板股票；4主板 B股；5国债 （含地方债）；6企业债；
                                                    // 7公司债；8可转债；9私募债；10可交换私募债；11证券公司次级债；12质押式回购；13资产支持证券；
                                                    // 14本市场股票ETF；15跨市场ETF；16跨境ETF；17本市场实物债券ETF；18现金债券ETF；19黄金ETF；20货币ETF；
                                                    // 21（预留）杠杆ETF;22(预留)商品期货ETF；23标准LOF;24分级子基金；25封闭式基金；26仅申赎基金；28权证；
                                                    // 29个股期权；30ETF期权；33优先股；34证券公司短期债；35可交换公司债
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string SecurityStatusTag;                 // 证券状态标识，该字段为20位字符串（后六位备用），
                                                         // 每位表示特定的含义，“1”表示位数有业务意义，“0”表示该位数无业务意义。第1位对应：“1”表示停牌；
                                                         // 第2位对应：“1”表示除权；第3位对应：“1”表示除息；第4位对应：“1”表示ST;第5位对应：“1”表示*ST;
                                                         // 第6位对应：“1”表示上市首日；第7位对应：“1”表示公司再融资；第8位对应：“1”表示恢复上市首日；
                                                         // 第9位对应：“1”表示网络投票；第10位对应：“1”表示退市整理期；第12位对应：“1”表示增发股份上市；
                                                         // 第13位对应：“1”表示合约调整；第14位对应：“1”表示暂停上市后协议转让。
        public double PreClosePrice;                       // 昨日收盘价，4位或5位小数
        public Int32 ListingDate;                          // 上市日期
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string Currency;                           // 币种，CNY = 人民币，HKD = 港币
        public double ParValue;                            // 每股面值，4位小数
        public double IssuedVolume;                        // 总发行量，2位小数
        public double OutstandingShare;                    // 流通股数，2位小数
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string IndustryType;                       // 行业种类
        public double PreYearEPS;                          // 上年每股利润，4位小数
        public  double YearEPS;                             // 本年每股利润，4位小数
        public  char OfferingFlag;                          // 收购（转股、行权）标志，股票：要约收购；债券、优先股：转股回售；Y=是，N=否
        public double NAV;                                 // 基金T-1日累计净值，4位小数
        public  double CouponRate;                          // 票面利率，4位小数
        public double IssuePrice;                          // 贴现发行价，4位小数
        public double Interest;                            // 每百元应计利息，8位小数，优先股：0.0000 表示浮动股息率
        public  Int32 InterestAccrualDate;                  // 起息日
        public  Int32 MaturityDate;                       // 到期交割日
        public  double ConversionPrice;                    // 行权价格，4位小数
        public double ConversionRatio;                    // 行权比例，4位小数
        public  Int32 ConversionBeginDate;                // 行权开始日
        public Int32 ConversionEndDate;                  // 行权结束日
        public char CallOrPut;                          // 认购认沽，C = Call，P = Put
        public char WarrantClearingType;                // 权证结算方式，S = 证券结算，C = 现金结算
        public double ClearingPrice;                      // 结算价格，适用于权证，4位小数
        public char OptionType;                         // 行权类型，A = 美式，E = 欧式，B = 百慕大式
        public Int32 EndDate;                           // 最后交易日
        public Int32 ExpirationDays;                     // 购回期限
        public char DayTrading;                            // 回转交易标志，是否支持当日回，转交易：Y=支持，N=不支持
        public  char GageFlag;                           // 保证金证券标志，是否可作为融资，融券可充抵保证，金证券：Y=是，N=否
        public double GageRate;                           // 担保品折算率，2位小数
        public  char CrdBuyUnderlying;                   // 融资标的标志，Y=是，N=否
        public  char CrdSellUnderlying;                  // 融券标的标志，Y=是，N=否
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string CrdPriceCheckType;               // 提价检查方式，0=不检查，1=不低于最近成交价，2=不低于昨收价，3=不低于最高叫买，4=不低于最低叫卖
        public  char PledgeFlag;                         // 质押入库标志，是否可质押入库:Y=是，N=否
        public  double ContractMultiplier;                 // 债券折合回购标准券比例，4位小数
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string RegularShare;                    // 对应回购标准券
        public  char QualificationFlag;                  // 投资者适当性管理标志，是否需要对该证券作投资者适当性管理，Y=是，N=否
        public  char MarketMakerFlag;                    // 做市商标志，标识是否有做市商，Y=是，N=否
        public  double RoundLot;                           // 整手数(2位有效小数)，对于某一证券申报的委托，其委托数量字段必须为该证券数量单位的整数倍
        public double TickSize;                           // 最小报价单位，4位小数
        public  double BuyQtyUpperLimit;                   // 买数量上限，2位小数
        public  double SellQtyUpperLimit;                  // 卖数量上限，2位小数
        public double BuyVolumeUnit;                      // 买数量单位，每笔买委托的委托数量必须是买数量单位的整数倍，2位小数
        public double SellVolumeUnit;                     // 卖数量单位，每笔卖委托的委托数量必须是卖数量单位的整数倍，2位小数
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public AuctionUpDown[] OTC;
        public Int32 TradeDate;                         //市场日期,交易日
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string QualificationClass;               //投资者适当性管理分类
    };


    public struct SZSEL2_Quotation
    {
        public UInt64 QDSTime;                         // 数据接收时间: 从1970/1/1开始的微秒数
        public Int64 Time;                               // 数据生成时间YYYYMMDDHHMMSSMMM
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Symbol;                    // 证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string SymbolSource;        // 证券代码源
        public double PreClosePrice;                      // 昨日收盘价,4位小数
        public double OpenPrice;                          // 开盘价,6位小数
        public double LastPrice;                          // 现价,6位小数
        public double HighPrice;                          // 最高价,6位小数
        public double LowPrice;                           // 最低价,6位小数
        public double PriceUpLimit;                       // 涨停价,6位小数
        public double PriceDownLimit;                     // 跌停价,6位小数
        public double PriceUpdown1;                       // 升跌一,6位小数
        public double PriceUpdown2;                       // 升跌二,6位小数
        public UInt64 TotalNo;                            // 成交笔数
        public double TotalVolume;                        // 成交总量,2位小数
        public double TotalAmount;                        // 成交总金额,4位小数
        public double ClosePrice;                         // 今收盘价，6位小数
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string SecurityPhaseTag;      // 当前品种交易状态：产品所处的交易阶段代码：
                                             // 第 0 位：S=启动（开市前），O=开盘集合竞价， T=连续,B=休市
                                             //          C=收盘集合竞价,E=已闭市,H=临时停牌,A=盘后交易,V=波动性中断;
                                             // 第 1 位：0=正常状态,1=全天停牌"
        public double PERatio1;                           // 市盈率 1,6位小数
        public double NAV;                                // 基金 T-1 日净值,6位小数
        public double PERatio2;                           // 市盈率 2,6位小数
        public double IOPV;                               // 基金实时参考净值,6位小数
        public double PremiumRate;                        // 权证溢价率,6位小数
        public double TotalSellOrderVolume;               // 委托卖出总量（有效竞价范围内）2位小数
        public double WtAvgSellPrice;                     // 加权平均卖出价格（有效竞价范围内）,6位小数
        public UInt32 SellLevelNo;                        // 申卖档位数（价格由低至高）
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public SZSE_BuySellLevelInfo3[] SellLevel;

        public UInt32 SellLevelQueueNo01;                 // 卖一档揭示委托笔数
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
        public double[] SellLevelQueue;  	// 揭示卖一价前50笔委托，50档，不足补0，2位小数
        public double TotalBuyOrderVolume;                // 委托买入总量（有效竞价范围内），2位小数
        public double WtAvgBuyPrice;                      // 加权平均买入价格（有效竞价范围内）,6位小数
        public UInt32 BuyLevelNo;                         // 申买档位数（价格由高至低）

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public SZSE_BuySellLevelInfo3[] BuyLevel;      // 十档买行情
        public UInt32 BuyLevelQueueNo01;                  // 买一档揭示委托笔数
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
        public double[] BuyLevelQueue;      // 揭示买一价前50笔委托，50档，不足补0，2位小数
        public double WtAvgRate;            // 实时加权平均利率    质押式回购产品实时行情增加三个字段
        public double WtAvgRateUpdown;                    //加权平均利率涨跌BP
        public double PreWtAvgRate;                       //昨收盘加权平均利率

    };

    public struct SZSEL2_Transaction
    {
        public UInt64 QDSTime;                         // 数据接收时间: 从1970/1/1开始的微秒数
        public UInt32 SetID;                              // 证券集代号
        public UInt64 RecID;                              // 消息记录号 从 1 开始计数，同一频道连续
        public UInt64 BuyOrderID;                         // 买方委托索引
        public UInt64 SellOrderID;                        // 卖方委托索引
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Symbol;                    // 证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string SymbolSource;        // 证券代码源
        public Int64 TradeTime;                          // 成交时间YYYYMMDDHHMMSSMMM
        public  double TradePrice;                         // 成交价格,4位小数
        public double TradeVolume;                        // 成交数量,2位小数
        public char TradeType;                          // 成交类别：4=撤销，主动或自动撤单执行报告；F=成交，成交执行报告
    };

    public struct SZSEL2_Index
    {
        public UInt64 QDSTime;                         // 数据接收时间: 从1970/1/1开始的微秒数
        public Int64 Time;                               // 数据生成时间YYYYMMDDHHMMSSMMM
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Symbol;                    // 证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string SymbolSource;        // 102=深圳证券交易所, 103=香港交易所
        public double PreClosePrice;                      // 前收盘指数,6位小数
        public double OpenPrice;                          // 今开盘指数,6位小数
        public double HighPrice;                          // 最高指数,6位小数
        public double LowPrice;                           // 最低指数,6位小数
        public double LastPrice;                          // 最新指数,6位小数
        public double TotalAmount;                        // 参与计算相应指数的成交金额,4位小数
        public UInt64 TotalNo;                             // 参与计算相应指数的成交笔数
        public double TotalVolume;                         // 参与计算相应指数的交易数量，2位小数
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string SecurityPhaseTag;      // 当前品种交易状态
        public UInt32 SampleNo;                            // 样本个数
    };

    public struct SZSEL2_Order
    {
        public UInt64 QDSTime;                         // 数据接收时间: 从1970/1/1开始的微秒数
        public UInt32 SetID;                              // 频道代码
        public UInt64 RecID;                              // 消息记录号:从 1 开始计数，同一频道连续
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Symbol;                    // 证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string SymbolSource;         // 证券代码源
        public Int64 Time;                               // 委托时间YYYYMMDDHHMMSSMMM
        public double OrderPrice;                         // 委托价格,4位小数
        public double OrderVolume;                        // 委托数量,2位小数
        public char OrderCode;                          // 买卖方向：1=买 2=卖 G=借入 F=出借
        public char OrderType;                          // 订单类别：1=市价 2=限价 U=本方最优
    };

    public struct SZSEL2_Status
    {
        public UInt64 QDSTime;                     // 数据接收时间: 从1970/1/1开始的微秒数
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Symbol;                    // 证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string SymbolSource;         // 证券代码源，102=深圳证券交易所，103=香港交易所
        public Int64 Time;                                 // 数据生成时间YYYYMMDDHHMMSSMMM
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string FinancialStatus;                    // A=上市公司早间披露提示,
                                                          // B=上市公司午间披露提示,
                                                          // 每个字节揭示一种状态，最多可同时揭示八种状态
        public char CrdBuyStatus;                       // 适用于融资标的证券。1= 开放,0=暂停，空格无意义
        public char CrdSellStatus;                      // 适用于融券标的证券。1= 开放,0=暂停，空格无意义
        public char SubscribeStatus;                    // 适用于 ETF， LOF 等开放式基金，对于黄金 ETF 是指现金申购。1= 是,0= 否，空格无意义
        public char RedemptionStatus;                   // 适用于 ETF， LOF 等开放式基金，对于黄金 ETF 是指现金赎回开关。1= 是,0= 否，空格无意义
        public char PurchasingStatus;                   // 适用于网上发行认购代。1= 是,0= 否，空格无意义
        public char StockDiviStatus;                    // 适用于处于转股回售期的可转债。1= 是,0= 否，空格无意义
        public char PutableStatus;                      // 适用于处于转股回售期的可转债。1= 是,0= 否，空格无意义
        public char ExerciseStatus;                     // 适用于处于行权期的权证。1= 是,0=否，空格无意义
        public char GoldPurchase;                       // 适用于黄金ETF实物申购。1= 是,0= 否，空格无意义
        public char GoldRedemption;                     // 适用于黄金ETF实物赎回。1= 是,0= 否，空格无意义
        public char AcceptedStatus;                     // 适用于处于要约收购期的股票。1= 是,0= 否，空格无意义
        public char ReleaseStatus;                      // 适用于处于要约收购期的股票。1= 是,0= 否，空格无意义
        public char CancStockDiviStatus;                // 适用于处于转股回售期的可转债。1= 是,0= 否，空格无意义
        public char CancPutableStatus;                  // 适用于处于转股回售期的可转债。1= 是,0= 否，空格无意义
        public char PledgeStatus;                       // 适用于质押式回购可质押入库证券。1= 是,0= 否，空格无意义
        public char RemovePledge;                       // 适用于质押式回购可质押入库证券。1= 是,0= 否，空格无意义
        public char VoteStatus;                         // 适用于优先股。1= 是,0= 否，空格无意义
        public char StockPledgeRepo;                    // 适用于可开展股票质押式回购业务的证券。1= 是,0= 否，空格无意义
        public char DivideStatus;                       // 适用于分级基金。1= 是,0= 否，空格无意义
        public char MergerStatus;                       // 适用于分级基金。1= 是,0= 否，空格无意义
    };

}

from enum import Enum

class MsgType(Enum):
        Msg_Unknown = 0x00000000
        Msg_SSEL1_Static = 0x00101000
        Msg_SSEL1_Quotation = 0x00101001
        Msg_SSE_IndexPress = 0x0010100D
        Msg_SSEL2_Static = 0x00102000 
        Msg_SSEL2_Quotation = 0x00102001
        Msg_SSEL2_Transaction = 0x00102002
        Msg_SSEL2_Index = 0x00102003
        Msg_SSEL2_Auction = 0x00102004
        Msg_SSEL2_Overview = 0x00102005
        Msg_SSEIOL1_Static = 0x00103000
        Msg_SSEIOL1_Quotation = 0x00103001
        Msg_SZSEL1_Static = 0x00201000
        Msg_SZSEL1_Quotation = 0x00201001
        Msg_SZSEL1_Bulletin = 0x0020100C
        Msg_SZSEL2_Static = 0x00202000
        Msg_SZSEL2_Quotation = 0x00202001
        Msg_SZSEL2_Transaction = 0x00202002
        Msg_SZSEL2_Index = 0x00202003
        Msg_SZSEL2_Order = 0x00202006
        Msg_SZSEL2_Status = 0x00202007
        Msg_CFFEXL2_Static = 0x00302000
        Msg_CFFEXL2_Quotation = 0x00302001
        Msg_SHFEL1_Static = 0x00401000
        Msg_SHFEL1_Quotation = 0x00401001
        Msg_CZCEL1_Static = 0x00501000
        Msg_CZCEL1_Quotation = 0x00501001
        Msg_ESUNNY_Index = 0x00501003
        Msg_DCEL1_Static = 0x00601000
        Msg_DCEL1_Quotation = 0x00601001
        Msg_DCEL1_ArbiQuotation = 0x00601008
        Msg_DCEL2_Static = 0x00602000
        Msg_DCEL2_Quotation = 0x00602001
        Msg_DCEL2_ArbiQuotation = 0x00602008
        Msg_DCEL2_RealTimePrice = 0x00602009
        Msg_DCEL2_OrderStatistic = 0x0060200A
        Msg_DCEL2_MarchPriceQty = 0x0060200B

class RetCode(Enum):
    Ret_Error = -1
    Ret_Success = 0
    Ret_NoAddress = 1
    Ret_NoPermission = 2
    Ret_ParamInvalid = 3
    Ret_AccountError = 4
    Ret_AccountOutDate = 5,
    Ret_ConnectFail = 6
    Ret_LoginRepeat = 7
    Ret_OutTime = 8
    Ret_CloseConnect = 9
    Ret_OutLimit = 10
    Ret_LowVersion = 11
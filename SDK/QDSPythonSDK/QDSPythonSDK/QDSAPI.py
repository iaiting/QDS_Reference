from QDSApiCallbackBase import QDSApiCallbackBase
from QDSApiCallbackBaseDelegate import cLib

class QDSAPI:
    @classmethod
    def CreateInstance(Obj):
        return cLib.CreateInstance()
    
    @classmethod
    def RegisterService(Obj, ip, port):
        return cLib.RegisterService(ip, port)

    @classmethod
    def Login(Obj, publicKey, secretKey, bWAN):
        return cLib.Login(publicKey, secretKey, bWAN)

    @classmethod
    def Login2(Obj, userName, bWAN):
        return cLib.Login2(userName, bWAN)

    @classmethod
    def Subscribe(Obj, msgType, codeList):
        return cLib.Subscribe(msgType, codeList)

    @classmethod
    def Unsubscribe(Obj, msgType, codeList):
        return cLib.Unsubscribe(msgType, codeList)

    @classmethod
    def UnsubscribeAll(Obj):
        return cLib.UnsubscribeAll()

    @classmethod
    def ReleaseInstance(Obj):
        return cLib.ReleaseInstance()
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace QDSCSharpSDK
{
    public class QDSAPI
    {
        [DllImport("wQDSApi.dll", EntryPoint = "CreateInstance")]
        public static extern void CreateInstance();

        [DllImport("wQDSApi.dll", EntryPoint = "QDSTimeToStr")]
        public static extern string QDSTimeToStr(UInt64 us);

        [DllImport("wQDSApi.dll", EntryPoint = "RegisterService")]
        public static extern RetCode RegisterService(string ip, UInt16 port);

        [DllImport("wQDSApi.dll", EntryPoint = "Login2")]
        public static extern RetCode Login2(string userName, bool bWAN);

        [DllImport("wQDSApi.dll", EntryPoint = "Login")]
        public static extern RetCode Login(string publicKey , string secretKey, bool bWAN);

        [DllImport("wQDSApi.dll", EntryPoint = "Subscribe")]
        public static extern RetCode Subscribe(MsgType msgType, string codeList);

        [DllImport("wQDSApi.dll", EntryPoint = "Unsubscribe")]
        public static extern RetCode Unsubscribe(MsgType msgType, string codeList);

        [DllImport("wQDSApi.dll", EntryPoint = "UnsubscribeAll")]
        public static extern RetCode UnsubscribeAll();

        [DllImport("wQDSApi.dll", EntryPoint = "ReleaseInstance")]
        public static extern void ReleaseInstance();
    }
}

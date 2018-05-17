using System;
using QDSCSharpSDK;
using System.Threading;
using System.Collections.Generic;

namespace QDS.Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> allArgs = PhaseArgs(args);

            //基础接口及回调实例化
            CallbackBase callback = new CallbackBase();
            QDSAPI.CreateInstance();
            QDSApiCallbackBaseDelegate.Bind(callback);

            //连接ip地址、端口及登录公钥、私钥
            string ip = allArgs.ContainsKey("-s") ? allArgs["-s"] : "222.186.50.178";
            ushort port = allArgs.ContainsKey("-p") ? ushort.Parse(allArgs["-p"]) : (ushort)8889;
            string publicKey = allArgs.ContainsKey("-k") ? allArgs["-k"] : "Jt?Wb=3mDe64R9u@+HrL9.kPt?{x?:sbc*r3[G5s";
            string secretKey = allArgs.ContainsKey("-K") ? allArgs["-K"] : "Gmz9m9HfgbVBT2-JRtj6v69nZJ3jbn[c@k1bLEJm";
            bool bWAN = allArgs.ContainsKey("-w");

            //连接
            QDSAPI.RegisterService(ip, port);

            //登录
            Console.WriteLine("start login");
            RetCode ret = RetCode.Ret_Success;
            while (true)
            {
                ret = QDSAPI.Login(publicKey, secretKey, bWAN);
                if (ret == 0)
                    break;
                else
                {
                    int wait = 5;
                    Console.WriteLine("LoginX error=" + ret);
                    Console.WriteLine("will retry after " + wait + " seconds");
                    Thread.Sleep(5000);
                }
            }
            Console.WriteLine("login success");


            //订阅
            if (allArgs.ContainsKey("-A"))
            {
                //全部订阅
                QDSAPI.Subscribe(MsgType.Msg_SSEL2_Static, null);    //上交所L2静态数据
                QDSAPI.Subscribe(MsgType.Msg_SSEL2_Quotation, null);    //上交所L2实时行情
                QDSAPI.Subscribe(MsgType.Msg_SSEL2_Transaction, null);      //上交所L2逐笔成交
                QDSAPI.Subscribe(MsgType.Msg_SSEL2_Index, null);    //上交所L2指数行情
                QDSAPI.Subscribe(MsgType.Msg_SSEL2_Auction, null);      //上交所L2虚拟集合竞价
                QDSAPI.Subscribe(MsgType.Msg_SSEL2_Overview, null);     //上交所L2时长总览
                QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Static, null);      //深交所L2静态数据
                QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Quotation, null);       //深交所L2实时行情
                QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Transaction, null);     //深交所L2逐笔成交
                QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Index, null);       //深交所L2逐笔成交
                QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Order, null);       //深交所L2逐笔委托
                QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Status, null);		//深交所L2逐笔成交
            }
            else
            {
                //订阅代码
                string symbols = "000001,002001,300001";

                //订阅深交所L2实时行情
                ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Quotation, symbols);
                if (ret != RetCode.Ret_Success)
                {
                    Console.WriteLine("subscribe1 error:" + ret);
                }
                Console.WriteLine("sunscribe1 success");

                //订阅深交所L2逐笔委托
                ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Order, symbols);
                if (ret != RetCode.Ret_Success)
                {
                    Console.WriteLine("subscribe error:" + ret);
                }
                Console.WriteLine("sunscribe2 success");


                //订阅深交所L2逐笔成交
                ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Transaction, symbols);
                if (ret != RetCode.Ret_Success)
                {
                    Console.WriteLine("subscribe error:" + ret);
                }
                Console.WriteLine("sunscribe3 success");

                //订阅深交所L2证券状态
                ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Status, symbols);
                if (ret != RetCode.Ret_Success)
                {
                    Console.WriteLine("subscribe error:" + ret);
                }
                Console.WriteLine("sunscribe4 success");

                //订阅深交所L2静态数据
                ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Static, symbols);
                if (ret != RetCode.Ret_Success)
                {
                    Console.WriteLine("subscribe error:" + ret);
                }
                Console.WriteLine("sunscribe5 success");
            }

            

            //挂起当前线程，直至按下回车后取消订阅并结束
            Console.WriteLine("press enter to unsunscribe");
            Console.ReadKey(); 

            //取消订阅所有内容
            ret = QDSAPI.UnsubscribeAll();
            if (ret != RetCode.Ret_Success)
                Console.WriteLine("UnsubscribeAll error:" + ret);
            Console.WriteLine("unsunscribeAll success");

            //删除实例
            QDSAPI.ReleaseInstance();
        }

        //将命令行参数存入到字典
        static Dictionary<string, string> PhaseArgs(string[] args)
        {
            Dictionary<string, string> argDict = new Dictionary<string, string>();
            for (int i = 0; i < args.Length; i++)
            {
                string str = args[i];
                if (str == "-s" || str == "-p" || str == "-k" || str == "-K" || str == "-f")
                {
                    if (i < args.Length - 1 && args[i+1][0] != '-')
                    {
                        argDict.Add(str, args[i + 1]);
                        i++;
                    }
                    else
                    {
                        throw new Exception("读取参数列表错误");
                    }
                }
                else if (str == "-w" || str == "-A")
                    argDict.Add(str, "");
            }

            return argDict;
        }

    }
}

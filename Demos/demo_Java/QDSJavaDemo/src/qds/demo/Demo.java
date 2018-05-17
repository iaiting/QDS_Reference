package qds.demo;

import java.lang.String;
import java.util.HashMap;
import java.util.Map;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import qds.api.*;
import qds.api.QDSDataType.*;

public class Demo {
	
	public static void main(String[] args) throws IOException, InterruptedException {
		Map<String, String> allArgs = Demo.PhaseArgs(args);
		
		QDSAPI.CreateInstance();
		
//		//基础接口及回调实例化
		CallBackBase callback = new CallBackBase();
		QDSApiCallbackBaseDelegate.Bind(callback);;
//
		//连接ip地址、端口及登录公钥、私钥
		String ip = allArgs.containsKey("-s") ? allArgs.get("-s") : "222.186.50.178";
        char port = allArgs.containsKey("-p") ?  (char)Integer.parseInt(allArgs.get("-p")) : 8889;
        String publicKey = allArgs.containsKey("-k") ? allArgs.get("-k") : "Jt?Wb=3mDe64R9u@+HrL9.kPt?{x?:sbc*r3[G5s";
        String secretKey = allArgs.containsKey("-K") ? allArgs.get("-K") : "Gmz9m9HfgbVBT2-JRtj6v69nZJ3jbn[c@k1bLEJm";
        boolean bWAN = allArgs.containsKey("-w");
		
		//连接
		QDSAPI.RegisterService(ip, port);
		
		//登录
		System.out.println("start login");
		int ret = RetCode.Ret_Success;
		while (true) {
			ret = QDSAPI.Login(publicKey, secretKey, bWAN);
			if (ret == RetCode.Ret_Success)
				break;
			else {
				int wait = 5;
				System.out.println("login error=" + ret);
				System.out.println("will retry after " + wait + " seconds");
				Thread.sleep(wait * 1000);
			}
		}
		System.out.println("login success");

		if (allArgs.containsKey("-A"))
		{
			//全部订阅
            QDSAPI.Subscribe(MsgType.Msg_SSEL2_Static, null);	 //上交所L2静态数据
            QDSAPI.Subscribe(MsgType.Msg_SSEL2_Quotation, null);	//上交所L2实时行情
            QDSAPI.Subscribe(MsgType.Msg_SSEL2_Transaction, null);		//上交所L2逐笔成交
            QDSAPI.Subscribe(MsgType.Msg_SSEL2_Index, null);	//上交所L2指数行情
            QDSAPI.Subscribe(MsgType.Msg_SSEL2_Auction, null);		//上交所L2虚拟集合竞价
            QDSAPI.Subscribe(MsgType.Msg_SSEL2_Overview, null);		//上交所L2时长总览
            QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Static, null);		//深交所L2静态数据
            QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Quotation, null);		//深交所L2实时行情
            QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Transaction, null);		//深交所L2逐笔成交
            QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Index, null);		//深交所L2逐笔成交
            QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Order, null);		//深交所L2逐笔委托
            QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Status, null);		//深交所L2逐笔成交
		}
		else
		{
			//订阅代码
			String symbols = "000001,002001,300001";
			
			//深交所L2实时行情
			ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Quotation, symbols);
			if (ret != RetCode.Ret_Success) {
				System.out.println("subscribe error:" + ret);
			}
			System.out.println("sunscribe1 success");
			
			//深交所L2逐笔委托
			ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Order, symbols);
			if (ret != RetCode.Ret_Success) {
				System.out.println("subscribe error:" + ret);
			}
			System.out.println("sunscribe2 success");

			//深交所L2逐笔成交
			ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Transaction, symbols);
			if (ret != RetCode.Ret_Success) {
				System.out.println("subscribe error:" + ret);
			}
			System.out.println("sunscribe3 success");

			//深交所L2证券状态
			ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Status, symbols);
			if (ret != RetCode.Ret_Success) {
				System.out.println("subscribe error:" + ret);
			}
			System.out.println("sunscribe4 success");

			//深交所L2静态数据
			ret = QDSAPI.Subscribe(MsgType.Msg_SZSEL2_Static, symbols);
			if (ret != RetCode.Ret_Success) {
				System.out.println("subscribe error:" + ret);
			}
			System.out.println("sunscribe5 success");


		}
		
		//挂起当前线程，直至按下回车后取消订阅并结束程序
		System.out.println("press enter to unsunscribe");
		InputStreamReader is_reader = new InputStreamReader(System.in);
		new BufferedReader(is_reader).readLine();	
		
		
		//取消所有订阅内容
		ret = QDSAPI.UnsubscribeAll();
		if (ret != RetCode.Ret_Success)
			System.out.println("UnsubscribeAll error:" + ret);
		System.out.println("unsunscribeAll success");

		//删除实例
		QDSAPI.ReleaseInstance();
	}
	
	
	//将命令行参数存入到字典
    static public Map<String, String> PhaseArgs(String[] args)
    {
    	Map<String, String> argDict = new HashMap<String, String>();
        for (int i = 0; i < args.length; i++)
        {
            String str = args[i];
            if (str.equals("-s")|| str.equals("-p") || str.equals("-k") || str.equals("-K") || str.equals("-f"))
            {
                if (i < args.length - 1 && args[i+1].substring(0, 1).equals("-") == false)
                {
                    argDict.put(str, args[i + 1]);
                    i++;
                }
            }
            else if (str.equals("-w") || str.equals("-A"))
                argDict.put(str, "");
        }

        return argDict;
    }
}

package qds.api;

import java.lang.String;

import com.sun.jna.Library;
import com.sun.jna.Native;

//基础接口
public class QDSAPI {
	

	public interface CLibrary extends Library
    {
		void CreateInstance();
		int RegisterService(String ip, char port);
		int Login(String publicKey, String secretKey, boolean bWAN);
		int Login2(String userName, boolean bWAN);
		int Subscribe(int msgType, String codeList);
		int Unsubscribe(int msgType, String codeList);
		int UnsubscribeAll();
		void ReleaseInstance();
    }
	
	private static CLibrary lib = (CLibrary)Native.loadLibrary("wQDSApi.dll",CLibrary.class); 
	
	public static void CreateInstance()
	{
		lib.CreateInstance();
	}
	
	public static int RegisterService(String ip, char port)
	{
		return lib.RegisterService(ip, port);
	}
	
	public static int Login(String publicKey, String secretKey, boolean bWAN)
	{
		return lib.Login(publicKey, secretKey, bWAN);
	}
	
	public static int Login2(String userName, boolean bWAN)
	{
		return lib.Login2(userName, bWAN);
	}
	
	public static int Subscribe(int msgType, String codeList)
	{
		return lib.Subscribe(msgType, codeList);
	}
	
	public static int Unsubscribe(int msgType, String codeList)
	{
		return lib.Unsubscribe(msgType, codeList);
	}
	
	public static int UnsubscribeAll()
	{
		return lib.UnsubscribeAll();
	}
	
	public static void ReleaseInstance()
	{
		lib.ReleaseInstance();
	}
	
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlyweightPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			string CookieStr = string.Empty;

			string result = "";

			for(int i = 0;i < 10000;i++)
			{
				CookieStr = string.Empty; //每次都清除cookie SessionID
				result = SimulatedGet("",ref CookieStr);
				result = result.Replace("\r\n","\r");
				string[] html = result.Split('\r');
				Console.WriteLine(html[0]);
				Thread.Sleep(10);
			}

			//string userId = Session["userId"].ToString();
			//User U = UserManager.getUser(userId);
		}
		private static string SimulatedGet(string Url,ref string CookieStr)
		{
			//GET /NewsAdmin/Login.aspx HTTP/1.1
			//Host: localhost
			//User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64; rv:33.0) Gecko/20100101 Firefox/33.0
			//Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8
			//Accept-Language: zh-cn,zh;q=0.8,en-us;q=0.5,en;q=0.3
			//Accept-Encoding: gzip, deflate
			//Connection: keep-alive
			string result = "";
			WebClient context = new WebClient();

			context.Headers.Add("Host: localhost");
			context.Headers.Add("User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64; rv:33.0) Gecko/20100101 Firefox/33.0");
			context.Headers.Add("Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
			context.Headers.Add("Accept-Language: zh-cn,zh;q=0.8,en-us;q=0.5,en;q=0.3");
			context.Headers.Add("Content-Type: multipart/form-data");
			context.Headers.Add("Accept-Encoding: gzip, deflate");
			context.Headers.Add("Cache-Control: no-cache"); //Connection: keep-alive

			if(!string.IsNullOrEmpty(CookieStr))
			{
				context.Headers.Add(CookieStr); //把cookie添加到请求报文头中。
			}
			context.Encoding = Encoding.UTF8;

			result = context.DownloadString(Url);

			if(string.IsNullOrEmpty(CookieStr))
			{
				CookieStr = context.ResponseHeaders["Set-Cookie"].ToString();
				CookieStr = GetCookie(CookieStr);
			}
			return result;
		}
		private static string GetCookie(string CookieStr)
		{
			string result = "";
			string[] myArray = CookieStr.Split(',');
			if(myArray.Count() > 0)
			{
				result = "Cookie: ";
				foreach(var str in myArray)
				{
					string[] CookieArray = str.Split(';');
					result += CookieArray[0].Trim();
					result += "; ";
				}
				result = result.Substring(0,result.Length - 2);
			}
			return result;
		}
	}
}

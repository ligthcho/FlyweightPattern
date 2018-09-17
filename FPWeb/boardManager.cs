
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FPWeb
{
	public static class boardManager
	{
		public static Dictionary<string,board> Boards = new Dictionary<string,board>();
		/// <summary>
		/// 把2个人丢进实体
		/// </summary>
		/// <param name="redUserId"></param>
		/// <param name="grayUserId"></param>
		/// <returns></returns>
		public static board getBoard(string redUserId,string grayUserId)
		{
			string Key = (Convert.ToInt32(redUserId) > Convert.ToInt32(grayUserId)) ? (redUserId + "_" + grayUserId) : (grayUserId + "_" + redUserId);
			if(Boards.ContainsKey(Key))
			{
				return (Boards[Key]);
			}
			else
			{
				Boards.Add(Key,new board(redUserId,grayUserId));
			}
			return (Boards[Key]);
		}
	}
}
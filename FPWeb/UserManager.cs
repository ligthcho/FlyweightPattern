using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPWeb
{
	public static class UserManager
	{
		public static Dictionary<string,User> Users = new Dictionary<string,User>();
		/// <summary>
		/// 把UserId作为key放进Users集合里
		/// </summary>
		/// <param name="UserId"></param>
		/// <returns></returns>
		public static User getUser(string UserId)
		{
			if(Users.ContainsKey(UserId))
			{
				return (Users[UserId]);
			}
			else
			{
				Users.Add(UserId,new User(UserId));
			}
			return (Users[UserId]);
		}
	}
}

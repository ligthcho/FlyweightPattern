using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FPWeb
{
	public partial class Index:System.Web.UI.Page
	{
		protected void Page_Load(object sender,EventArgs e)
		{
			string userId = Session["userId"].ToString();
			User U = UserManager.getUser(userId);
			board B = boardManager.getBoard(U.userId,U.enmyUserId);

			lock(typeof(boardManager))
            {
				//连续多次修改静态类某些全局变量
			}
		}
	}
}
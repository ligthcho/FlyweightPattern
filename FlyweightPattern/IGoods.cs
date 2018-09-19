using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
	/// <summary>
	/// 商品接口 --抽象享元角色
	/// </summary>
	public interface IGoods
	{
		/// <summary>
		/// 用来展示商品的价格
		/// </summary>
		/// <param name="name"></param>
		void showGoodsPrice(string name);
	}
}

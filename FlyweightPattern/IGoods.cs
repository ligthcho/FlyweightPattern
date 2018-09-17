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
	   void showGoodsPrice(string name);
	}
}

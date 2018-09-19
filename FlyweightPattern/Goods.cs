using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
	/// <summary>
	/// 商品类--具体享元角色
	/// </summary>
	public class Goods:IGoods
	{
		private string name;//名称
		private string version;//版本
		public Goods(string name)
		{
			this.name = name;
		}
		public void showGoodsPrice(string version)
		{
			if(version.Equals("32G"))
			{
				Console.WriteLine("价格为5199元");
			}
			else if(version.Equals("128G"))
			{
				Console.WriteLine("价格为5999元");
			}
		}
	}
}

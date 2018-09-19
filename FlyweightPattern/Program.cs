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
			///某宝商城卖商品，如果每个用户下单都生成商品对象显然会耗费很多资源，如果赶上双11，那恐怖的订单量会生成很多商品对象，更何况商城卖的商品种类繁多，这样就极易会产生OOM。因此我们采用享元模式来对商品的创建进行优化。
			Goods goods1 = GoodsFactory.getGoods("iphone7");
			goods1.showGoodsPrice("32G");
			Goods goods2 = GoodsFactory.getGoods("iphone7");
			goods2.showGoodsPrice("32G");
			Goods goods3 = GoodsFactory.getGoods("iphone7");
			goods3.showGoodsPrice("128G");
			Console.ReadKey();
		}
	}
}

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
			Goods goods1 = GoodsFactory.getGoods("iphone7");
			goods1.showGoodsPrice("32G");
			Goods goods2 = GoodsFactory.getGoods("iphone7");
			goods2.showGoodsPrice("32G");
			Goods goods3 = GoodsFactory.getGoods("iphone7");
			goods3.showGoodsPrice("128G");
		}
	}
}

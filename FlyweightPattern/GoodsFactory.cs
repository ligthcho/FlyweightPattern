using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
	public class GoodsFactory
	{
		private static Dictionary<String,Goods> pool = new Dictionary<String,Goods>();
		public static Goods getGoods(String name)
		{
			if(pool.ContainsKey(name))
			{
				Console.WriteLine("使用缓存,key为:" + name);
				return pool[name];
			}
			else
			{
				Goods goods = new Goods(name);
				pool.Add(name,goods);
				Console.WriteLine("创建商品,key为:" + name);
				return goods;
			}
		}
	}
}

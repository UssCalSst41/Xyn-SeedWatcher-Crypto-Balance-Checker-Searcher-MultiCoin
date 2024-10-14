using System;
using System.Collections.Generic;

namespace BalanceCheckerWin
{
	// Token: 0x0200000D RID: 13
	public static class IListExtensions
	{
		// Token: 0x060008B5 RID: 2229 RVA: 0x0001DD08 File Offset: 0x0001BF08
		public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source, int count)
		{
			List<TSource> list = new List<TSource>(count);
			foreach (TSource item in source)
			{
				list.Add(item);
			}
			return list;
		}
	}
}

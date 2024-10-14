using System;
using System.Net;

namespace BalanceCheckerWin
{
	// Token: 0x0200000F RID: 15
	public static class HttpWebResponseExt
	{
		// Token: 0x060008B7 RID: 2231 RVA: 0x0001DD88 File Offset: 0x0001BF88
		public static HttpWebResponse GetResponseNoException(this HttpWebRequest req)
		{
			HttpWebResponse result;
			try
			{
				result = (HttpWebResponse)req.GetResponse();
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
				if (httpWebResponse == null)
				{
					throw;
				}
				result = httpWebResponse;
			}
			return result;
		}
	}
}

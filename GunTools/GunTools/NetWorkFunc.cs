using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GunTools
{
    public class NetWorkFunc
    {
        public string DownLoadFile(string url, string fileSave = null)
        {
			WebClient webClient = new WebClient();
            webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; " +
                                  "Windows NT 5.2; .NET CLR 1.0.3705;)");
            try
			{
                if(fileSave == null)
                {
                    fileSave = System.IO.Path.Combine(StaticsMgr.DownloadPath, url.Replace("//","/").Split(new char[] { '/'}).Last());
                    csFunction.CheckFolder(fileSave);
                }
                webClient.DownloadFile(url, fileSave);

            }
			catch (Exception)
			{

				
			}
            return fileSave;
        }
    }
}

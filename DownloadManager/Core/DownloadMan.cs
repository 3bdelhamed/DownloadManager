using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.Core
{
    internal class DownloadMan
    {
        public string extractNameFromURl(TextBox txtBox)
        {
            string txt = txtBox.Text;
            string[] parts = txt.Split('/');

            return parts[parts.Length - 1];
        }
        public string GetSize(WebClient webClient,string Url )
        {
            string size = "0";
            try
            {
                webClient.OpenRead(Url);
                size = webClient.ResponseHeaders["Content-Length"];

            } 
            catch (Exception e)
            {
                size = "NA";
                
            }
            return size;
        }
    }
}

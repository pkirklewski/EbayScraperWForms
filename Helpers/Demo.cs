using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class Demo
    {
        public string DownloadPage(string url)
        {
            string response = string.Empty;
            using (WebClient client = new WebClient())
            {
                response = client.DownloadString(url);
            }
            return response;
        }
    }
}

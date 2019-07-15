using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ProtoType;

namespace Design_Patterns_Console.Day2.ProtoType.Web
{
    public class WebInfo : IProtoType<WebInfo>
    {
        public DateTime Time { get; set; }
        string Size { get; set; }
        string Url { get; set; }

        public WebInfo(DateTime time, string size, string url)
        {
            this.Size = size;
            this.Time = time;
            this.Url = url;
        }

        public WebInfo clone()
        {
            return new WebInfo(new DateTime(this.Time.Ticks), this.Size, this.Url);
        }
    }
}

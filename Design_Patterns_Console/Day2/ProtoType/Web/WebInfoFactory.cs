using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Design_Patterns_Console.Day2.ProtoType.Web
{
    public class WebInfoFactory
    {
        Dictionary<string, WebInfo> webInfoDict;

        public WebInfoFactory()
        {
            this.webInfoDict = new Dictionary<string, WebInfo>();
        }

        public WebInfo CreateWebInfo(string url)
        {
            WebInfo temp = null;

            if(webInfoDict.TryGetValue(url,out temp) == false)
            {
                Task<string> T = WriteWebRequestSizeAsync(url);
                T.Wait();
                temp = new WebInfo(DateTime.Now, T.Result, url);
                webInfoDict.Add(url, temp);
            }

            return temp.clone();
        }

        static public string FormatBytes(long bytes)
        {
            string[] magnitudes =
                new string[] { "GB", "MB", "KB", "Bytes" };
            long max =
                (long)Math.Pow(1024, magnitudes.Length);

            return string.Format("{1:##.##} {0}",
                magnitudes.FirstOrDefault(
                    magnitude =>
                    bytes > (max /= 1024)) ?? "0 Bytes",
              (decimal)bytes / (decimal)max);
        }


        public static async Task<string> WriteWebRequestSizeAsync(string url)
        {
            try
            {
                WebRequest webRequest =
                    WebRequest.Create(url);
                WebResponse response =
                    await webRequest.GetResponseAsync();
                using (StreamReader reader =
                    new StreamReader(
                        response.GetResponseStream()))
                {
                    string text =
                        await reader.ReadToEndAsync();
                    return
                        FormatBytes(text.Length);
                }
            }
            catch (WebException)
            {
                // ...
            }
            catch (IOException)
            {

                // ...
            }
            catch (NotSupportedException)
            {
                // ...
            }

            return "";
        }
    }
}

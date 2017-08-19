using System;
using System.Net.Http;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //HttpClient hc = new HttpClient();
            //var rm = new HttpRequestMessage(HttpMethod.Get, "http://localhost:34963/Store/WeiChartUrl/HAHAHA");
            
            //var res = hc.SendAsync(rm);

            //var rl = res.Result;
            //var str = rl.Content.ReadAsStringAsync().Result;

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine(str);
            //rm = new HttpRequestMessage(HttpMethod.Post, "http://localhost:34963/Store/PostTest?sd=00000,1111,2222,3333");
            
            //res = hc.SendAsync(rm);

            //rl = res.Result;
            //str = rl.Content.ReadAsStringAsync().Result;
            //Console.WriteLine(str);
            get();
            Console.Read();
        }

        static async void get()
        {
            System.Net.Http.HttpClient hc = new HttpClient();
            string appID = "wx90615a576942afb7";
            string appSecret = "664e56edce9fb8d5929152da8952528c";
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}", appID, appSecret);
            var response = await hc.SendAsync(
                new HttpRequestMessage(HttpMethod.Get, url));
            string restr = response.Content.ReadAsStringAsync().Result;
            
            JObject c = JsonConvert.DeserializeObject(restr) as JObject;
            Console.WriteLine(c.ToString());
            foreach (var item in c)
            {
                Console.WriteLine(string.Format("{0}:{1}", item.Key, item.Value));
            }
            
            Console.Read();
        }
    }
}
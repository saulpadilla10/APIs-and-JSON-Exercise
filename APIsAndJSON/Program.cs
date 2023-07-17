using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace APIsAndJSON;
public class Program
{
   
    static void Main(string[] args)
    {
        var client = new HttpClient();

        string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

        //var ronResponse = client.GetStringAsync(ronURL).Result;
        //var ronQuote = JArray.Parse(ronResponse);
        //var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
        //Console.WriteLine($"Ron: {ronQuote}");
   
        string kanyeURL = "https://api.kanye.rest/";

        //var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
        //var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
        //Console.WriteLine($"Kanye: {kanyeQuote}");    

        for (int i = 1; i <= 5; i++)
        {
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            Console.WriteLine($"Ron: {ronQuote}");

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine($"Kanye: {kanyeQuote}");

            Console.WriteLine();
        }



    }
}
    


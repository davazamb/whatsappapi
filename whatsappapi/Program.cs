using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatsappapi
{
    class Program
    {
        static void Main(string[] args)
        {
            var sms = SendWhats();
            Console.WriteLine(sms);
            Console.ReadKey();
        }

        public static string SendWhats()
        {
            var client = new RestClient("https://whatsmsapi.com/api/send_sms");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("x-api-key", "5c728da65ea74");
            request.AddParameter("undefined", "phone=5699777777&text=Hello%20World!", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}

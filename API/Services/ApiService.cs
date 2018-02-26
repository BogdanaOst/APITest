using API.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
 
using System.Configuration;

namespace API.Services
{
    public class RequestTypeConstants 
    {
        public const string OrderHistoryRequest = "order-history";
    }


    public class ApiService
    {
        string MainPath = ConfigurationManager.AppSettings["MainPath"];
        string ApiKey = ConfigurationManager.AppSettings["ApiKey"];
        string ContentType = "application/json";
        HttpClient client = new HttpClient();
        public ApiService()
        {
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(ContentType));
            client.DefaultRequestHeaders.Add("ApiKey", ApiKey);
        }

        public async Task OrderHistory(RootObjectOrder Data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(Data).ToString(), Encoding.UTF8, ContentType);
            // new Uri(new Uri(MainPath), RequestTypeConstants.OrderHistoryRequest);
            var result = await client.PostAsync(MainPath + RequestTypeConstants.OrderHistoryRequest, content);
            Console.WriteLine(result.StatusCode);
            Console.WriteLine(await result.Content.ReadAsStringAsync());
        }

        public async Task SalesReseipt(RootObjectSales_Purchase Data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(Data).ToString(), Encoding.UTF8, ContentType);
            var result = await client.PostAsync(MainPath + "sales-receipt", content);
            Console.WriteLine(result.StatusCode);
            //Console.WriteLine(await result.Content.ReadAsStringAsync());
        }

        public async Task PurchaseReseipt(RootObjectSales_Purchase Data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(Data).ToString(), Encoding.UTF8, ContentType);
            var result = await client.PostAsync(MainPath + "purchase-receipt", content);
            Console.WriteLine(result.StatusCode);
           // Console.WriteLine(await result.Content.ReadAsStringAsync());
        }
    }
}

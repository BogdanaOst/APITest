using API.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API.Services
{
    public class ApiService
    {
        string MainPath = "https://qa03chq.teamworkinsight.com/chqapi/export/v1/";
        string ApiKey = "441b6217-6a8c-4389-ab3b-48a5ca42dbd8";
        HttpClient client = new HttpClient();
        public ApiService()
        {
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("ApiKey", ApiKey);
        }

        public async Task OrderHistory(RootObjectOrder Data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(Data).ToString(), Encoding.UTF8, "application/json");
            var result = await client.PostAsync(MainPath+"order-history", content);
            Console.WriteLine(result.StatusCode);
           // Console.WriteLine(await result.Content.ReadAsStringAsync());
        }

        public async Task SalesReseipt(RootObjectSales_Purchase Data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(Data).ToString(), Encoding.UTF8, "application/json");
            var result = await client.PostAsync(MainPath + "sales-receipt", content);
            Console.WriteLine(result.StatusCode);
            //Console.WriteLine(await result.Content.ReadAsStringAsync());
        }

        public async Task PurchaseReseipt(RootObjectSales_Purchase Data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(Data).ToString(), Encoding.UTF8, "application/json");
            var result = await client.PostAsync(MainPath + "purchase-receipt", content);
            Console.WriteLine(result.StatusCode);
           // Console.WriteLine(await result.Content.ReadAsStringAsync());
        }
    }
}

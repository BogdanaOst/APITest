﻿using API.Entities;
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
   
    //Service to connect with Cloudworks server
    public class ApiService
    {
        private readonly string MainPath = ConfigurationManager.AppSettings["MainPath"];
        private readonly string ApiKey = ConfigurationManager.AppSettings["ApiKey"];
        private readonly string ContentType = "application/json";
        private readonly string OrderHistoryRequest = "order-history";

        private HttpClient client;

        #region Preparations
        //Init HttpClient
        void InitClient()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(ContentType));
            client.DefaultRequestHeaders.Add("ApiKey", ApiKey);
        }

        //Dispose HttpClient
        void DisposeClient()
        {
            client.Dispose();
        }
        #endregion

        #region Methods
        //HttpPost Data to get List of OrderHistory
        public async Task OrderHistory(RootObjectOrder Data)
        {
            try
            {
                InitClient();
                var content = new StringContent(JsonConvert.SerializeObject(Data).ToString(), Encoding.UTF8, ContentType);
                var url = new Uri(new Uri(MainPath), OrderHistoryRequest);
                var result = await client.PostAsync(url, content);
                Console.WriteLine(result.StatusCode);
                Console.WriteLine(await result.Content.ReadAsStringAsync());
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception! Info:" + ex.Message);
            }
            finally
            {
                DisposeClient();
            }
        }
        #endregion

    }
}

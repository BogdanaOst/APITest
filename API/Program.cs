﻿using API.Entities;
using API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Discovery.v1;
using Google.Apis.Discovery.v1.Data;
using Google.Apis.Services;
namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Discovery API Sample");
            Console.WriteLine("====================");
            try
            {
                new Program().Run().Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //RootObjectOrder Data = new RootObjectOrder()
            //{
            //    Source = "Something",
            //    ApiDocumentId = "00000000-0000-0000-0000-000000000000",
            //    IsAsync = true,
            //    Data = new Data()
            //    {
            //        ApiDocumentId = "00000000-0000-0000-0000-000000000000",
            //        Request = new Request()
            //        {
            //            Filters = new List<Filter>(),
            //            Settings = new List<Setting>(),
            //            Skip = 0,
            //            SortDescriptions = new List<SortDescription>(),
            //            Ties = true,
            //            Top = 0
            //        }
            //    }
            //};
            //RootObjectSales_Purchase DataS = new RootObjectSales_Purchase()
            //{
            //    Source = "Something",
            //    Data = new Data()
            //    {
            //        ApiDocumentId = "00000000-0000-0000-0000-000000000000",
            //        Request = new Request()
            //        {
            //            Filters = new List<Filter>(),
            //            Settings = new List<Setting>(),
            //            Skip = 0,
            //            SortDescriptions = new List<SortDescription>(),
            //          //  Ties = true,
            //            Top = 0
            //        }
            //    }
            //};
            //ApiService service = new ApiService();
            //service.OrderHistory(Data).GetAwaiter().GetResult();
            //service.SalesReseipt(DataS).GetAwaiter().GetResult();
            //service.PurchaseReseipt(DataS).GetAwaiter().GetResult();

        }

        private async Task Run()
        {
            // Create the service.
            var service = new DiscoveryService(new BaseClientService.Initializer
            {
                ApplicationName = "Discovery Sample",
                ApiKey = "AIzaSyBEGQ946k-pGUZZRYTYIDM6NJEkGFh6G2s",
                            });

            // Run the request.
            Console.WriteLine("Executing a list request...");
            var result = await service.Apis.List().ExecuteAsync();
            // Display the results.
            if (result.Items != null)
            {
                foreach (DirectoryList.ItemsData api in result.Items)
                {
                    Console.WriteLine(api.Id + " - " + api.Title);
                }
            }
        }
    }
}

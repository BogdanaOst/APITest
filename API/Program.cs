using API.Services;
using System;
using System.Collections.Generic;
using API.Entities;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Discovery API Sample");
            //Console.WriteLine("====================");
            //try
            //{
            //    var bq = new BigQuerryServise();
            //    var data = new Dictionary<string, object>()
            //    {
            //       { "FIRSTCOLUMN", "newRow" },
            //       { "SECONDCOLUMN", 56 },
            //       { "THIRDCOLUMN", 65.01 }
            //    };
            //    bq.Insert("test1","TESTING",data);
            //}
            //catch (AggregateException ex)
            //{
            //    foreach (var e in ex.InnerExceptions)
            //    {
            //        Console.WriteLine("ERROR: " + e.Message);
            //    }
            //}
            //Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();


            RootObject Data = new RootObject()
            {
                Source = "Something",
                Data = new Data()
                {
                    ApiDocumentId = "00000000-0000-0000-0000-000000000000",
                    Request = new Request()
                    {
                        Filters = new List<Filter>(),
                        Settings = new List<Setting>(),
                        Skip = 0,
                        SortDescriptions = new List<SortDescription>(),
                        Top = 0
                    }
                }
            };

            ApiService service = new ApiService();
            service.SalesReceipts(Data).GetAwaiter().GetResult();

        }
        
    }
}

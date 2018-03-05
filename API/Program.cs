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
            int i = 0;
            int counter=0;
            do
            {
                try
                {
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
                                Top = 100
                            }
                        }
                    };

                    ApiService apiService = new ApiService();
                    var data = apiService.SalesReceipts(Data).GetAwaiter().GetResult();
                    counter = data.ApiDocument.Response.SalesReceipts.Count;
                    i += counter;
                    Console.WriteLine(i);
                    BigQuerryServise bqService = new BigQuerryServise();
                    bqService.Insert(data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (counter >= 100);
         

        }
        
    }
}

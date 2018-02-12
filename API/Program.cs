using API.Entities;
using API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            RootObjectOrder Data = new RootObjectOrder()
            {
                Source = "Something",
                ApiDocumentId = "00000000-0000-0000-0000-000000000000",
                IsAsync = true,
                Data = new Data()
                {
                    ApiDocumentId = "00000000-0000-0000-0000-000000000000",
                    Request = new Request()
                    {
                        Filters = new List<Filter>(),
                        Settings = new List<Setting>(),
                        Skip = 0,
                        SortDescriptions = new List<SortDescription>(),
                        Ties = true,
                        Top = 0
                    }
                }
            };
            RootObjectSales_Purchase DataS = new RootObjectSales_Purchase()
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
                      //  Ties = true,
                        Top = 0
                    }
                }
            };
            ApiService service = new ApiService();
            service.OrderHistory(Data).GetAwaiter().GetResult();
            service.SalesReseipt(DataS).GetAwaiter().GetResult();
            service.PurchaseReseipt(DataS).GetAwaiter().GetResult();

        }
    }
}

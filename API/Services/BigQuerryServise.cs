using Google.Apis.Auth.OAuth2;
using API.Entities;
using Google.Apis.Discovery.v1;
using Google.Apis.Services;
using Google.Cloud.BigQuery.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Configuration;
namespace API.Services
{
    //Service to connect with BigQuerry Data Table
    public class BigQuerryServise
    {
        private readonly string _projectId = "bamboo-creek-195008";
        private BigQueryClient _client;
        private readonly string jsonPath = "../../My First Project-010f4a50940c.json";
        private readonly string ApiKey = ConfigurationManager.AppSettings["BigQueryApiKey"];

        #region Preparations
        //Init BigQueryClient
        void InitClient()
        {
            var credential = GoogleCredential.FromFile(jsonPath);
            _client = BigQueryClient.Create(_projectId, credential);    
        }

        //Dispose BigQueryClient
        void DisposeClient()
        {
            _client.Dispose();
        }
        #endregion

        #region Methods

        //Inserting data into table by datasetId,tableId 
        public void Insert(string datasetId, string tableId, Dictionary<string, object> data)
        {
            try
            {
                InitClient();        
                BigQueryInsertRow row = new BigQueryInsertRow()
                 {
                   data
                 };

                _client.InsertRow(datasetId, tableId, row);
                Console.WriteLine("Done");
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

        public void Insert(ResultObj obj)
        {
            var sr = obj.ApiDocument.Response.SalesReceipts;
            foreach(var s in sr)
            {
                var date = s.PostedDateTime;
                foreach(var i in s.Items)
                {
                    var prod = new OleSmokey()
                    {
                        DateTimeS = date,
                        Quantity = i.Qty,
                        ProductId = i.ItemDetails.PLU,
                        Price = i.UnitAmount,
                        ProductName = i.ItemDetails.ItemDescription,
                        DCSS = i.ItemDetails.DCSS.DCSSCode,
                        Department = i.ItemDetails.DCSS.DeptName,
                        Class = i.ItemDetails.DCSS.ClassName,
                        Subclass = i.ItemDetails.DCSS.SubClass1Name
                    };

                    
                }
            }

        }
        #endregion
    }
}

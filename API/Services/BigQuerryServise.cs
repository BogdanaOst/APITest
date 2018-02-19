using Google.Apis.Auth.OAuth2;
using Google.Apis.Discovery.v1;
using Google.Apis.Discovery.v1.Data;
using Google.Apis.Services;
using Google.Cloud.BigQuery.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services
{
    public class BigQuerryServise
    {
        private readonly string _projectId = "bamboo-creek-195008";
        private readonly BigQueryClient _client;
        private readonly DiscoveryService _service;
        private readonly string jsonPath = "../../My First Project-010f4a50940c.json";
        public BigQuerryServise()
        {
            var credential = GoogleCredential.FromFile(jsonPath);
            _client =  BigQueryClient.Create(_projectId,credential);
           _service = new DiscoveryService(new BaseClientService.Initializer
            {
                ApplicationName = "Discovery Sample",
                ApiKey = "AIzaSyBEGQ946k-pGUZZRYTYIDM6NJEkGFh6G2s",
            });
        }

        public List<BigQueryDataset> ListDatasets(BigQueryClient client)
        {
            var datasets = client.ListDatasets().ToList();
            return datasets;
        }
        public async Task InsertTest()
        {
            try
            {
                var result = ListDatasets(_client);
                var dataset = result.Where(x => x.FullyQualifiedId == "bamboo-creek-195008:test1").FirstOrDefault();
                var table = dataset.GetTable("TESTING");
                BigQueryInsertRow row1 = new BigQueryInsertRow("row1")
            {
                { "FIRSTCOLUMN", "example" },
                { "SECONDCOLUMN", 123 },
                { "THIRDCOLUMN", 2.3 }
            };
                _client.InsertRow("test1", "TESTING", row1);
                Console.WriteLine("Done");
            }
            catch(Exception exp)
            {
                Console.WriteLine("Exception! Info:" + exp.Message);
            }
        }

     
    }
}

using Google.Apis.Auth.OAuth2;
using Google.Apis.Discovery.v1;
using Google.Apis.Services;
using Google.Cloud.BigQuery.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class BigQuerryServise
    {
        private readonly string _projectId = "bamboo-creek-195008";
        private readonly BigQueryClient _client;
        private readonly DiscoveryService _service;
        private readonly string jsonPath = "../../My First Project-010f4a50940c.json";
        
        #region Constructors 

        public BigQuerryServise()
        {
            var credential = GoogleCredential.FromFile(jsonPath);
            _client = BigQueryClient.Create(_projectId, credential);
            _service = new DiscoveryService(new BaseClientService.Initializer
            {
                ApplicationName = "Discovery Sample",
                ApiKey = "AIzaSyBEGQ946k-pGUZZRYTYIDM6NJEkGFh6G2s",
            });
        }

        #endregion

        public List<BigQueryDataset> ListDatasets(BigQueryClient client)
        {
            var datasets = client.ListDatasets().ToList();
            return datasets;
        }

        public async Task<BigQueryTable> GetTableById(string datasetId, string tableId)
        {
            try
            {
                var list = ListDatasets(_client);
                var dataset = list.Where(x => x.FullyQualifiedId == _projectId + ":" + datasetId).FirstOrDefault();
                var table = await dataset.GetTableAsync(tableId);
                return table;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception! Info:" + ex.Message);
                return null;
            }
        }
        public void Insert(string datasetId, string tableId, Dictionary<string, object> data)
        {
            try
            {
                              
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

        }
     
    }
}

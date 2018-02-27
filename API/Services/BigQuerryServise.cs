using Google.Apis.Auth.OAuth2;
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
        #endregion
    }
}

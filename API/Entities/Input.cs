using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Setting
    {
        public string Value { get; set; }
        public string Key { get; set; }
    }

    public class Filter
    {
        public string Field { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
    }

    public class SortDescription
    {
        public string Name { get; set; }
        public string Direction { get; set; }
    }

    public class Request
    {
        public List<Setting> Settings { get; set; }
        public List<Filter> Filters { get; set; }
        public List<SortDescription> SortDescriptions { get; set; }
        public int Top { get; set; }
        public int Skip { get; set; }
    }

    public class Data
    {
        public string ApiDocumentId { get; set; }
        public Request Request { get; set; }
    }
  
    public class RootObject
    {
        public string Source { get; set; }
        public Data Data { get; set; }
    }

   
    
}

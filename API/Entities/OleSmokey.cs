using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Entities
{
    public class OleSmokey
    {
        public DateTime DateTimeS { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string ProductName { get; set; }
        public string DCSS { get; set; }
        public string Department { get; set; }
        public string Class { get; set; }
        public string Subclass { get; set; }

        public Dictionary<string, object> GetDictionary()
        {
            var dictionary = new Dictionary<string, object>()
            {
                {"DateTimeS", DateTimeS},
                {"ProductId", ProductId},
                {"Quantity", Quantity},
                {"Price", Price},
                {"ProductName", ProductName},
                {"DCSS", DCSS},
                {"Department", Department},
                {"Class", Class},
                {"Subclass", Subclass}
            };

            return dictionary;
        }
    }
}

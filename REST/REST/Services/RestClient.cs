using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST
{
    public class RestClient
    {

        public string Serialize()
        {
            var countries = new[]{
            new Country { Name="Colombia"},
            new Country { Name="Canada"}
            };

            string json = JsonConvert.SerializeObject(countries);

            Debug.WriteLine(json);

            return json;
                            
        }


        public void Deserialize() {

            var json = Serialize();

            var parseJson = JsonConvert.DeserializeObject<IEnumerable<Country>>(json);

            foreach (Country item in parseJson)
            {
                Debug.WriteLine(item);
            }

        }
     
    }
}

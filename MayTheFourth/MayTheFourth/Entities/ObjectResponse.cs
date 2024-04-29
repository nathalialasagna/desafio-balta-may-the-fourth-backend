using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Entities
{
      internal class ObjectResponse<T>
      {
            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("next")]
            public string Next { get; set; }

            [JsonProperty("previous")]
            public string Previous { get; set; }

            [JsonProperty("results")]
            public List<T> Results { get; set; }
      }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Entities
{
      public class Planet
      {
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Nome { get; set; }

            [JsonProperty("rotation_period")]
            public string PeriodoRotacao { get; set; }

            [JsonProperty("orbital_period")]
            public string PeriodoOrbital { get; set; }

            [JsonProperty("diameter")]
            public string Diametro { get; set; }

            [JsonProperty("climate")]
            public string Clima { get; set; }

            [JsonProperty("gravity")]
            public string Gravidade { get; set; }

            [JsonProperty("terrain")]
            public string Terreno { get; set; }

            [JsonProperty("surface_water")]
            public string SuperficieAquatica { get; set; }

            [JsonProperty("population")]
            public string Populacao { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
      }
}
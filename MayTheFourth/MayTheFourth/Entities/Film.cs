using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Entities
{
      public class Film
      {
            public int Id { get; set; }

            [JsonProperty("title")]
            public string Titulo { get; set; }

            [JsonProperty("episode_id")]
            public string Episodio { get; set; }

            [JsonProperty("opening_crawl")]
            public string TextoAbertura { get; set; }

            [JsonProperty("director")]
            public string Diretor { get; set; }

            [JsonProperty("producer")]
            public string Produtor { get; set; }

            [JsonProperty("release_date")]
            public string DataLancamento { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
      }
}
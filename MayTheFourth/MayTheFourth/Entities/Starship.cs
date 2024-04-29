using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Entities
{
      public class Starship
      {
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Nome { get; set; }

            [JsonProperty("model")]
            public string Modelo { get; set; }

            [JsonProperty("manufacturer")]
            public string Fabricante { get; set; }

            [JsonProperty("cost_in_credits")]
            public string CustoEmCreditos { get; set; }

            [JsonProperty("length")]
            public string Comprimento { get; set; }

            [JsonProperty("max_atmosphering_speed")]
            public string VelocidadeMaxima { get; set; }

            [JsonProperty("crew")]
            public string Tripulacao { get; set; }

            [JsonProperty("passengers")]
            public string Passageiros { get; set; }

            [JsonProperty("cargo_capacity")]
            public string CapacidadeCarga { get; set; }

            [JsonProperty("consumables")]
            public string Consumiveis { get; set; }

            [JsonProperty("hyperdrive_rating")]
            public string ClassificaçãoHiperdrive { get; set; }

            [JsonProperty("MGLT")]
            public string MGLT { get; set; }

            [JsonProperty("starship_class")]
            public string Classe { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
      }
}
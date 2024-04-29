using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Entities;

public class Person
{
      public int Id { get; set; }

      [JsonProperty("name")]
      public string Nome { get; set; }

      [JsonProperty("height")]
      public string Altura { get; set; }

      [JsonProperty("mass")]
      public string Peso { get; set; }

      [JsonProperty("hair_color")]
      public string CorCabelo { get; set; }

      [JsonProperty("skin_color")]
      public string CorPele { get; set; }

      [JsonProperty("eye_color")]
      public string CorOlhos { get; set; }

      [JsonProperty("birth_year")]
      public string DataNascimento { get; set; }

      [JsonProperty("gender")]
      public string Genero { get; set; }

      [JsonProperty("url")]
      public string Url { get; set; }
}

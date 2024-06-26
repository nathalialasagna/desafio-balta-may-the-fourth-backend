﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MayTheFourth.Domain.Entities
{
    public class NavesEstelares
    {
        [JsonIgnore]
        public int Id { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "O Modelo não deve exceder 255 caracteres.")]
        public string Modelo { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "O Fabricante não deve exceder 255 caracteres.")]
        public string Fabricante { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "O Custo não deve exceder 255 caracteres.")]
        public string Custo { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "O Comprimento não deve exceder 255 caracteres.")]
        public string Comprimento { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "A VelocidadeMaxima não deve exceder 255 caracteres.")]
        public string VelocidadeMaxima { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "A Tripulacao não deve exceder 255 caracteres.")]
        public string Tripulacao { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "O Passageiros não deve exceder 255 caracteres.")]
        public string Passageiros { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "A CapacidadeCarga não deve exceder 255 caracteres.")]
        public string CapacidadeCarga { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "A ClassificacaoHiperdrive não deve exceder 255 caracteres.")]
        public string ClassificacaoHiperdrive { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "O Mglt não deve exceder 255 caracteres.")]
        public string Mglt { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "Os Consumiveis não deve exceder 255 caracteres.")]
        public string Consumiveis { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "A Classe não deve exceder 255 caracteres.")]
        public string Classe { get; set; }

        [JsonIgnore]
        public IList<Filme> Filmes { get; set; }
    }
}

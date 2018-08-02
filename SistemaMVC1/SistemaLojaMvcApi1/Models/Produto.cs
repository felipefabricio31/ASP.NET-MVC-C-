using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaLojaMvcApi1.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public DateTime UltimaCompra { get; set; }

        public float Estoque { get; set; }

        public string Comentario { get; set; }

        //Migration Automatic - Aula 25
        //public string teste { get; set; }
    }
}
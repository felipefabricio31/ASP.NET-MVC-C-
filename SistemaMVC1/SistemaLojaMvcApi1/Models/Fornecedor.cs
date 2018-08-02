using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaLojaMvcApi1.Models
{
    public class Fornecedor
    {
        [Key]
        public int FornecedorId { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public virtual ICollection<FornecedorProduto> FornecedorProduto { get; set; }
    }
}
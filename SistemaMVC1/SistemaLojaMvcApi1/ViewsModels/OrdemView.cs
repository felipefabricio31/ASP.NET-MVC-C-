using SistemaLojaMvcApi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaLojaMvcApi1.ViewsModels
{
    public class OrdemView
    {
        //Mostra a ordem dos produtos

        public Customizar Customizar { get; set; }

        public List<ProdutoOrdem> ProdutoOrdem { get; set; }
    }
}
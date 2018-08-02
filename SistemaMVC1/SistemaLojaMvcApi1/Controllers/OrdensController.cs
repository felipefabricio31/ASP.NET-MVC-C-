using SistemaLojaMvcApi1.Models;
using SistemaLojaMvcApi1.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaLojaMvcApi1.Controllers
{

    public class OrdensController : Controller
    {
        private SistemaLojaMvcApi1Context db = new SistemaLojaMvcApi1Context();

        // GET: Ordens
        public ActionResult NovaOrdem()
        {
            var ordemView = new OrdemView();
            ordemView.Customizar = new Customizar();
            ordemView.ProdutoOrdem = new List<ProdutoOrdem>();
            
            var lista = db.Customizars.ToList();
            //Campo para inicar no formulario a opção Selecione....
            //lista.Add(new TipoDocumento { TipoDocumentoId = 0, Descricao = "[Selecione...]" });
            lista = lista.OrderBy(c => c.NomeCompleto).ToList();
            ViewBag.CustomizarId = new SelectList(lista, "CustomizarId", "NomeCompleto");

            return View(ordemView);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
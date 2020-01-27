using BlogPessoal.Web.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPessoal.Web.Controllers
{
    public class CategoriasDeArtigoController : Controller
    {

        private BlogPessoalContexto _ctx = new BlogPessoalContexto();
        // GET: CategoriasDeArtigo
        public ActionResult Index()
        {
            var categorias = _ctx.CategoriaDeArtigo
                .OrderBy(t => t.Nome)
                .ToList();

            return View(categorias);
        }
    }
}
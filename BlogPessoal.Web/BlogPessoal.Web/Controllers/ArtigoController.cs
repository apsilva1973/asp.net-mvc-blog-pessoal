using BlogPessoal.Web.Data.Contexto;
using BlogPessoal.Web.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BlogPessoal.Web.Controllers
{
    public class ArtigoController : Controller
    {
        private BlogPessoalContexto _ctx = new BlogPessoalContexto();
        // GET: Artigo 
        public ActionResult Index()
        {
            var artigos = _ctx.Artigo
                .OrderBy(t => t.Titulo)
                .ToList();

            return View(artigos);
        }

        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Create(Artigo artigo)
        {
            if (ModelState.IsValid)
            {
                _ctx.Artigo.Add(artigo);
                _ctx.SaveChanges();
                return RedirectToAction("index");
            }

            return View(artigo);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var artigo = _ctx.Artigo.Find(id);
            if (artigo == null)
                return HttpNotFound();
            return View(artigo);
        }

        [HttpPost]
        public ActionResult Edit(Artigo artigo)
        {
            if (ModelState.IsValid)
            {
                _ctx.Entry(artigo).State = EntityState.Modified;
                _ctx.SaveChanges();
                return RedirectToAction("index");
            }

            return View(artigo);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var artigo = _ctx.Artigo.Find(id);
            if (artigo == null)
                return HttpNotFound();
            return View(artigo);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var artigo = _ctx.Artigo.Find(id);
            _ctx.Artigo.Remove(artigo);
            _ctx.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
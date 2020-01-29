using BlogPessoal.Web.Mapeamento;
using BlogPessoal.Web.Models;
using System.Data.Entity;

namespace BlogPessoal.Web.Data.Contexto
{
    public class BlogPessoalContexto : DbContext
    {
        public BlogPessoalContexto()
            : base(typeof(BlogPessoalContexto).Name)
        {

        }

        public DbSet<CategoriaDeArtigo> CategoriaDeArtigo { get; set; }
        public DbSet<Autor> Autor { get; set; }

        public DbSet<Artigo> Artigo { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaDeArtigoMap());
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new ArtigoMap());

            base.OnModelCreating(modelBuilder);
        }

       





    }
}
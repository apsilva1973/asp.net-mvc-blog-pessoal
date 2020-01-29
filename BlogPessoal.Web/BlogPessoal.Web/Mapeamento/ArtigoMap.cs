using BlogPessoal.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Mapeamento
{
    public class ArtigoMap : EntityTypeConfiguration<Artigo>
    {
        public ArtigoMap()
        {
            ToTable("artigo", "dbo");

            HasKey(t => t.Id);
            Property(x => x.Titulo).IsRequired().HasMaxLength(300).HasColumnName("titulo");
            Property(x => x.Conteudo).IsOptional().HasMaxLength(null).HasColumnName("conteudo");
            Property(x => x.Data_Publicacao).IsOptional().HasColumnName("data_publicacao");
            Property(x => x.Removido).IsOptional().HasColumnName("removido");

        }
    }
}
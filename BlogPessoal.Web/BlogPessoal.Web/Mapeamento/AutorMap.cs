using BlogPessoal.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Mapeamento
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("autor", "dbo");

            HasKey(t => t.Id);
            Property(x => x.Nome).IsRequired().HasMaxLength(150).HasColumnName("nome");
            Property(x => x.Email).IsOptional().HasMaxLength(150).HasColumnName("email");
            Property(x => x.Senha).IsOptional().HasMaxLength(50).HasColumnName("senha");
            Property(x => x.Administrador).IsOptional().HasColumnName("administrador");
            Property(x => x.Data_Cadastro).IsOptional().HasColumnName("data_cadastro");
        }
    }
}
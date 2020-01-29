using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Models
{
    public class CategoriaDeArtigo
    {
        public int Id { get; private set; }
        [Required]
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
    }
}
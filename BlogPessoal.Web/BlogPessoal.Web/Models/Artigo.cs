using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Models
{
    public class Artigo
    {
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Conteudo { get; private set; }
        public DateTime Data_Publicacao { get; private set; }
        public byte Removido { get; private set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Models
{
    public class Autor
    {
        public int Id { get; private set; }
        [Required]
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public Byte Administrador { get; private set; }
        public DateTime Data_Cadastro { get; private set; }

    }
}
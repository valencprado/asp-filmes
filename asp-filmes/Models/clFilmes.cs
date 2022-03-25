using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace asp_filmes.Models
{
    public class clFilmes
    {   public string CodGen { get; set; }
        [DisplayName("Gênero do Filme")]
        public string Gen { get; set; }
        public string CodDir { get; set; }
        [DisplayName("Diretor do Filme")]
        public string Diretor { get; set; }
        public string CodFilme { get; set; }
        [DisplayName("Nome do Filme")]
        public string Filme { get; set; }

    }
}
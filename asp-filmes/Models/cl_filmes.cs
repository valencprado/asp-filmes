using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace asp_filmes.Models
{
    public class cl_filmes
    { public string cod_gen { get; set; }
        [DisplayName("Gênero do filme")]
        public string gen { get; set; }

      public string cod_dir { get; set; }
        [DisplayName("Diretor do filme")]
        public string dir { get; set; }

      public string cod_filme { get; set; }
        [DisplayName("Nome do filme")]
        public string filme { get; set; }
    }
}
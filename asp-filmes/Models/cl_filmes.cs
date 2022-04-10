using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace asp_filmes.Models
{
    public class cl_filmes
    { public string cod_gen { get; set; }
        [Required]
        [DisplayName("Gênero do filme")]
        public string gen { get; set; }

      public string cod_dir { get; set; }
        [Required]
        [DisplayName("Diretor do filme")]
        public string dir { get; set; }

      public string cod_filme { get; set; }
        [Required]
        [DisplayName("Nome do filme")]
        public string filme { get; set; }

        public string cod_ator { get; set; }
        [Required]
        [DisplayName("Nome do ator")]
       public string nome_ator { get; set; }
        [Required]
        //[DataType(DataType.Date)]
        [DisplayName("Data de nascimento do ator")]
        public string data_nasc_ator { get; set; }


    }
}
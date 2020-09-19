using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEscola.Models
{
    public class AlunoNotaModels
    {
        [Required(ErrorMessage = "Informe o código...")]
        public int CodigoAlunoNota { get; set; }

        [Required(ErrorMessage = "Informe o RA...")]
        public String Ra { get; set; }

        [Required(ErrorMessage = "Informe o código da disciplina...")]
        public int CodigoDisciplina { get; set; }

        [Required(ErrorMessage = "Informe o código do bimestre...")]
        public int CodigoBimestre { get; set; }
    }

    public class AlunoNotaEditModels
    {
       
        public int CodigoAlunoNota { get; set; }

        [Required(ErrorMessage = "Informe o RA...")]
        public String Ra { get; set; }

        [Required(ErrorMessage = "Informe o código da disciplina...")]
        public int CodigoDisciplina { get; set; }

        [Required(ErrorMessage = "Informe o código do bimestre...")]
        public int CodigoBimestre { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoEscola.Models
{
    public class DisciplinaModels
    {
        [Required(ErrorMessage = "Informe o código da disciplina...")]
        public int CodigoDisciplina { get; set; }

        [Required(ErrorMessage = "Informe o nome da disciplina...")]
        public String NomeDisciplina { get; set; }

        [Required(ErrorMessage = "Informe o código da categoria da disciplina...")]
        public int CodigoCategoriaDisciplina { get; set; }
    }
}
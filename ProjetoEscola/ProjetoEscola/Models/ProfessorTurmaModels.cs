using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoEscola.Models
{
    public class ProfessorTurmaModels
    {
        [Required(ErrorMessage = "Informe o código...")]
        public int CodigoProfessorTurma { get; set; }

        [Required(ErrorMessage = "Informe o CPF do professor...")]
        public String CPF { get; set; }

        [Required(ErrorMessage = "Informe o código da turma...")]
        public int CodigoTurma { get; set; }
    }
}
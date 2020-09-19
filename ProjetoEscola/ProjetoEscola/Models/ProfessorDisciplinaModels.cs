using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoEscola.Models
{
    public class ProfessorDisciplinaModels
    {
        [Required(ErrorMessage = "Informe o código...")]
        public int CodigoProfessorDisciplina { get; set; }

        [Required(ErrorMessage = "Informe o CPF do professor...")]
        public String CpfProfessor { get; set; }

        [Required(ErrorMessage = "Informe a disciplina...")]
        public int CodigoDisciplina { get; set; }
    }
}
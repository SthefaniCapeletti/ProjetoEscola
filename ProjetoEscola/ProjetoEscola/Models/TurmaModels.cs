using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoEscola.Models
{
    public class TurmaModels
    {
        [Required(ErrorMessage = "Informe o código da turma...")]
        public int CodigoTurma { get; set; }

        [Required(ErrorMessage = "Informe o número da turma...")]
        public String Numero { get; set; }

        [Required(ErrorMessage = "Informe a sigla da turma...")]
        public String Sigla { get; set; }
    }
}
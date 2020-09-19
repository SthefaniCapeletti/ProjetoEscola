using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoEscola.Models
{
    public class FaltaModels
    {
        [Required(ErrorMessage = "Informe o código da falta...")]
        public int CodigoFalta { get; set; }

        [Required(ErrorMessage = "Informe o RA do aluno...")]
        public String RA { get; set; }

        [Required(ErrorMessage = "Informe o bimestre...")]
        public int CodigoBimestre { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de faltas...")]
        public int QtdeFaltas { get; set; }
    }
}
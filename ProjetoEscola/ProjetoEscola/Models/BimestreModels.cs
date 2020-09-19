using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoEscola.Models
{
    public class BimestreModels
    {
        [Required(ErrorMessage = "Informe o código do bimestre...")]
        public int CodigoBimestre { get; set; }

        [Required(ErrorMessage = "Informe o número do bimestre...")]
        public String NumeroBimestre { get; set; }
    }
}
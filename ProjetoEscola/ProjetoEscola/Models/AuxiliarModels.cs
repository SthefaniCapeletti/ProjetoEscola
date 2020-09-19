using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoEscola.Models
{
    public class AuxiliarModels
    {
        [Required(ErrorMessage = "Informe o CPF...")]
        public String CPF { get; set; }

        [Required(ErrorMessage = "Informe o nome...")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome..")]
        public String Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento...")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Informe o código da categoria...")]
        public int CodigoCategoria { get; set; }
    }

    public class AuxiliarEditModels
    {

        public String CPF { get; set; }

        [Required(ErrorMessage = "Informe o nome...")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome..")]
        public String Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento...")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Informe o código da categoria...")]
        public int CodigoCategoria { get; set; }
    }
}
}
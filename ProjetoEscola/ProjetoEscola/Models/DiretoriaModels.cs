using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoEscola.Models
{
    public class DiretoriaModels
    {
        [Required(ErrorMessage = "Informe o CPF...")]
        public String CPF { get; set; }

        [Required(ErrorMessage = "Informe o nome...")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome...")]
        public String Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento...")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Informe o usuário...")]
        public String Username { get; set; }

        [Required(ErrorMessage = "Informe a senha...")]
        public String Senha { get; set; }
    }

    public class DiretoriaEditModels
    {
      
        public String CPF { get; set; }

        [Required(ErrorMessage = "Informe o nome...")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome...")]
        public String Sobrenome { get; set; }
   
        public DateTime DataNascimento { get; set; }

        public String Username { get; set; }

        [Required(ErrorMessage = "Informe a senha...")]
        public String Senha { get; set; }
    }
}
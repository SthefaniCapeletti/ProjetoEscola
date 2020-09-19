using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEscola.Models
{
    public class UsuarioModels
    {
        [Required(ErrorMessage = "Informe o usuário...")]
        public String Username { get; set; }

        [Required(ErrorMessage = "Informe a senha...")]
        public String Senha { get; set; }

        [Required(ErrorMessage = "Informe o código de nivel de acesso...")]
        public int CodigoNivelAcesso { get; set; }

        [Required(ErrorMessage = "Informe o status de atividade")]
        public Boolean Status { get; set; }
    }
}
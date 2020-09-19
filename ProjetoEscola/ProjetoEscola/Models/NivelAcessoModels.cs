using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoEscola.Models
{
    public class NivelAcessoModels
    {
        [Required(ErrorMessage = "Informe o código de Nível de Acesso...")]
        public int CodigoNivelAcesso { get; set; }

        [Required(ErrorMessage = "Informe a descrição do Nível do Acesso...")]
        public String Descricao { get; set; }
    }
}
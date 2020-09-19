using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoEscola.Models
{
    public class CategoriaDisciplinaModels
    {
        [Required(ErrorMessage = "Informe o codigo da categoria da disciplina")]
        public int CodigoCategoriaDisciplina { get; set; }

        [Required(ErrorMessage = "Informe a descrição...")]
        public String DescricaoCategoria { get; set; }

    }
}
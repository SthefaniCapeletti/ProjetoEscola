using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoEscola.Models
{
    public class CategoriaAuxiliarModels
    {
        [Required(ErrorMessage = "Informe o código da categoria do auxiliar...")]
        public int CodigoCategoria { get; set; }

        [Required(ErrorMessage = "Informe a descrição da categoria...")]
        public String Descricao { get; set; }
    }
}
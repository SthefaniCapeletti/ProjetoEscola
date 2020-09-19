using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjetoEscola.Models
{
    public class TurmaModels
    {
        public int CodigoTurma { get; set; }
        public String Numero { get; set; }
        public String Sigla { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoEscola
{
    using System;
    using System.Collections.Generic;
    
    public partial class falta
    {
        public int cd_falta { get; set; }
        public string ra_aluno { get; set; }
        public Nullable<int> cd_bimestre { get; set; }
        public Nullable<int> qtde_falta { get; set; }
    
        public virtual aluno aluno { get; set; }
        public virtual bimestre bimestre { get; set; }
    }
}
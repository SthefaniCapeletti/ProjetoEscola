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
    
    public partial class categoria_disciplina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public categoria_disciplina()
        {
            this.disciplina = new HashSet<disciplina>();
        }
    
        public int cd_categoria_disciplina { get; set; }
        public string dsc_categoria_disciplina { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<disciplina> disciplina { get; set; }
    }
}
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
    
    public partial class categoria_auxiliar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public categoria_auxiliar()
        {
            this.auxiliar = new HashSet<auxiliar>();
        }
    
        public int cd_categoria { get; set; }
        public string dsc_categoria { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<auxiliar> auxiliar { get; set; }
    }
}

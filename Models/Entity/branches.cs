//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TreinamentoWeb.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class branches
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public branches()
        {
            this.responsibles = new HashSet<responsibles>();
        }
    
        public string name { get; set; }
        public string description { get; set; }
        public bool merge_executed { get; set; }
        public int parent_branch { get; set; }
        public int type { get; set; }
        public int product { get; set; }
        public int id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<responsibles> responsibles { get; set; }
    }
}

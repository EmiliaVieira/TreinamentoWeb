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
    
    public partial class responsibles
    {
        public int id { get; set; }
        public int branche_id { get; set; }
        public int user_id { get; set; }
    
        public virtual branches branches { get; set; }
        public virtual users users { get; set; }
    }
}

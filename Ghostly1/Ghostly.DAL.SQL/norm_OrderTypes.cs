//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ghostly.DAL.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class norm_OrderTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public norm_OrderTypes()
        {
            this.Modifiers = new HashSet<Modifier>();
        }
    
        public string OrderTypeId { get; set; }
        public string OrderTypedsec { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modifier> Modifiers { get; set; }
    }
}

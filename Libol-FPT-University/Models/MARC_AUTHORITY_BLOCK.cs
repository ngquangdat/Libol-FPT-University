//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libol_FPT_University.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MARC_AUTHORITY_BLOCK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MARC_AUTHORITY_BLOCK()
        {
            this.MARC_AUTHORITY_FIELD = new HashSet<MARC_AUTHORITY_FIELD>();
        }
    
        public int ID { get; set; }
        public string VietBlockName { get; set; }
        public string BlockName { get; set; }
        public string BlockCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MARC_AUTHORITY_FIELD> MARC_AUTHORITY_FIELD { get; set; }
    }
}

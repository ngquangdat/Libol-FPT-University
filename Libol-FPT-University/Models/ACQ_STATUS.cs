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
    
    public partial class ACQ_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACQ_STATUS()
        {
            this.ACQ_PO = new HashSet<ACQ_PO>();
            this.ACQ_PO_STATUS = new HashSet<ACQ_PO_STATUS>();
        }
    
        public int ID { get; set; }
        public string Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACQ_PO> ACQ_PO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACQ_PO_STATUS> ACQ_PO_STATUS { get; set; }
    }
}

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
    
    public partial class CIR_DIC_COLLEGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CIR_DIC_COLLEGE()
        {
            this.CIR_PATRON_UNIVERSITY = new HashSet<CIR_PATRON_UNIVERSITY>();
        }
    
        public int ID { get; set; }
        public string College { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIR_PATRON_UNIVERSITY> CIR_PATRON_UNIVERSITY { get; set; }
    }
}
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
    
    public partial class ILL_REQUEST_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ILL_REQUEST_STATUS()
        {
            this.ILL_INCOMING_REQUESTS = new HashSet<ILL_INCOMING_REQUESTS>();
            this.ILL_OUTGOING_REQUESTS = new HashSet<ILL_OUTGOING_REQUESTS>();
        }
    
        public string DisplayState { get; set; }
        public int ID { get; set; }
        public string State { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ILL_INCOMING_REQUESTS> ILL_INCOMING_REQUESTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ILL_OUTGOING_REQUESTS> ILL_OUTGOING_REQUESTS { get; set; }
    }
}

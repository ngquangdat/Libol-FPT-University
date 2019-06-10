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
    
    public partial class CIR_LOAN_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CIR_LOAN_TYPE()
        {
            this.CIR_LOAN = new HashSet<CIR_LOAN>();
            this.HOLDINGs = new HashSet<HOLDING>();
            this.HOLDING_COPY = new HashSet<HOLDING_COPY>();
        }
    
        public int ID { get; set; }
        public decimal Fee { get; set; }
        public bool FixedFee { get; set; }
        public int LoanPeriod { get; set; }
        public string LoanType { get; set; }
        public decimal OverdueFine { get; set; }
        public int RenewalPeriod { get; set; }
        public Nullable<int> Renewals { get; set; }
        public int TimeUnit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIR_LOAN> CIR_LOAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOLDING> HOLDINGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOLDING_COPY> HOLDING_COPY { get; set; }
    }
}

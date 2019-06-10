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
    
    public partial class CIR_PATRON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CIR_PATRON()
        {
            this.CIR_LOAN = new HashSet<CIR_LOAN>();
            this.CIR_PATRON_BLOCK = new HashSet<CIR_PATRON_BLOCK>();
            this.CIR_PATRON_OTHER_ADDR = new HashSet<CIR_PATRON_OTHER_ADDR>();
            this.CIR_PRINTED_CARD = new HashSet<CIR_PRINTED_CARD>();
            this.CIR_RESERVE_REQUEST = new HashSet<CIR_RESERVE_REQUEST>();
            this.ILL_OUTGOING_REQUESTS = new HashSet<ILL_OUTGOING_REQUESTS>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public System.DateTime ValidDate { get; set; }
        public System.DateTime ExpiredDate { get; set; }
        public Nullable<System.DateTime> LastIssuedDate { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> EthnicID { get; set; }
        public Nullable<int> EducationID { get; set; }
        public Nullable<int> OccupationID { get; set; }
        public string WorkPlace { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Portrait { get; set; }
        public int PatronGroupID { get; set; }
        public string Password { get; set; }
        public Nullable<int> Status { get; set; }
        public string Note { get; set; }
        public decimal Debt { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public string InterestedSubjectBBK { get; set; }
        public string InterestedSubjectDDC { get; set; }
        public string IDCard { get; set; }
    
        public virtual CIR_DIC_EDUCATION CIR_DIC_EDUCATION { get; set; }
        public virtual CIR_DIC_ETHNIC CIR_DIC_ETHNIC { get; set; }
        public virtual CIR_DIC_OCCUPATION CIR_DIC_OCCUPATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIR_LOAN> CIR_LOAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIR_PATRON_BLOCK> CIR_PATRON_BLOCK { get; set; }
        public virtual CIR_PATRON_GROUP CIR_PATRON_GROUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIR_PATRON_OTHER_ADDR> CIR_PATRON_OTHER_ADDR { get; set; }
        public virtual CIR_PATRON_UNIVERSITY CIR_PATRON_UNIVERSITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIR_PRINTED_CARD> CIR_PRINTED_CARD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIR_RESERVE_REQUEST> CIR_RESERVE_REQUEST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ILL_OUTGOING_REQUESTS> ILL_OUTGOING_REQUESTS { get; set; }
    }
}

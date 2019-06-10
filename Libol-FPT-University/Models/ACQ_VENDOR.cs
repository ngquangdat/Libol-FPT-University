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
    
    public partial class ACQ_VENDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACQ_VENDOR()
        {
            this.ACQ_PO = new HashSet<ACQ_PO>();
        }
    
        public string BankingInfo { get; set; }
        public int ID { get; set; }
        public Nullable<int> ClaimCycle1 { get; set; }
        public Nullable<int> ClaimCycle2 { get; set; }
        public Nullable<int> ClaimCycle3 { get; set; }
        public string ClaimEmail { get; set; }
        public Nullable<int> DeliveryTime { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Note { get; set; }
        public string LibAC { get; set; }
        public string LibSAN { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string SAN { get; set; }
        public string Tel { get; set; }
        public string Name { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public string X12Email { get; set; }
        public Nullable<bool> X12Enabled { get; set; }
        public string ZIP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACQ_PO> ACQ_PO { get; set; }
        public virtual CAT_DIC_COUNTRY CAT_DIC_COUNTRY { get; set; }
        public virtual CIR_DIC_PROVINCE CIR_DIC_PROVINCE { get; set; }
    }
}
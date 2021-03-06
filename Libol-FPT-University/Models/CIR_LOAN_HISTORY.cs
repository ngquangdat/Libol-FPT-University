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
    
    public partial class CIR_LOAN_HISTORY
    {
        public int ID { get; set; }
        public string CopyNumber { get; set; }
        public System.DateTime CheckOutdate { get; set; }
        public System.DateTime CheckInDate { get; set; }
        public Nullable<int> PatronID { get; set; }
        public int ItemID { get; set; }
        public byte LoanMode { get; set; }
        public int LocationID { get; set; }
        public int LoanTypeID { get; set; }
        public int OverdueDays { get; set; }
        public decimal OverdueFine { get; set; }
        public decimal Fees { get; set; }
        public string Serial { get; set; }
        public Nullable<int> RenewCount { get; set; }
    }
}

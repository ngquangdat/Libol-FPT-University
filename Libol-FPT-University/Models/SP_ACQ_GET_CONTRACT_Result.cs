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
    
    public partial class SP_ACQ_GET_CONTRACT_Result
    {
        public string ReceiptNo_POName { get; set; }
        public int ID { get; set; }
        public bool Accepted { get; set; }
        public Nullable<float> Discount { get; set; }
        public int POType { get; set; }
        public System.DateTime ValidDate { get; set; }
        public Nullable<System.DateTime> FilledDate { get; set; }
        public Nullable<int> VendorID { get; set; }
        public string ReceiptNo { get; set; }
        public string POName { get; set; }
        public Nullable<decimal> PrepaidAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public int StatusID { get; set; }
        public Nullable<float> FixedRate { get; set; }
        public string Currency { get; set; }
        public bool Renewed { get; set; }
        public string StatusNote { get; set; }
        public Nullable<decimal> PrepaidAmount1 { get; set; }
    }
}

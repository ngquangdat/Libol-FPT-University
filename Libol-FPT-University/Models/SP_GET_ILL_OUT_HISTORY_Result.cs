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
    
    public partial class SP_GET_ILL_OUT_HISTORY_Result
    {
        public Nullable<int> ID { get; set; }
        public string ReasonCode { get; set; }
        public string Reason_Viet { get; set; }
        public string Reason_Eng { get; set; }
        public Nullable<byte> CategoryID { get; set; }
        public Nullable<System.DateTime> mProvidedDate { get; set; }
        public Nullable<System.DateTime> mDueDate { get; set; }
        public string STD { get; set; }
        public string LibrarySymbol { get; set; }
        public int ID1 { get; set; }
        public int ResponderID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string Note { get; set; }
        public byte APDUType { get; set; }
        public Nullable<byte> ReasonID { get; set; }
        public Nullable<System.DateTime> ProvidedDate { get; set; }
        public string ResponderSpecReason { get; set; }
        public byte SendShipped { get; set; }
        public byte SendCheckedIn { get; set; }
        public byte SendReceived { get; set; }
        public byte SendReturned { get; set; }
        public Nullable<int> TRE { get; set; }
        public Nullable<int> Medium { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string CurrencyCode1 { get; set; }
        public bool Answer { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public bool Renewable { get; set; }
        public bool Alert { get; set; }
        public int LogID { get; set; }
        public Nullable<byte> ServiceType { get; set; }
        public string Location { get; set; }
        public Nullable<byte> CopyrightCompliance { get; set; }
        public string ReturnedVia { get; set; }
        public Nullable<decimal> InsuredForCost { get; set; }
        public string CurrencyCode2 { get; set; }
        public Nullable<decimal> ReturnInsuranceCost { get; set; }
        public string CurrencyCode3 { get; set; }
        public string TransportationMode { get; set; }
        public string APDUDisplay { get; set; }
    }
}

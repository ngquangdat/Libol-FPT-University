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
    
    public partial class SP_ACQ_BUDGET_CREDIT_SEL_Result
    {
        public int ID { get; set; }
        public Nullable<int> POID { get; set; }
        public string Currency { get; set; }
        public string Reason { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string Inputer { get; set; }
        public int BudgetID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<float> ExchangeRate { get; set; }
        public Nullable<float> FixedRate { get; set; }
        public int ID1 { get; set; }
        public string Currency1 { get; set; }
        public string BudgetCode { get; set; }
        public string Purpose { get; set; }
        public decimal Balance { get; set; }
        public Nullable<decimal> RealBalance { get; set; }
        public string BudgetName { get; set; }
        public Nullable<int> Status { get; set; }
    }
}

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
    
    public partial class SP_GET_BUDGETS_Result
    {
        public int ID { get; set; }
        public string Currency { get; set; }
        public string BudgetCode { get; set; }
        public string Purpose { get; set; }
        public decimal Balance { get; set; }
        public Nullable<decimal> RealBalance { get; set; }
        public string BudgetName { get; set; }
        public Nullable<int> Status { get; set; }
    }
}

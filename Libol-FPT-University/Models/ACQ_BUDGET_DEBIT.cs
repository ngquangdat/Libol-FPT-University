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
    
    public partial class ACQ_BUDGET_DEBIT
    {
        public int ID { get; set; }
        public Nullable<int> POID { get; set; }
        public string Currency { get; set; }
        public Nullable<bool> Commited { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string Inputer { get; set; }
        public int BudgetID { get; set; }
        public decimal Amount { get; set; }
        public Nullable<float> ExChangeRate { get; set; }
        public Nullable<float> FixedRate { get; set; }
    
        public virtual ACQ_BUDGET ACQ_BUDGET { get; set; }
        public virtual ACQ_CURRENCY ACQ_CURRENCY { get; set; }
        public virtual ACQ_PO ACQ_PO { get; set; }
    }
}
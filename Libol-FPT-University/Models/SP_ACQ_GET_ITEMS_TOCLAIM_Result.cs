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
    
    public partial class SP_ACQ_GET_ITEMS_TOCLAIM_Result
    {
        public Nullable<int> POID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }
        public string Publisher { get; set; }
        public string YEAR { get; set; }
        public string ISBN { get; set; }
        public string ISSN { get; set; }
        public Nullable<int> REQUESTEDCOPIES { get; set; }
        public Nullable<int> RETRIEVEDCOPIES { get; set; }
        public Nullable<int> ERRONEUOS { get; set; }
    }
}
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
    
    public partial class FIELD300S
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public int ItemID { get; set; }
        public string Ind1 { get; set; }
        public string Ind2 { get; set; }
        public string FieldCode { get; set; }
    
        public virtual ITEM ITEM { get; set; }
    }
}

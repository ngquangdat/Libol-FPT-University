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
    
    public partial class ITEM_OAI_SET
    {
        public int ItemID { get; set; }
        public int OaiID { get; set; }
        public string FieldCode { get; set; }
    
        public virtual CAT_DIC_OAI_SET CAT_DIC_OAI_SET { get; set; }
        public virtual ITEM ITEM { get; set; }
    }
}

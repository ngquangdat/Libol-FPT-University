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
    
    public partial class OPAC_COMMENT
    {
        public int ID { get; set; }
        public Nullable<int> PatronID { get; set; }
        public string Commentator { get; set; }
        public string Comments { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string EmailAddr { get; set; }
        public byte Ranking { get; set; }
        public string Subject { get; set; }
        public Nullable<int> ItemID { get; set; }
    }
}

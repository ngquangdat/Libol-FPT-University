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
    
    public partial class CAT_EDATA_IMAGE
    {
        public int ID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public string FieldCode { get; set; }
        public string UploadedBy { get; set; }
        public System.DateTime UploadedDate { get; set; }
        public Nullable<byte> BitmapType { get; set; }
        public string ColorModel { get; set; }
        public int ImgWidth { get; set; }
        public int ImgHeight { get; set; }
        public Nullable<short> Xdpi { get; set; }
        public Nullable<short> Ydpi { get; set; }
        public Nullable<int> NoColorUsed { get; set; }
        public int FileSize { get; set; }
        public string URL { get; set; }
        public Nullable<int> Weight1 { get; set; }
        public Nullable<int> Weight2 { get; set; }
        public short DataTypeID { get; set; }
    
        public virtual ITEM ITEM { get; set; }
    }
}

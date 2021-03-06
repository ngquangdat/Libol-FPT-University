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
    
    public partial class ITEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ITEM()
        {
            this.ACQ_ITEM = new HashSet<ACQ_ITEM>();
            this.CAT_EDATA_AUDIO = new HashSet<CAT_EDATA_AUDIO>();
            this.CAT_EDATA_FILE = new HashSet<CAT_EDATA_FILE>();
            this.CAT_EDATA_IMAGE = new HashSet<CAT_EDATA_IMAGE>();
            this.CAT_EDATA_URL = new HashSet<CAT_EDATA_URL>();
            this.CAT_EDATA_VIDEO = new HashSet<CAT_EDATA_VIDEO>();
            this.CIR_HOLDING = new HashSet<CIR_HOLDING>();
            this.CIR_LOAN = new HashSet<CIR_LOAN>();
            this.CIR_RESERVE_REQUEST = new HashSet<CIR_RESERVE_REQUEST>();
            this.EDELIV_FILE = new HashSet<EDELIV_FILE>();
            this.FIELD000S = new HashSet<FIELD000S>();
            this.FIELD100S = new HashSet<FIELD100S>();
            this.FIELD200S = new HashSet<FIELD200S>();
            this.FIELD300S = new HashSet<FIELD300S>();
            this.FIELD400S = new HashSet<FIELD400S>();
            this.FIELD500S = new HashSet<FIELD500S>();
            this.FIELD600S = new HashSet<FIELD600S>();
            this.FIELD700S = new HashSet<FIELD700S>();
            this.FIELD800S = new HashSet<FIELD800S>();
            this.FIELD900S = new HashSet<FIELD900S>();
            this.HOLDINGs = new HashSet<HOLDING>();
            this.HOLDING_INVENTORY = new HashSet<HOLDING_INVENTORY>();
            this.ILL_INCOMING_REQUESTS = new HashSet<ILL_INCOMING_REQUESTS>();
            this.CAT_QUEUE = new HashSet<CAT_QUEUE>();
            this.ITEM_AUTHOR = new HashSet<ITEM_AUTHOR>();
            this.ITEM_BBK = new HashSet<ITEM_BBK>();
            this.ITEM_COUNTRY = new HashSet<ITEM_COUNTRY>();
            this.ITEM_DDC = new HashSet<ITEM_DDC>();
            this.ITEM_KEYWORD = new HashSet<ITEM_KEYWORD>();
            this.ITEM_LANGUAGE = new HashSet<ITEM_LANGUAGE>();
            this.ITEM_LIBRARY = new HashSet<ITEM_LIBRARY>();
            this.ITEM_LOC = new HashSet<ITEM_LOC>();
            this.ITEM_NLM = new HashSet<ITEM_NLM>();
            this.ITEM_NSC = new HashSet<ITEM_NSC>();
            this.ITEM_OAI_SET = new HashSet<ITEM_OAI_SET>();
            this.ITEM_PUBLISHER = new HashSet<ITEM_PUBLISHER>();
            this.ITEM_SERIES = new HashSet<ITEM_SERIES>();
            this.ITEM_SH = new HashSet<ITEM_SH>();
            this.ITEM_THESIS_SUBJECT = new HashSet<ITEM_THESIS_SUBJECT>();
            this.ITEM_TITLE = new HashSet<ITEM_TITLE>();
            this.ITEM_UDC = new HashSet<ITEM_UDC>();
            this.SER_ROUTING = new HashSet<SER_ROUTING>();
            this.ITEM_FULLTEXT = new HashSet<ITEM_FULLTEXT>();
            this.SER_ISSUE = new HashSet<SER_ISSUE>();
            this.ACQ_PO = new HashSet<ACQ_PO>();
        }
    
        public int ID { get; set; }
        public string CoverPicture { get; set; }
        public bool NewRecord { get; set; }
        public string CallNumber { get; set; }
        public string BibLevel { get; set; }
        public Nullable<int> SourceAgencyID { get; set; }
        public int TypeID { get; set; }
        public int FormID { get; set; }
        public string RecordType { get; set; }
        public string Leader { get; set; }
        public string Code { get; set; }
        public byte AccessLevel { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string Cataloguer { get; set; }
        public string Reviewer { get; set; }
        public Nullable<int> SourceCountryID { get; set; }
        public bool OPAC { get; set; }
        public int MediumID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACQ_ITEM> ACQ_ITEM { get; set; }
        public virtual CAT_DIC_COUNTRY CAT_DIC_COUNTRY { get; set; }
        public virtual CAT_DIC_ITEM_TYPE CAT_DIC_ITEM_TYPE { get; set; }
        public virtual CAT_DIC_MEDIUM CAT_DIC_MEDIUM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAT_EDATA_AUDIO> CAT_EDATA_AUDIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAT_EDATA_FILE> CAT_EDATA_FILE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAT_EDATA_IMAGE> CAT_EDATA_IMAGE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAT_EDATA_URL> CAT_EDATA_URL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAT_EDATA_VIDEO> CAT_EDATA_VIDEO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIR_HOLDING> CIR_HOLDING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIR_LOAN> CIR_LOAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIR_RESERVE_REQUEST> CIR_RESERVE_REQUEST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EDELIV_FILE> EDELIV_FILE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIELD000S> FIELD000S { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIELD100S> FIELD100S { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIELD200S> FIELD200S { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIELD300S> FIELD300S { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIELD400S> FIELD400S { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIELD500S> FIELD500S { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIELD600S> FIELD600S { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIELD700S> FIELD700S { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIELD800S> FIELD800S { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIELD900S> FIELD900S { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOLDING> HOLDINGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOLDING_INVENTORY> HOLDING_INVENTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ILL_INCOMING_REQUESTS> ILL_INCOMING_REQUESTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAT_QUEUE> CAT_QUEUE { get; set; }
        public virtual HOLDING_COPY HOLDING_COPY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_AUTHOR> ITEM_AUTHOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_BBK> ITEM_BBK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_COUNTRY> ITEM_COUNTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_DDC> ITEM_DDC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_KEYWORD> ITEM_KEYWORD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_LANGUAGE> ITEM_LANGUAGE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_LIBRARY> ITEM_LIBRARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_LOC> ITEM_LOC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_NLM> ITEM_NLM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_NSC> ITEM_NSC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_OAI_SET> ITEM_OAI_SET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_PUBLISHER> ITEM_PUBLISHER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_SERIES> ITEM_SERIES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_SH> ITEM_SH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_THESIS_SUBJECT> ITEM_THESIS_SUBJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_TITLE> ITEM_TITLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_UDC> ITEM_UDC { get; set; }
        public virtual SER_ITEM SER_ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_ROUTING> SER_ROUTING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_FULLTEXT> ITEM_FULLTEXT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_ISSUE> SER_ISSUE { get; set; }
        public virtual MARC_WORKSHEET MARC_WORKSHEET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACQ_PO> ACQ_PO { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DocSearchWebForms.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Category()
        {
            this.tbl_DocumentType = new HashSet<tbl_DocumentType>();
        }
    
        public int Category_ID { get; set; }
        public string Name { get; set; }
        public int LastUser_ID { get; set; }
        public System.DateTime LastUser_DT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DocumentType> tbl_DocumentType { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace odev3.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblmusteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblmusteri()
        {
            this.tblsatiss = new HashSet<tblsatiss>();
        }
    
        public int musteriid { get; set; }
        public string musteriad { get; set; }
        public string musterisoyad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblsatiss> tblsatiss { get; set; }
    }
}

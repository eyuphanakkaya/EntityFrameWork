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
    
    public partial class tblsatiss
    {
        public int satisid { get; set; }
        public Nullable<int> urun { get; set; }
        public Nullable<int> musteri { get; set; }
        public Nullable<int> personel { get; set; }
        public Nullable<decimal> fiyat { get; set; }
    
        public virtual tblmusteri tblmusteri { get; set; }
        public virtual tblpersonel tblpersonel { get; set; }
        public virtual tblurun tblurun { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceSync
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblFATURABILGILERI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblFATURABILGILERI()
        {
            this.TblFATURADETAY = new HashSet<TblFATURADETAY>();
        }
    
        public int ID { get; set; }
        public string SERI { get; set; }
        public string SERINO { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public string SAAT { get; set; }
        public string VERGIDAIRESI { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<short> PERSONEL { get; set; }
    
        public virtual TblCARI TblCARI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblFATURADETAY> TblFATURADETAY { get; set; }
        public virtual TblPERSONEL TblPERSONEL { get; set; }
    }
}
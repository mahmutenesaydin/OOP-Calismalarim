//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goruntu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goruntu()
        {
            this.Monitors = new HashSet<Monitor>();
            this.Televizyons = new HashSet<Televizyon>();
        }
    
        public int GoruntuID { get; set; }
        public string GoruntuTuru { get; set; }
        public Nullable<int> UrunID { get; set; }
        public Nullable<int> KategoriID { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
        public virtual Urunler Urunler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Monitor> Monitors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Televizyon> Televizyons { get; set; }
    }
}

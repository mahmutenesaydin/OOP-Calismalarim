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
    
    public partial class Bilgisayar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bilgisayar()
        {
            this.Laptops = new HashSet<Laptop>();
            this.MasaüstüBilgisayar = new HashSet<MasaüstüBilgisayar>();
            this.Tablets = new HashSet<Tablet>();
        }
    
        public int BilgisayarID { get; set; }
        public string BilgisayarTuru { get; set; }
        public Nullable<int> UrunID { get; set; }
        public Nullable<int> KategoriID { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
        public virtual Urunler Urunler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Laptop> Laptops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasaüstüBilgisayar> MasaüstüBilgisayar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tablet> Tablets { get; set; }
    }
}

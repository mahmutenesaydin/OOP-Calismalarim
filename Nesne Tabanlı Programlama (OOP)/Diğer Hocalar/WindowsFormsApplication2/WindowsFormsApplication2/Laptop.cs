//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Laptop
    {
        public int LaptopID { get; set; }
        public string Markasi { get; set; }
        public string Modeli { get; set; }
        public string CikisYili { get; set; }
        public string TahminiFiyatAraligi { get; set; }
        public string PanelTipi { get; set; }
        public string IslemciMarkasi { get; set; }
        public string IsletimSistemi { get; set; }
        public string IslemciNesli { get; set; }
        public string HHDBoyutu { get; set; }
        public string SSDBoyutu { get; set; }
        public string EkranKartıModeli { get; set; }
        public string EkranKartiBellekMiktari { get; set; }
        public string RAM { get; set; }
        public string IslemciModeli { get; set; }
        public string IslemciTemelFrekansi { get; set; }
        public Nullable<int> BilgisayarID { get; set; }
    
        public virtual Bilgisayar Bilgisayar { get; set; }
    }
}

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
    
    public partial class AkilliTelefon
    {
        public int AkilliTelefonID { get; set; }
        public string Markasi { get; set; }
        public string Modeli { get; set; }
        public string CikisYili { get; set; }
        public string TahminiFiyatAraligi { get; set; }
        public string DahiliDepolama { get; set; }
        public string RAM { get; set; }
        public string EkranBoyutu { get; set; }
        public string BataryaKapasitesi { get; set; }
        public string ArkaKameraÇözünürlüğü { get; set; }
        public string ÖnKameraÇözünürlüğü { get; set; }
        public string Anaİşlemci { get; set; }
        public string YongaSeti { get; set; }
        public string IsletimSistemi { get; set; }
        public string AnTuTuPuanı { get; set; }
        public string Ağırlık { get; set; }
        public Nullable<int> TelefonID { get; set; }
    
        public virtual Telefon Telefon { get; set; }
    }
}

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
    
    public partial class BulasikMakinesi
    {
        public int BulasikMakinesiID { get; set; }
        public string Markasi { get; set; }
        public string Modeli { get; set; }
        public string TahminiFiyatAraligi { get; set; }
        public string SuTuketimi { get; set; }
        public Nullable<int> SicaklikSayisi { get; set; }
        public string Kapasite { get; set; }
        public string EnerjiTuketimSinifi { get; set; }
        public string KullanimTipi { get; set; }
        public string Guc { get; set; }
        public Nullable<int> BeyazEsyaID { get; set; }
    
        public virtual BeyazEsya BeyazEsya { get; set; }
    }
}

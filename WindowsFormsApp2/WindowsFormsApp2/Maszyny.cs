//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Maszyny
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maszyny()
        {
            this.Obsluga_techniczna = new HashSet<Obsluga_techniczna>();
            this.Przydzial_zasobow = new HashSet<Przydzial_zasobow>();
        }
    
        public int ID_Maszyny { get; set; }
        public string Model { get; set; }
        public int ID_Rodzaj_maszyny { get; set; }
        public string Producent { get; set; }
        public System.DateTime Gwarancja_do { get; set; }
        public System.DateTime Data_zakupu { get; set; }
        public int Resurs_rbh { get; set; }
        public System.DateTime Resurs_data_serwisu { get; set; }
    
        public virtual Rodzaj_maszyny Rodzaj_maszyny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obsluga_techniczna> Obsluga_techniczna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Przydzial_zasobow> Przydzial_zasobow { get; set; }
    }
}

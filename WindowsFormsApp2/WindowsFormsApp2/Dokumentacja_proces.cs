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
    
    public partial class Dokumentacja_proces
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dokumentacja_proces()
        {
            this.Proces_Produkcyjny = new HashSet<Proces_Produkcyjny>();
            this.Proces_technologiczny = new HashSet<Proces_technologiczny>();
        }
    
        public int ID_Dokumentacji_proces { get; set; }
        public int ID_Dokumentacji { get; set; }
    
        public virtual Dokumentacje Dokumentacje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_Produkcyjny> Proces_Produkcyjny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_technologiczny> Proces_technologiczny { get; set; }
    }
}

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
    
    public partial class Magazyn_dostarczenia_zewn
    {
        public int ID_dostarczenia { get; set; }
        public Nullable<int> ID_pracownicy { get; set; }
        public Nullable<int> ID_zamowienia { get; set; }
        public Nullable<double> Ilosc_dostarczona { get; set; }
        public string ID_miejsca { get; set; }
        public string Data_dostarczenia { get; set; }
    
        public virtual Magazyn_miejsca Magazyn_miejsca { get; set; }
        public virtual Pracownicy Pracownicy { get; set; }
        public virtual Zamowienia Zamowienia { get; set; }
    }
}

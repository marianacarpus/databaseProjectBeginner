//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proiect_baze_de_date
{
    using System;
    using System.Collections.Generic;
    
    public partial class CATEGORIE_SPORT
    {
        public CATEGORIE_SPORT()
        {
            this.PRODUSEs = new HashSet<PRODUSE>();
        }
    
        public short CATEGORIE_SPORT_ID { get; set; }
        public string DENUMIRE { get; set; }
    
        public virtual ICollection<PRODUSE> PRODUSEs { get; set; }
    }
}

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
    
    public partial class FURNIZOR
    {
        public FURNIZOR()
        {
            this.CONTRACTs = new HashSet<CONTRACT>();
        }
    
        public short FURNIZOR_ID { get; set; }
        public string NUME_FURNIZOR { get; set; }
        public string ADRESA { get; set; }
        public string EMAIL { get; set; }
    
        public virtual ICollection<CONTRACT> CONTRACTs { get; set; }
    }
}

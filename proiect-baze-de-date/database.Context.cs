﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CATEGORIE_SPORT> CATEGORIE_SPORT { get; set; }
        public DbSet<COMANDA_STOC> COMANDA_STOC { get; set; }
        public DbSet<CONTRACT> CONTRACTs { get; set; }
        public DbSet<FURNIZOR> FURNIZORs { get; set; }
        public DbSet<PRODUCATOR> PRODUCATORs { get; set; }
        public DbSet<PRODUSE> PRODUSEs { get; set; }
    }
}

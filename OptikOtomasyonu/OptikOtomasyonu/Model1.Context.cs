﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OptikOtomasyonu
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OptikOtomasyonuEntities : DbContext
    {
        public OptikOtomasyonuEntities()
            : base("name=OptikOtomasyonuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLSATIS> TBLSATIS { get; set; }
        public virtual DbSet<TBLBARKOD> TBLBARKOD { get; set; }
        public virtual DbSet<TBLHIZLIURUN> TBLHIZLIURUN { get; set; }
        public virtual DbSet<TBLISLEM> TBLISLEM { get; set; }
        public virtual DbSet<TBLISLEMOZET> TBLISLEMOZET { get; set; }
        public virtual DbSet<TBLTERAZI> TBLTERAZI { get; set; }
        public virtual DbSet<TBLURUNGRUP> TBLURUNGRUP { get; set; }
        public virtual DbSet<TBLURUN> TBLURUN { get; set; }
        public virtual DbSet<TBLSTOKHAREKET> TBLSTOKHAREKET { get; set; }
        public virtual DbSet<TBLSABIT> TBLSABIT { get; set; }
        public virtual DbSet<TBLKULLANICI> TBLKULLANICI { get; set; }
        public virtual DbSet<TBLFIXURUN> TBLFIXURUN { get; set; }
    }
}

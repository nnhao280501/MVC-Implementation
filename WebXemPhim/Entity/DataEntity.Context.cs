﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebXemPhim.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbDoAnWebEntities : DbContext
    {
        public dbDoAnWebEntities()
            : base("name=dbDoAnWebEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Banner> Banners { get; set; }
        public DbSet<CTTapPhim> CTTapPhims { get; set; }
        public DbSet<DSPhimBo> DSPhimBoes { get; set; }
        public DbSet<DSPhimLe> DSPhimLes { get; set; }
        public DbSet<Nam> Nams { get; set; }
        public DbSet<QuocGia> QuocGias { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<tintucphim> tintucphims { get; set; }
    }
}
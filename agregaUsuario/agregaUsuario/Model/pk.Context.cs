﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace agregaUsuario.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ParkeatedbEntities : DbContext
    {
        public ParkeatedbEntities()
            : base("name=ParkeatedbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<BannerShow> BannerShow { get; set; }
        public virtual DbSet<CheckIn> CheckIn { get; set; }
        public virtual DbSet<ParkingLot> ParkingLot { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PAOEntities : DbContext
    {
        public PAOEntities()
            : base("name=PAOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Subsidiary_companies> Subsidiary_companies { get; set; }
        public virtual DbSet<Sale_basket> Sale_basket { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<Employees_education> Employees_education { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<User_access> User_access { get; set; }
        public virtual DbSet<Goods_category> Goods_category { get; set; }
        public virtual DbSet<Subsidiary_companies_region> Subsidiary_companies_region { get; set; }
    }
}

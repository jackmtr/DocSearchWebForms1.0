﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DocSearchWebForms.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WASEntities : DbContext
    {
        public WASEntities()
            : base("name=WASEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Cabinet> tbl_Cabinet { get; set; }
        public virtual DbSet<tbl_Category> tbl_Category { get; set; }
        public virtual DbSet<tbl_DocReference> tbl_DocReference { get; set; }
        public virtual DbSet<tbl_Document> tbl_Document { get; set; }
        public virtual DbSet<tbl_DocumentType> tbl_DocumentType { get; set; }
        public virtual DbSet<tbl_Folder> tbl_Folder { get; set; }
        public virtual DbSet<tbl_Repository> tbl_Repository { get; set; }
        public virtual DbSet<tbl_Security> tbl_Security { get; set; }
        public virtual DbSet<tbl_Updates> tbl_Updates { get; set; }
        public virtual DbSet<tbl_User> tbl_User { get; set; }
        public virtual DbSet<tbl_Config> tbl_Config { get; set; }
        public virtual DbSet<tbl_UpdatesData> tbl_UpdatesData { get; set; }
    }
}

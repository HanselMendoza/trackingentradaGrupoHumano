﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace trackingentradaGrupoHumano.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBENTRYTRAKYNGEntities : DbContext
    {
        public DBENTRYTRAKYNGEntities()
            : base("name=DBENTRYTRAKYNGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CONFIGURACION> CONFIGURACIONs { get; set; }
        public virtual DbSet<loginuser> loginusers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBCOORDENADA> TBCOORDENADAs { get; set; }
        public virtual DbSet<TBDEPARTAMENTO> TBDEPARTAMENTOes { get; set; }
        public virtual DbSet<TBENTRADA> TBENTRADAs { get; set; }
        public virtual DbSet<TBESTADO> TBESTADOes { get; set; }
        public virtual DbSet<tblocalidad> tblocalidads { get; set; }
        public virtual DbSet<TBMOTIVOENTRADA> TBMOTIVOENTRADAs { get; set; }
        public virtual DbSet<TBOCUPACION> TBOCUPACIONs { get; set; }
        public virtual DbSet<TBPERSONA> TBPERSONAs { get; set; }
        public virtual DbSet<TBPISO> TBPISOes { get; set; }
        public virtual DbSet<estado> estadoes { get; set; }
    }
}
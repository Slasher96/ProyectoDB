﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagicalLogger
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class loggerBDEntities : DbContext
    {
        public loggerBDEntities()
            : base("name=loggerBDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<genAccionesCat> genAccionesCat { get; set; }
        public virtual DbSet<genFuncion> genFuncion { get; set; }
        public virtual DbSet<genLlamada> genLlamada { get; set; }
        public virtual DbSet<genPerfilUsuario> genPerfilUsuario { get; set; }
        public virtual DbSet<genPermisos> genPermisos { get; set; }
        public virtual DbSet<genSubsistemas> genSubsistemas { get; set; }
        public virtual DbSet<genVentana> genVentana { get; set; }
        public virtual DbSet<regAcciones> regAcciones { get; set; }
        public virtual DbSet<genUsuarios> genUsuarios { get; set; }
        public virtual DbSet<genControl> genControl { get; set; }
        public virtual DbSet<regcontroles> regcontroles { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PORTAFOLIO.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class portafolioEntities : DbContext
    {
        public portafolioEntities()
            : base("name=portafolioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Datos> Datos { get; set; }
        public virtual DbSet<Experiencia> Experiencia { get; set; }
        public virtual DbSet<Habilidad> Habilidad { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<Testimonio> Testimonio { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }
    }
}

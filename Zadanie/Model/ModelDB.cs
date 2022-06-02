using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Zadanie.Model
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<Analyzator> Analyzator { get; set; }
        public virtual DbSet<buhgalters> buhgalters { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Laborants> Laborants { get; set; }
        public virtual DbSet<Pacient> Pacient { get; set; }
        public virtual DbSet<Schet> Schet { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Uslugi> Uslugi { get; set; }
        public virtual DbSet<Vep_usluga> Vep_usluga { get; set; }
        public virtual DbSet<Zakaz> Zakaz { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Analyzator>()
                .Property(e => e.date_work)
                .IsFixedLength();

            modelBuilder.Entity<Analyzator>()
                .HasMany(e => e.Vep_usluga)
                .WithRequired(e => e.Analyzator)
                .HasForeignKey(e => e.id_analizator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<buhgalters>()
                .HasMany(e => e.Schet)
                .WithRequired(e => e.buhgalters)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Pacient)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Schet)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Laborants>()
                .HasMany(e => e.Vep_usluga)
                .WithRequired(e => e.Laborants)
                .HasForeignKey(e => e.id_lab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pacient>()
                .HasMany(e => e.Zakaz)
                .WithRequired(e => e.Pacient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Uslugi>()
                .HasMany(e => e.Vep_usluga)
                .WithRequired(e => e.Uslugi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zakaz>()
                .HasMany(e => e.Vep_usluga)
                .WithRequired(e => e.Zakaz)
                .WillCascadeOnDelete(false);
        }
    }
}

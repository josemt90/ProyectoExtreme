using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoExtreme_Datos
{
    public partial class ProyectoExtremeContext : DbContext
    {
        public ProyectoExtremeContext()
        {
        }

        public ProyectoExtremeContext(DbContextOptions<ProyectoExtremeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<Vehiculo> Vehiculos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Apellidos)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Carnet)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DNI");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Potencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_Vehiculos_Usuarios");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

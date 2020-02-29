using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class DbContexto : DbContext
    {
        protected DbContexto()
        {
        }

        public DbContexto([NotNullAttribute] DbContextOptions<DbContexto> options) : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }

        ///Constructor de la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);
                entity.ToTable("categoria");
                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);
                entity.ToTable("producto");
                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e=> e.IdCategoria).HasColumnName("idCategoria");
                
                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e=> e.Nombre)
                    .HasColumnName("nombre")
                    .IsRequired(true)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.HasIndex(e => e.Nombre).IsUnique();

                entity.Property(e=> e.Precio_venta)
                    .HasColumnName("precio_venta")
                    .IsRequired(true)
                    .HasColumnType("decimal(11,2)"); 
                
                entity.Property(e => e.Stock)
                    .HasColumnName("stock")
                    .IsRequired();
                
                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e=> e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(p => p.Categoria)
                    .WithMany(c => c.Producto)
                    .HasForeignKey(p => p.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_producto_categoria");

            }   
            );
        }

    }
}

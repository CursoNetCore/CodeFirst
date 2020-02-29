﻿// <auto-generated />
using System;
using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirst.Migrations
{
    [DbContext(typeof(DbContexto))]
    partial class DbContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeFirst.Models.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idCategoria")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnName("codigo")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Descripcion")
                        .HasColumnName("descripcion")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<bool?>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("estado")
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdCategoria");

                    b.ToTable("categoria");
                });

            modelBuilder.Entity("CodeFirst.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idProducto")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnName("codigo")
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    b.Property<string>("Descripcion")
                        .HasColumnName("descripcion")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<bool?>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("estado")
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("IdCategoria")
                        .HasColumnName("idCategoria")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<decimal>("Precio_venta")
                        .HasColumnName("precio_venta")
                        .HasColumnType("decimal(11,2)");

                    b.Property<int>("Stock")
                        .HasColumnName("stock")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("producto");
                });

            modelBuilder.Entity("CodeFirst.Models.Producto", b =>
                {
                    b.HasOne("CodeFirst.Models.Categoria", "Categoria")
                        .WithMany("Producto")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("FK_producto_categoria")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamenProgramacionAvanzada.Migrations
{
    [DbContext(typeof(ComercialSantaClaraContext))]
    [Migration("20241213192331_UpdateProveedor2")]
    partial class UpdateProveedor2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExamenProgramacionAvanzada.Models.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UbicacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UbicacionId");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("ExamenProgramacionAvanzada.Models.Ubicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ubicaciones");
                });

            modelBuilder.Entity("TipoProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposProducto");
                });

            modelBuilder.Entity("ExamenProgramacionAvanzada.Models.Proveedor", b =>
                {
                    b.HasOne("ExamenProgramacionAvanzada.Models.Ubicacion", "Ubicacion")
                        .WithMany("Proveedores")
                        .HasForeignKey("UbicacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("ExamenProgramacionAvanzada.Models.Ubicacion", b =>
                {
                    b.Navigation("Proveedores");
                });
#pragma warning restore 612, 618
        }
    }
}

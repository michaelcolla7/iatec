﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iatec_v2.Data;

namespace iatec_v2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("iatec_v2.Data.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Name = "Pneu aro 15",
                            Price = 256.50m,
                            Stock = 10
                        },
                        new
                        {
                            id = 2,
                            Name = "Limpador de parabrisas universal",
                            Price = 45.99m,
                            Stock = 30
                        },
                        new
                        {
                            id = 3,
                            Name = "Kit de carpet emborrachado",
                            Price = 110.60m,
                            Stock = 10
                        });
                });

            modelBuilder.Entity("iatec_v2.Data.Vehicle", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Cambium")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Doors")
                        .HasColumnType("int");

                    b.Property<string>("Fuel")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Model")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Brand = "Volkswagen",
                            Cambium = "m",
                            Doors = 4,
                            Fuel = "f",
                            Model = "Gol",
                            Year = 2015
                        },
                        new
                        {
                            id = 2,
                            Brand = "Ford",
                            Cambium = "m",
                            Doors = 2,
                            Fuel = "g",
                            Model = "Fiesta",
                            Year = 2017
                        },
                        new
                        {
                            id = 3,
                            Brand = "Renault",
                            Cambium = "a",
                            Doors = 4,
                            Fuel = "a",
                            Model = "Duster",
                            Year = 2019
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

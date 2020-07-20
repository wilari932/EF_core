﻿// <auto-generated />
using System;
using ConsoleApp5;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp5.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200720193956_init3")]
    partial class init3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp5.Tablas.Autmovil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("EstaRentado");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<double>("Precio");

                    b.HasKey("Id");

                    b.ToTable("Autmovil");
                });
#pragma warning restore 612, 618
        }
    }
}

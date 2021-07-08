﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TruckManagementWebAppNetCore.Models;

namespace TruckManagementWebAppNetCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210707182708_PopulateModels")]
    partial class PopulateModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TruckManagementWebAppNetCore.Models.Truck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ManufactureYear")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("ModelYear")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("TruckManagementWebAppNetCore.Models.TruckModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "FH"
                        },
                        new
                        {
                            Id = 2,
                            Name = "FM"
                        });
                });

            modelBuilder.Entity("TruckManagementWebAppNetCore.Models.Truck", b =>
                {
                    b.HasOne("TruckManagementWebAppNetCore.Models.TruckModel", "Model")
                        .WithMany("Trucks")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");
                });

            modelBuilder.Entity("TruckManagementWebAppNetCore.Models.TruckModel", b =>
                {
                    b.Navigation("Trucks");
                });
#pragma warning restore 612, 618
        }
    }
}

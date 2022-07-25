﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkOrderAssignment.Repositories;

namespace WorkOrderAssignment.Migrations
{
    [DbContext(typeof(dataContext))]
    partial class dataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkOrderAssignment.Technician", b =>
                {
                    b.Property<string>("TId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("TId");

                    b.ToTable("TC");
                });

            modelBuilder.Entity("WorkOrderAssignment.WorkOrder", b =>
                {
                    b.Property<string>("OId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Duration")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostalAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("technicianTId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OId");

                    b.HasIndex("technicianTId");

                    b.ToTable("WO");
                });

            modelBuilder.Entity("WorkOrderAssignment.WorkOrder", b =>
                {
                    b.HasOne("WorkOrderAssignment.Technician", "technician")
                        .WithMany()
                        .HasForeignKey("technicianTId");

                    b.Navigation("technician");
                });
#pragma warning restore 612, 618
        }
    }
}

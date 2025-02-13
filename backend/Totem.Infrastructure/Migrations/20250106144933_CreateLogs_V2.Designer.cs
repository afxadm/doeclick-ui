﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Totem.Infrastructure.Data;

#nullable disable

namespace Totem.Infrastructure.Migrations
{
    [DbContext(typeof(TotemContext))]
    [Migration("20250106144933_CreateLogs_V2")]
    partial class CreateLogs_V2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Totem.Domain.Entities.AuditLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Entity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("AuditLog");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Branch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<long>("CodeBranch")
                        .HasMaxLength(6)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameBranch")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telephone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CodeBranch")
                        .IsUnique();

                    b.ToTable("Branch", (string)null);
                });

            modelBuilder.Entity("Totem.Domain.Entities.Categories", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Causes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CauseType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Goal")
                        .HasColumnType("bit");

                    b.Property<string>("Observations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OperationsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TokenPagBank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Value")
                        .HasColumnType("float");

                    b.Property<double?>("ValueGoal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId")
                        .IsUnique()
                        .HasFilter("[CategoryId] IS NOT NULL");

                    b.HasIndex("OperationsId");

                    b.ToTable("Causes");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Operations", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CauseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOperation")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("HourOperation")
                        .HasColumnType("time(7)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int?>("QuantityCauses")
                        .HasColumnType("int");

                    b.Property<Guid?>("TaxpayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double?>("ValueTotalCauses")
                        .HasColumnType("float");

                    b.Property<double?>("ValueTotalOperation")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BranchId")
                        .IsUnique()
                        .HasFilter("[BranchId] IS NOT NULL");

                    b.HasIndex("TaxpayerId")
                        .IsUnique()
                        .HasFilter("[TaxpayerId] IS NOT NULL");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Positions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Description")
                        .IsUnique();

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Taxpayers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PositionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long?>("Registration")
                        .HasColumnType("bigint");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Worker")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("PositionId");

                    b.ToTable("Taxpayers");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid?>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid?>("PositionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Telephone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TypeUser")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("PositionId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Totem.Domain.Entities.Causes", b =>
                {
                    b.HasOne("Totem.Domain.Entities.Categories", "Category")
                        .WithOne("Causes")
                        .HasForeignKey("Totem.Domain.Entities.Causes", "CategoryId");

                    b.HasOne("Totem.Domain.Entities.Operations", null)
                        .WithMany("Causes")
                        .HasForeignKey("OperationsId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Operations", b =>
                {
                    b.HasOne("Totem.Domain.Entities.Branch", "Branch")
                        .WithOne("Operation")
                        .HasForeignKey("Totem.Domain.Entities.Operations", "BranchId");

                    b.HasOne("Totem.Domain.Entities.Taxpayers", "Taxpayer")
                        .WithOne("Operation")
                        .HasForeignKey("Totem.Domain.Entities.Operations", "TaxpayerId");

                    b.Navigation("Branch");

                    b.Navigation("Taxpayer");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Taxpayers", b =>
                {
                    b.HasOne("Totem.Domain.Entities.Branch", "Branch")
                        .WithMany("Taxpayers")
                        .HasForeignKey("BranchId");

                    b.HasOne("Totem.Domain.Entities.Positions", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId");

                    b.Navigation("Branch");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Users", b =>
                {
                    b.HasOne("Totem.Domain.Entities.Branch", "Branch")
                        .WithMany("Users")
                        .HasForeignKey("BranchId");

                    b.HasOne("Totem.Domain.Entities.Positions", "Position")
                        .WithMany("Users")
                        .HasForeignKey("PositionId");

                    b.Navigation("Branch");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Branch", b =>
                {
                    b.Navigation("Operation")
                        .IsRequired();

                    b.Navigation("Taxpayers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Categories", b =>
                {
                    b.Navigation("Causes")
                        .IsRequired();
                });

            modelBuilder.Entity("Totem.Domain.Entities.Operations", b =>
                {
                    b.Navigation("Causes");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Positions", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Totem.Domain.Entities.Taxpayers", b =>
                {
                    b.Navigation("Operation")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

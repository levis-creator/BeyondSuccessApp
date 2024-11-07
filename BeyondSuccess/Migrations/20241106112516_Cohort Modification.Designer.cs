﻿// <auto-generated />
using System;
using BeyondSuccessWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeyondSuccessWeb.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241106112516_Cohort Modification")]
    partial class CohortModification
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BeyondSuccessWeb.Models.Entities.Cohort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CohortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CohortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cohorts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CohortName = "Cohort1",
                            CreatedAt = new DateTime(2024, 11, 6, 14, 25, 15, 901, DateTimeKind.Local).AddTicks(6053),
                            StartDate = new DateOnly(2002, 7, 27),
                            UpdatedAt = new DateTime(2024, 11, 6, 14, 25, 15, 901, DateTimeKind.Local).AddTicks(6040)
                        },
                        new
                        {
                            Id = 2,
                            CohortName = "Cohort2",
                            CreatedAt = new DateTime(2024, 11, 6, 14, 25, 15, 901, DateTimeKind.Local).AddTicks(6064),
                            StartDate = new DateOnly(2010, 7, 27),
                            UpdatedAt = new DateTime(2024, 11, 6, 14, 25, 15, 901, DateTimeKind.Local).AddTicks(6063)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
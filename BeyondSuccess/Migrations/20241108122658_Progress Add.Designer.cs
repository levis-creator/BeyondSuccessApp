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
    [Migration("20241108122658_Progress Add")]
    partial class ProgressAdd
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
                            CreatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9139),
                            StartDate = new DateOnly(2002, 7, 27),
                            UpdatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9126)
                        },
                        new
                        {
                            Id = 2,
                            CohortName = "Cohort2",
                            CreatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9149),
                            StartDate = new DateOnly(2010, 7, 27),
                            UpdatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9148)
                        });
                });

            modelBuilder.Entity("BeyondSuccessWeb.Models.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LessonDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LessonTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9360),
                            LessonDescription = "",
                            LessonTitle = "lesson 1",
                            UpdatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9359)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9363),
                            LessonDescription = "",
                            LessonTitle = "lesson 2",
                            UpdatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9363)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9366),
                            LessonDescription = "",
                            LessonTitle = "lesson 3",
                            UpdatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9365)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9367),
                            LessonDescription = "",
                            LessonTitle = "lesson 4",
                            UpdatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9367)
                        });
                });

            modelBuilder.Entity("BeyondSuccessWeb.Models.Entities.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CohortId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CohortId");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CohortId = 2,
                            CreatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9312),
                            EmailAddress = "eluid@email.com",
                            FirstName = "Eluid",
                            LastName = "Kipchoge",
                            PhoneNumber = "+2548708988",
                            UpdatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9311)
                        },
                        new
                        {
                            Id = 2,
                            CohortId = 2,
                            CreatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9316),
                            EmailAddress = "kinyanjuiSimon@email.com",
                            FirstName = "Simon",
                            LastName = "Kinyanjui",
                            PhoneNumber = "+2548708988",
                            UpdatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9316)
                        });
                });

            modelBuilder.Entity("BeyondSuccessWeb.Models.Entities.Progress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CohortId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("CompletedOnDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CohortId");

                    b.HasIndex("LessonId");

                    b.ToTable("Progresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CohortId = 2,
                            CompletedOnDate = new DateOnly(2001, 7, 27),
                            CreatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9613),
                            LessonId = 1,
                            UpdatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9612)
                        },
                        new
                        {
                            Id = 2,
                            CohortId = 2,
                            CompletedOnDate = new DateOnly(2019, 7, 27),
                            CreatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9617),
                            LessonId = 2,
                            UpdatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9616)
                        },
                        new
                        {
                            Id = 3,
                            CohortId = 2,
                            CompletedOnDate = new DateOnly(2029, 7, 27),
                            CreatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9619),
                            LessonId = 3,
                            UpdatedAt = new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9619)
                        });
                });

            modelBuilder.Entity("BeyondSuccessWeb.Models.Entities.Member", b =>
                {
                    b.HasOne("BeyondSuccessWeb.Models.Entities.Cohort", "Cohort")
                        .WithMany("Members")
                        .HasForeignKey("CohortId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cohort");
                });

            modelBuilder.Entity("BeyondSuccessWeb.Models.Entities.Progress", b =>
                {
                    b.HasOne("BeyondSuccessWeb.Models.Entities.Cohort", "Cohort")
                        .WithMany("Progress")
                        .HasForeignKey("CohortId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeyondSuccessWeb.Models.Entities.Lesson", "Lesson")
                        .WithMany("Progress")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cohort");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("BeyondSuccessWeb.Models.Entities.Cohort", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Progress");
                });

            modelBuilder.Entity("BeyondSuccessWeb.Models.Entities.Lesson", b =>
                {
                    b.Navigation("Progress");
                });
#pragma warning restore 612, 618
        }
    }
}

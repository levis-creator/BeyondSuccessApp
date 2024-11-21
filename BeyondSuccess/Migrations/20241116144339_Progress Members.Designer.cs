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
    [Migration("20241116144339_Progress Members")]
    partial class ProgressMembers
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
                            StartDate = new DateOnly(2002, 7, 27),
                            UpdatedAt = new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2183)
                        },
                        new
                        {
                            Id = 2,
                            CohortName = "Cohort2",
                            StartDate = new DateOnly(2010, 7, 27),
                            UpdatedAt = new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2202)
                        });
                });

            modelBuilder.Entity("BeyondSuccessWeb.Models.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                            LessonDescription = "",
                            LessonTitle = "lesson 1",
                            UpdatedAt = new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2466)
                        },
                        new
                        {
                            Id = 2,
                            LessonDescription = "",
                            LessonTitle = "lesson 2",
                            UpdatedAt = new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2468)
                        },
                        new
                        {
                            Id = 3,
                            LessonDescription = "",
                            LessonTitle = "lesson 3",
                            UpdatedAt = new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2470)
                        },
                        new
                        {
                            Id = 4,
                            LessonDescription = "",
                            LessonTitle = "lesson 4",
                            UpdatedAt = new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2473)
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
                            EmailAddress = "eluid@email.com",
                            FirstName = "Eluid",
                            LastName = "Kipchoge",
                            PhoneNumber = "+2548708988",
                            UpdatedAt = new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2437)
                        },
                        new
                        {
                            Id = 2,
                            CohortId = 2,
                            EmailAddress = "kinyanjuiSimon@email.com",
                            FirstName = "Simon",
                            LastName = "Kinyanjui",
                            PhoneNumber = "+2548708988",
                            UpdatedAt = new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2442)
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

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

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
                            LessonId = 1,
                            Remarks = "",
                            UpdatedAt = new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2498)
                        },
                        new
                        {
                            Id = 2,
                            CohortId = 2,
                            CompletedOnDate = new DateOnly(2019, 7, 27),
                            LessonId = 2,
                            Remarks = "",
                            UpdatedAt = new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2503)
                        },
                        new
                        {
                            Id = 3,
                            CohortId = 2,
                            CompletedOnDate = new DateOnly(2029, 7, 27),
                            LessonId = 3,
                            Remarks = "",
                            UpdatedAt = new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2505)
                        });
                });

            modelBuilder.Entity("MemberProgress", b =>
                {
                    b.Property<int>("MembersPresentId")
                        .HasColumnType("int");

                    b.Property<int>("ProgressId")
                        .HasColumnType("int");

                    b.HasKey("MembersPresentId", "ProgressId");

                    b.HasIndex("ProgressId");

                    b.ToTable("MemberProgress");
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

            modelBuilder.Entity("MemberProgress", b =>
                {
                    b.HasOne("BeyondSuccessWeb.Models.Entities.Member", null)
                        .WithMany()
                        .HasForeignKey("MembersPresentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeyondSuccessWeb.Models.Entities.Progress", null)
                        .WithMany()
                        .HasForeignKey("ProgressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisionX.Data;

#nullable disable

namespace VisionX.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231119045004_M1")]
    partial class M1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VisionX.Models.Appointment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExamID")
                        .HasColumnType("int");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientID")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ExamID");

                    b.HasIndex("PatientID");

                    b.ToTable("Appointment", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Day = "21",
                            ExamID = 1,
                            Month = "January",
                            PatientID = 1,
                            Time = "9:00",
                            Year = "2023"
                        });
                });

            modelBuilder.Entity("VisionX.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Exam", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "REE1",
                            Description = "Regular Eye Exam",
                            Fee = 100
                        },
                        new
                        {
                            Id = 2,
                            Code = "GEE1",
                            Description = "General Eye Exam",
                            Fee = 200
                        },
                        new
                        {
                            Id = 3,
                            Code = "YEE1",
                            Description = "Regular Eye Exam 3",
                            Fee = 300
                        });
                });

            modelBuilder.Entity("VisionX.Models.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEditing")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSelected")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvincialHealthNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientID");

                    b.ToTable("Patient", (string)null);

                    b.HasData(
                        new
                        {
                            PatientID = 1,
                            Address = "123 Main st",
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Vancouver",
                            Email = "test@mail.com",
                            FirstName = "Edmond",
                            IsEditing = false,
                            IsSelected = false,
                            LastName = "Chen",
                            MiddleName = "Li",
                            Occupation = "test",
                            Phone = "233132",
                            PostalCode = "VA2 34B",
                            Province = "BC",
                            ProvincialHealthNumber = "12345"
                        },
                        new
                        {
                            PatientID = 2,
                            Address = "123 Test St",
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Richmond",
                            Email = "test@mail.com",
                            FirstName = "Chris",
                            IsEditing = false,
                            IsSelected = false,
                            LastName = "Wu",
                            MiddleName = "Yue",
                            Occupation = "test",
                            Phone = "233132",
                            PostalCode = "VA2 34B",
                            Province = "BC",
                            ProvincialHealthNumber = "12345"
                        },
                        new
                        {
                            PatientID = 3,
                            Address = "123 Minor st",
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Vancouver",
                            Email = "test@mail.com",
                            FirstName = "Kris",
                            IsEditing = false,
                            IsSelected = false,
                            LastName = "Ocampo",
                            MiddleName = "Li",
                            Occupation = "test",
                            Phone = "233132",
                            PostalCode = "VA2 34B",
                            Province = "BC",
                            ProvincialHealthNumber = "12345"
                        });
                });

            modelBuilder.Entity("VisionX.Models.Appointment", b =>
                {
                    b.HasOne("VisionX.Models.Exam", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamID");

                    b.HasOne("VisionX.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID");

                    b.Navigation("Exam");

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}

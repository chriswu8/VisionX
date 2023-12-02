﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisionX.Data;

#nullable disable

namespace VisionX.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientID")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceID")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PatientID");

                    b.HasIndex("ServiceID");

                    b.ToTable("Appointment", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Day = "21",
                            Month = "1",
                            PatientID = 1,
                            ServiceID = 1,
                            Time = "9:00",
                            Year = "2023"
                        });
                });

            modelBuilder.Entity("VisionX.Models.Invoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Fee")
                        .HasColumnType("int");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientID")
                        .HasColumnType("int");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceID")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PatientID");

                    b.HasIndex("ProductID");

                    b.HasIndex("ServiceID");

                    b.ToTable("Invoice", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 2,
                            Day = "14",
                            Fee = 100,
                            IsPaid = false,
                            Month = "12",
                            PatientID = 1,
                            ServiceID = 1,
                            Year = "2023"
                        },
                        new
                        {
                            ID = 3,
                            Day = "14",
                            Fee = 100,
                            IsPaid = false,
                            Month = "12",
                            PatientID = 1,
                            ProductID = 1,
                            Year = "2023"
                        });
                });

            modelBuilder.Entity("VisionX.Models.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodPressure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complaint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrectedODAxis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrectedODCylinder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrectedODSphere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrectedOSAxis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrectedOSCylinder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrectedOSSphere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EyeDrops")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlaucomaHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasGlaucoma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("HistoryOfCancer")
                        .HasColumnType("bit");

                    b.Property<bool?>("HistoryOfCataracts")
                        .HasColumnType("bit");

                    b.Property<bool?>("HistoryOfDiabetes")
                        .HasColumnType("bit");

                    b.Property<bool?>("HistoryOfHIV")
                        .HasColumnType("bit");

                    b.Property<bool?>("HistoryOfHeartProblems")
                        .HasColumnType("bit");

                    b.Property<bool?>("HistoryOfKidneyDisease")
                        .HasColumnType("bit");

                    b.Property<bool?>("HistoryOfMacularDegeneration")
                        .HasColumnType("bit");

                    b.Property<bool?>("HistoryOfNeuromuscularDisease")
                        .HasColumnType("bit");

                    b.Property<bool?>("HistoryOfRetinalDetachment")
                        .HasColumnType("bit");

                    b.Property<bool?>("HistoryOfStroke")
                        .HasColumnType("bit");

                    b.Property<bool?>("HistoryOfThyroid")
                        .HasColumnType("bit");

                    b.Property<bool?>("HistoryOfTuberculosis")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEditing")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSelected")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LifeStage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvincialHealthNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symptoms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UncorrectedODAxis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UncorrectedODCylinder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UncorrectedODSphere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UncorrectedOSAxis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UncorrectedOSCylinder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UncorrectedOSSphere")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientID");

                    b.ToTable("Patient", (string)null);

                    b.HasData(
                        new
                        {
                            PatientID = 1,
                            Address = "123 Main st",
                            BirthDate = "1923-01-01",
                            BloodPressure = "Hypertensive Crisis",
                            City = "Vancouver",
                            Complaint = "",
                            CorrectedODAxis = "0",
                            CorrectedODCylinder = "0",
                            CorrectedODSphere = "0",
                            CorrectedOSAxis = "0",
                            CorrectedOSCylinder = "0",
                            CorrectedOSSphere = "0",
                            Email = "test@mail.com",
                            ExamDay = "1",
                            ExamMonth = "1",
                            ExamTime = "11",
                            ExamYear = "2011",
                            EyeDrops = "",
                            FirstName = "Edmond",
                            GlaucomaHistory = "Maternal parent",
                            HasGlaucoma = "Yes",
                            HistoryOfCancer = false,
                            HistoryOfCataracts = false,
                            HistoryOfDiabetes = false,
                            HistoryOfHIV = false,
                            HistoryOfHeartProblems = false,
                            HistoryOfKidneyDisease = false,
                            HistoryOfMacularDegeneration = false,
                            HistoryOfNeuromuscularDisease = false,
                            HistoryOfRetinalDetachment = false,
                            HistoryOfStroke = false,
                            HistoryOfThyroid = false,
                            HistoryOfTuberculosis = false,
                            IsEditing = false,
                            IsSelected = false,
                            LastName = "Chen",
                            LifeStage = "Senior",
                            MiddleName = "Li",
                            Occupation = "test",
                            Phone = "233132",
                            PostalCode = "VA2 34B",
                            Province = "BC",
                            ProvincialHealthNumber = "12345",
                            Sex = "Female",
                            UncorrectedODAxis = "0",
                            UncorrectedODCylinder = "0",
                            UncorrectedODSphere = "0.00",
                            UncorrectedOSAxis = "0",
                            UncorrectedOSCylinder = "0",
                            UncorrectedOSSphere = "0.00"
                        },
                        new
                        {
                            PatientID = 2,
                            Address = "123 Test St",
                            BirthDate = "1923-02-02",
                            BloodPressure = "Hypertensive Crisis",
                            City = "Richmond",
                            Complaint = "",
                            CorrectedODAxis = "0",
                            CorrectedODCylinder = "0",
                            CorrectedODSphere = "0",
                            CorrectedOSAxis = "0",
                            CorrectedOSCylinder = "0",
                            CorrectedOSSphere = "0",
                            Email = "test@mail.com",
                            ExamDay = "1",
                            ExamMonth = "1",
                            ExamTime = "11",
                            ExamYear = "2011",
                            EyeDrops = "",
                            FirstName = "Chris",
                            GlaucomaHistory = "Maternal parent",
                            HasGlaucoma = "Yes",
                            HistoryOfCancer = false,
                            HistoryOfCataracts = false,
                            HistoryOfDiabetes = false,
                            HistoryOfHIV = false,
                            HistoryOfHeartProblems = false,
                            HistoryOfKidneyDisease = false,
                            HistoryOfMacularDegeneration = false,
                            HistoryOfNeuromuscularDisease = false,
                            HistoryOfRetinalDetachment = false,
                            HistoryOfStroke = false,
                            HistoryOfThyroid = false,
                            HistoryOfTuberculosis = false,
                            IsEditing = false,
                            IsSelected = false,
                            LastName = "Wu",
                            LifeStage = "Senior",
                            MiddleName = "Yue",
                            Occupation = "test",
                            Phone = "233132",
                            PostalCode = "VA2 34B",
                            Province = "BC",
                            ProvincialHealthNumber = "12345",
                            Sex = "Female",
                            UncorrectedODAxis = "0",
                            UncorrectedODCylinder = "0",
                            UncorrectedODSphere = "0.00",
                            UncorrectedOSAxis = "0",
                            UncorrectedOSCylinder = "0",
                            UncorrectedOSSphere = "0.00"
                        },
                        new
                        {
                            PatientID = 3,
                            Address = "123 Minor st",
                            BirthDate = "2000-03-03",
                            BloodPressure = "Hypertensive Crisis",
                            City = "Vancouver",
                            Complaint = "",
                            CorrectedODAxis = "0",
                            CorrectedODCylinder = "0",
                            CorrectedODSphere = "0",
                            CorrectedOSAxis = "0",
                            CorrectedOSCylinder = "0",
                            CorrectedOSSphere = "0",
                            Email = "test@mail.com",
                            ExamDay = "1",
                            ExamMonth = "1",
                            ExamTime = "11",
                            ExamYear = "2011",
                            EyeDrops = "",
                            FirstName = "Kris",
                            GlaucomaHistory = "Maternal parent",
                            HasGlaucoma = "Yes",
                            HistoryOfCancer = false,
                            HistoryOfCataracts = false,
                            HistoryOfDiabetes = false,
                            HistoryOfHIV = false,
                            HistoryOfHeartProblems = false,
                            HistoryOfKidneyDisease = false,
                            HistoryOfMacularDegeneration = false,
                            HistoryOfNeuromuscularDisease = false,
                            HistoryOfRetinalDetachment = false,
                            HistoryOfStroke = false,
                            HistoryOfThyroid = false,
                            HistoryOfTuberculosis = false,
                            IsEditing = false,
                            IsSelected = false,
                            LastName = "Ocampo",
                            LifeStage = "Senior",
                            MiddleName = "Li",
                            Occupation = "test",
                            Phone = "233132",
                            PostalCode = "VA2 34B",
                            Province = "BC",
                            ProvincialHealthNumber = "12345",
                            Sex = "Female",
                            UncorrectedODAxis = "0",
                            UncorrectedODCylinder = "0",
                            UncorrectedODSphere = "0.00",
                            UncorrectedOSAxis = "0",
                            UncorrectedOSCylinder = "0",
                            UncorrectedOSSphere = "0.00"
                        });
                });

            modelBuilder.Entity("VisionX.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("Fee")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Fee = 100,
                            Manufacturer = "Ray Ban",
                            ModelNumber = "RB3558",
                            Type = "Sunglasses"
                        },
                        new
                        {
                            ID = 2,
                            Fee = 150,
                            Manufacturer = "Ray Ban",
                            ModelNumber = "RB3025",
                            Type = "Aviator Sunglasses"
                        },
                        new
                        {
                            ID = 3,
                            Fee = 120,
                            Manufacturer = "Ray Ban",
                            ModelNumber = "RB2140",
                            Type = "Wayfarer Sunglasses"
                        });
                });

            modelBuilder.Entity("VisionX.Models.Service", b =>
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

                    b.ToTable("Service", (string)null);

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
                            Description = "Glaucoma Eye Exam",
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

            modelBuilder.Entity("VisionX.Models.Appointment", b =>
                {
                    b.HasOne("VisionX.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID");

                    b.HasOne("VisionX.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceID");

                    b.Navigation("Patient");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("VisionX.Models.Invoice", b =>
                {
                    b.HasOne("VisionX.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID");

                    b.HasOne("VisionX.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID");

                    b.HasOne("VisionX.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceID");

                    b.Navigation("Patient");

                    b.Navigation("Product");

                    b.Navigation("Service");
                });
#pragma warning restore 612, 618
        }
    }
}

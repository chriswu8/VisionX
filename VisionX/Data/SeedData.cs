using Microsoft.EntityFrameworkCore;
using VisionX.Models;

namespace VisionX.Data
{
    public static class SeedData
    {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                GetPatients()
            );

            modelBuilder.Entity<Exam>().HasData(GetExams());

        }
        public static List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>() {
            new Patient() {
                PatientID = 1,
                LastName = "Chen",
                FirstName = "Edmond",
                MiddleName = "Li",
                Address = "123 Main st",
                Province = "BC",
                City = "Vancouver",
                PostalCode = "VA2 34B",
                ProvincialHealthNumber = "12345",
                Phone = "233132",
                Email = "test@mail.com",
                Occupation = "test",
            },
            new Patient() {
                PatientID = 2,
                LastName = "Wu",
                FirstName = "Chris",
                MiddleName = "Yue",
                Address = "123 Test St",
                Province = "BC",
                City = "Richmond",
                PostalCode = "VA2 34B",
                ProvincialHealthNumber = "12345",
                Phone = "233132",
                Email = "test@mail.com",
                Occupation = "test",
            },
            new Patient() {
                PatientID = 3,
                LastName = "Ocampo",
                FirstName = "Kris",
                MiddleName = "Li",
                Address = "123 Minor st",
                Province = "BC",
                City = "Vancouver",
                PostalCode = "VA2 34B",
                ProvincialHealthNumber = "12345",
                Phone = "233132",
                Email = "test@mail.com",
                Occupation = "test",
            }
        };

            return patients;
        }

        public static List<Service> GetExams()
        {
            List<Service> services = new List<Service>() {
            new Service() {
                Id = 1,
                Fee = 100,
                Code = "REE1",
                Description = "Regular Eye Exam"
            },
            new Service() {
                Id = 2,
                Fee = 200,
                Code = "GEE1",
                Description = "General Eye Exam"
            },
            new Service() {
                Id = 3,
                Fee = 300,
                Code = "YEE1",
                Description = "Regular Eye Exam 3"
            }
        };

            return services;
        }
    }
}
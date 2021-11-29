using System;

using EFCORE_DATAACCESS.Models;
using EFCORE_DATAACCESS.SQLViews;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCORE_DATAACCESS
{
    public partial class CovidXSQLDBContext : IdentityDbContext<CovidXUser>
    {
        public CovidXSQLDBContext()
        {
        }

        public CovidXSQLDBContext(DbContextOptions<CovidXSQLDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CovidXUser> CovidXusers { get; set; }
        public virtual DbSet<Dependent> Dependents { get; set; }
        public virtual DbSet<DependentType> DependentTypes { get; set; }
        public virtual DbSet<LabUser> LabUsers { get; set; }
        public virtual DbSet<MedicalAidPlan> MedicalAidPlans { get; set; }
        public virtual DbSet<MedicalAidScheme> MedicalAidSchemes { get; set; }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<NurseSchedule> NurseSchedules { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
       
        public virtual DbSet<Suburb> Suburbs { get; set; }
        public virtual DbSet<SuburbsPreffered> SuburbsPreffereds { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestRequest> TestRequests { get; set; }
        public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }

        //SQL VIEWS
        public virtual DbSet<GetAllTestRequests> AllTestRequests {get;set;}
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configure entities using 'IEntityTypeConfiguration'
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

            
            
            modelBuilder.SeedingCity();
            modelBuilder.SeedingSuburb();
            modelBuilder.SeedingMedicalAidScheme();
            modelBuilder.SeedingMedicalAidPlan();
            modelBuilder.SeedingDependentType();
            modelBuilder.SeedingPatients();
            modelBuilder.SeedingDependents();
            modelBuilder.SeedingNurses();
            modelBuilder.SeedingNursePreferredSuburbs();
            modelBuilder.SeedingLabUser();
            modelBuilder.SeedingTestRequests();
           modelBuilder.SeedingTests();
            modelBuilder.SeedingCalenderEvents();


            //SQL VIEWS
            modelBuilder
                .Entity<GetAllTestRequests>()
                .ToView(nameof(GetAllTestRequests))
                .HasKey(t => t.TestRequestId);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

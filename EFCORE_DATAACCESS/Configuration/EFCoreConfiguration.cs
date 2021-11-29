
using EFCORE_DATAACCESS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE_DATAACCESS.Configuration
{
    public class EFCoreConfiguration :
        IEntityTypeConfiguration<IdentityUserLogin<string>>,
        IEntityTypeConfiguration<IdentityUserRole<string>>,
        IEntityTypeConfiguration<IdentityUserToken<string>>,
        IEntityTypeConfiguration<SuburbsPreffered>,
        IEntityTypeConfiguration<Suburb>,
        IEntityTypeConfiguration<Dependent>,
        IEntityTypeConfiguration<TestRequest>,
        IEntityTypeConfiguration<NurseSchedule>,
        IEntityTypeConfiguration<Patient>,
        IEntityTypeConfiguration<CalendarEvent>




    {
        public void Configure(EntityTypeBuilder<IdentityUserLogin<string>> builder)
        {
            builder.HasKey(entity => entity.UserId);
        }

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasKey(entity => new { entity.RoleId, entity.UserId });
        }

        public void Configure(EntityTypeBuilder<IdentityUserToken<string>> builder)
        {
            builder.HasKey(entity => entity.UserId);
        }

        public void Configure(EntityTypeBuilder<SuburbsPreffered> builder)
        {
            builder.HasKey(entity => new { entity.NurseId, entity.SuburbId });
        }

        public void Configure(EntityTypeBuilder<Suburb> builder)
        {
            //// from Suburbs to SuburbsPreffered
            //builder.HasMany(fk => fk.SuburbsPreffereds)
            //    // from SuburbsPreffered to Suburbs
            //    .WithOne()
            //    .OnDelete(DeleteBehavior.NoAction);
        }

        public void Configure(EntityTypeBuilder<Dependent> builder)
        {
            builder.HasOne(fk => fk.Suburb)
                .WithMany(fk => fk.Dependents)
                .HasForeignKey(fk => fk.SuburbId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(fk => fk.MainMember)
                .WithMany(fk => fk.Dependents)
                .HasForeignKey(fk => fk.MainMemberId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public void Configure(EntityTypeBuilder<TestRequest> builder)
        {
            builder.HasOne(fk => fk.Suburb)
                .WithMany(fk => fk.TestRequests)
                .HasForeignKey(fk => fk.SuburbId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(fk => fk.Patient)
                 .WithMany(fk => fk.TestRequests)
                .HasForeignKey(fk => fk.PatientId)
                .OnDelete(DeleteBehavior.NoAction);

           
        }

        public void Configure(EntityTypeBuilder<NurseSchedule> builder)
        {
            {
                builder.HasKey(entity => new { entity.TestRequestId, entity.NurseId });
            }

            builder.HasOne(fk => fk.TestRequest)
                 .WithMany(fk => fk.NurseSchedules)
                .HasForeignKey(fk => fk.TestRequestId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(fk => fk.Nurse)
                .WithMany(fk => fk.NurseSchedules)
               .HasForeignKey(fk => fk.NurseId)
               .OnDelete(DeleteBehavior.NoAction);




        }

        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasOne(fk => fk.Suburb)
                .WithMany(fk => fk.Patients)
                .HasForeignKey(fk => fk.SuburbId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public void Configure(EntityTypeBuilder<CalendarEvent> builder)
        {
            builder.HasOne<TestRequest>(calendar => calendar.TestRequest)
                 .WithOne(test => test.CalenderEvent)
                 .HasForeignKey<CalendarEvent>(fk => fk.ID);
        }
    }
}

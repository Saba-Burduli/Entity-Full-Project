using Microsoft.EntityFrameworkCore;
using SchoolDb.Configurations;
using SchoolDb.Models;
using SchoolSystemDemo.Configurations;
using SchoolSystemDemo.Models;

namespace SchoolDb
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Pupil>? Pupils { get; set; }
        public DbSet<Class>? Classes { get; set; }
        public DbSet<Teacher>? Teachers { get; set; }
        public DbSet<Subject>? Subjects { get; set; }
        public DbSet<Journal>? Journals { get; set; }
        public DbSet<Schedule>? Schedules { get; set; }
        public DbSet<Grade>? Grades { get; set; }
        public DbSet<AttendanceStatus>? AttendanceStatuses { get; set; }
        public DbSet<School>? Schools { get; set; }
        public DbSet<Role>? Roles { get; set; }

        public SchoolDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use the base OnConfiguring method to configure the connection
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                       .SetBasePath(AppContext.BaseDirectory)
                       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                       .Build();

                var connectionString = configuration.GetConnectionString("SchoolDbConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // seeding
            modelBuilder.Entity<AttendanceStatus>().HasData(
                new AttendanceStatus()
                {
                    AttendanceStatusId = 1,
                    AttendanceStatusName = "Present",
                },

                new AttendanceStatus()
                {
                    AttendanceStatusId = 2,
                    AttendanceStatusName = "Absent"
                },

                new AttendanceStatus()
                {
                    AttendanceStatusId = 3,
                    AttendanceStatusName = "Late"
                },

                new AttendanceStatus()
                {
                    AttendanceStatusId = 4,
                    AttendanceStatusName = "Online"
                });

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleId = 1,
                    RoleName = "Mentor",
                },

                new Role
                {
                    RoleId = 2,
                    RoleName = "Leading Teacher"
                },

                new Role
                {
                    RoleId = 3,
                    RoleName = "Senior Teacher"
                },

                new Role
                {
                    RoleId = 4,
                    RoleName = "Assistant Teacher"
                });


            modelBuilder.Entity<Class>().HasData(
               new Class
               {
                   ClassId = 1,
                   ClassName = Enums.ClassEnum.SeventhClass.ToString(),
               },

               new Class
               {
                   ClassId = 2,
                   ClassName = Enums.ClassEnum.EightClass.ToString(),
               },
               new Class
               {
                   ClassId = 3,
                   ClassName = Enums.ClassEnum.NinthClass.ToString(),
               },

               new Class
               {
                   ClassId = 4,
                   ClassName = Enums.ClassEnum.TenthClass.ToString(),
               },

               new Class
               {
                   ClassId = 5,
                   ClassName = Enums.ClassEnum.EleventhClass.ToString()
               },

               new Class
               {
                   ClassId = 6,
                   ClassName = Enums.ClassEnum.TwelvethClass.ToString()
               }
               );

            modelBuilder.Entity<Grade>().HasData(
                new Grade
                {
                    GradeId = 1,
                    GradeName = "A",
                },

                new Grade
                {
                    GradeId = 2,
                    GradeName = "B",
                },

                new Grade
                {
                    GradeId = 3,
                    GradeName = "C",
                },

                new Grade
                {
                    GradeId = 4,
                    GradeName = "D",
                },

                new Grade
                {
                    GradeId = 5,
                    GradeName = "E",
                }
                );

            modelBuilder.ApplyConfiguration(new PupilConfiguration());
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new JournalConfiguration());
            modelBuilder.ApplyConfiguration(new ScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new SchoolConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolDb;

#nullable disable

namespace SchoolDb.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20250116130027_migration_v1")]
    partial class migration_v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClassTeacher", b =>
                {
                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("ClassId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ClassTeacher");
                });

            modelBuilder.Entity("SchoolDb.Models.AttendanceStatus", b =>
                {
                    b.Property<int>("AttendanceStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttendanceStatusId"), 1L, 1);

                    b.Property<string>("AttendanceStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AttendanceStatusId");

                    b.ToTable("AttendanceStatuses");

                    b.HasData(
                        new
                        {
                            AttendanceStatusId = 1,
                            AttendanceStatusName = "Present"
                        },
                        new
                        {
                            AttendanceStatusId = 2,
                            AttendanceStatusName = "Absent"
                        },
                        new
                        {
                            AttendanceStatusId = 3,
                            AttendanceStatusName = "Late"
                        },
                        new
                        {
                            AttendanceStatusId = 4,
                            AttendanceStatusName = "Online"
                        });
                });

            modelBuilder.Entity("SchoolDb.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.ToTable("Classes", (string)null);

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            ClassName = "SeventhClass",
                            ScheduleId = 0
                        },
                        new
                        {
                            ClassId = 2,
                            ClassName = "EightClass",
                            ScheduleId = 0
                        },
                        new
                        {
                            ClassId = 3,
                            ClassName = "NinthClass",
                            ScheduleId = 0
                        },
                        new
                        {
                            ClassId = 4,
                            ClassName = "TenthClass",
                            ScheduleId = 0
                        },
                        new
                        {
                            ClassId = 5,
                            ClassName = "EleventhClass",
                            ScheduleId = 0
                        },
                        new
                        {
                            ClassId = 6,
                            ClassName = "TwelvethClass",
                            ScheduleId = 0
                        });
                });

            modelBuilder.Entity("SchoolDb.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"), 1L, 1);

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradeId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            GradeId = 1,
                            GradeName = "A"
                        },
                        new
                        {
                            GradeId = 2,
                            GradeName = "B"
                        },
                        new
                        {
                            GradeId = 3,
                            GradeName = "C"
                        },
                        new
                        {
                            GradeId = 4,
                            GradeName = "D"
                        },
                        new
                        {
                            GradeId = 5,
                            GradeName = "E"
                        });
                });

            modelBuilder.Entity("SchoolDb.Models.Journal", b =>
                {
                    b.Property<int>("JournalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JournalId"), 1L, 1);

                    b.Property<int>("AttendanceStatusId")
                        .HasColumnType("int");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<int>("PupilId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("date");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("JournalId");

                    b.HasIndex("AttendanceStatusId");

                    b.HasIndex("GradeId");

                    b.HasIndex("PupilId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Journals", (string)null);
                });

            modelBuilder.Entity("SchoolDb.Models.Pupil", b =>
                {
                    b.Property<int>("PupilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PupilId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("PupilId");

                    b.HasIndex("ClassId");

                    b.ToTable("Pupils", (string)null);
                });

            modelBuilder.Entity("SchoolDb.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleId"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("DayOfWeek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId");

                    b.HasIndex("ClassId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Schedules", (string)null);
                });

            modelBuilder.Entity("SchoolDb.Models.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchoolId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SchoolId");

                    b.ToTable("Schools", (string)null);
                });

            modelBuilder.Entity("SchoolDb.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SchoolDb.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId");

                    b.HasIndex("RoleId");

                    b.ToTable("Teachers", (string)null);
                });

            modelBuilder.Entity("SchoolSystemDemo.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "Mentor"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "Leading Teacher"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleName = "Senior Teacher"
                        },
                        new
                        {
                            RoleId = 4,
                            RoleName = "Assistant Teacher"
                        });
                });

            modelBuilder.Entity("SchoolTeacher", b =>
                {
                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("SchoolId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("SchoolTeacher");
                });

            modelBuilder.Entity("TeacherSubject", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherSubject");
                });

            modelBuilder.Entity("ClassTeacher", b =>
                {
                    b.HasOne("SchoolDb.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolDb.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolDb.Models.Journal", b =>
                {
                    b.HasOne("SchoolDb.Models.AttendanceStatus", "AttendanceStatus")
                        .WithMany("Journals")
                        .HasForeignKey("AttendanceStatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SchoolDb.Models.Grade", "Grade")
                        .WithMany("Journals")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SchoolDb.Models.Pupil", "Pupil")
                        .WithMany("Journals")
                        .HasForeignKey("PupilId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SchoolDb.Models.Subject", "Subject")
                        .WithMany("Journals")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SchoolDb.Models.Teacher", "Teacher")
                        .WithMany("Journals")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AttendanceStatus");

                    b.Navigation("Grade");

                    b.Navigation("Pupil");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SchoolDb.Models.Pupil", b =>
                {
                    b.HasOne("SchoolDb.Models.Class", "Class")
                        .WithMany("Pupils")
                        .HasForeignKey("ClassId");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("SchoolDb.Models.Schedule", b =>
                {
                    b.HasOne("SchoolDb.Models.Class", "Class")
                        .WithMany("Schedules")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SchoolDb.Models.Subject", "Subject")
                        .WithMany("Schedules")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SchoolDb.Models.Teacher", "Teacher")
                        .WithMany("Schedules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SchoolDb.Models.Teacher", b =>
                {
                    b.HasOne("SchoolSystemDemo.Models.Role", "Role")
                        .WithMany("Teachers")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SchoolTeacher", b =>
                {
                    b.HasOne("SchoolDb.Models.School", null)
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolDb.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeacherSubject", b =>
                {
                    b.HasOne("SchoolDb.Models.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolDb.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolDb.Models.AttendanceStatus", b =>
                {
                    b.Navigation("Journals");
                });

            modelBuilder.Entity("SchoolDb.Models.Class", b =>
                {
                    b.Navigation("Pupils");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("SchoolDb.Models.Grade", b =>
                {
                    b.Navigation("Journals");
                });

            modelBuilder.Entity("SchoolDb.Models.Pupil", b =>
                {
                    b.Navigation("Journals");
                });

            modelBuilder.Entity("SchoolDb.Models.Subject", b =>
                {
                    b.Navigation("Journals");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("SchoolDb.Models.Teacher", b =>
                {
                    b.Navigation("Journals");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("SchoolSystemDemo.Models.Role", b =>
                {
                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}

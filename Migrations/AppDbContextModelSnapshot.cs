﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PsychoHelp_API.Persistence.Contexts;

namespace PsychoHelp_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("PsychoHelp_API.Appointments.Domain.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patient_id");

                    b.Property<int>("PsychoId")
                        .HasColumnType("int")
                        .HasColumnName("psycho_id");

                    b.Property<string>("PsychoNotes")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("psycho_notes");

                    b.Property<DateTime>("ScheduleDate")
                        .HasColumnType("timestamp")
                        .HasColumnName("schedule_date");

                    b.HasKey("Id")
                        .HasName("p_k_appointments");

                    b.HasIndex("PatientId")
                        .HasDatabaseName("i_x_appointments_patient_id");

                    b.HasIndex("PsychoId")
                        .HasDatabaseName("i_x_appointments_psycho_id");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("PsychoHelp_API.Psychologists.Domain.Model.Psychologist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("about");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("age");

                    b.Property<int>("Cmp")
                        .HasColumnType("int")
                        .HasColumnName("cmp");

                    b.Property<int>("Dni")
                        .HasColumnType("int")
                        .HasColumnName("dni");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Formation")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("formation");

                    b.Property<byte>("Genre")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("genre");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("img");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("name");

                    b.Property<bool>("New")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("new");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<int>("Phone")
                        .HasColumnType("int")
                        .HasColumnName("phone");

                    b.Property<byte>("SessionType")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("session_type");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("specialization");

                    b.HasKey("Id")
                        .HasName("p_k_psychologists");

                    b.ToTable("psychologists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "qwertyuiop",
                            Active = false,
                            Age = "28/04/2001",
                            Cmp = 987456,
                            Dni = 12345678,
                            Email = "usuarios1@hotmail.com",
                            Formation = "UPC",
                            Genre = (byte)1,
                            Img = "sadsdasda",
                            Name = "Juan Garcia",
                            New = false,
                            Password = "123456789",
                            Phone = 123456789,
                            SessionType = (byte)1,
                            Specialization = "autoestima"
                        },
                        new
                        {
                            Id = 2,
                            About = "qwertyuiop",
                            Active = false,
                            Age = "28/04/2001",
                            Cmp = 123456,
                            Dni = 12344569,
                            Email = "usuarios2@hotmail.com",
                            Formation = "UPC",
                            Genre = (byte)2,
                            Img = "sadsdasda",
                            Name = "Ana Flores",
                            New = false,
                            Password = "123456",
                            Phone = 987456123,
                            SessionType = (byte)1,
                            Specialization = "autoestima"
                        });
                });

            modelBuilder.Entity("PsychoHelp_API.Psychologists.Domain.Model.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("time");

                    b.HasKey("Id")
                        .HasName("p_k_schedules");

                    b.ToTable("schedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Time = "8:00"
                        },
                        new
                        {
                            Id = 2,
                            Time = "9:00"
                        },
                        new
                        {
                            Id = 3,
                            Time = "10:00"
                        },
                        new
                        {
                            Id = 4,
                            Time = "11:00"
                        });
                });

            modelBuilder.Entity("PsychoHelp_API.Publications.Domain.Models.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("description");

                    b.Property<int>("PsychologistId")
                        .HasColumnType("int")
                        .HasColumnName("psychologist_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("p_k_publications");

                    b.HasIndex("PsychologistId")
                        .HasDatabaseName("i_x_publications_psychologist_id");

                    b.ToTable("publications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 10, 31, 22, 49, 49, 450, DateTimeKind.Local),
                            Description = "Descripcion de Prueba",
                            PsychologistId = 1,
                            Title = "Prueba 1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 10, 31, 22, 49, 49, 450, DateTimeKind.Local),
                            Description = "Descripcion de Prueba",
                            PsychologistId = 2,
                            Title = "Prueba 2"
                        });
                });

            modelBuilder.Entity("PsychoHelp_API.Publications.Domain.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("PublicationId")
                        .HasColumnType("int")
                        .HasColumnName("publication_id");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("text");

                    b.HasKey("Id")
                        .HasName("p_k_tags");

                    b.HasIndex("PublicationId")
                        .HasDatabaseName("i_x_tags_publication_id");

                    b.ToTable("tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PublicationId = 1,
                            Text = "Tag Prueba 1"
                        },
                        new
                        {
                            Id = 2,
                            PublicationId = 1,
                            Text = "Tag Prueba 2"
                        },
                        new
                        {
                            Id = 3,
                            PublicationId = 2,
                            Text = "Tag Prueba 3"
                        });
                });

            modelBuilder.Entity("PsychoHelp_API.patients.Domain.Models.Logbook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ConsultationReason")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("consultation_reason");

                    b.Property<string>("LogBookName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("log_book_name");

                    b.Property<string>("PublicHistory")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("public_history");

                    b.HasKey("Id")
                        .HasName("p_k_log_book");

                    b.ToTable("log_book");
                });

            modelBuilder.Entity("PsychoHelp_API.patients.Domain.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("gender");

                    b.Property<string>("Img")
                        .HasColumnType("text")
                        .HasColumnName("img");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("last_name");

                    b.Property<int>("LogBookId")
                        .HasColumnType("int")
                        .HasColumnName("log_book_id");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("password");

                    b.Property<long>("Phone")
                        .HasMaxLength(9)
                        .HasColumnType("bigint")
                        .HasColumnName("phone");

                    b.HasKey("Id")
                        .HasName("p_k_patient");

                    b.ToTable("patient");
                });

            modelBuilder.Entity("PsychologistSchedule", b =>
                {
                    b.Property<int>("PsychologistsId")
                        .HasColumnType("int")
                        .HasColumnName("psychologists_id");

                    b.Property<int>("SchedulesId")
                        .HasColumnType("int")
                        .HasColumnName("schedules_id");

                    b.HasKey("PsychologistsId", "SchedulesId")
                        .HasName("p_k_psychologist_schedule");

                    b.HasIndex("SchedulesId")
                        .HasDatabaseName("i_x_psychologist_schedule_schedules_id");

                    b.ToTable("psychologist_schedule");
                });

            modelBuilder.Entity("PsychoHelp_API.Appointments.Domain.Models.Appointment", b =>
                {
                    b.HasOne("PsychoHelp_API.patients.Domain.Models.Patient", "patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("k_appointment_patient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PsychoHelp_API.Psychologists.Domain.Model.Psychologist", "psychologist")
                        .WithMany("Appointments")
                        .HasForeignKey("PsychoId")
                        .HasConstraintName("k_appointment_psycho")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("patient");

                    b.Navigation("psychologist");
                });

            modelBuilder.Entity("PsychoHelp_API.Publications.Domain.Models.Publication", b =>
                {
                    b.HasOne("PsychoHelp_API.Psychologists.Domain.Model.Psychologist", "Psychologist")
                        .WithMany("Publications")
                        .HasForeignKey("PsychologistId")
                        .HasConstraintName("f_k_publications_psychologists_psychologist_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Psychologist");
                });

            modelBuilder.Entity("PsychoHelp_API.Publications.Domain.Models.Tag", b =>
                {
                    b.HasOne("PsychoHelp_API.Publications.Domain.Models.Publication", "Publication")
                        .WithMany("Tags")
                        .HasForeignKey("PublicationId")
                        .HasConstraintName("f_k_tags_publications_publication_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publication");
                });

            modelBuilder.Entity("PsychoHelp_API.patients.Domain.Models.Logbook", b =>
                {
                    b.HasOne("PsychoHelp_API.patients.Domain.Models.Patient", "Patient")
                        .WithOne("Logbook")
                        .HasForeignKey("PsychoHelp_API.patients.Domain.Models.Logbook", "Id")
                        .HasConstraintName("f_k_log_book__patient_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PsychologistSchedule", b =>
                {
                    b.HasOne("PsychoHelp_API.Psychologists.Domain.Model.Psychologist", null)
                        .WithMany()
                        .HasForeignKey("PsychologistsId")
                        .HasConstraintName("f_k_psychologist_schedule_psychologists_psychologists_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PsychoHelp_API.Psychologists.Domain.Model.Schedule", null)
                        .WithMany()
                        .HasForeignKey("SchedulesId")
                        .HasConstraintName("f_k_psychologist_schedule_schedules_schedules_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PsychoHelp_API.Psychologists.Domain.Model.Psychologist", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Publications");
                });

            modelBuilder.Entity("PsychoHelp_API.Publications.Domain.Models.Publication", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("PsychoHelp_API.patients.Domain.Models.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Logbook");
                });
#pragma warning restore 612, 618
        }
    }
}

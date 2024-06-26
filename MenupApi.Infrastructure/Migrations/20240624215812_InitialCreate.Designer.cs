﻿// <auto-generated />
using System;
using MenupApi.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MenupApi.Infrastructure.Migrations
{
    [DbContext(typeof(MenupDbContext))]
    [Migration("20240624215812_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MenupApi.Domain.OpeningHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<TimeSpan>("ClosingTime")
                        .HasColumnType("interval");

                    b.Property<int>("Day")
                        .HasColumnType("integer");

                    b.Property<TimeSpan>("OpeningTime")
                        .HasColumnType("interval");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.ToTable("opening_hours", (string)null);
                });

            modelBuilder.Entity("MenupApi.Domain.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsWhatsappPhone")
                        .HasColumnType("boolean");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("WeeklyScheduleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WeeklyScheduleId");

                    b.ToTable("restaurants", (string)null);
                });

            modelBuilder.Entity("MenupApi.Domain.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("schedules", (string)null);
                });

            modelBuilder.Entity("MenupApi.Domain.OpeningHours", b =>
                {
                    b.HasOne("MenupApi.Domain.Schedule", "Schedule")
                        .WithMany("DailyHours")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("MenupApi.Domain.Restaurant", b =>
                {
                    b.HasOne("MenupApi.Domain.Schedule", "WeeklySchedule")
                        .WithMany()
                        .HasForeignKey("WeeklyScheduleId");

                    b.Navigation("WeeklySchedule");
                });

            modelBuilder.Entity("MenupApi.Domain.Schedule", b =>
                {
                    b.Navigation("DailyHours");
                });
#pragma warning restore 612, 618
        }
    }
}
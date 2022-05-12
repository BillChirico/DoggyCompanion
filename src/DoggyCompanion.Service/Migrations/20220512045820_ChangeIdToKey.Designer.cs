﻿// <auto-generated />
using System;
using DoggyCompanion.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DoggyCompanion.Service.Migrations
{
    [DbContext(typeof(DoggyCompanionContext))]
    [Migration("20220512045820_ChangeIdToKey")]
    partial class ChangeIdToKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DoggyCompanion.Domain.PetEvents.BathroomEvent", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("PetId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("BathroomEvents");
                });

            modelBuilder.Entity("DoggyCompanion.Domain.PetEvents.EatEvent", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("PetId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("EatEvents");
                });

            modelBuilder.Entity("DoggyCompanion.Domain.PetEvents.ExerciseEvent", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("PetId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("ExerciseEvents");
                });

            modelBuilder.Entity("DoggyCompanion.Domain.PetEvents.SleepEvent", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("PetId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("SleepEvents");
                });

            modelBuilder.Entity("DoggyCompanion.Domain.Pets.Pet", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PetType")
                        .HasColumnType("integer");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("DoggyCompanion.Domain.Users.User", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DoggyCompanion.Domain.PetEvents.BathroomEvent", b =>
                {
                    b.HasOne("DoggyCompanion.Domain.Pets.Pet", "Pet")
                        .WithMany("BathroomEvents")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("DoggyCompanion.Domain.PetEvents.EatEvent", b =>
                {
                    b.HasOne("DoggyCompanion.Domain.Pets.Pet", "Pet")
                        .WithMany("EatEvents")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("DoggyCompanion.Domain.PetEvents.ExerciseEvent", b =>
                {
                    b.HasOne("DoggyCompanion.Domain.Pets.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("DoggyCompanion.Domain.PetEvents.SleepEvent", b =>
                {
                    b.HasOne("DoggyCompanion.Domain.Pets.Pet", "Pet")
                        .WithMany("SleepEvents")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("DoggyCompanion.Domain.Pets.Pet", b =>
                {
                    b.HasOne("DoggyCompanion.Domain.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DoggyCompanion.Domain.Pets.Pet", b =>
                {
                    b.Navigation("BathroomEvents");

                    b.Navigation("EatEvents");

                    b.Navigation("SleepEvents");
                });
#pragma warning restore 612, 618
        }
    }
}

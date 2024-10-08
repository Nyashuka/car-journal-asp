﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarJournal.Migrations
{
    [DbContext(typeof(CarJournalDbContext))]
    [Migration("20240928155646_AddServiceCategoryTable")]
    partial class AddServiceCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CarJournal.Domain.BodyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.ToTable("BodyTypes", (string)null);
                });

            modelBuilder.Entity("CarJournal.Domain.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BodyTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("EngineId")
                        .HasColumnType("integer");

                    b.Property<int>("FuelTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("GearboxId")
                        .HasColumnType("integer");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Series")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("VendorId")
                        .HasColumnType("integer");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BodyTypeId");

                    b.HasIndex("EngineId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("GearboxId");

                    b.HasIndex("Model")
                        .IsUnique();

                    b.HasIndex("VendorId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarJournal.Domain.Engine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<float>("EngineSize")
                        .HasColumnType("real");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.ToTable("Engines", (string)null);
                });

            modelBuilder.Entity("CarJournal.Domain.FuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.ToTable("FuelTypes", (string)null);
                });

            modelBuilder.Entity("CarJournal.Domain.Gearbox", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.ToTable("Gearboxes", (string)null);
                });

            modelBuilder.Entity("CarJournal.Domain.MileageRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAutomatic")
                        .HasColumnType("boolean");

                    b.Property<int>("Mileage")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserCarId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserCarId");

                    b.ToTable("MileageRecords");
                });

            modelBuilder.Entity("CarJournal.Domain.ServiceCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ServiceCategories");
                });

            modelBuilder.Entity("CarJournal.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Email = "admin",
                            PasswordHash = new byte[] { 115, 72, 158, 189, 8, 183, 122, 205, 47, 72, 62, 189, 61, 224, 182, 17, 79, 164, 64, 66, 155, 98, 144, 32, 13, 191, 18, 190, 235, 53, 183, 142, 133, 255, 134, 236, 236, 36, 102, 202, 157, 119, 75, 103, 17, 210, 59, 123, 39, 68, 209, 78, 91, 6, 10, 105, 236, 88, 223, 214, 178, 34, 42, 143 },
                            PasswordSalt = new byte[] { 13, 171, 121, 162, 205, 125, 242, 56, 48, 69, 212, 31, 53, 198, 191, 44, 8, 54, 164, 243, 237, 255, 147, 103, 150, 33, 195, 237, 153, 110, 136, 176, 50, 53, 219, 164, 126, 82, 65, 223, 174, 122, 85, 165, 217, 148, 82, 105, 137, 59, 150, 174, 5, 128, 239, 141, 137, 77, 126, 2, 217, 180, 133, 237, 34, 250, 57, 184, 42, 205, 10, 235, 195, 55, 21, 89, 13, 103, 63, 99, 170, 151, 54, 219, 160, 42, 50, 78, 241, 42, 34, 72, 254, 161, 95, 94, 0, 91, 166, 220, 17, 162, 160, 106, 229, 96, 205, 246, 72, 56, 138, 187, 46, 221, 64, 218, 126, 224, 139, 44, 162, 187, 186, 185, 36, 198, 32, 142 },
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("CarJournal.Domain.UserCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CarId")
                        .HasColumnType("integer");

                    b.Property<int>("CurrentMileage")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateOfAdd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("StartMileage")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCars");
                });

            modelBuilder.Entity("CarJournal.Domain.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Vendors", (string)null);
                });

            modelBuilder.Entity("Role", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "user"
                        },
                        new
                        {
                            Id = 2,
                            Name = "admin"
                        });
                });

            modelBuilder.Entity("CarJournal.Domain.Car", b =>
                {
                    b.HasOne("CarJournal.Domain.BodyType", "BodyType")
                        .WithMany()
                        .HasForeignKey("BodyTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CarJournal.Domain.Engine", "Engine")
                        .WithMany()
                        .HasForeignKey("EngineId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CarJournal.Domain.FuelType", "FuelType")
                        .WithMany()
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CarJournal.Domain.Gearbox", "Gearbox")
                        .WithMany()
                        .HasForeignKey("GearboxId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CarJournal.Domain.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyType");

                    b.Navigation("Engine");

                    b.Navigation("FuelType");

                    b.Navigation("Gearbox");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("CarJournal.Domain.MileageRecord", b =>
                {
                    b.HasOne("CarJournal.Domain.UserCar", "UserCar")
                        .WithMany()
                        .HasForeignKey("UserCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserCar");
                });

            modelBuilder.Entity("CarJournal.Domain.User", b =>
                {
                    b.HasOne("Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CarJournal.Domain.UserCar", b =>
                {
                    b.HasOne("CarJournal.Domain.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("CarJournal.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}

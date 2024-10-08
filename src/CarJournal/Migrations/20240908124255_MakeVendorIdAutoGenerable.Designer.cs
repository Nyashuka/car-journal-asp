﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarJournal.Migrations
{
    [DbContext(typeof(CarJournalDbContext))]
    [Migration("20240908124255_MakeVendorIdAutoGenerable")]
    partial class MakeVendorIdAutoGenerable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

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
                            PasswordHash = new byte[] { 111, 79, 158, 218, 32, 200, 57, 7, 243, 37, 123, 211, 241, 171, 70, 124, 129, 76, 97, 73, 137, 92, 123, 32, 201, 121, 125, 85, 135, 124, 9, 164, 156, 38, 192, 58, 195, 143, 213, 24, 242, 0, 224, 167, 152, 176, 127, 83, 210, 44, 91, 141, 204, 39, 103, 104, 36, 250, 21, 145, 228, 247, 91, 201 },
                            PasswordSalt = new byte[] { 11, 82, 28, 26, 36, 93, 245, 180, 250, 126, 201, 150, 160, 7, 124, 173, 163, 103, 224, 49, 110, 172, 218, 170, 110, 111, 237, 223, 45, 94, 102, 119, 120, 252, 8, 68, 43, 66, 0, 255, 169, 223, 247, 217, 7, 230, 254, 44, 241, 248, 193, 22, 17, 239, 216, 74, 172, 26, 185, 155, 38, 134, 93, 133, 23, 208, 109, 238, 102, 140, 240, 187, 4, 98, 226, 42, 167, 143, 40, 137, 149, 44, 113, 203, 194, 83, 242, 3, 48, 32, 85, 69, 12, 183, 61, 145, 69, 1, 53, 242, 125, 212, 2, 121, 237, 174, 77, 91, 125, 120, 254, 150, 172, 69, 223, 240, 69, 49, 203, 225, 146, 228, 198, 215, 215, 233, 188, 78 },
                            RoleId = 2
                        });
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

            modelBuilder.Entity("CarJournal.Domain.User", b =>
                {
                    b.HasOne("Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}

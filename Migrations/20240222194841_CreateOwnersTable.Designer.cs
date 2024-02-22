﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pet_hotel.Models;

#nullable disable

namespace pet_hotel.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240222194841_CreateOwnersTable")]
    partial class CreateOwnersTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pet_hotel.Pet", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("PetOwnerId")
                        .HasColumnType("integer");

                    b.Property<bool>("checkedIn")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("petBreedType")
                        .HasColumnType("integer");

                    b.Property<int>("petColorType")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("PetOwnerId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("pet_hotel.PetOwner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("pet_hotel.Pet", b =>
                {
                    b.HasOne("pet_hotel.PetOwner", "ownedBy")
                        .WithMany("Pets")
                        .HasForeignKey("PetOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ownedBy");
                });

            modelBuilder.Entity("pet_hotel.PetOwner", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}

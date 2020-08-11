﻿// <auto-generated />
using System;
using Chefs_N_Dishes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Chefs_N_Dishes.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200422230836_ChefsNDishesFourthMigration")]
    partial class ChefsNDishesFourthMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Chefs_N_Dishes.Models.Chefs", b =>
                {
                    b.Property<int>("Chef_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Chef_Age");

                    b.Property<string>("Chef_FirstName")
                        .IsRequired();

                    b.Property<string>("Chef_LastName")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Chef_ID");

                    b.ToTable("chefs");
                });

            modelBuilder.Entity("Chefs_N_Dishes.Models.Dishes", b =>
                {
                    b.Property<int>("Food_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calories");

                    b.Property<int>("Chef_ID");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Food_Name")
                        .IsRequired();

                    b.Property<int>("Tastiness");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Food_ID");

                    b.HasIndex("Chef_ID");

                    b.ToTable("dishes");
                });

            modelBuilder.Entity("Chefs_N_Dishes.Models.Dishes", b =>
                {
                    b.HasOne("Chefs_N_Dishes.Models.Chefs", "Creator")
                        .WithMany("CreatedDishes")
                        .HasForeignKey("Chef_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

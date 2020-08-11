﻿// <auto-generated />
using System;
using BankAccount.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankAccount.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200421173217_BankAccountFifthMigration")]
    partial class BankAccountFifthMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BankAccount.Models.Register", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("RegisterEmail")
                        .IsRequired();

                    b.Property<string>("RegisterPassword")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BankAccount.Models.Transaction", b =>
                {
                    b.Property<int>("transaction_id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Users_user_id");

                    b.Property<decimal>("amount");

                    b.Property<DateTime>("timestamp");

                    b.Property<string>("type");

                    b.HasKey("transaction_id");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using BookLending.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookLending.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20221207104355_BookCreate")]
    partial class BookCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookLending.Model.Book", b =>
                {
                    b.Property<int>("B_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("B_ID"), 1L, 1);

                    b.Property<string>("BookAuthor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageNumbers")
                        .HasColumnType("int");

                    b.HasKey("B_ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookLending.Model.Person", b =>
                {
                    b.Property<int>("P_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("P_ID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("P_ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("BookLending.Model.Transaction", b =>
                {
                    b.Property<int>("T_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("T_ID"), 1L, 1);

                    b.Property<int>("B_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("BarrowingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LendingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("P_ID")
                        .HasColumnType("int");

                    b.HasKey("T_ID");

                    b.HasIndex("B_ID");

                    b.HasIndex("P_ID");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("BookLending.Model.Transaction", b =>
                {
                    b.HasOne("BookLending.Model.Book", "Book")
                        .WithMany()
                        .HasForeignKey("B_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookLending.Model.Person", "Person")
                        .WithMany()
                        .HasForeignKey("P_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}

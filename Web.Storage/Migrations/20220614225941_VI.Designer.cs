﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.Storage.Data;

#nullable disable

namespace Web.Storage.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220614225941_VI")]
    partial class VI
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Web.Storage.Entitiess.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Web.Storage.Entitiess.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Web.Storage.Entitiess.Commentary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("newsId")
                        .HasColumnType("int");

                    b.Property<int?>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("newsId");

                    b.HasIndex("userId");

                    b.ToTable("Commentaries");
                });

            modelBuilder.Entity("Web.Storage.Entitiess.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Web.Storage.Entitiess.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("categoryId")
                        .HasColumnType("int");

                    b.Property<int?>("countryId")
                        .HasColumnType("int");

                    b.Property<int?>("publisherId")
                        .HasColumnType("int");

                    b.Property<int?>("sourceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("categoryId");

                    b.HasIndex("countryId");

                    b.HasIndex("publisherId");

                    b.HasIndex("sourceId");

                    b.ToTable("NewsNamespace");
                });

            modelBuilder.Entity("Web.Storage.Entitiess.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Web.Storage.Entitiess.PublisherCountry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("countryId")
                        .HasColumnType("int");

                    b.Property<int?>("publisherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("countryId");

                    b.HasIndex("publisherId");

                    b.ToTable("PublisherCountries");
                });

            modelBuilder.Entity("Web.Storage.Entitiess.Source", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("Web.Storage.Entitiess.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("countryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("countryId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Web.Storage.Entitiess.Commentary", b =>
                {
                    b.HasOne("Web.Storage.Entitiess.News", "News")
                        .WithMany()
                        .HasForeignKey("newsId");

                    b.HasOne("Web.Storage.Entitiess.User", "User")
                        .WithMany()
                        .HasForeignKey("userId");

                    b.Navigation("News");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Web.Storage.Entitiess.News", b =>
                {
                    b.HasOne("Web.Storage.Entitiess.Category", "Category")
                        .WithMany()
                        .HasForeignKey("categoryId");

                    b.HasOne("Web.Storage.Entitiess.Country", "Country")
                        .WithMany()
                        .HasForeignKey("countryId");

                    b.HasOne("Web.Storage.Entitiess.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("publisherId");

                    b.HasOne("Web.Storage.Entitiess.Source", "Source")
                        .WithMany()
                        .HasForeignKey("sourceId");

                    b.Navigation("Category");

                    b.Navigation("Country");

                    b.Navigation("Publisher");

                    b.Navigation("Source");
                });

            modelBuilder.Entity("Web.Storage.Entitiess.PublisherCountry", b =>
                {
                    b.HasOne("Web.Storage.Entitiess.Country", "Country")
                        .WithMany()
                        .HasForeignKey("countryId");

                    b.HasOne("Web.Storage.Entitiess.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("publisherId");

                    b.Navigation("Country");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Web.Storage.Entitiess.User", b =>
                {
                    b.HasOne("Web.Storage.Entitiess.Country", "Country")
                        .WithMany()
                        .HasForeignKey("countryId");

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}

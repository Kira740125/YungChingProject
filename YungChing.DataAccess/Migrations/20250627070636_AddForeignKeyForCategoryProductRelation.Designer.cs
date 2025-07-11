﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YungChing.DataAccess.Data;

#nullable disable

namespace YungChing.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250627070636_AddForeignKeyForCategoryProductRelation")]
    partial class AddForeignKeyForCategoryProductRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.6");

            modelBuilder.Entity("YungChing.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Large"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Small"
                        });
                });

            modelBuilder.Entity("YungChing.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St, Springfield, USA",
                            CategoryId = 1,
                            Description = "Foreign House",
                            Price = 90000.0,
                            Title = "A House"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Elm St, HsinChu, Taiwan",
                            CategoryId = 2,
                            Description = "Local House",
                            Price = 50000.0,
                            Title = "B House"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Oak St, Taipei, Taiwan",
                            CategoryId = 3,
                            Description = "Local House",
                            Price = 40000.0,
                            Title = "C House"
                        },
                        new
                        {
                            Id = 4,
                            Address = "101 Pine St, Taichung, Taiwan",
                            CategoryId = 1,
                            Description = "Local House",
                            Price = 30000.0,
                            Title = "B House"
                        });
                });

            modelBuilder.Entity("YungChing.Models.Product", b =>
                {
                    b.HasOne("YungChing.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RockShop.Infrastructure.Data;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221212031340_OrderUserPKChanged")]
    partial class OrderUserPKChanged
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4590bdbb-d05b-4f91-b369-679c0280b56c",
                            Email = "user@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "user@mail.com",
                            NormalizedUserName = "user@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEORaettYr3tDEO/KKU9+f00PwY5QTNswaJfBL+sSY5Ckkua0Z2lYOVpaGwummNddkg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ed50bba3-520b-422c-902a-38b3cd17d914",
                            TwoFactorEnabled = false,
                            UserName = "user@mail.com"
                        },
                        new
                        {
                            Id = "f2423455-638c-4558-b7eb-510312d02ef1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c607c12a-88af-4160-a2ad-2820d9182b97",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@mail.com",
                            NormalizedUserName = "admin@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAENQxk/dBsA3t5tux2u52N8pnc/YpLxh8x1gzwbBQ4TKZn/ekQHTTYRdFc3z9YOmNLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "01155125-1500-4f3e-992a-7bdcd2464b56",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        });
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.CartItem", b =>
                {
                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("AccountId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Guitar"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ukulele"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Harmonica"
                        });
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("StaffId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.OrderUserProducts", b =>
                {
                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("AccountId", "ProductId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderUserProducts");
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adapters")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Body")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Bridge")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("Frets")
                        .HasColumnType("int");

                    b.Property<int?>("Holes")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Neck")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("money");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("Tune")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("StaffId");

                    b.HasIndex("TypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adapters = "Humbucker",
                            Body = "Poplar",
                            Bridge = "T102 Tremolo",
                            CategoryId = 1,
                            Description = "Amazing guitar for beginner and intermediate players!",
                            Frets = 24,
                            ImageUrl = "https://rockshock.eu/uploads/2021/10/01/1633091545_8612_i.webp",
                            InStock = true,
                            IsActive = true,
                            Name = "Ibanez GRG170DX BKN",
                            Neck = "Maple",
                            Price = 528.00m,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 2,
                            Adapters = "EMG® 85",
                            Body = "Mahogany wing",
                            Bridge = "T102 Tremolo",
                            CategoryId = 1,
                            Description = "Amazing guitar for advanced players!",
                            Frets = 24,
                            ImageUrl = "https://rockshock.eu/uploads/2021/10/01/1633091523_6553_i.webp",
                            InStock = true,
                            IsActive = true,
                            Name = "Ibanez RGT6EX-IPT",
                            Neck = "Wizard II Maple/Walnut neck-thru",
                            Price = 1721.00m,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Adapters = "None",
                            Body = "Grand Dreadnought body",
                            Bridge = "Ovangkol Scalloped bridge",
                            CategoryId = 1,
                            Description = "Clear sound and amazing feeling!",
                            Frets = 20,
                            ImageUrl = "https://rockshock.eu/uploads/2022/04/12/1649751909_0387_i.webp",
                            InStock = true,
                            IsActive = true,
                            Name = "Ibanez AAD100 OPN",
                            Neck = "Low Oval Grip with Rounded Fretboard EdgeThermo Aged™ Nyatoh neck",
                            Price = 548.00m,
                            TypeId = 1
                        });
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = "f2423455-638c-4558-b7eb-510312d02ef1",
                            PhoneNumber = "+35988888"
                        });
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Acoustic"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Electric"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Electroacoustic"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RockShop.Infrastructure.Data.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RockShop.Infrastructure.Data.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RockShop.Infrastructure.Data.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RockShop.Infrastructure.Data.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.CartItem", b =>
                {
                    b.HasOne("RockShop.Infrastructure.Data.AppUser", "AccountUser")
                        .WithMany("UserProducts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RockShop.Infrastructure.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountUser");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.Order", b =>
                {
                    b.HasOne("RockShop.Infrastructure.Data.AppUser", "Acc")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RockShop.Infrastructure.Data.Staff", null)
                        .WithMany("Orders")
                        .HasForeignKey("StaffId");

                    b.Navigation("Acc");
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.OrderUserProducts", b =>
                {
                    b.HasOne("RockShop.Infrastructure.Data.AppUser", "AccountUser")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RockShop.Infrastructure.Data.Order", null)
                        .WithMany("OrderUsersProducts")
                        .HasForeignKey("OrderId");

                    b.HasOne("RockShop.Infrastructure.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountUser");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.Product", b =>
                {
                    b.HasOne("RockShop.Infrastructure.Data.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RockShop.Infrastructure.Data.Staff", null)
                        .WithMany("Products")
                        .HasForeignKey("StaffId");

                    b.HasOne("RockShop.Infrastructure.Data.Type", "Type")
                        .WithMany("Products")
                        .HasForeignKey("TypeId");

                    b.Navigation("Category");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.Staff", b =>
                {
                    b.HasOne("RockShop.Infrastructure.Data.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.AppUser", b =>
                {
                    b.Navigation("UserProducts");
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.Order", b =>
                {
                    b.Navigation("OrderUsersProducts");
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.Staff", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("RockShop.Infrastructure.Data.Type", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

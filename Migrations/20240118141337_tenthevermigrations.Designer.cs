﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asp_net_core_web_app_authentication_authorisation.Services;

#nullable disable

namespace asp_net_core_web_app_authentication_authorisation.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240118141337_tenthevermigrations")]
    partial class tenthevermigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.Hotel", b =>
                {
                    b.Property<Guid>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailableSpaces")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            HotelId = new Guid("2e08985a-612a-4b02-ae46-089f89fdbbe3"),
                            AvailableSpaces = 20,
                            Cost = 375m,
                            Name = "HiltonLondonHotel",
                            RoomType = "single"
                        },
                        new
                        {
                            HotelId = new Guid("db585420-0221-43be-bae4-134124ef5fa2"),
                            AvailableSpaces = 20,
                            Cost = 775m,
                            Name = "HiltonLondonHotel",
                            RoomType = "double"
                        },
                        new
                        {
                            HotelId = new Guid("28073bf4-ba1f-4f18-8937-09b0c51a9a39"),
                            AvailableSpaces = 20,
                            Cost = 950m,
                            Name = "HiltonLondonHotel",
                            RoomType = "family suite"
                        },
                        new
                        {
                            HotelId = new Guid("3229d58b-f241-4c94-bed2-2b06291f404a"),
                            AvailableSpaces = 20,
                            Cost = 300m,
                            Name = "LondonMarriotHotel",
                            RoomType = "single"
                        },
                        new
                        {
                            HotelId = new Guid("83fb3898-8f68-4665-9948-5fb0c116476c"),
                            AvailableSpaces = 20,
                            Cost = 300m,
                            Name = "LondonMarriotHotel",
                            RoomType = "Double"
                        },
                        new
                        {
                            HotelId = new Guid("3ecf8287-66bc-454f-bd54-fca0d6b1da9f"),
                            AvailableSpaces = 20,
                            Cost = 300m,
                            Name = "LondonMarriotHotel",
                            RoomType = "family suite"
                        },
                        new
                        {
                            HotelId = new Guid("d14d1836-c819-4662-a9f4-4fd51228ebce"),
                            AvailableSpaces = 20,
                            Cost = 300m,
                            Name = "LondonMarriotHotel",
                            RoomType = "single"
                        },
                        new
                        {
                            HotelId = new Guid("50b60cfc-f491-4c5b-947c-4b869530208f"),
                            AvailableSpaces = 20,
                            Cost = 300m,
                            Name = "LondonMarriotHotel",
                            RoomType = "double"
                        },
                        new
                        {
                            HotelId = new Guid("c8ec46a3-901f-4882-8ffb-bd934fa67ec0"),
                            AvailableSpaces = 20,
                            Cost = 300m,
                            Name = "LondonMarriotHotel",
                            RoomType = "family suite"
                        });
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.HotelAvailability", b =>
                {
                    b.Property<Guid>("HotelAvailabilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AvailableFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AvailableTo")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HotelAvailabilityId");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelAvailabilities");

                    b.HasData(
                        new
                        {
                            HotelAvailabilityId = new Guid("699c4b82-b7bf-4702-85e5-9cc2dce4ab22"),
                            AvailableFrom = new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AvailableTo = new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelId = new Guid("2e08985a-612a-4b02-ae46-089f89fdbbe3")
                        });
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.HotelBooking", b =>
                {
                    b.Property<Guid>("HotelBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("HotelBookingId");

                    b.HasIndex("HotelId");

                    b.HasIndex("UserId");

                    b.ToTable("HotelBookings");
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.HotelDiscount", b =>
                {
                    b.Property<Guid>("HotelDiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("HotelDiscountPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelDiscountId");

                    b.ToTable("HotelDiscounts");
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.PackageBooking", b =>
                {
                    b.Property<Guid>("PackageBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TourEndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TourStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PackageBookingId");

                    b.HasIndex("HotelId");

                    b.HasIndex("TourId");

                    b.HasIndex("UserId");

                    b.ToTable("PackageBookings");
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.Tour", b =>
                {
                    b.Property<Guid>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailableSpaces")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DurationInDays")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TourId");

                    b.ToTable("Tours");

                    b.HasData(
                        new
                        {
                            TourId = new Guid("797eaa85-82a1-4d5b-af1a-4f7a7c33f06d"),
                            AvailableSpaces = 20,
                            Cost = 600m,
                            DurationInDays = 7,
                            Name = "Real Britain"
                        },
                        new
                        {
                            TourId = new Guid("c27955c6-55e4-41d7-b78e-7a6370485322"),
                            AvailableSpaces = 20,
                            Cost = 600m,
                            DurationInDays = 7,
                            Name = "Britain and Ireland Explorer"
                        });
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.TourAvailability", b =>
                {
                    b.Property<Guid>("TourAvailabilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AvailableFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AvailableTo")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TourId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TourAvailabilityId");

                    b.HasIndex("TourId");

                    b.ToTable("TourAvailabilities");
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.TourBooking", b =>
                {
                    b.Property<Guid>("TourBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TourEndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TourStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TourBookingId");

                    b.HasIndex("TourId");

                    b.HasIndex("UserId");

                    b.ToTable("TourBookings");
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
                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.ApplicationUser", null)
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

                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.HotelAvailability", b =>
                {
                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.HotelBooking", b =>
                {
                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.PackageBooking", b =>
                {
                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.Tour", "Tour")
                        .WithMany()
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Hotel");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.TourAvailability", b =>
                {
                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.Tour", "Tour")
                        .WithMany()
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("asp_net_core_web_app_authentication_authorisation.Models.TourBooking", b =>
                {
                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.Tour", "Tour")
                        .WithMany()
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asp_net_core_web_app_authentication_authorisation.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Tour");
                });
#pragma warning restore 612, 618
        }
    }
}

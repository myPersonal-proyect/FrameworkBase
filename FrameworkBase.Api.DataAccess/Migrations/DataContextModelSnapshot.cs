﻿// <auto-generated />
using System;
using FrameworkBase.Api.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FrameworkBase.Api.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FrameworkBase.Api.DataAccess.Contracts.Entities.AdminEntity", b =>
                {
                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("FrameworkBase.Api.DataAccess.Contracts.Entities.BookingEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateBooking")
                        .HasColumnType("datetime2");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<bool>("RentWorkSpace")
                        .HasColumnType("bit");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("FrameworkBase.Api.DataAccess.Contracts.Entities.Office2RoomsEntity", b =>
                {
                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("OfficeId", "RoomId");

                    b.HasIndex("RoomId");

                    b.ToTable("Office2Room");
                });

            modelBuilder.Entity("FrameworkBase.Api.DataAccess.Contracts.Entities.OfficeEntity", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasIndividualWorkSpace")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumerWorkSpace")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceWorkSpaceDaily")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceWorkSpaceMonthly")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OfficeId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("FrameworkBase.Api.DataAccess.Contracts.Entities.Room2ServiceEntity", b =>
                {
                    b.Property<int>("IdRoom")
                        .HasColumnType("int");

                    b.Property<int>("IdService")
                        .HasColumnType("int");

                    b.HasKey("IdRoom", "IdService");

                    b.HasIndex("IdService");

                    b.ToTable("Room2Services");
                });

            modelBuilder.Entity("FrameworkBase.Api.DataAccess.Contracts.Entities.RoomEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("FrameworkBase.Api.DataAccess.Contracts.Entities.ServiceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("FrameworkBase.Api.DataAccess.Contracts.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FrameworkBase.Api.DataAccess.Contracts.Entities.AdminEntity", b =>
                {
                    b.HasOne("FrameworkBase.Api.DataAccess.Contracts.Entities.OfficeEntity", "Office")
                        .WithOne("Admin")
                        .HasForeignKey("FrameworkBase.Api.DataAccess.Contracts.Entities.AdminEntity", "AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FrameworkBase.Api.DataAccess.Contracts.Entities.BookingEntity", b =>
                {
                    b.HasOne("FrameworkBase.Api.DataAccess.Contracts.Entities.OfficeEntity", "Office")
                        .WithOne("Booking")
                        .HasForeignKey("FrameworkBase.Api.DataAccess.Contracts.Entities.BookingEntity", "OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FrameworkBase.Api.DataAccess.Contracts.Entities.UserEntity", "User")
                        .WithOne("Booking")
                        .HasForeignKey("FrameworkBase.Api.DataAccess.Contracts.Entities.BookingEntity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FrameworkBase.Api.DataAccess.Contracts.Entities.Office2RoomsEntity", b =>
                {
                    b.HasOne("FrameworkBase.Api.DataAccess.Contracts.Entities.OfficeEntity", "Office")
                        .WithMany("Office2Rooms")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FrameworkBase.Api.DataAccess.Contracts.Entities.RoomEntity", "Room")
                        .WithMany("Office2Rooms")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FrameworkBase.Api.DataAccess.Contracts.Entities.Room2ServiceEntity", b =>
                {
                    b.HasOne("FrameworkBase.Api.DataAccess.Contracts.Entities.RoomEntity", "Room")
                        .WithMany("Room2ServiceEntity")
                        .HasForeignKey("IdRoom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FrameworkBase.Api.DataAccess.Contracts.Entities.ServiceEntity", "Service")
                        .WithMany("Room2ServiceEntity")
                        .HasForeignKey("IdService")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

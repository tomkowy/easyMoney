﻿// <auto-generated />
using System;
using EasyMoney.Modules.FakeNotifications.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyMoney.Modules.FakeNotifications.Infrastructure.Migrations
{
    [DbContext(typeof(NotificationsContext))]
    [Migration("20200516075411_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Notifications")
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyMoney.Modules.FakeNotifications.Domain.Emails.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Addresses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Emails");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bcd0f82f-de11-4d0e-9127-968ac7374fd8"),
                            Addresses = "email1@com.pl;email2@com.pl;email3@com.pl",
                            Body = "lorem ipsum, lorem ipsum",
                            Subject = "Perfect subject!"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaApp.Models;

namespace PizzaAPI.Migrations
{
    [DbContext(typeof(PizzaAppContext))]
    partial class PizzaAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaEntities.Customer", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<long>("creditCardNumber");

                    b.Property<int>("cvc");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<DateTime>("expDate");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(18);

                    b.Property<long>("phoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PizzaEntities.Order", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("CustomerId");

                    b.Property<string>("address");

                    b.Property<DateTime>("date");

                    b.Property<bool>("delivery");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("status")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaEntities.Pizza", b =>
                {
                    b.Property<int>("id");

                    b.Property<int>("OrderId");

                    b.Property<string>("crust")
                        .IsRequired();

                    b.Property<string>("sauce")
                        .IsRequired();

                    b.Property<string>("size")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Pizza");
                });

            modelBuilder.Entity("PizzaEntities.PizzaTopping", b =>
                {
                    b.Property<int>("id");

                    b.Property<int>("pizzaId");

                    b.Property<int>("toppingId");

                    b.HasKey("id");

                    b.ToTable("PizzaToppings");
                });

            modelBuilder.Entity("PizzaEntities.Topping", b =>
                {
                    b.Property<int>("id");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Toppings");
                });
#pragma warning restore 612, 618
        }
    }
}
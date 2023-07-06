﻿// <auto-generated />
using System;
using CoffeeShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoffeeShop.Migrations
{
    [DbContext(typeof(CoffeeShopContext))]
    [Migration("20230706211339_createDb")]
    partial class createDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CoffeeShop.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_customers");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("CoffeeShop.Model.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer")
                        .HasColumnName("order_id");

                    b.Property<int>("PriceInCents")
                        .HasColumnType("integer")
                        .HasColumnName("price_in_cents");

                    b.HasKey("Id")
                        .HasName("pk_items");

                    b.HasIndex("OrderId")
                        .HasDatabaseName("ix_items_order_id");

                    b.ToTable("items", (string)null);
                });

            modelBuilder.Entity("CoffeeShop.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.HasKey("Id")
                        .HasName("pk_orders");

                    b.HasIndex("CustomerId")
                        .HasDatabaseName("ix_orders_customer_id");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("CoffeeShop.Model.Item", b =>
                {
                    b.HasOne("CoffeeShop.Model.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("fk_items_orders_order_id");
                });

            modelBuilder.Entity("CoffeeShop.Model.Order", b =>
                {
                    b.HasOne("CoffeeShop.Model.Customer", null)
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("fk_orders_customers_customer_id");
                });

            modelBuilder.Entity("CoffeeShop.Model.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CoffeeShop.Model.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
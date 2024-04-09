﻿// <auto-generated />
using System;
using IntexII_Project_4_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IntexII_Project_4_2.Migrations
{
    [DbContext(typeof(IntexProjectDbContext))]
    [Migration("20240409155454_initial2")]
    partial class initial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("IntexII_Project_4_2.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("customer_ID");

                    b.Property<double?>("Age")
                        .HasColumnType("REAL")
                        .HasColumnName("age");

                    b.Property<string>("BirthDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("birth_date");

                    b.Property<string>("CountryOfResidence")
                        .HasColumnType("TEXT")
                        .HasColumnName("country_of_residence");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("last_name");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("IntexII_Project_4_2.Models.LineItem", b =>
                {
                    b.Property<int>("TransactionId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("transaction_ID");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("product_ID");

                    b.Property<int?>("Qty")
                        .HasColumnType("INTEGER")
                        .HasColumnName("qty");

                    b.Property<int?>("Rating")
                        .HasColumnType("INTEGER")
                        .HasColumnName("rating");

                    b.HasKey("TransactionId", "ProductId");

                    b.ToTable("LineItems");
                });

            modelBuilder.Entity("IntexII_Project_4_2.Models.Order", b =>
                {
                    b.Property<int>("TransactionId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("transaction_ID");

                    b.Property<int?>("Amount")
                        .HasColumnType("INTEGER")
                        .HasColumnName("amount");

                    b.Property<string>("Bank")
                        .HasColumnType("TEXT")
                        .HasColumnName("bank");

                    b.Property<string>("CountryOfTransaction")
                        .HasColumnType("TEXT")
                        .HasColumnName("country_of_transaction");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("customer_ID");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT")
                        .HasColumnName("date");

                    b.Property<string>("DayOfWeek")
                        .HasColumnType("TEXT")
                        .HasColumnName("day_of_week");

                    b.Property<string>("EntryMode")
                        .HasColumnType("TEXT")
                        .HasColumnName("entry_mode");

                    b.Property<int?>("Fraud")
                        .HasColumnType("INTEGER")
                        .HasColumnName("fraud");

                    b.Property<string>("ShippingAddress")
                        .HasColumnType("TEXT")
                        .HasColumnName("shipping_address");

                    b.Property<int?>("Time")
                        .HasColumnType("INTEGER")
                        .HasColumnName("time");

                    b.Property<string>("TypeOfCard")
                        .HasColumnType("TEXT")
                        .HasColumnName("type_of_card");

                    b.Property<string>("TypeOfTransaction")
                        .HasColumnType("TEXT")
                        .HasColumnName("type_of_transaction");

                    b.HasKey("TransactionId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("IntexII_Project_4_2.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("product_ID");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("ImgLink")
                        .HasColumnType("TEXT")
                        .HasColumnName("img_link");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<int?>("NumParts")
                        .HasColumnType("INTEGER")
                        .HasColumnName("num_parts");

                    b.Property<int?>("Price")
                        .HasColumnType("INTEGER")
                        .HasColumnName("price");

                    b.Property<string>("PrimaryColor")
                        .HasColumnType("TEXT")
                        .HasColumnName("primary_color");

                    b.Property<string>("SecondaryColor")
                        .HasColumnType("TEXT")
                        .HasColumnName("secondary_color");

                    b.Property<int?>("Year")
                        .HasColumnType("INTEGER")
                        .HasColumnName("year");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

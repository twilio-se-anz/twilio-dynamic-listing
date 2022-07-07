﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Twilio.Example.Data;

#nullable disable

namespace Twilio.Example.Migrations
{
    [DbContext(typeof(CallTrackingContext))]
    partial class CallTrackingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Twilio.Example.Models.Dealer", b =>
                {
                    b.Property<int>("DealerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LocalRegion")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrivateNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("DealerId");

                    b.ToTable("Dealer");
                });

            modelBuilder.Entity("Twilio.Example.Models.DynamicNumber", b =>
                {
                    b.Property<int>("DynamicNumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DealerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastUsedDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ListingId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("DynamicNumberId");

                    b.HasIndex("DealerId");

                    b.HasIndex("ListingId");

                    b.ToTable("DynamicNumber");
                });

            modelBuilder.Entity("Twilio.Example.Models.Listing", b =>
                {
                    b.Property<int>("ListingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("ListingId");

                    b.ToTable("Listing");
                });

            modelBuilder.Entity("Twilio.Example.Models.DynamicNumber", b =>
                {
                    b.HasOne("Twilio.Example.Models.Dealer", "Dealer")
                        .WithMany()
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Twilio.Example.Models.Listing", "Listing")
                        .WithMany()
                        .HasForeignKey("ListingId");

                    b.Navigation("Dealer");

                    b.Navigation("Listing");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220520151646_ImageFiles")]
    partial class ImageFiles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("EntityLayer.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AboutDetails1")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutDetails2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutImage1")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutImage2")
                        .HasColumnType("TEXT");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Massage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Content", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ContentDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ContentStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContentValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("HeadingId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WriterID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ContentId");

                    b.HasIndex("HeadingId");

                    b.HasIndex("WriterID");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("EntityLayer.Heading", b =>
                {
                    b.Property<int>("HeadingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("HeadingDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("HeadingName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("HeadingStatus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WriterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("HeadingId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WriterId");

                    b.ToTable("Headings");
                });

            modelBuilder.Entity("EntityLayer.ImageFile", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ImageName")
                        .HasMaxLength(100)
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.HasKey("ImageId");

                    b.ToTable("ImageFiles");
                });

            modelBuilder.Entity("EntityLayer.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MessageContent")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecieverMail")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderMail")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("EntityLayer.Writer", b =>
                {
                    b.Property<int>("WriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("WriterAbout")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterMail")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterName")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterPassword")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<bool>("WriterStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WriterSurname")
                        .HasColumnType("TEXT");

                    b.Property<string>("WritterJob")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("WriterId");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("EntityLayer.Content", b =>
                {
                    b.HasOne("EntityLayer.Heading", "Heading")
                        .WithMany("Contents")
                        .HasForeignKey("HeadingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Writer", "Writer")
                        .WithMany("Contents")
                        .HasForeignKey("WriterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Heading");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("EntityLayer.Heading", b =>
                {
                    b.HasOne("EntityLayer.Category", "Category")
                        .WithMany("Headings")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Writer", "Writer")
                        .WithMany("Headings")
                        .HasForeignKey("WriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("EntityLayer.Category", b =>
                {
                    b.Navigation("Headings");
                });

            modelBuilder.Entity("EntityLayer.Heading", b =>
                {
                    b.Navigation("Contents");
                });

            modelBuilder.Entity("EntityLayer.Writer", b =>
                {
                    b.Navigation("Contents");

                    b.Navigation("Headings");
                });
#pragma warning restore 612, 618
        }
    }
}

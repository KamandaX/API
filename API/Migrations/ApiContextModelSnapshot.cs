﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API.Models.Camera", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("FNumber")
                        .HasColumnType("float");

                    b.Property<int>("Megapixels")
                        .HasColumnType("int");

                    b.Property<int>("PhoneID")
                        .HasColumnType("int");

                    b.Property<int>("Side")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PhoneID");

                    b.ToTable("Cameras");
                });

            modelBuilder.Entity("API.Models.Phone", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BatterySize")
                        .HasColumnType("int");

                    b.Property<int>("DisplayResolutionHorizontal")
                        .HasColumnType("int");

                    b.Property<int>("DisplayResolutionVertical")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LaunchDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("ProtectionRating")
                        .HasColumnType("float");

                    b.Property<int>("Ram")
                        .HasColumnType("int");

                    b.Property<float>("ScreenSize")
                        .HasColumnType("float");

                    b.Property<int>("Storage")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("API.Models.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Aspect")
                        .HasColumnType("int");

                    b.Property<string>("QuestionContent")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("API.Models.QuestionOption", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("NextQuestionID")
                        .HasColumnType("int");

                    b.Property<string>("OptionContent")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PictureLink")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<float>("QuestionMultiplier")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("NextQuestionID");

                    b.HasIndex("QuestionID");

                    b.ToTable("QuestionOptions");
                });

            modelBuilder.Entity("API.Models.Score", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("BatteryLifeScore")
                        .HasColumnType("float");

                    b.Property<float>("DurabilityScore")
                        .HasColumnType("float");

                    b.Property<float>("MainCameraScore")
                        .HasColumnType("float");

                    b.Property<int>("PhoneID")
                        .HasColumnType("int");

                    b.Property<float>("PopularityScore")
                        .HasColumnType("float");

                    b.Property<float>("PriceScore")
                        .HasColumnType("float");

                    b.Property<float>("ProcessingPowerScore")
                        .HasColumnType("float");

                    b.Property<float>("ScreenSizeScore")
                        .HasColumnType("float");

                    b.Property<float>("SelfieCameraScore")
                        .HasColumnType("float");

                    b.Property<float>("StorageScore")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("PhoneID")
                        .IsUnique();

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("API.Models.Camera", b =>
                {
                    b.HasOne("API.Models.Phone", "Phone")
                        .WithMany("Cameras")
                        .HasForeignKey("PhoneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.QuestionOption", b =>
                {
                    b.HasOne("API.Models.Question", "NextQuestion")
                        .WithMany("LinkedQuestionOptions")
                        .HasForeignKey("NextQuestionID");

                    b.HasOne("API.Models.Question", "Question")
                        .WithMany("QuestionOptions")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Score", b =>
                {
                    b.HasOne("API.Models.Phone", "Phone")
                        .WithOne("Score")
                        .HasForeignKey("API.Models.Score", "PhoneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

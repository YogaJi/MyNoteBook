﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyNoteBook.Data;

namespace MyNoteBook.Migrations
{
    [DbContext(typeof(MyNoteBookContext))]
    [Migration("20220415204845_add weatherId, moodId, and weatherId")]
    partial class addweatherIdmoodIdandweatherId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyNoteBook.Models.Journal", b =>
                {
                    b.Property<int>("JournalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackgroundColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Mood")
                        .HasColumnType("int");

                    b.Property<int>("MoodId")
                        .HasColumnType("int");

                    b.Property<int?>("Notebook")
                        .HasColumnType("int");

                    b.Property<int>("NotebookId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Weather")
                        .HasColumnType("int");

                    b.Property<int>("WeatherId")
                        .HasColumnType("int");

                    b.HasKey("JournalId");

                    b.HasIndex("Mood");

                    b.HasIndex("Notebook");

                    b.HasIndex("Weather");

                    b.ToTable("Journal");
                });

            modelBuilder.Entity("MyNoteBook.Models.Mood", b =>
                {
                    b.Property<int>("MoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MoodPic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MoodId");

                    b.ToTable("Mood");
                });

            modelBuilder.Entity("MyNoteBook.Models.Notebook", b =>
                {
                    b.Property<int>("NotebookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotebookId");

                    b.ToTable("Notebook");
                });

            modelBuilder.Entity("MyNoteBook.Models.PhotoDiary", b =>
                {
                    b.Property<int>("PhotoDiaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Template")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("secondContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoDiaryId");

                    b.HasIndex("Template");

                    b.ToTable("PhotoDiary");
                });

            modelBuilder.Entity("MyNoteBook.Models.Template", b =>
                {
                    b.Property<int>("TemplateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("TemplateId");

                    b.ToTable("Template");
                });

            modelBuilder.Entity("MyNoteBook.Models.Weather", b =>
                {
                    b.Property<int>("WeatherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WeatherPic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WeatherId");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("MyNoteBook.Models.Journal", b =>
                {
                    b.HasOne("MyNoteBook.Models.Mood", "mood")
                        .WithMany()
                        .HasForeignKey("Mood");

                    b.HasOne("MyNoteBook.Models.Notebook", "notebook")
                        .WithMany()
                        .HasForeignKey("Notebook");

                    b.HasOne("MyNoteBook.Models.Weather", "weather")
                        .WithMany()
                        .HasForeignKey("Weather");
                });

            modelBuilder.Entity("MyNoteBook.Models.PhotoDiary", b =>
                {
                    b.HasOne("MyNoteBook.Models.Template", "template")
                        .WithMany()
                        .HasForeignKey("Template");
                });
#pragma warning restore 612, 618
        }
    }
}

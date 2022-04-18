﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyNoteBook.Data;

namespace MyNoteBook.Migrations
{
    [DbContext(typeof(MyNoteBookContext))]
    partial class MyNoteBookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyNoteBook.Models.BGColor", b =>
                {
                    b.Property<int>("BGId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BGString")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BGId");

                    b.ToTable("BGColor");
                });

            modelBuilder.Entity("MyNoteBook.Models.Journal", b =>
                {
                    b.Property<int>("JournalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BGColorBGId")
                        .HasColumnType("int");

                    b.Property<int>("BGId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MoodId")
                        .HasColumnType("int");

                    b.Property<int>("NotebookId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeatherId")
                        .HasColumnType("int");

                    b.HasKey("JournalId");

                    b.HasIndex("BGColorBGId");

                    b.HasIndex("MoodId");

                    b.HasIndex("NotebookId");

                    b.HasIndex("WeatherId");

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

                    b.Property<int>("TemplateId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("secondContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoDiaryId");

                    b.HasIndex("TemplateId");

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

                    b.Property<string>("WeatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeatherPic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WeatherId");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("MyNoteBook.Models.Journal", b =>
                {
                    b.HasOne("MyNoteBook.Models.BGColor", "BGColor")
                        .WithMany("Journals")
                        .HasForeignKey("BGColorBGId");

                    b.HasOne("MyNoteBook.Models.Mood", "mood")
                        .WithMany("Journals")
                        .HasForeignKey("MoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyNoteBook.Models.Notebook", "notebook")
                        .WithMany("Journals")
                        .HasForeignKey("NotebookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyNoteBook.Models.Weather", "weather")
                        .WithMany("Journals")
                        .HasForeignKey("WeatherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyNoteBook.Models.PhotoDiary", b =>
                {
                    b.HasOne("MyNoteBook.Models.Template", "template")
                        .WithMany()
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

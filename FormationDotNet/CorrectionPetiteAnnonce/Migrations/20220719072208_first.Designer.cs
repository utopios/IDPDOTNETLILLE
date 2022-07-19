﻿// <auto-generated />
using CorrectionPetiteAnnonce.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CorrectionPetiteAnnonce.Migrations
{
    [DbContext(typeof(DataContextService))]
    [Migration("20220719072208_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CorrectionPetiteAnnonce.Models.Annonce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategorieId")
                        .HasColumnType("int")
                        .HasColumnName("categorie_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("Text")
                        .HasColumnName("description");

                    b.Property<decimal>("Prix")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("prix");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("titre");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("annonce");
                });

            modelBuilder.Entity("CorrectionPetiteAnnonce.Models.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("titre");

                    b.HasKey("Id");

                    b.ToTable("categorie");
                });

            modelBuilder.Entity("CorrectionPetiteAnnonce.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnnonceId")
                        .HasColumnType("int")
                        .HasColumnName("annonce_id");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("uri");

                    b.HasKey("Id");

                    b.HasIndex("AnnonceId");

                    b.ToTable("image");
                });

            modelBuilder.Entity("CorrectionPetiteAnnonce.Models.Annonce", b =>
                {
                    b.HasOne("CorrectionPetiteAnnonce.Models.Categorie", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");
                });

            modelBuilder.Entity("CorrectionPetiteAnnonce.Models.Image", b =>
                {
                    b.HasOne("CorrectionPetiteAnnonce.Models.Annonce", "Annonce")
                        .WithMany("Images")
                        .HasForeignKey("AnnonceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Annonce");
                });

            modelBuilder.Entity("CorrectionPetiteAnnonce.Models.Annonce", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}

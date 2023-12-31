﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using wayss.Models;

#nullable disable

namespace wayss.Migrations
{
    [DbContext(typeof(RandevuDBContext))]
    partial class RandevuDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("wayss.Models.Bolum", b =>
                {
                    b.Property<int>("BolumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BolumId"));

                    b.Property<string>("BolumAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("BolumdeBulunanDoktorSayisi")
                        .HasColumnType("integer");

                    b.Property<int?>("KlinikId")
                        .HasColumnType("integer");

                    b.HasKey("BolumId");

                    b.HasIndex("KlinikId");

                    b.ToTable("Bolumler");
                });

            modelBuilder.Entity("wayss.Models.Hastane", b =>
                {
                    b.Property<int>("HastaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("HastaneId"));

                    b.Property<string>("HastaneAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("HastaneId");

                    b.ToTable("Hastaneler");
                });

            modelBuilder.Entity("wayss.Models.Insan", b =>
                {
                    b.Property<int>("InsanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InsanId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("InsanNo")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("InsanId");

                    b.ToTable("Insanlar");
                });

            modelBuilder.Entity("wayss.Models.Klinik", b =>
                {
                    b.Property<int>("KlinikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("KlinikId"));

                    b.Property<int?>("HastaneId")
                        .HasColumnType("integer");

                    b.Property<string>("KlinikAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("KlinikId");

                    b.HasIndex("HastaneId");

                    b.ToTable("Klinikler");
                });

            modelBuilder.Entity("wayss.Models.Randevular", b =>
                {
                    b.Property<int>("RandevuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RandevuId"));

                    b.Property<int>("InsanId")
                        .HasColumnType("integer");

                    b.Property<bool>("Onaylandi")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("RandevuTarihi")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("RandevuId");

                    b.HasIndex("InsanId");

                    b.ToTable("Randevular");
                });

            modelBuilder.Entity("wayss.Models.Bolum", b =>
                {
                    b.HasOne("wayss.Models.Klinik", null)
                        .WithMany("BulunanBolumler")
                        .HasForeignKey("KlinikId");
                });

            modelBuilder.Entity("wayss.Models.Klinik", b =>
                {
                    b.HasOne("wayss.Models.Hastane", null)
                        .WithMany("Klinikler")
                        .HasForeignKey("HastaneId");
                });

            modelBuilder.Entity("wayss.Models.Randevular", b =>
                {
                    b.HasOne("wayss.Models.Insan", "Insan")
                        .WithMany()
                        .HasForeignKey("InsanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insan");
                });

            modelBuilder.Entity("wayss.Models.Hastane", b =>
                {
                    b.Navigation("Klinikler");
                });

            modelBuilder.Entity("wayss.Models.Klinik", b =>
                {
                    b.Navigation("BulunanBolumler");
                });
#pragma warning restore 612, 618
        }
    }
}

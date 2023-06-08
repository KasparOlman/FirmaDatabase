﻿// <auto-generated />
using System;
using FirmaDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirmaDb.Migrations
{
    [DbContext(typeof(FirmaDatabaseContext))]
    partial class FirmaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FirmaDb.Models.Haigusleht", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AlgusKuupäev")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kommentaar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("LõppKuupäev")
                        .HasColumnType("datetime2");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Haigusleht");
                });

            modelBuilder.Entity("FirmaDb.Models.Harukontor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FaksiNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Kommentaar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nimi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelefoniNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Harukontor");
                });

            modelBuilder.Entity("FirmaDb.Models.LaenutatavadAsjad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Kirjeldus")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Kogus")
                        .HasColumnType("int");

                    b.Property<int>("Kommentaar")
                        .HasMaxLength(255)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LaenutatavadAsjad");
                });

            modelBuilder.Entity("FirmaDb.Models.Laenutus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AsjaId")
                        .HasColumnType("int");

                    b.Property<string>("Kommentaar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("LaenutusKp")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TagastamisKp")
                        .HasColumnType("datetime2");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AsjaId");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Laenutus");
                });

            modelBuilder.Entity("FirmaDb.Models.Laps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Isikukood")
                        .HasColumnType("int");

                    b.Property<string>("Kommentaar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nimi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PerekonnaNimi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Sünnipäev")
                        .HasColumnType("datetime2");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Laps");
                });

            modelBuilder.Entity("FirmaDb.Models.LigipääsuLuba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AlgusKp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kommentaar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("LigipääsuTase")
                        .HasColumnType("int");

                    b.Property<DateTime>("LõppKp")
                        .HasColumnType("datetime2");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LigipääsuTase");

                    b.HasIndex("TöötajaId");

                    b.ToTable("LigipääsuLuba");
                });

            modelBuilder.Entity("FirmaDb.Models.LigipääsuTase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AlgusKp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kommentaar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Ligipääsu_Tase")
                        .HasColumnType("int");

                    b.Property<string>("LigipääsuÕigused")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("LõppKp")
                        .HasColumnType("datetime2");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("LigipääsuTase");
                });

            modelBuilder.Entity("FirmaDb.Models.Palved", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("KoostamisKp")
                        .HasColumnType("datetime2");

                    b.Property<string>("PalveTekst")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Palved");
                });

            modelBuilder.Entity("FirmaDb.Models.Puhkus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AlgusKuupäev")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kommentaar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("LõpuKuupäev")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Tasu")
                        .HasColumnType("bit");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Puhkus");
                });

            modelBuilder.Entity("FirmaDb.Models.Tervisekontrollinimekiri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("JärgmiseTervisekontrolliKp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kommentaar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("TervisekontrolliKp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tervisenõuanded")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Tervisekontrollinimekiri");
                });

            modelBuilder.Entity("FirmaDb.Models.Töötaja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AmetiNimetus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("HaiguslehtedeArv")
                        .HasColumnType("int");

                    b.Property<int>("HarukontoriId")
                        .HasColumnType("int");

                    b.Property<int>("Isikukood")
                        .HasColumnType("int");

                    b.Property<string>("Kommentaar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("KontaktTel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nimi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PerekonnaNimi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PuhkuspäevadeArv")
                        .HasColumnType("int");

                    b.Property<DateTime>("Sünnipäev")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Töökoormus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("TöölAlates")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TöölKuni")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HarukontoriId");

                    b.ToTable("Töötaja");
                });

            modelBuilder.Entity("FirmaDb.Models.Vihjed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("KoostamiseKp")
                        .HasColumnType("datetime2");

                    b.Property<int>("TöötajaId")
                        .HasMaxLength(255)
                        .HasColumnType("int");

                    b.Property<string>("VihjeTekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Vihjed");
                });

            modelBuilder.Entity("FirmaDb.Models.Haigusleht", b =>
                {
                    b.HasOne("FirmaDb.Models.Töötaja", "Töötaja")
                        .WithMany()
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("FirmaDb.Models.Laenutus", b =>
                {
                    b.HasOne("FirmaDb.Models.LaenutatavadAsjad", "LaenutatavadAsjad")
                        .WithMany()
                        .HasForeignKey("AsjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirmaDb.Models.Töötaja", "Töötaja")
                        .WithMany()
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LaenutatavadAsjad");

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("FirmaDb.Models.Laps", b =>
                {
                    b.HasOne("FirmaDb.Models.Töötaja", "Töötaja")
                        .WithMany()
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("FirmaDb.Models.LigipääsuLuba", b =>
                {
                    b.HasOne("FirmaDb.Models.LigipääsuTase", "Ligipääsu_Tase")
                        .WithMany()
                        .HasForeignKey("LigipääsuTase")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirmaDb.Models.Töötaja", "Töötaja")
                        .WithMany()
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ligipääsu_Tase");

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("FirmaDb.Models.LigipääsuTase", b =>
                {
                    b.HasOne("FirmaDb.Models.Töötaja", "Töötaja")
                        .WithMany()
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("FirmaDb.Models.Palved", b =>
                {
                    b.HasOne("FirmaDb.Models.Töötaja", "Töötaja")
                        .WithMany()
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("FirmaDb.Models.Puhkus", b =>
                {
                    b.HasOne("FirmaDb.Models.Töötaja", "Töötaja")
                        .WithMany()
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("FirmaDb.Models.Tervisekontrollinimekiri", b =>
                {
                    b.HasOne("FirmaDb.Models.Töötaja", "Töötaja")
                        .WithMany()
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("FirmaDb.Models.Töötaja", b =>
                {
                    b.HasOne("FirmaDb.Models.Harukontor", "Harukontor")
                        .WithMany()
                        .HasForeignKey("HarukontoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Harukontor");
                });

            modelBuilder.Entity("FirmaDb.Models.Vihjed", b =>
                {
                    b.HasOne("FirmaDb.Models.Töötaja", "Töötaja")
                        .WithMany()
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });
#pragma warning restore 612, 618
        }
    }
}

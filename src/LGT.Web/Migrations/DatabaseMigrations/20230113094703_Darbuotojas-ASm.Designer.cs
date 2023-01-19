﻿// <auto-generated />
using System;
using LGT.Internals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    [DbContext(typeof(Database))]
    [Migration("20230113094703_Darbuotojas-ASm")]
    partial class DarbuotojasASm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("LGT.Internals.Models.Incidents.Incidentas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("datetime()");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("InformacinisIstekliusID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PozymisID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reason")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Since")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Until")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("InformacinisIstekliusID");

                    b.HasIndex("PozymisID");

                    b.ToTable("I_Incidentas", (string)null);
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.IncidentoPozymis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("I_IncidentoPozymis", (string)null);
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.InformacinisIsteklius", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("DarbovieteID")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Priklauso");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentID")
                        .HasColumnType("TEXT")
                        .HasColumnName("Parent");

                    b.HasKey("ID");

                    b.HasIndex("DarbovieteID");

                    b.HasIndex("ParentID");

                    b.ToTable("I_InformacinisIsteklius", (string)null);
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.Kreipinys", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AsmuoID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("datetime()");

                    b.Property<string>("DarbovieteID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("DarbuotojasID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IncidentasID")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT")
                        .HasColumnName("Nuoroda");

                    b.Property<DateTime?>("Since")
                        .HasColumnType("TEXT");

                    b.Property<string>("SolutionText")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("UName")
                        .HasColumnType("TEXT")
                        .HasColumnName("Krepinys");

                    b.Property<DateTime?>("Until")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("AsmuoID");

                    b.HasIndex("IncidentasID");

                    b.HasIndex("DarbovieteID", "AsmuoID");

                    b.ToTable("I_Kreipinys", (string)null);
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.Skundas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AsmuoID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("At")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("datetime()");

                    b.Property<int?>("DarbuotojasID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IncidentasID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Markdown")
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<int?>("TypeID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("AsmuoID");

                    b.HasIndex("DarbuotojasID");

                    b.HasIndex("IncidentasID");

                    b.HasIndex("TypeID");

                    b.ToTable("I_Skundas", (string)null);
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.SkundasType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("I_SkundasType", (string)null);
                });

            modelBuilder.Entity("LGT.Internals.Models.Kontaktai.Asmuo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("K_Asmuo", (string)null);
                });

            modelBuilder.Entity("LGT.Internals.Models.Kontaktai.Darboviete", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("K_Darboviete", (string)null);
                });

            modelBuilder.Entity("LGT.Internals.Models.Kontaktai.Darbuotojas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AsmuoID")
                        .IsRequired()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Asmuo");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("datetime()");

                    b.Property<string>("DarbovieteID")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Darboviete");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("Pareigybe");

                    b.Property<DateTime?>("Since")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tel1")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Tel2")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Tel3")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Tel4")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Until")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasAlternateKey("AsmuoID", "DarbovieteID");

                    b.ToTable("K_Darbuotojas", (string)null);
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.AptarnaujantiImone", b =>
                {
                    b.HasBaseType("LGT.Internals.Models.Kontaktai.Darboviete");

                    b.ToTable("I_AptarnaujantiImone", (string)null);
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.Incidentas", b =>
                {
                    b.HasOne("LGT.Internals.Models.Incidents.InformacinisIsteklius", "InformacinisIsteklius")
                        .WithMany()
                        .HasForeignKey("InformacinisIstekliusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LGT.Internals.Models.Incidents.IncidentoPozymis", "Pozymis")
                        .WithMany()
                        .HasForeignKey("PozymisID");

                    b.Navigation("InformacinisIsteklius");

                    b.Navigation("Pozymis");
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.InformacinisIsteklius", b =>
                {
                    b.HasOne("LGT.Internals.Models.Kontaktai.Darboviete", "Darboviete")
                        .WithMany("InformaciniaiIstekliai")
                        .HasForeignKey("DarbovieteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LGT.Internals.Models.Incidents.InformacinisIsteklius", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentID");

                    b.Navigation("Darboviete");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.Kreipinys", b =>
                {
                    b.HasOne("LGT.Internals.Models.Kontaktai.Asmuo", "Asmuo")
                        .WithMany()
                        .HasForeignKey("AsmuoID");

                    b.HasOne("LGT.Internals.Models.Kontaktai.Darboviete", "Darboviete")
                        .WithMany()
                        .HasForeignKey("DarbovieteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LGT.Internals.Models.Incidents.Incidentas", "Incidentas")
                        .WithMany("Kreipiniai")
                        .HasForeignKey("IncidentasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LGT.Internals.Models.Kontaktai.Darbuotojas", "Darbuotojas")
                        .WithMany()
                        .HasForeignKey("DarbovieteID", "AsmuoID")
                        .HasPrincipalKey("DarbovieteID", "AsmuoID");

                    b.Navigation("Asmuo");

                    b.Navigation("Darboviete");

                    b.Navigation("Darbuotojas");

                    b.Navigation("Incidentas");
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.Skundas", b =>
                {
                    b.HasOne("LGT.Internals.Models.Kontaktai.Asmuo", "Asmuo")
                        .WithMany("Skundai")
                        .HasForeignKey("AsmuoID");

                    b.HasOne("LGT.Internals.Models.Kontaktai.Darbuotojas", "Darbuotojas")
                        .WithMany("Skundai")
                        .HasForeignKey("DarbuotojasID");

                    b.HasOne("LGT.Internals.Models.Incidents.Incidentas", "Incidentas")
                        .WithMany("Skundai")
                        .HasForeignKey("IncidentasID");

                    b.HasOne("LGT.Internals.Models.Incidents.SkundasType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID");

                    b.Navigation("Asmuo");

                    b.Navigation("Darbuotojas");

                    b.Navigation("Incidentas");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("LGT.Internals.Models.Kontaktai.Darbuotojas", b =>
                {
                    b.HasOne("LGT.Internals.Models.Kontaktai.Asmuo", "Asmuo")
                        .WithMany("DarbovieteAssignments")
                        .HasForeignKey("AsmuoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LGT.Internals.Models.Kontaktai.Darboviete", "Darboviete")
                        .WithMany("DarbuotojasAssignments")
                        .HasForeignKey("DarbovieteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asmuo");

                    b.Navigation("Darboviete");
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.AptarnaujantiImone", b =>
                {
                    b.HasOne("LGT.Internals.Models.Kontaktai.Darboviete", null)
                        .WithOne()
                        .HasForeignKey("LGT.Internals.Models.Incidents.AptarnaujantiImone", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.Incidentas", b =>
                {
                    b.Navigation("Kreipiniai");

                    b.Navigation("Skundai");
                });

            modelBuilder.Entity("LGT.Internals.Models.Incidents.InformacinisIsteklius", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("LGT.Internals.Models.Kontaktai.Asmuo", b =>
                {
                    b.Navigation("DarbovieteAssignments");

                    b.Navigation("Skundai");
                });

            modelBuilder.Entity("LGT.Internals.Models.Kontaktai.Darboviete", b =>
                {
                    b.Navigation("DarbuotojasAssignments");

                    b.Navigation("InformaciniaiIstekliai");
                });

            modelBuilder.Entity("LGT.Internals.Models.Kontaktai.Darbuotojas", b =>
                {
                    b.Navigation("Skundai");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using LGT.Kontaktai;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LGT.Intranet.Migrations.KontaktaiContextMigrations
{
    [DbContext(typeof(KontaktaiContext))]
    [Migration("20240415070452_Added Darbuotojas.DateOfBirth field")]
    partial class AddedDarbuotojasDateOfBirthfield
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("LGT.Kontaktai.Models.Darboviete", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int?>("OrderWeight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Darbovietes", (string)null);
                });

            modelBuilder.Entity("LGT.Kontaktai.Models.Darbuotojas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("datetime()");

                    b.Property<string>("DarbovieteId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Darboviete");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EtatasId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Kabinetas")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int?>("Lytis")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("Pareigybe");

                    b.Property<Guid?>("PadalinysId")
                        .HasColumnType("TEXT");

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

                    b.HasKey("Id");

                    b.HasIndex("DarbovieteId");

                    b.HasIndex("EtatasId");

                    b.HasIndex("PadalinysId");

                    b.ToTable("Darbuotojai", (string)null);
                });

            modelBuilder.Entity("LGT.Kontaktai.Models.Etatas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DarbovieteId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NameId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PadalinysId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Since")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Until")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DarbovieteId");

                    b.HasIndex("NameId");

                    b.HasIndex("PadalinysId");

                    b.ToTable("Etatai", (string)null);
                });

            modelBuilder.Entity("LGT.Kontaktai.Models.EtatasName", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kilmininkas")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kilmininke")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vardininkas")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vardininke")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("EtatuPavadinimai", (string)null);
                });

            modelBuilder.Entity("LGT.Kontaktai.Models.Padalinys", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DarbovieteId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("TEXT");

                    b.Property<string>("NameShort")
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<int?>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DarbovieteId");

                    b.ToTable("Padaliniai", (string)null);
                });

            modelBuilder.Entity("LGT.Kontaktai.Models.Darbuotojas", b =>
                {
                    b.HasOne("LGT.Kontaktai.Models.Darboviete", "Darboviete")
                        .WithMany("DarbuotojasAssignments")
                        .HasForeignKey("DarbovieteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LGT.Kontaktai.Models.Etatas", "Etatas")
                        .WithMany("Darbuotojai")
                        .HasForeignKey("EtatasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LGT.Kontaktai.Models.Padalinys", "Padalinys")
                        .WithMany()
                        .HasForeignKey("PadalinysId");

                    b.Navigation("Darboviete");

                    b.Navigation("Etatas");

                    b.Navigation("Padalinys");
                });

            modelBuilder.Entity("LGT.Kontaktai.Models.Etatas", b =>
                {
                    b.HasOne("LGT.Kontaktai.Models.Darboviete", "Darboviete")
                        .WithMany("Etatai")
                        .HasForeignKey("DarbovieteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LGT.Kontaktai.Models.EtatasName", "Name")
                        .WithMany()
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LGT.Kontaktai.Models.Padalinys", "Padalinys")
                        .WithMany("Etatai")
                        .HasForeignKey("PadalinysId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Darboviete");

                    b.Navigation("Name");

                    b.Navigation("Padalinys");
                });

            modelBuilder.Entity("LGT.Kontaktai.Models.Padalinys", b =>
                {
                    b.HasOne("LGT.Kontaktai.Models.Darboviete", "Darboviete")
                        .WithMany("Padaliniai")
                        .HasForeignKey("DarbovieteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Darboviete");
                });

            modelBuilder.Entity("LGT.Kontaktai.Models.Darboviete", b =>
                {
                    b.Navigation("DarbuotojasAssignments");

                    b.Navigation("Etatai");

                    b.Navigation("Padaliniai");
                });

            modelBuilder.Entity("LGT.Kontaktai.Models.Etatas", b =>
                {
                    b.Navigation("Darbuotojai");
                });

            modelBuilder.Entity("LGT.Kontaktai.Models.Padalinys", b =>
                {
                    b.Navigation("Etatai");
                });
#pragma warning restore 612, 618
        }
    }
}

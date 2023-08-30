﻿// <auto-generated />
using System;
using Incidentai.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace LGT.Web.Migrations.DatabaseMigrations
{
    [DbContext(typeof(Database))]
    [Migration("20230830110902_Initial commit")]
    partial class Initialcommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 30);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Incidentai.Models.Incidentas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("INC_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aprasymas")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("INC_APRASYMAS");

                    b.Property<DateTime?>("DataIki")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("INC_DATA_IKI");

                    b.Property<DateTime?>("DataNuo")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("INC_DATA_NUO");

                    b.Property<DateTime?>("DataPastebetas")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("INC_DATA_PASTEBETAS");

                    b.Property<int?>("PoveikisId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("INC_POV_ID");

                    b.Property<int?>("RizikaId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("INC_RIZ_ID");

                    b.HasKey("Id");

                    b.HasIndex("PoveikisId");

                    b.HasIndex("RizikaId");

                    b.ToTable("INCIDENTAI");
                });

            modelBuilder.Entity("Incidentai.Models.Incidentas+IncidentoGrupe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("GR_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desc")
                        .HasMaxLength(1024)
                        .HasColumnType("NVARCHAR2(1024)")
                        .HasColumnName("GR_APRASYMAS");

                    b.Property<int>("Index")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("GR_INDEX");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("NVARCHAR2(512)")
                        .HasColumnName("GR_PAV");

                    b.Property<int?>("ParentId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("GR_GR_ID");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("INC_GRUPES");
                });

            modelBuilder.Entity("Incidentai.Models.Incidentas+IncidentoPoveikis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(25)
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("POV_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("IsReal")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(1)")
                        .HasDefaultValue(true)
                        .HasColumnName("POV_YRATIKRAS");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("POV_PAV");

                    b.HasKey("Id");

                    b.ToTable("INC_POVEIKIAI");
                });

            modelBuilder.Entity("Incidentai.Models.Incidentas+IncidentoRizikos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(25)
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("RIZ_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("RIZ_PAV");

                    b.HasKey("Id");

                    b.ToTable("INC_RIZIKOS");
                });

            modelBuilder.Entity("Incidentai.Models.Incidento_Grupes", b =>
                {
                    b.Property<int>("GrupeId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("R_GR_ID");

                    b.Property<int>("IncidentasId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("R_INC_ID");

                    b.HasKey("GrupeId", "IncidentasId");

                    b.HasIndex("IncidentasId");

                    b.ToTable("INCIDENTU_GRUPES");
                });

            modelBuilder.Entity("Incidentai.Models.Incidento_InformacinisIsteklius", b =>
                {
                    b.Property<int>("IncidentasId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("R_INC_ID");

                    b.Property<int>("InformacinisIstekliusId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("R_IST_ID");

                    b.HasKey("IncidentasId", "InformacinisIstekliusId");

                    b.HasIndex("InformacinisIstekliusId");

                    b.ToTable("INCIDENTU_INF_IST");
                });

            modelBuilder.Entity("Incidentai.Models.Incidento_Serveris", b =>
                {
                    b.Property<int>("IncidentasId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("R_INC_ID");

                    b.Property<int>("InformacinisIstekliusId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("R_IST_ID");

                    b.Property<string>("ServerId")
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("R_SER_ID");

                    b.HasKey("IncidentasId", "InformacinisIstekliusId", "ServerId");

                    b.HasIndex("InformacinisIstekliusId", "ServerId");

                    b.ToTable("INCIDENTU_SERVERIAI");
                });

            modelBuilder.Entity("Incidentai.Models.InformacinisIsteklius", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("IST_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Index")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("IST_INDEX");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("NVARCHAR2(250)")
                        .HasColumnName("IST_PAV");

                    b.Property<int>("RTO_Minutes")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("IST_RTO");

                    b.Property<int>("TipasId")
                        .HasMaxLength(25)
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("IST_TIP_ID");

                    b.HasKey("Id");

                    b.HasIndex("TipasId");

                    b.ToTable("INFORMACINIAI_ISTEKLIAI");
                });

            modelBuilder.Entity("Incidentai.Models.InformacinisIsteklius+InformacinioIstekliausTipas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(25)
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("TIP_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Index")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("TIP_INDEX");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("TIP_PAV");

                    b.HasKey("Id");

                    b.ToTable("INF_IST_TIPAI");
                });

            modelBuilder.Entity("Incidentai.Models.Kreipinys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("KR_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("HelperId")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("KR_APT_TRUMP");

                    b.Property<int>("IncidentasId")
                        .HasMaxLength(25)
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("KR_INC_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("KR_NR");

                    b.HasKey("Id");

                    b.HasIndex("HelperId");

                    b.HasIndex("IncidentasId");

                    b.ToTable("KREIPINIAI");
                });

            modelBuilder.Entity("Incidentai.Models.KreipiniuVykdytojai", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("APT_TRUMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("APT_PAV");

                    b.HasKey("Id");

                    b.ToTable("KR_APTARNAUJANTYS");
                });

            modelBuilder.Entity("Incidentai.Models.Server", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("SER_ID");

                    b.Property<int>("InformacinisIstekliusId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("SER_IST_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("SER_PAV");

                    b.Property<string>("TypeId")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("SER_TIP_TRUMP");

                    b.HasKey("Id");

                    b.HasIndex("InformacinisIstekliusId", "TypeId");

                    b.ToTable("SERVERIAI");
                });

            modelBuilder.Entity("Incidentai.Models.ServerType", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("TIP_TRUMP");

                    b.Property<int>("InformacinisIstekliusId")
                        .HasMaxLength(25)
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("TIP_IST_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("TIP_PAV");

                    b.HasKey("Id");

                    b.ToTable("SER_TIPAI");
                });

            modelBuilder.Entity("Incidentai.Models.Incidentas", b =>
                {
                    b.HasOne("Incidentai.Models.Incidentas+IncidentoPoveikis", "Poveikis")
                        .WithMany("Incidentai")
                        .HasForeignKey("PoveikisId");

                    b.HasOne("Incidentai.Models.Incidentas+IncidentoRizikos", "Rizika")
                        .WithMany("Incidentai")
                        .HasForeignKey("RizikaId");

                    b.Navigation("Poveikis");

                    b.Navigation("Rizika");
                });

            modelBuilder.Entity("Incidentai.Models.Incidentas+IncidentoGrupe", b =>
                {
                    b.HasOne("Incidentai.Models.Incidentas+IncidentoGrupe", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Incidentai.Models.Incidento_Grupes", b =>
                {
                    b.HasOne("Incidentai.Models.Incidentas+IncidentoGrupe", "Grupe")
                        .WithMany()
                        .HasForeignKey("GrupeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incidentai.Models.Incidentas", "Incidentas")
                        .WithMany()
                        .HasForeignKey("IncidentasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupe");

                    b.Navigation("Incidentas");
                });

            modelBuilder.Entity("Incidentai.Models.Incidento_InformacinisIsteklius", b =>
                {
                    b.HasOne("Incidentai.Models.Incidentas", "Incidentas")
                        .WithMany()
                        .HasForeignKey("IncidentasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incidentai.Models.InformacinisIsteklius", "InformacinisIsteklius")
                        .WithMany()
                        .HasForeignKey("InformacinisIstekliusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Incidentas");

                    b.Navigation("InformacinisIsteklius");
                });

            modelBuilder.Entity("Incidentai.Models.Incidento_Serveris", b =>
                {
                    b.HasOne("Incidentai.Models.Incidentas", "Incidentas")
                        .WithMany()
                        .HasForeignKey("IncidentasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incidentai.Models.Incidento_InformacinisIsteklius", null)
                        .WithMany("ServeriuPriskyrimai")
                        .HasForeignKey("IncidentasId", "InformacinisIstekliusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_INCIDENTU_SERVERIAI_INCID~1");

                    b.HasOne("Incidentai.Models.Server", "Server")
                        .WithMany()
                        .HasForeignKey("InformacinisIstekliusId", "ServerId")
                        .HasPrincipalKey("InformacinisIstekliusId", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Incidentas");

                    b.Navigation("Server");
                });

            modelBuilder.Entity("Incidentai.Models.InformacinisIsteklius", b =>
                {
                    b.HasOne("Incidentai.Models.InformacinisIsteklius+InformacinioIstekliausTipas", "Tipas")
                        .WithMany("InformaciniaiIstekliai")
                        .HasForeignKey("TipasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipas");
                });

            modelBuilder.Entity("Incidentai.Models.Kreipinys", b =>
                {
                    b.HasOne("Incidentai.Models.KreipiniuVykdytojai", "Helper")
                        .WithMany("Kreipiniai")
                        .HasForeignKey("HelperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incidentai.Models.Incidentas", "Incidentas")
                        .WithMany("Kreipiniai")
                        .HasForeignKey("IncidentasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Helper");

                    b.Navigation("Incidentas");
                });

            modelBuilder.Entity("Incidentai.Models.Server", b =>
                {
                    b.HasOne("Incidentai.Models.InformacinisIsteklius", "InformacinisIsteklius")
                        .WithMany("Servers")
                        .HasForeignKey("InformacinisIstekliusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incidentai.Models.ServerType", "Type")
                        .WithMany("Servers")
                        .HasForeignKey("InformacinisIstekliusId", "TypeId")
                        .HasPrincipalKey("InformacinisIstekliusId", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InformacinisIsteklius");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Incidentai.Models.ServerType", b =>
                {
                    b.HasOne("Incidentai.Models.InformacinisIsteklius", "InformacinisIsteklius")
                        .WithMany("ServerTypes")
                        .HasForeignKey("InformacinisIstekliusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InformacinisIsteklius");
                });

            modelBuilder.Entity("Incidentai.Models.Incidentas", b =>
                {
                    b.Navigation("Kreipiniai");
                });

            modelBuilder.Entity("Incidentai.Models.Incidentas+IncidentoGrupe", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("Incidentai.Models.Incidentas+IncidentoPoveikis", b =>
                {
                    b.Navigation("Incidentai");
                });

            modelBuilder.Entity("Incidentai.Models.Incidentas+IncidentoRizikos", b =>
                {
                    b.Navigation("Incidentai");
                });

            modelBuilder.Entity("Incidentai.Models.Incidento_InformacinisIsteklius", b =>
                {
                    b.Navigation("ServeriuPriskyrimai");
                });

            modelBuilder.Entity("Incidentai.Models.InformacinisIsteklius", b =>
                {
                    b.Navigation("ServerTypes");

                    b.Navigation("Servers");
                });

            modelBuilder.Entity("Incidentai.Models.InformacinisIsteklius+InformacinioIstekliausTipas", b =>
                {
                    b.Navigation("InformaciniaiIstekliai");
                });

            modelBuilder.Entity("Incidentai.Models.KreipiniuVykdytojai", b =>
                {
                    b.Navigation("Kreipiniai");
                });

            modelBuilder.Entity("Incidentai.Models.ServerType", b =>
                {
                    b.Navigation("Servers");
                });
#pragma warning restore 612, 618
        }
    }
}

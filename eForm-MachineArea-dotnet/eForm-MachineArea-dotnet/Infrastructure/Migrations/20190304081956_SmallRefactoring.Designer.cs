﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microting.eFormMachineAreaBase.Infrastructure.Data;

namespace Microting.eFormMachineAreaBase.Migrations
{
    [DbContext(typeof(MachineAreaPnDbContext))]
    [Migration("20190304081956_SmallRefactoring")]
    partial class SmallRefactoring
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            string autoIDGenStrategy = "SqlServer:ValueGenerationStrategy";
            object autoIDGenStrategyValue = SqlServerValueGenerationStrategy.IdentityColumn;
            if (DbConfig.IsMySQL)
            {
                autoIDGenStrategy = "MySql:ValueGenerationStrategy";
                autoIDGenStrategyValue = MySqlValueGenerationStrategy.IdentityColumn;
            }
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("Name");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.AreaVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("AreaVersions");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("Name");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MachineId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("MachineId");

                    b.ToTable("MachineAreas");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("MachineAreaSettings");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaSettingVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MachineAreaSettingId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("MachineAreaSettingVersions");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MachineAreaId");

                    b.Property<int>("MicrotingSdkCaseId");

                    b.Property<int>("MicrotingSdkSiteId");

                    b.Property<int>("MicrotingSdkeFormId");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MachineAreaId");

                    b.ToTable("MachineAreaSites");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaSiteVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MachineAreaId");

                    b.Property<int>("MachineAreaSiteId");

                    b.Property<int>("MicrotingSdkCaseId");

                    b.Property<int>("MicrotingSdkSiteId");

                    b.Property<int>("MicrotingSdkeFormId");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("MachineAreaSiteVersions");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaTimeRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("DoneAt");

                    b.Property<int>("MachineId");

                    b.Property<int>("SDKCaseId");

                    b.Property<int>("SDKFieldValueId");

                    b.Property<int>("SDKSiteId");

                    b.Property<int>("TimeInHours");

                    b.Property<int>("TimeInMinutes");

                    b.Property<int>("TimeInSeconds");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("MachineId");

                    b.ToTable("MachineAreaTimeRegistrations");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaTimeRegistrationVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("DoneAt");

                    b.Property<int>("MachineAreaTimeRegistrationId");

                    b.Property<int>("MachineId");

                    b.Property<int>("SDKCaseId");

                    b.Property<int>("SDKFieldValueId");

                    b.Property<int>("SDKSiteId");

                    b.Property<int>("TimeInHours");

                    b.Property<int>("TimeInMinutes");

                    b.Property<int>("TimeInSeconds");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("MachineAreaTimeRegistrationId");

                    b.HasIndex("MachineId");

                    b.ToTable("MachineAreaTimeRegistrationVersions");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MachineAreaId");

                    b.Property<int>("MachineId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("MachineAreaId");

                    b.HasIndex("MachineId");

                    b.ToTable("MachineAreaVersions");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MachineId");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MachineId");

                    b.ToTable("MachineVersions");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.AreaVersion", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineArea", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Area", "Area")
                        .WithMany("MachineAreas")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Machine", "Machine")
                        .WithMany("MachineAreas")
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaSite", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineArea", "MachineArea")
                        .WithMany("MachineAreaSites")
                        .HasForeignKey("MachineAreaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaTimeRegistration", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaTimeRegistrationVersion", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaTimeRegistration", "MachineAreaTimeRegistration")
                        .WithMany()
                        .HasForeignKey("MachineAreaTimeRegistrationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaVersion", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineArea", "MachineArea")
                        .WithMany()
                        .HasForeignKey("MachineAreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineVersion", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

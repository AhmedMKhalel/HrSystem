﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(HrMisContext))]
    [Migration("20230612063047_JobTitle_Table")]
    partial class JobTitle_Table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.GeneralStaff.GeneralJobGradesGroups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GeneralJobGradesGroups");
                });

            modelBuilder.Entity("Core.Entities.GeneralStaff.JobTitle_QualityGroup_GeneralJobGradesGroups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QualityGroup_GeneralJobGradesGroupsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QualityGroup_GeneralJobGradesGroupsId");

                    b.ToTable("JobTitle_QualityGroup_GeneralJobGradesGroups");
                });

            modelBuilder.Entity("Core.Entities.GeneralStaff.QualityGroup_GeneralJobGradesGroups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<int>("GeneralJobGradesGroupsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneralJobGradesGroupsId");

                    b.ToTable("QualityGroup_GeneralJobGradesGroups");
                });

            modelBuilder.Entity("Core.Entities.GeneralStaff.JobTitle_QualityGroup_GeneralJobGradesGroups", b =>
                {
                    b.HasOne("Core.Entities.GeneralStaff.QualityGroup_GeneralJobGradesGroups", "QualityGroup_GeneralJobGradesGroups")
                        .WithMany()
                        .HasForeignKey("QualityGroup_GeneralJobGradesGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QualityGroup_GeneralJobGradesGroups");
                });

            modelBuilder.Entity("Core.Entities.GeneralStaff.QualityGroup_GeneralJobGradesGroups", b =>
                {
                    b.HasOne("Core.Entities.GeneralStaff.GeneralJobGradesGroups", "GeneralJobGradesGroups")
                        .WithMany("QualityGroups")
                        .HasForeignKey("GeneralJobGradesGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GeneralJobGradesGroups");
                });

            modelBuilder.Entity("Core.Entities.GeneralStaff.GeneralJobGradesGroups", b =>
                {
                    b.Navigation("QualityGroups");
                });
#pragma warning restore 612, 618
        }
    }
}

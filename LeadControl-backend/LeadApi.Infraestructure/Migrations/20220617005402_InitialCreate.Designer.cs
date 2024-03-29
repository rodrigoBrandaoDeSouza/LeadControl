﻿// <auto-generated />
using System;
using LeadApi.Infraestructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeadApi.Infraestructure.Migrations
{
    [DbContext(typeof(LeadApiContext))]
    [Migration("20220617005402_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Api.Domain.Entities.Lead", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Suburb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("LeadAPI.Domain.Entitites.LeadStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LeadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LeadId")
                        .IsUnique();

                    b.HasIndex("StatusId")
                        .IsUnique();

                    b.ToTable("LeadStatus");
                });

            modelBuilder.Entity("LeadAPI.Domain.Entitites.Status", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("LeadAPI.Domain.Entitites.LeadStatus", b =>
                {
                    b.HasOne("Api.Domain.Entities.Lead", "Lead")
                        .WithOne("LeadStatus")
                        .HasForeignKey("LeadAPI.Domain.Entitites.LeadStatus", "LeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeadAPI.Domain.Entitites.Status", "Status")
                        .WithOne("LeadStatus")
                        .HasForeignKey("LeadAPI.Domain.Entitites.LeadStatus", "StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lead");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Api.Domain.Entities.Lead", b =>
                {
                    b.Navigation("LeadStatus")
                        .IsRequired();
                });

            modelBuilder.Entity("LeadAPI.Domain.Entitites.Status", b =>
                {
                    b.Navigation("LeadStatus")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using GraphQLAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraphQLAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210913154844_MySecondMigration")]
    partial class MySecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GraphQLAPI.Models.Command", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommandLine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlatdormId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlatdormId");

                    b.ToTable("Commands");
                });

            modelBuilder.Entity("GraphQLAPI.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LicenseKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("GraphQLAPI.Models.Command", b =>
                {
                    b.HasOne("GraphQLAPI.Models.Platform", "Platform")
                        .WithMany("Commands")
                        .HasForeignKey("PlatdormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("GraphQLAPI.Models.Platform", b =>
                {
                    b.Navigation("Commands");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eproject.Models;

#nullable disable

namespace eproject.Migrations
{
    [DbContext(typeof(mycontext))]
    [Migration("20230820192211_friendsmigration")]
    partial class friendsmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eproject.Models.friends", b =>
                {
                    b.Property<int>("friend_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("friend_id"), 1L, 1);

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("friend_id");

                    b.ToTable("tbl_friends");
                });

            modelBuilder.Entity("eproject.Models.user", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("user_id"), 1L, 1);

                    b.Property<string>("user_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_college")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_dob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_marital_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_phone")
                        .HasColumnType("int");

                    b.Property<string>("user_qualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_school")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_work_status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("user_id");

                    b.ToTable("tbl_user");
                });
#pragma warning restore 612, 618
        }
    }
}

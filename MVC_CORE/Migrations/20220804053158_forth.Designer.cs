﻿// <auto-generated />
using MVC_CORE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_CORE.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220804053158_forth")]
    partial class forth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MVC_CORE.Models.tblcountry", b =>
                {
                    b.Property<int>("cid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cid");

                    b.ToTable("tblcountries");
                });

            modelBuilder.Entity("MVC_CORE.Models.tblemployee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("country")
                        .HasColumnType("int");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tblemployees");
                });

            modelBuilder.Entity("MVC_CORE.Models.tblgender", b =>
                {
                    b.Property<int>("gid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("gname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("gid");

                    b.ToTable("tblgenders");
                });

            modelBuilder.Entity("MVC_CORE.Models.tblstate", b =>
                {
                    b.Property<int>("sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("cid")
                        .HasColumnType("int");

                    b.Property<string>("sname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sid");

                    b.ToTable("tblstates");
                });
#pragma warning restore 612, 618
        }
    }
}
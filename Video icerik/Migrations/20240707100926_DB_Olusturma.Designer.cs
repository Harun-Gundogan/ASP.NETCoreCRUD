﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Video_icerik.Data;

#nullable disable

namespace Video_icerik.Migrations
{
    [DbContext(typeof(VideoicerikContext))]
    [Migration("20240707100926_DB_Olusturma")]
    partial class DB_Olusturma
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Video_icerik.Models.Icerik", b =>
                {
                    b.Property<int>("IcerikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IcerikId"));

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EgitmeninNotlari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kategori")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullanilanTeknolojiler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UretimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("YouTubeVideoId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IcerikId");

                    b.ToTable("Icerik");
                });
#pragma warning restore 612, 618
        }
    }
}
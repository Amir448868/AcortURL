﻿// <auto-generated />
using AcortURL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcortURL.Migrations
{
    [DbContext(typeof(UrlsShortenerContext))]
    partial class UrlsShortenerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("AcortURL.Entities.URL", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlCorta")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Urls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Karen",
                            Url = "https://www.facebook.com/karen.gonzalez.520900"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Luis",
                            Url = "https://www.facebook.com/luis.gonzalez.520900"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

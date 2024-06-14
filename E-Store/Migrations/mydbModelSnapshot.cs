﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Store.Migrations
{
    [DbContext(typeof(mydb))]
    partial class mydbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_Store.Models.products", b =>
                {
                    b.Property<int>("prod_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("prod_id"));

                    b.Property<string>("prod_")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prod_color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prod_size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prod_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("prod_id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("E_Store.Models.users", b =>
                {
                    b.Property<int>("usr_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("usr_id"));

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("usr_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usr_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usr_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("usr_id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}

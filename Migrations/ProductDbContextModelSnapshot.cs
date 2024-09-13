﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Ec2WebApi.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProductCRUD.API.Models.Product", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<string>("Description")
                    .HasColumnType("text");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<decimal>("Price")
                    .HasColumnType("numeric");

                b.HasKey("Id");

                b.ToTable("Products");
            });
#pragma warning restore 612, 618
        }
    }
}

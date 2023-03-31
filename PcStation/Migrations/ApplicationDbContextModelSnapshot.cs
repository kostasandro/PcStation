﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PcStation.Data;

#nullable disable

namespace PcStation.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("FilterProduct", b =>
                {
                    b.Property<int>("FiltersNameId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("FiltersNameId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("FilterProduct");
                });

            modelBuilder.Entity("GroupProduct", b =>
                {
                    b.Property<int>("GroupsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("GroupsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("GroupProduct");
                });

            modelBuilder.Entity("PcStation.Models.Barcode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PrimaryBarcode")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Barcode");
                });

            modelBuilder.Entity("PcStation.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("PcStation.Models.Filter", b =>
                {
                    b.Property<int>("NameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NameId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ValueId")
                        .HasColumnType("int");

                    b.HasKey("NameId");

                    b.ToTable("Filter");
                });

            modelBuilder.Entity("PcStation.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("PcStation.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("PcStation.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Availability")
                        .HasColumnType("int");

                    b.Property<double>("Courier_weight")
                        .HasColumnType("float");

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Dim1")
                        .HasColumnType("float");

                    b.Property<double>("Dim2")
                        .HasColumnType("float");

                    b.Property<double>("Dim3")
                        .HasColumnType("float");

                    b.Property<int>("InOffer")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinimumQuantityToOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pp")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("PriceWithoutOffer")
                        .HasColumnType("float");

                    b.Property<int>("RetailPercent")
                        .HasColumnType("int");

                    b.Property<double>("RetailPrice")
                        .HasColumnType("float");

                    b.Property<double>("Rrp")
                        .HasColumnType("float");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("StockIndicator")
                        .HasColumnType("int");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vat")
                        .HasColumnType("int");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("PcStation.Models.ProductImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<bool>("PrimaryImage")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("PcStation.Models.Subcategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategory");
                });

            modelBuilder.Entity("ProductSubcategory", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("SubcategoriesId")
                        .HasColumnType("int");

                    b.HasKey("ProductsId", "SubcategoriesId");

                    b.HasIndex("SubcategoriesId");

                    b.ToTable("ProductSubcategory");
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("PcStation.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PcStation.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FilterProduct", b =>
                {
                    b.HasOne("PcStation.Models.Filter", null)
                        .WithMany()
                        .HasForeignKey("FiltersNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PcStation.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GroupProduct", b =>
                {
                    b.HasOne("PcStation.Models.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PcStation.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PcStation.Models.Barcode", b =>
                {
                    b.HasOne("PcStation.Models.Product", "Product")
                        .WithMany("Barcodes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PcStation.Models.Category", b =>
                {
                    b.HasOne("PcStation.Models.Group", "Group")
                        .WithMany("Categories")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("PcStation.Models.ProductImages", b =>
                {
                    b.HasOne("PcStation.Models.Image", "Image")
                        .WithMany("ProductImages")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PcStation.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PcStation.Models.Subcategory", b =>
                {
                    b.HasOne("PcStation.Models.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ProductSubcategory", b =>
                {
                    b.HasOne("PcStation.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PcStation.Models.Subcategory", null)
                        .WithMany()
                        .HasForeignKey("SubcategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PcStation.Models.Category", b =>
                {
                    b.Navigation("Subcategories");
                });

            modelBuilder.Entity("PcStation.Models.Group", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("PcStation.Models.Image", b =>
                {
                    b.Navigation("ProductImages");
                });

            modelBuilder.Entity("PcStation.Models.Product", b =>
                {
                    b.Navigation("Barcodes");

                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}

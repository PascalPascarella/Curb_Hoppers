﻿// <auto-generated />
using System;
using GroupCapstone.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroupCapstone.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
<<<<<<< HEAD:GroupCapstone/Migrations/20201106162048_intial14.Designer.cs
    [Migration("20201106162048_intial14")]
    partial class intial14
=======
    [Migration("20201106160239_initagain")]
    partial class initagain
>>>>>>> EmployeeControllers:GroupCapstone/Migrations/20201106160239_initagain.Designer.cs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GroupCapstone.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("GroupCapstone.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "customer1@consume.com",
                            FirstName = "Bob",
                            LastName = "McBoberson",
                            PhoneNumber = "414-555-1234"
                        },
                        new
                        {
                            Id = 2,
                            Email = "customer1@consume.com",
                            FirstName = "Tom",
                            LastName = "Tomson",
                            PhoneNumber = "123-456-7890"
                        },
                        new
                        {
                            Id = 3,
                            Email = "",
                            FirstName = "",
                            LastName = "",
                            PhoneNumber = ""
                        },
                        new
                        {
                            Id = 4,
                            Email = "",
                            FirstName = "",
                            LastName = "",
                            PhoneNumber = ""
                        },
                        new
                        {
                            Id = 5,
                            Email = "",
                            FirstName = "",
                            LastName = "",
                            PhoneNumber = ""
                        });
                });

            modelBuilder.Entity("GroupCapstone.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("GroupCapstone.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPicked")
                        .HasColumnType("bit");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Date = new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            IsPicked = true,
                            TotalPrice = 50
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Date = new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            IsPicked = false,
                            TotalPrice = 20
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 1,
                            Date = new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            IsPicked = false,
                            TotalPrice = 120
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 2,
                            Date = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            IsPicked = false,
                            TotalPrice = 70
                        },
                        new
                        {
                            Id = 5,
                            CustomerId = 1,
                            Date = new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            IsPicked = false,
                            TotalPrice = 80
                        },
                        new
                        {
                            Id = 6,
                            CustomerId = 2,
                            Date = new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = true,
                            IsPicked = true,
                            TotalPrice = 50
                        });
                });

            modelBuilder.Entity("GroupCapstone.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            Price = 0,
                            ProductId = 2,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 2,
                            Price = 0,
                            ProductId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 3,
                            OrderId = 2,
                            Price = 0,
                            ProductId = 3,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 4,
                            OrderId = 4,
                            Price = 0,
                            ProductId = 4,
                            Quantity = 18
                        },
                        new
                        {
                            Id = 5,
                            OrderId = 4,
                            Price = 0,
                            ProductId = 5,
                            Quantity = 14
                        },
                        new
                        {
                            Id = 6,
                            OrderId = 4,
                            Price = 0,
                            ProductId = 3,
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("GroupCapstone.Models.OrderOrderDetailProductVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderDetailsVMId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderVMId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductVMId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderDetailsVMId");

                    b.HasIndex("OrderVMId");

                    b.HasIndex("ProductVMId");

                    b.ToTable("OrderOrderDetailProductVMs");
                });

            modelBuilder.Entity("GroupCapstone.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Details = "Wisconsin cheese from Mexico.",
                            ImageUrl = "",
                            Name = "Cheese",
                            Price = 2.0,
                            ProductCategory = "Dairy"
                        },
                        new
                        {
                            Id = 2,
                            Details = "Harvested by blind monks.",
                            ImageUrl = "",
                            Name = "Coffee",
                            Price = 20.0,
                            ProductCategory = "Dry goods"
                        },
                        new
                        {
                            Id = 3,
                            Details = "99% tofu the rest is a secrect.",
                            ImageUrl = "",
                            Name = "Vegan Sausages",
                            Price = 9.0,
                            ProductCategory = "Vegan"
                        },
                        new
                        {
                            Id = 4,
                            Details = "No horses were harmed in the making of this product.",
                            ImageUrl = "",
                            Name = "Dog food",
                            Price = 5.0,
                            ProductCategory = "Pets"
                        },
                        new
                        {
                            Id = 5,
                            Details = "Please do not drink this product",
                            ImageUrl = "",
                            Name = "Windex",
                            Price = 3.0,
                            ProductCategory = "Cleaners"
                        });
                });

            modelBuilder.Entity("GroupCapstone.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("GroupCapstone.Models.StoreInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AddressZip")
                        .HasColumnType("int");

                    b.Property<string>("CompanyVision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreHours")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StoreInfo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
<<<<<<< HEAD:GroupCapstone/Migrations/20201106162048_intial14.Designer.cs
                            Id = "5571bf80-9e05-402b-bddd-c9be200277f8",
                            ConcurrencyStamp = "294791df-ec6b-4d5c-80dd-3ab64404c90f",
=======
                            Id = "a96ed66c-73f5-4031-959c-9084a8676217",
                            ConcurrencyStamp = "a136271b-b511-4902-b473-6e64b8d8ed33",
>>>>>>> EmployeeControllers:GroupCapstone/Migrations/20201106160239_initagain.Designer.cs
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
<<<<<<< HEAD:GroupCapstone/Migrations/20201106162048_intial14.Designer.cs
                            Id = "ac529b9f-4f32-419e-8447-2afffcb116c7",
                            ConcurrencyStamp = "b73a796d-53d1-4bb9-9d0a-78af7bd46df2",
=======
                            Id = "8288db62-fedd-4713-9b4c-553e13317d2b",
                            ConcurrencyStamp = "9dc07cd4-c702-4be3-9e3a-a39aa351c26b",
>>>>>>> EmployeeControllers:GroupCapstone/Migrations/20201106160239_initagain.Designer.cs
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
<<<<<<< HEAD:GroupCapstone/Migrations/20201106162048_intial14.Designer.cs
                            Id = "f3d8a8a5-caa8-46fd-9c8e-08e6a8307870",
                            ConcurrencyStamp = "445023a3-806f-49f0-a126-a1461fbf7381",
=======
                            Id = "3b59763f-4132-406e-a585-934dd543475d",
                            ConcurrencyStamp = "56352df5-8898-462a-b1f2-cf1fbb44f082",
>>>>>>> EmployeeControllers:GroupCapstone/Migrations/20201106160239_initagain.Designer.cs
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GroupCapstone.Models.Admin", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("GroupCapstone.Models.Customer", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("GroupCapstone.Models.Employee", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("GroupCapstone.Models.Order", b =>
                {
                    b.HasOne("GroupCapstone.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GroupCapstone.Models.OrderDetails", b =>
                {
                    b.HasOne("GroupCapstone.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroupCapstone.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GroupCapstone.Models.OrderOrderDetailProductVM", b =>
                {
                    b.HasOne("GroupCapstone.Models.OrderDetails", "OrderDetailsVM")
                        .WithMany()
                        .HasForeignKey("OrderDetailsVMId");

                    b.HasOne("GroupCapstone.Models.Order", "OrderVM")
                        .WithMany()
                        .HasForeignKey("OrderVMId");

                    b.HasOne("GroupCapstone.Models.Product", "ProductVM")
                        .WithMany()
                        .HasForeignKey("ProductVMId");
                });

            modelBuilder.Entity("GroupCapstone.Models.ShoppingCart", b =>
                {
                    b.HasOne("GroupCapstone.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroupCapstone.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
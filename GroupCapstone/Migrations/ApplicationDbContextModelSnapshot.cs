﻿// <auto-generated />
using System;
using GroupCapstone.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroupCapstone.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

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
                            TotalPrice = 50.0
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Date = new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            IsPicked = false,
                            TotalPrice = 20.0
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 1,
                            Date = new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            IsPicked = false,
                            TotalPrice = 120.0
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 2,
                            Date = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            IsPicked = false,
                            TotalPrice = 70.0
                        },
                        new
                        {
                            Id = 5,
                            CustomerId = 1,
                            Date = new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            IsPicked = false,
                            TotalPrice = 80.0
                        },
                        new
                        {
                            Id = 6,
                            CustomerId = 2,
                            Date = new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = true,
                            IsPicked = true,
                            TotalPrice = 50.0
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

                    b.Property<double>("Price")
                        .HasColumnType("float");

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
                            Price = 0.0,
                            ProductId = 2,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 2,
                            Price = 0.0,
                            ProductId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 3,
                            OrderId = 2,
                            Price = 0.0,
                            ProductId = 3,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 4,
                            OrderId = 4,
                            Price = 0.0,
                            ProductId = 4,
                            Quantity = 18
                        },
                        new
                        {
                            Id = 5,
                            OrderId = 4,
                            Price = 0.0,
                            ProductId = 5,
                            Quantity = 14
                        },
                        new
                        {
                            Id = 6,
                            OrderId = 4,
                            Price = 0.0,
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
                            ImageUrl = "https://lovingitvegan.com/wp-content/uploads/2018/02/Cashew-Cheese-11.jpg",
                            Name = "Cheese",
<<<<<<< HEAD
                            Price = 210,
=======
                            Price = 2.1000000000000001,
>>>>>>> bd40dbf257567496997dd0d3dba3e717d281c73e
                            ProductCategory = "Dairy"
                        },
                        new
                        {
                            Id = 2,
                            Details = "Harvested by blind monks.",
                            ImageUrl = "https://www.qsi-q3.com/wp-content/uploads/sites/52/2017/02/Teaser_05.jpg",
                            Name = "Coffee",
<<<<<<< HEAD
                            Price = 2019,
=======
                            Price = 20.190000000000001,
>>>>>>> bd40dbf257567496997dd0d3dba3e717d281c73e
                            ProductCategory = "Dry goods"
                        },
                        new
                        {
                            Id = 3,
                            Details = "99% tofu the rest is a secrect.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/56/Smokey_tofu_sausages_%283084642875%29.jpg",
                            Name = "Vegan Sausages",
<<<<<<< HEAD
                            Price = 950,
=======
                            Price = 9.5,
>>>>>>> bd40dbf257567496997dd0d3dba3e717d281c73e
                            ProductCategory = "Vegan"
                        },
                        new
                        {
                            Id = 4,
                            Details = "No horses were harmed in the making of this product.",
                            ImageUrl = "https://www.petflow.com/images/default/products/maximal/42303-1556549859.png",
                            Name = "Dog food",
<<<<<<< HEAD
                            Price = 599,
=======
                            Price = 5.9900000000000002,
>>>>>>> bd40dbf257567496997dd0d3dba3e717d281c73e
                            ProductCategory = "Pets"
                        },
                        new
                        {
                            Id = 5,
                            Details = "Please do not drink this product",
                            ImageUrl = "https://www.cvs.com/bizcontent/merchandising/productimages/large/1980020133.jpg",
                            Name = "Windex",
<<<<<<< HEAD
                            Price = 356,
=======
                            Price = 3.5600000000000001,
>>>>>>> bd40dbf257567496997dd0d3dba3e717d281c73e
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

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductCategory")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("AddressZip")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressCity = "Milwaukee",
                            AddressState = "WI",
                            AddressZip = "53203",
                            CompanyVision = "Our DNA is coded so that the customer comes first, well, right after all of our petty internal stuff.  Trust me, the customer is right up there in the top five…maybe ten, things we are focused on.",
                            Email = "ICU@curbhoppers.com",
                            Latitude = 0.0,
                            Logo = "",
                            Longitude = 0.0,
                            Name = "Curb Hoppers",
                            PhoneNumber = "867-5309",
                            StoreHours = "24/7",
                            StreetAddress = "313 N Plankinton Ave"
                        });
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
<<<<<<< HEAD
                            Id = "03e02d81-d8b4-454e-92df-970fb7bc3e30",
                            ConcurrencyStamp = "31e75e70-7187-4cb4-afaf-8c3bfad4aa27",
=======
                            Id = "f0ce4a07-a5c6-4810-bd89-262e14b10d1a",
                            ConcurrencyStamp = "f6a5cf1f-4cfb-4bbd-8fdb-8d6950043089",
>>>>>>> bd40dbf257567496997dd0d3dba3e717d281c73e
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
<<<<<<< HEAD
                            Id = "4127ac04-41dc-4d6a-a3cf-70e32f60ad22",
                            ConcurrencyStamp = "9d5e9a27-43e2-4af7-b81f-d8232ce590af",
=======
                            Id = "939ba267-9394-4650-ab5f-5ee745029f10",
                            ConcurrencyStamp = "d9d120bb-cd2b-4493-a7ab-0f4be3dbe91d",
>>>>>>> bd40dbf257567496997dd0d3dba3e717d281c73e
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
<<<<<<< HEAD
                            Id = "a0832112-fd68-44fa-8ead-cb89d8c6a731",
                            ConcurrencyStamp = "e070bb91-59f8-4020-b446-29c09b83b074",
=======
                            Id = "a0a86acf-3f16-4f98-a638-4c9f6e66f1e2",
                            ConcurrencyStamp = "fcc25889-40a4-47c1-9f60-fa7c873513ac",
>>>>>>> bd40dbf257567496997dd0d3dba3e717d281c73e
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

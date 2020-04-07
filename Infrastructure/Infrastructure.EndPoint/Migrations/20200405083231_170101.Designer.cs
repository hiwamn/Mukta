﻿// <auto-generated />
using System;
using Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.EndPoint.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20200405083231_170101")]
    partial class _170101
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.ActiveCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<long>("CreatedAt");

                    b.Property<string>("Mobile")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ActiveCodes");
                });

            modelBuilder.Entity("Core.Entities.City", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ProvinceId");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sede",
                            ProvinceId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Shahin Shahr",
                            ProvinceId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Jalal Abad",
                            ProvinceId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ghahdrijan",
                            ProvinceId = 1
                        });
                });

            modelBuilder.Entity("Core.Entities.Country", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "India"
                        });
                });

            modelBuilder.Entity("Core.Entities.Device", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<string>("PushId")
                        .IsRequired();

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Core.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<int>("DocumentType");

                    b.Property<int>("Duration");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<int>("Size");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Core.Entities.EntityStatus", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("EntityStatuses");

                    b.HasData(
                        new
                        {
                            Id = 0,
                            Name = "Waiting/Deactivated"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Activated/Submited"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Deleted"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rejected"
                        },
                        new
                        {
                            Id = 4,
                            Name = "WaitingToSendImage"
                        },
                        new
                        {
                            Id = 5,
                            Name = "ImageHasBeenSent"
                        },
                        new
                        {
                            Id = 6,
                            Name = "ImageHasBeenRejected"
                        });
                });

            modelBuilder.Entity("Core.Entities.Expense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<long>("CreatedAt");

                    b.Property<double>("Lat");

                    b.Property<double>("Lon");

                    b.Property<int>("StatusId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("Core.Entities.ExpenseCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<Guid>("ExpenseId");

                    b.Property<Guid>("StoreCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("ExpenseId");

                    b.HasIndex("StoreCategoryId");

                    b.ToTable("ExpenseCategories");
                });

            modelBuilder.Entity("Core.Entities.Feedback", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<Guid>("PartyId");

                    b.Property<int>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.HasIndex("StatusId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Core.Entities.Lead", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<string>("CreditLimit");

                    b.Property<bool?>("GstStatus");

                    b.Property<string>("Investment");

                    b.Property<string>("OtherCompanyRepresented");

                    b.Property<int>("StatusId");

                    b.Property<string>("StoreAddress");

                    b.Property<string>("StoreEmail");

                    b.Property<double>("StoreLat");

                    b.Property<double>("StoreLon");

                    b.Property<string>("StoreName");

                    b.Property<double>("StoreNumber");

                    b.Property<int?>("TypeId");

                    b.Property<long>("UpdatedAt");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("Core.Entities.LeadDocuments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<Guid>("DocumentId");

                    b.Property<Guid>("LeadId");

                    b.Property<Guid?>("LeadId1");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.HasIndex("LeadId");

                    b.HasIndex("LeadId1");

                    b.ToTable("LeadDocuments");
                });

            modelBuilder.Entity("Core.Entities.LeadStoreCategories", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<Guid>("LeadId");

                    b.Property<Guid>("StoreCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("LeadId");

                    b.HasIndex("StoreCategoryId");

                    b.ToTable("LeadStoreCategories");
                });

            modelBuilder.Entity("Core.Entities.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<Guid?>("DeviceId");

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Link")
                        .IsRequired();

                    b.Property<string>("Title");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Core.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<string>("DayCount");

                    b.Property<string>("Days");

                    b.Property<string>("DeliveryPeriod");

                    b.Property<string>("Description");

                    b.Property<string>("Discount");

                    b.Property<bool>("Insurance");

                    b.Property<string>("ItemCode");

                    b.Property<string>("NetPrice");

                    b.Property<Guid>("PartyId");

                    b.Property<bool>("PaymentTerms");

                    b.Property<long>("PurchaseOrderValidityDate");

                    b.Property<string>("Quantity");

                    b.Property<string>("RatePerUnit");

                    b.Property<string>("SaleTax");

                    b.Property<int>("SlNo");

                    b.Property<int>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.HasIndex("StatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Core.Entities.OrderDocuments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<Guid>("DocumentId");

                    b.Property<Guid>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDocuments");
                });

            modelBuilder.Entity("Core.Entities.Party", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContractNumber");

                    b.Property<long>("CreatedAt");

                    b.Property<string>("CreditLimit");

                    b.Property<bool?>("GstStatus");

                    b.Property<string>("Investment");

                    b.Property<string>("OtherCompanyRepresented");

                    b.Property<int>("StatusId");

                    b.Property<string>("StoreAddress");

                    b.Property<string>("StoreEmail");

                    b.Property<double>("StoreLat");

                    b.Property<double>("StoreLon");

                    b.Property<string>("StoreName");

                    b.Property<string>("StoreNumber");

                    b.Property<string>("TotalOutput");

                    b.Property<int>("TypeId");

                    b.Property<long>("UpdatedAt");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("Core.Entities.PartyDocuments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<Guid>("DocumentId");

                    b.Property<Guid>("PartyId");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.HasIndex("PartyId");

                    b.ToTable("PartyDocuments");
                });

            modelBuilder.Entity("Core.Entities.PartyStoreCategories", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<Guid>("PartyId");

                    b.Property<Guid>("StoreCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.HasIndex("StoreCategoryId");

                    b.ToTable("PartyStoreCategories");
                });

            modelBuilder.Entity("Core.Entities.PartyType", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PartyTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Direct Dealer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dealer Account"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Distributor"
                        });
                });

            modelBuilder.Entity("Core.Entities.ProductCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Core.Entities.Province", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Provinces");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Isfahan"
                        });
                });

            modelBuilder.Entity("Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mobile"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("Core.Entities.Setting", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Core.Entities.StoreCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("StoreCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("841b4765-c98e-4657-88be-cd586b9afecc"),
                            CreatedAt = 0L,
                            Name = "Cooktop"
                        },
                        new
                        {
                            Id = new Guid("eeee852b-6e23-4491-a967-2136e2575673"),
                            CreatedAt = 0L,
                            Name = "Cooking range"
                        },
                        new
                        {
                            Id = new Guid("6c3caeda-6b6c-4d88-8111-bc6fe24cb006"),
                            CreatedAt = 0L,
                            Name = "Chimney"
                        },
                        new
                        {
                            Id = new Guid("cc952945-374f-418d-b66c-b8a55cc0e753"),
                            CreatedAt = 0L,
                            Name = "Hobs"
                        },
                        new
                        {
                            Id = new Guid("31e06410-34f2-4dbf-a4e5-bcc3986516e3"),
                            CreatedAt = 0L,
                            Name = "Cookware"
                        },
                        new
                        {
                            Id = new Guid("165e26e4-0946-4305-9ac5-20e5ca6aeb27"),
                            CreatedAt = 0L,
                            Name = "Cooker"
                        });
                });

            modelBuilder.Entity("Core.Entities.Update", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Link")
                        .IsRequired();

                    b.Property<bool>("Restricted");

                    b.Property<string>("Version")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Updates");
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("Birthday");

                    b.Property<int?>("CityId");

                    b.Property<long>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FamilyName");

                    b.Property<int?>("Gender");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<Guid?>("ProfileImageId");

                    b.Property<Guid?>("ReferenceId");

                    b.Property<string>("Salt")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("ProfileImageId");

                    b.HasIndex("ReferenceId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Entities.UserImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<Guid>("DocumentId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.HasIndex("UserId");

                    b.ToTable("UserImages");
                });

            modelBuilder.Entity("Core.Entities.UserRole", b =>
                {
                    b.Property<long>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("Id");

                    b.Property<int>("RoleId");

                    b.Property<Guid>("UserId");

                    b.HasKey("CreatedAt");

                    b.HasAlternateKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Core.Entities.WorkTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedAt");

                    b.Property<long>("Entry");

                    b.Property<bool>("IsInput");

                    b.Property<int>("StatusId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("WorkTimes");
                });

            modelBuilder.Entity("Core.Entities.City", b =>
                {
                    b.HasOne("Core.Entities.Province", "Province")
                        .WithMany("City")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Device", b =>
                {
                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("Device")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Expense", b =>
                {
                    b.HasOne("Core.Entities.EntityStatus", "Status")
                        .WithMany("Expense")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("Expense")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.ExpenseCategory", b =>
                {
                    b.HasOne("Core.Entities.Expense", "Expense")
                        .WithMany("Categories")
                        .HasForeignKey("ExpenseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.StoreCategory", "StoreCategory")
                        .WithMany("ExpenseCategory")
                        .HasForeignKey("StoreCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Feedback", b =>
                {
                    b.HasOne("Core.Entities.Party", "Party")
                        .WithMany("Feedback")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.EntityStatus", "Status")
                        .WithMany("Feedback")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Lead", b =>
                {
                    b.HasOne("Core.Entities.EntityStatus", "Status")
                        .WithMany("Lead")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.PartyType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("Lead")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.LeadDocuments", b =>
                {
                    b.HasOne("Core.Entities.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.Lead", "Lead")
                        .WithMany()
                        .HasForeignKey("LeadId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.Lead")
                        .WithMany("StoreImages")
                        .HasForeignKey("LeadId1");
                });

            modelBuilder.Entity("Core.Entities.LeadStoreCategories", b =>
                {
                    b.HasOne("Core.Entities.Lead", "Lead")
                        .WithMany("StoreCategories")
                        .HasForeignKey("LeadId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.StoreCategory", "StoreCategory")
                        .WithMany("LeadStoreCategories")
                        .HasForeignKey("StoreCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Notification", b =>
                {
                    b.HasOne("Core.Entities.Device")
                        .WithMany("Notification")
                        .HasForeignKey("DeviceId");

                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("Notification")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Order", b =>
                {
                    b.HasOne("Core.Entities.Party", "Party")
                        .WithMany("Order")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.EntityStatus", "Status")
                        .WithMany("Order")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.OrderDocuments", b =>
                {
                    b.HasOne("Core.Entities.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.Order", "Order")
                        .WithMany("InvoiceImages")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Party", b =>
                {
                    b.HasOne("Core.Entities.EntityStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.PartyType", "Type")
                        .WithMany("Parties")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.PartyDocuments", b =>
                {
                    b.HasOne("Core.Entities.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.Party", "Party")
                        .WithMany("StoreImages")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.PartyStoreCategories", b =>
                {
                    b.HasOne("Core.Entities.Party", "Party")
                        .WithMany("StoreCategories")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.StoreCategory", "StoreCategory")
                        .WithMany("PartyStoreCategories")
                        .HasForeignKey("StoreCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Province", b =>
                {
                    b.HasOne("Core.Entities.Country", "Country")
                        .WithMany("Province")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.HasOne("Core.Entities.City", "City")
                        .WithMany("User")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.Document", "ProfileImage")
                        .WithMany()
                        .HasForeignKey("ProfileImageId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.User", "Reference")
                        .WithMany()
                        .HasForeignKey("ReferenceId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.UserImage", b =>
                {
                    b.HasOne("Core.Entities.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("UserImages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.UserRole", b =>
                {
                    b.HasOne("Core.Entities.Role", "Role")
                        .WithMany("UserRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("UserRole")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.WorkTime", b =>
                {
                    b.HasOne("Core.Entities.EntityStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("WorkTime")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

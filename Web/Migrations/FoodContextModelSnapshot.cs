﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.Models.EF;

#nullable disable

namespace Web.Migrations
{
    [DbContext(typeof(FoodContext))]
    partial class FoodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.database.Models.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keyword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Picture")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("Core.database.Models.Authorized", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("RoleId");

                    b.ToTable("Authorized");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3f213e00-43ce-488b-8e43-ff244a2009fb"),
                            GroupId = new Guid("e3e148af-0576-466e-b783-736c0f27f989"),
                            RoleId = new Guid("8cbc6a66-dce6-44c5-96c9-f8d700434016")
                        });
                });

            modelBuilder.Entity("Core.database.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2d6349ba-b2b6-49ce-8f9b-4531ec7372dd"),
                            CreatedBy = new Guid("e3d1cf68-a04c-4ff8-89d8-40266246c86e"),
                            CreatedOn = new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(234),
                            Name = "Root"
                        },
                        new
                        {
                            Id = new Guid("3a70fb4a-b22c-469f-8f50-5e3047d5b599"),
                            CreatedBy = new Guid("e3d1cf68-a04c-4ff8-89d8-40266246c86e"),
                            CreatedOn = new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(236),
                            Name = "Authorized",
                            ParentId = new Guid("2d6349ba-b2b6-49ce-8f9b-4531ec7372dd")
                        },
                        new
                        {
                            Id = new Guid("1e1ca786-81c5-4c4c-b3a7-2e79e1ce0894"),
                            CreatedBy = new Guid("e3d1cf68-a04c-4ff8-89d8-40266246c86e"),
                            CreatedOn = new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(238),
                            Name = "Nhóm quyền",
                            ParentId = new Guid("3a70fb4a-b22c-469f-8f50-5e3047d5b599")
                        },
                        new
                        {
                            Id = new Guid("22e62dda-eec5-40c2-872d-f5c495025d7c"),
                            CreatedBy = new Guid("e3d1cf68-a04c-4ff8-89d8-40266246c86e"),
                            CreatedOn = new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(240),
                            Name = "Article",
                            ParentId = new Guid("2d6349ba-b2b6-49ce-8f9b-4531ec7372dd")
                        },
                        new
                        {
                            Id = new Guid("74175c1d-096c-4274-97ee-0ea5cc3a7117"),
                            CreatedBy = new Guid("e3d1cf68-a04c-4ff8-89d8-40266246c86e"),
                            CreatedOn = new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(242),
                            Name = "Product",
                            ParentId = new Guid("2d6349ba-b2b6-49ce-8f9b-4531ec7372dd")
                        });
                });

            modelBuilder.Entity("Core.database.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Core.database.Models.Details", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("details");
                });

            modelBuilder.Entity("Core.database.Models.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Group");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e3e148af-0576-466e-b783-736c0f27f989"),
                            Name = "Quản trị viên"
                        });
                });

            modelBuilder.Entity("Core.database.Models.Member", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoginName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Picture")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Member");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e3d1cf68-a04c-4ff8-89d8-40266246c86e"),
                            CreatedOn = new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(201),
                            Email = "ngolinh@gmail.com",
                            GroupId = new Guid("e3e148af-0576-466e-b783-736c0f27f989"),
                            LoginName = "ngo.linh",
                            Name = "Ngô Văn Linh",
                            Password = "c4ca4238a0b923820dcc509a6f75849b",
                            Picture = "/img/users/ngolinh.jpg"
                        },
                        new
                        {
                            Id = new Guid("8c7e1501-422e-47e1-8f81-bfb3d226653b"),
                            CreatedOn = new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(214),
                            Email = "lethuonglong@gmail.com",
                            GroupId = new Guid("e3e148af-0576-466e-b783-736c0f27f989"),
                            LoginName = "lethuonglong",
                            Name = "Lê Thượng Long",
                            Password = "12345",
                            Picture = "/img/users/wean.jpg"
                        });
                });

            modelBuilder.Entity("Core.database.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Core.database.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Intro")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool?>("IsComming")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Picture")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Core.database.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8cbc6a66-dce6-44c5-96c9-f8d700434016"),
                            CategoryId = new Guid("1e1ca786-81c5-4c4c-b3a7-2e79e1ce0894"),
                            Code = "view-groups",
                            Name = "Xem Danh Sách "
                        },
                        new
                        {
                            Id = new Guid("92ba2ad6-b980-41b0-9e65-f513d3c5ae21"),
                            CategoryId = new Guid("1e1ca786-81c5-4c4c-b3a7-2e79e1ce0894"),
                            Code = "edit-group",
                            Name = "Cập nhật "
                        },
                        new
                        {
                            Id = new Guid("610f1ba6-cd51-4610-b1e5-bf8e53b5014c"),
                            CategoryId = new Guid("1e1ca786-81c5-4c4c-b3a7-2e79e1ce0894"),
                            Code = "save-group",
                            Name = "Lưu"
                        },
                        new
                        {
                            Id = new Guid("068cba2f-3879-44e8-a3d8-f3a80199b786"),
                            CategoryId = new Guid("1e1ca786-81c5-4c4c-b3a7-2e79e1ce0894"),
                            Code = "delete-group",
                            Name = "Xóa "
                        });
                });

            modelBuilder.Entity("Core.database.Models.Authorized", b =>
                {
                    b.HasOne("Core.database.Models.Group", "Group")
                        .WithMany("Authorizeds")
                        .HasForeignKey("GroupId");

                    b.HasOne("Core.database.Models.Role", "Role")
                        .WithMany("Authorizeds")
                        .HasForeignKey("RoleId");

                    b.Navigation("Group");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Core.database.Models.Category", b =>
                {
                    b.HasOne("Core.database.Models.Category", "Parent")
                        .WithMany("ChildCategories")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Core.database.Models.Details", b =>
                {
                    b.HasOne("Core.database.Models.Order", "Order")
                        .WithMany("Details")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.database.Models.Product", "Product")
                        .WithMany("Details")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.database.Models.Member", b =>
                {
                    b.HasOne("Core.database.Models.Group", "Group")
                        .WithMany("Members")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Core.database.Models.Order", b =>
                {
                    b.HasOne("Core.database.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Core.database.Models.Product", b =>
                {
                    b.HasOne("Core.database.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Core.database.Models.Role", b =>
                {
                    b.HasOne("Core.database.Models.Category", "Category")
                        .WithMany("Roles")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Core.database.Models.Category", b =>
                {
                    b.Navigation("ChildCategories");

                    b.Navigation("Products");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Core.database.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Core.database.Models.Group", b =>
                {
                    b.Navigation("Authorizeds");

                    b.Navigation("Members");
                });

            modelBuilder.Entity("Core.database.Models.Order", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("Core.database.Models.Product", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("Core.database.Models.Role", b =>
                {
                    b.Navigation("Authorizeds");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using BlogP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogP.Migrations
{
    [DbContext(typeof(BlogPContext))]
    [Migration("20200315193643_Seed-Database")]
    partial class SeedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogP.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Slug");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("PostId");

                    b.ToTable("Post");

                    b.HasData(
                        new { PostId = 1, Body = "Body test", CreatedAt = new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc), Description = "Description test", Slug = "title-test", Title = "Title test", UpdatedAt = new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc) },
                        new { PostId = 2, Body = "Body test2", CreatedAt = new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc), Description = "Description test2", Slug = "title-test2", Title = "Title test2", UpdatedAt = new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc) },
                        new { PostId = 3, Body = "Body test3", CreatedAt = new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc), Description = "Description test3", Slug = "title-test3", Title = "Title test3", UpdatedAt = new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc) },
                        new { PostId = 4, Body = "Body test4", CreatedAt = new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc), Description = "Description test4", Slug = "title-test4", Title = "Title test4", UpdatedAt = new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc) }
                    );
                });

            modelBuilder.Entity("BlogP.Models.PostTag", b =>
                {
                    b.Property<int>("PostId");

                    b.Property<string>("TagId");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTag");

                    b.HasData(
                        new { PostId = 1, TagId = "tag1" },
                        new { PostId = 2, TagId = "tag2" },
                        new { PostId = 3, TagId = "tag3" },
                        new { PostId = 4, TagId = "tag4" },
                        new { PostId = 1, TagId = "tag4" },
                        new { PostId = 2, TagId = "tag3" }
                    );
                });

            modelBuilder.Entity("BlogP.Models.Tag", b =>
                {
                    b.Property<string>("TagId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("TagId");

                    b.ToTable("Tag");

                    b.HasData(
                        new { TagId = "tag1" },
                        new { TagId = "tag2" },
                        new { TagId = "tag3" },
                        new { TagId = "tag4" }
                    );
                });

            modelBuilder.Entity("BlogP.Models.PostTag", b =>
                {
                    b.HasOne("BlogP.Models.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlogP.Models.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

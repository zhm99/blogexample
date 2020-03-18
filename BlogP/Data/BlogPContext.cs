using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogP.Models;

namespace BlogP.Models
{
    public class BlogPContext : DbContext
    {
        public BlogPContext (DbContextOptions<BlogPContext> options)
            : base(options)
        {
        }

         public DbSet<BlogP.Models.Post> Post { get; set; }

         public DbSet<BlogP.Models.Tag> Tag { get; set; }

         public DbSet<BlogP.Models.Tag> PostTag { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTag>()
                .HasKey(pt => new { pt.PostId, pt.TagId });

            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId);

            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.TagId);

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    PostId = 1,
                    Title = "Title test",
                    Slug = "title-test",
                    Body = "Body test",
                    Description = "Description test",
                    CreatedAt = DateTime.UtcNow,
                },
                new Post
                {
                    PostId = 2,
                    Title = "Title test2",
                    Slug = "title-test2",
                    Body = "Body test2",
                    Description = "Description test2",
                    CreatedAt = DateTime.UtcNow
                },
                new Post
                {
                    PostId = 3,
                    Title = "Title test3",
                    Slug = "title-test3",
                    Body = "Body test3",
                    Description = "Description test3",
                    CreatedAt = DateTime.UtcNow
                },
                new Post
                {
                    PostId = 4,
                    Title = "Title test4",
                    Slug = "title-test4",
                    Body = "Body test4",
                    Description = "Description test4",
                    CreatedAt = DateTime.UtcNow
                }
                );

            modelBuilder.Entity<Tag>().HasData(
                new Tag() { TagId = "tag1" },
                new Tag() { TagId = "tag2" },
                new Tag() { TagId = "tag3" },
                new Tag() { TagId = "tag4" }
            );

            modelBuilder.Entity<PostTag>().HasData(
                new PostTag()
                {
                    PostId = 1,
                    TagId = "tag1"
                },
                new PostTag()
                {
                    PostId = 2,
                    TagId = "tag2"
                },
                new PostTag()
                {
                    PostId = 3,
                    TagId = "tag3"
                },
                new PostTag()
                {
                    PostId = 4,
                    TagId = "tag4"
                },
                new PostTag()
                {
                    PostId = 1,
                    TagId = "tag4"
                },
                new PostTag()
                {
                    PostId = 2,
                    TagId = "tag3"
                }
            );
        }
    }
}

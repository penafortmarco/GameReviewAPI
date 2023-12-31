﻿using GameReview.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace GameReview.DataAccess.Data
{
    public class GameReviewContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }

        public GameReviewContext(DbContextOptions<GameReviewContext> Options) : base(Options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>(u =>
            {
                u.ToTable("User");
                u.HasKey(p => p.Id);
                u.Property(p => p.UserName).IsRequired().HasMaxLength(36);
                u.Property(p => p.Email).IsRequired().HasMaxLength(80);
                u.Property(p => p.Password).IsRequired().HasMaxLength(50);
            });
            {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade); 
            }

            modelBuilder.Entity<Review>(r => 
            {
                r.ToTable("Review");
                r.HasKey(p => p.Id);
                r.Property(p => p.Description).IsRequired().HasMaxLength(1000);
                r.Property(p => p.Image).IsRequired().HasMaxLength(200);
                r.Property(p => p.Date).IsRequired().HasDefaultValue(DateTime.Now);
            });
            modelBuilder.Entity<Like>(l =>
            {
                l.ToTable("Like");
                l.HasKey(p => p.Id);
                l.Property(p => p.UserId);
                l.Property(p => p.ReviewId);
            });

            modelBuilder.Entity<Comment>(c =>
            {
                c.ToTable("Comment");
                c.HasKey(p => p.Id);
                c.Property(p => p.Text).IsRequired().HasMaxLength(140);
                c.Property(p => p.UserId);
                c.Property(p => p.ReviewId);
            });

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Review)
                .WithMany(r => r.Comments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Like>()
               .HasOne(l => l.Review)
               .WithMany(r => r.Likes)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
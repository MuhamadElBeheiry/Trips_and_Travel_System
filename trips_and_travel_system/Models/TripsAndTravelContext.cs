﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace trips_and_travel_system.Models
{
    public class TripsAndTravelContext : DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<FAQ> FAQs { set; get; }

        public TripsAndTravelContext() : base("name=DatabaseContext")
        {
            Database.SetInitializer<TripsAndTravelContext>(new CreateDatabaseIfNotExists<TripsAndTravelContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region User Configration

            modelBuilder.Entity<User>()
                .HasKey<int>(u => u.UserId);
            modelBuilder.Entity<User>()
                .HasMany<Post>(u => u.SavedPosts)
                .WithMany(p => p.Users)
                .Map(userSavedPosts =>
                        {
                            userSavedPosts.MapLeftKey("UserId");
                            userSavedPosts.MapRightKey("PostId");
                            userSavedPosts.ToTable("UserSavedPosts");
                        });

            #endregion

            #region Post Configration

            modelBuilder.Entity<Post>()
                .HasKey<int>(p => p.PostId);
            modelBuilder.Entity<Post>()
                .HasRequired(p => p.Agency)
                .WithMany(u => u.TripPosts)
                .HasForeignKey(p => p.agencyId)
                .WillCascadeOnDelete(false);

            #endregion

            #region FAQ Configration

            modelBuilder.Entity<FAQ>()
                .HasKey<int>(f => f.FAQId);

            #endregion
        }
    }
}
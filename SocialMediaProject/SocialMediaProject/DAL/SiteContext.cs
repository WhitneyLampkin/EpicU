using Microsoft.AspNet.Identity.EntityFramework;
using SocialMediaProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Web;

namespace SocialMediaProject.DAL
{
    public class SiteContext : DbContext
    {
        public DbSet<ChatModels> ChatModels { get; set; }
        public DbSet<CommentModels> CommentModels { get; set; }
        public DbSet<FriendshipModels> FriendshipModels { get; set; }
        public DbSet<MessageModels> MessageModels { get; set; }
        public DbSet<ScenarioModels> ScenarioModels { get; set; }
        public DbSet<SurvivalMode> SurvivalModeMdoels { get; set; }
        public DbSet<ChillMode> ChillModeModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            modelBuilder.Entity<FriendshipModels>()
                        .HasRequired(m => m.CurrentUser)
                        .WithMany(t => t.RequestedFriendships)
                        .HasForeignKey(m => m.CurrentUserId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<FriendshipModels>()
                        .HasRequired(m => m.Recipient)
                        .WithMany(t => t.AcceptedFriendships)
                        .HasForeignKey(m => m.RecipientId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<MessageModels>()
                        .HasRequired(m => m.Sender)
                        .WithMany(t => t.UserMessages)
                        .HasForeignKey(m => m.SenderId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChatModels>()
                        .HasRequired(m => m.Recipient)
                        .WithMany(t => t.UserChats)
                        .HasForeignKey(m => m.RecipientId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<IdentityUserLogin>()
                        .HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>()
                        .HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>()
                        .HasKey(r => new { r.RoleId, r.UserId });
        }
    }
}
using MessengerData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessengerData.EF
{
    public class MessengerDbContext : DbContext
    {
        public MessengerDbContext()
        {
            //Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserStatus> UserStatuses { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=omega;Database=MessengerDB;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => {
                entity.HasIndex(e => e.Login)
                .IsUnique();
            });

            modelBuilder.Entity<User>(entity => {
                entity.HasIndex(e => e.Email)
                .IsUnique();
            });

            modelBuilder.Entity<User>(entity => {
                entity.HasIndex(e => e.Phone)
                .IsUnique();
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientNoAction)
                    .HasConstraintName("FK_Messages_Users_SenderId");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Participants)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientNoAction)
                    .HasConstraintName("FK_Participants_Users_UserId");
            });

        }

    }
}

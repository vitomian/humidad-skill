using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System;

namespace Layout4_Tabbed
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Username { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(100)]
        public string Password { get; set; } = string.Empty;
    }

    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        private string DbPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app.db");

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "123", Password = "123" }
            );
        }
    }
}
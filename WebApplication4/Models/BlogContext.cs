using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using System;

namespace WebApplication4.Models
{


public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Name = "Food Blog",
                    Url = "https://www.myfood.eat"
                },
                new Blog
                {
                    Id = 2,
                    Name = "Travel Blog",
                    Url = "https://www.mytravel.tips"
                },
                new Blog
                {
                    Id = 3,
                    Name = "Tech Blog",
                    Url = "https://www.mytech.info"
                }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=asp.db");
        }
    }



}


using CodeFirstDB.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CodeFirstDB.Net.Data
{
    class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.DisplayName)
                .HasColumnName("display_name");
        }
    }

    
}

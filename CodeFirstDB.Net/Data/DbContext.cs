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

    }
}

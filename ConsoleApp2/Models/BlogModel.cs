using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstDB.Data;

namespace CodeFirstDB.Models
{
    class BlogModel
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // prompt the user to create a new blog. This will be added to the DB
                Console.Write("Enter a name for a new blog");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog)

            }
           
        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }

        // virtual method that returns a list of Posts. Declaring it as virtual because we might want to override it later
        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }

        // virtual method that returns a Blog object called Blog. Declaring it as virtual because we might want to override it later
        public virtual Blog Blog { get; set; }
    }
  
}

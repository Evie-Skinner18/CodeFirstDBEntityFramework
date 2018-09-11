using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstDB.Net.Data;

namespace CodeFirstDB.Net.Models
{
    class BlogModel
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // prompt the user to create a new blog. This will be added to the DB
                Console.Write("Enter a name for a new blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                // Select each blog in Blogs
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                // loop through the array of blogs that query returns and display each one's name to the user
                Console.WriteLine("All blogs from the database: ");
                foreach (var i in query)
                {
                    Console.WriteLine(i.Name);
                }

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();


            }

        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        // virtual method that returns a list of Posts. Declaring it as virtual because we might want to override it later
        // Actually yes we override it with the seed when we do migrations
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

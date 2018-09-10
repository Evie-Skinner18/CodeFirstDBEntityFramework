using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDB.Models
{
    class BlogModel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

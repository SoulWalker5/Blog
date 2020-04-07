using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base(@"Data Source=.\;Initial Catalog=BlogDB;Integrated Security=True")
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}

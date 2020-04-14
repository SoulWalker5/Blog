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
        //public MyContext() : base(@"Data Source=.\;Initial Catalog=BlogDB;Integrated Security=True")
        //{

        //}

        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Articles)
                .WithRequired(x => x.User)
                .HasForeignKey(x => x.UserId)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Article>()
            //    .HasMany(x => x.Comments);
        }
        //modelBuilder.Entity<User>()
        //    .HasKey(x => x.Id)
        //    .HasMany(x => x.Comments)
        //    .WithRequired(x => x.User)
        //    .HasForeignKey(x => x.UserId)
        //    .WillCascadeOnDelete(true);



        //modelBuilder.Entity<Category>()
        //    .HasKey(x => x.Id)
        //    .HasMany(x => x.Articles);

        //modelBuilder.Entity<Comment>()
        //    .HasKey(x => x.Id)
        //    .HasIndex(x=>x.Id);
        //}
    }
}

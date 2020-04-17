using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContentInitializer : DropCreateDatabaseAlways<MyContext>
    {

        string errorTxt = "";
        protected override void Seed(MyContext context)
        {
            try
            {
                context.Categories.Add(new Category() { Name = "Nature" });
                context.Users.Add(new User() { FirstName = "Zero", LastName = "Two", NickName = "Zero_Two", Age = 18 });
                context.Users.Add(new User() { FirstName = "One", LastName = "Six", NickName = "One_Six", Age = 23 });
                context.Users.Add(new User() { FirstName = "User", LastName = "For", NickName = "Change_or_Delete", Age = 25 });

                context.SaveChanges();

                context.Articles.Add(new Article()
                {
                    Title = "Title",
                    Text = "Some text will here soon enough",
                    Category = context.Categories.FirstOrDefault(c => c.Name == "Nature"),
                    User = context.Users.FirstOrDefault(a => a.Id == 1)
                });

                context.Articles.Add(new Article()
                {
                    Title = "Natureeeeee",
                    Text = "Something about nature",
                    Category = context.Categories.FirstOrDefault(c => c.Name == "Nature"),
                    User = context.Users.FirstOrDefault(a => a.Id == 2)
                });

                base.Seed(context);
            }
            catch (Exception ex)
            {
                errorTxt = DateTime.Now.Date.ToString() + " " + ex.Message + "\n";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class User
    {
        public User()
        {
            Comments = new List<Comment>();
            Articles = new List<Article>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}

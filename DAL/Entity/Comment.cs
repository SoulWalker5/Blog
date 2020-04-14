using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }

        public int ArticleId { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public Article Article { get; set; }

    }
}

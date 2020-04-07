using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModel
{
    public class UserBL
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }

        public IEnumerable<CommentBL> Comments { get; set; }
        public IEnumerable<ArticleBL> Articles { get; set; }
    }
}

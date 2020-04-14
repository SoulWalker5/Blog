using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        //[Required]
        public string FirstName { get; set; }

        //[Required]
        public string LastName { get; set; }

        //[Required]
        public string NickName { get; set; }

        //[Required]
        public int Age { get; set; }

        public IEnumerable<CommentModel> Comments { get; set; }
        public IEnumerable<ArticleModel> Articles { get; set; }
    }
}
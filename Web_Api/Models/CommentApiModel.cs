using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api.Models
{
    public class CommentApiModel
    {
        public int Id { get; set; }
        public string Body { get; set; }

        public UserApiModel User { get; set; }
        public ArticleApiModel Article { get; set; }
    }
}
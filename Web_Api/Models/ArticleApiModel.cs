using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api.Models
{
    public class ArticleApiModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public UserApiModel User { get; set; }
        public CategoryApiModel Category { get; set; }


    }
}
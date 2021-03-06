﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Article
    {
        public Article()
        {
            Comments = new List<Comment>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public int UserId { get; set; }
        public int CategoryId { get; set; }

        public virtual User User { get; set; }
        public Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModel
{
    public class ArticleBL
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public UserBL User { get; set; }
        public CategoryBL Category { get; set; }

        public IEnumerable<CommentBL> Comments { get; set; }
    }
}

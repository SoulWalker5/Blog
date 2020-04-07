using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModel
{
    public class CommentBL
    {
        public int Id { get; set; }
        public string Body { get; set; }

        public UserBL User { get; set; }
        public ArticleBL Article { get; set; }
    }
}

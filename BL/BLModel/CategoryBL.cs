using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModel
{
    public class CategoryBL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ArticleBL> Articles { get; set; }
    }
}

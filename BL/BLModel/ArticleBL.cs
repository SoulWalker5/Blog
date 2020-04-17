using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModel
{
    //[DataContract(IsReference = true)]
    public class ArticleBL
    {
        //[DataMember]
        public int Id { get; set; }
        //[DataMember]
        public string Title { get; set; }
        //[DataMember]
        public string Text { get; set; }

        //[DataMember]
        public UserBL User { get; set; }
        public CategoryBL Category { get; set; }

        public IEnumerable<CommentBL> Comments { get; set; }
    }
}

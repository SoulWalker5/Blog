using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModel
{
    //[DataContract(IsReference = true)]
    public class UserBL
    {
        //[DataMember]
        public int Id { get; set; }
        //[DataMember]
        public string FirstName { get; set; }
        //[DataMember]
        public string LastName { get; set; }
       // [DataMember]
        public string NickName { get; set; }
        //[DataMember]
        public int Age { get; set; }

        public IEnumerable<CommentBL> Comments { get; set; }
        [DataMember]
        public IEnumerable<ArticleBL> Articles { get; set; }
    }
}

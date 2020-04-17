using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Web_Api.Models
{
    [DataContract(IsReference = true)]
    public class UserApiModel
    {
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string NickName { get; set; }
        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public IEnumerable<ArticleApiModel> Articles { get; set; }
        //[DataMember]
        public IEnumerable<CommentApiModel> Comments { get; set; }

    }
}
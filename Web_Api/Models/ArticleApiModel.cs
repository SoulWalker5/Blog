using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Web_Api.Models
{
    [DataContract(IsReference = true)]
    public class ArticleApiModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public UserApiModel User { get; set; }
        [DataMember]
        public CategoryApiModel Category { get; set; }

        //[DataMember]
        public IEnumerable<CommentApiModel> Comments { get; set; }

    }
}
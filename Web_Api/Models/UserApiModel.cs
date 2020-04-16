using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api.Models
{
    public class UserApiModel
    {
        public int Id { get; set; }

        //[Required]
        public string FirstName { get; set; }
        //[Required]
        public string LastName { get; set; }
        //[Required]
        public string NickName { get; set; }
        //[Required]
        public int Age { get; set; }
    }
}
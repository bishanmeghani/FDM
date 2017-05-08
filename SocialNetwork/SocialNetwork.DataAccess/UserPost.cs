﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DataAccess
{
    [DataContract]
    public class UserPost : Post
    {
        public User user { get; set; }

        public UserPost() : base() { }

        public override string ToString()
        {
            return time.ToShortDateString() + "-" + postId + "-" + title + "-" + 
                content + "-" + language + "-[User: " + user.ToString() + "]";
        }
    }
}

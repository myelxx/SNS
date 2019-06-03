
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Post : EntityBaseClass
    {
        public int PostId { get; set; }

        public int UserId { get; set; }

        public string PostDetails { get; set; }

        public DateTime DateTimeCreated { get; set; }

    }
}

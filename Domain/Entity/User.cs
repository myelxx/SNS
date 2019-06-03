using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class User : EntityBaseClass
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public DateTime DateTimeCreated { get; set; }

    }
}

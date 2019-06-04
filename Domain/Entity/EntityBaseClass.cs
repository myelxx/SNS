using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class EntityBaseClass 
    {
        //public int UserId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateTimeCreated { get; set; }

    }
}

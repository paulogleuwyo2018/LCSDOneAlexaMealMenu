using System;
using System.Collections.Generic;
using System.Text;

namespace LCSDOneLunch.Entity
{
    public class SchoolDistirict : BaseEntity
    {
        public string Title { get; set; }
        public virtual ICollection <School> Schools { get; set; }
    }
}

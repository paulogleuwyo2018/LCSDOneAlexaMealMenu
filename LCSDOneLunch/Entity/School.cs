using System;
using System.Collections.Generic;
using System.Text;

namespace LCSDOneLunch.Entity
{
    public class School : BaseEntity
    {
        public string Title { get; set; }
        public virtual SchoolDistirict SchoolDistirict { get; set; }
        public SchoolType SchoolType { get; set; }
    }
}

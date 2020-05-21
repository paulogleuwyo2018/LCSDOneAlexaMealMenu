using System;
using System.Collections.Generic;
using System.Text;

namespace LCSDOneLunch.Entity
{
    public class SchoolMeal : BaseEntity
    {
        public virtual School School { get; set; }
        public virtual Meal Meal { get; set; }
    }
}

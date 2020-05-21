using System;
using System.Collections.Generic;
using System.Text;

namespace LCSDOneLunch.Entity
{
    public class MealSide : BaseEntity
    {
        public virtual Meal Meal { get; set; }
        public virtual Side Side { get; set; }
    }
}

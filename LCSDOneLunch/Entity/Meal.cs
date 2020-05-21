using System;
using System.Collections.Generic;
using System.Text;

namespace LCSDOneLunch.Entity
{
    public class Meal : BaseEntity
    {
        public string Description { get; set; }
        public DateTime MealDate { get; set; }
        public virtual MealType MealType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace LCSDOneLunch.Entity
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        public long ID { get; set; }
        public DateTime CreateDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LCSDOneLunch.Entity
{
    public interface IBaseEntity
    {
        long ID { get; set; }
        DateTime CreateDate { get; set; }
    }
}

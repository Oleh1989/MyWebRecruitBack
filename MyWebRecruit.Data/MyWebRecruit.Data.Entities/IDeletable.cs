using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Data.MyWebRecruit.Data.Entities
{
    public interface IDeletable
    {
        public bool IsDeleted { get; set; }
    }
}

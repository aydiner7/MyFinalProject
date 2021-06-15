using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // classları mutlaka inheritance veya interface lerle implement et
    // classları çıplak bırakmamaya çalış.

    public class Category : IEntity
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}

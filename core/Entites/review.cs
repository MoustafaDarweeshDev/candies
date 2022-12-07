using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Entites
{
    public class review: BaseEntity
    {
        public string details { get; set; }
        public string rate { get; set; }

        public Customer Customer { get; set; }


    }
}

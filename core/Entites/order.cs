using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Entites
{
    public class order: BaseEntity
    {
        public DateTime orderDateTime { get; set; }
        public int totalPrice { get; set; }
        public int orderStatus { get; set; }
        public Product Product { get; set; }

        public Customer Customer { get; set; }

    }
}

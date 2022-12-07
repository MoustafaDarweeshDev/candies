using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Entites
{
    public class Customer:BaseEntity
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
        public string email { get; set; }




        public Customer()
        {
            reviews = new HashSet<review>();
            orders = new HashSet<order>();
            Products = new HashSet<Product>();
        }
        public ICollection<review> reviews { get; set; }

        public ICollection<order> orders { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}

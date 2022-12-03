using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Entites
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public int Rate{ get; set; }
        public decimal Price { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }

    }
}

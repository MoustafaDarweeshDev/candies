using core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Specifications
{
    public class ProductWithTypesSpecifications : BaseSpecification<Product>
    {
        public ProductWithTypesSpecifications()
        {
            AddInclude(o => o.ProductType);
        }


        public ProductWithTypesSpecifications(int id):base(o=>o.Id == id)
        {
            AddInclude(o=>o.ProductType);
        }
    }
}

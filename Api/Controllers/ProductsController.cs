using core.Entites;
using core.Interfaces;
using core.Specifications;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IGenericRepository<Product> productRepo;
        private readonly IGenericRepository<ProductType> typeRepo;

        public ProductsController(IGenericRepository<Product> productRepo, IGenericRepository<ProductType> typeRepo)
        {
            this.productRepo = productRepo;
            this.typeRepo = typeRepo;
        }

        //[HttpGet]
        //public async Task<IReadOnlyList<Product>> GetAllProducts()
        //{
        //    return await productRepo.ListAllAsync();
        //}

        //[HttpGet("{id}")]
        //public async Task<Product> GetProduct(int id)
        //{
        //    return await productRepo.GetByIdAsync(id);
        //}

        //[HttpGet("types")]
        //public async Task<IReadOnlyList<ProductType>> GetAllProductsTypes()
        //{
        //    return await typeRepo.ListAllAsync();
        //}

        [HttpGet("sec")]
        public async Task<IReadOnlyList<Product>> GetAllProducts()
        {

            var productSpec = new ProductWithTypesSpecifications();

            return await productRepo.ListAllAsyncWithSpec(productSpec);
        }

        //[HttpGet("{id}")]
        //public async Task<Product> GetProduct(int id)
        //{
        //    var productSpec = new ProductWithTypesSpecifications(id);
        //    var product = await productRepo.ListAllAsyncWithSpec(productSpec);

        //    return product;
        //}


    }
}

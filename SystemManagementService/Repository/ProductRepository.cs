using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemManagementService.Context;
using SystemManagementService.Models;

namespace SystemManagementService.Repository
{
    public class ProductRepository
    {
        private readonly ProductContext _productContext = null;

        public ProductRepository(ProductContext context)
        {
            _productContext = context;
        }

        //add product data to database
        public string AddProduct(Product product)
        {
            var newProduct = new Product()
            {
                ProductNumber = product.ProductNumber,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription
            };

            _productContext.products.Add(newProduct);
            _productContext.SaveChanges();

            return newProduct.ProductId;
        }
    }
}
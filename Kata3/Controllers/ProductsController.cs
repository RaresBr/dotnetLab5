using System;
using System.Collections.Generic;
using Data.Domain;
using Kata3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kata3.Controllers
{   
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _repo.GetAll();
        }

        [HttpGet("{id}")]
        public Product Get(Guid id)
        {
            return _repo.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]CreateProductModel product)
        {
            var createproduct = Product.Create(product.Description, product.Price);
            _repo.Add(createproduct);
        }
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]UpdateProductModel product)
        {
            var entity = _repo.GetById(id);
            entity.Update(product.Description, product.Price);
            // magic
            _repo.Edit(entity);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repo.Delete(id);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Data.Domain;
using Data.Persistence;

namespace Business.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly IDatabaseService _databaseService;

        public ProductRepository(IDatabaseService dbserv)
        {
            _databaseService = dbserv;
        }

        public void Add(Product product)
        {
            _databaseService.Products.Add(product);
            _databaseService.SaveChanges();
        }

        public void Edit(Product product)
        {
            _databaseService.Products.Update(product);
            _databaseService.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var product = GetById(id);
            _databaseService.Products.Remove(product);
            _databaseService.SaveChanges();
        }

        public IReadOnlyList<Product> GetAll()
        {
            return _databaseService.Products.ToList();
        }

        public Product GetById(Guid id)
        {
            return _databaseService.Products.FirstOrDefault(x => x.Id == id);
        }
    }
}

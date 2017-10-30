using System;
using System.Collections.Generic;

namespace Data.Domain
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Edit(Product product);
        void Delete(Guid id);
        IReadOnlyList<Product> GetAll();
        Product GetById(Guid id);

    }
}

using System;

namespace Data.Domain
{
    public class Product
    {
        private Product()
        {
            // EF Core
        }

        public Guid Id { get; private set; }

        public string Description { get; private set; }

        public int Price { get; private set; }

        public static Product Create(string description, int price)
        {
            var instance = new Product { Id = Guid.NewGuid() };
            instance.Update(description, price);
            return instance;
        }

        public void Update(string description, int price)
        {
            Description = description;
            Price = price;
        }
    }
}

using System;

namespace Kata3.Models
{
    public class UpdateProductModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }
    }
}

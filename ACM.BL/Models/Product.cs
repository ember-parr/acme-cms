using System;
using ACM.BL.Models;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        public override string ToString() => ProductName;

        public override bool Validate()
        {
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                return false;
            }
            else if (CurrentPrice == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}

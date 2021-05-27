using System;
using ACM.BL.Models;
using Acme.Common.Methods;

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

        public override string ToString() => ProductName;

        private string _productName;
        public string ProductName
        {
            get
            {
                var stringHandler = new StringHandler();
                return stringHandler.TitleCase(_productName);
            }
            set
            {
                _productName = value;
            }
        }

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

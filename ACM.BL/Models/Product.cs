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

        /// <summary>
        /// prints product name
        /// </summary>
        /// <returns></returns>
        public override string ToString() => ProductName;

        private string _productName;

        /// <summary>
        /// GET formats name in title casing
        /// </summary>
        public string ProductName
        {
            get
            {
                return _productName.TitleCase();
            }
            set
            {
                _productName = value;
            }
        }

        /// <summary>
        /// checks for existing product name and current price
        /// </summary>
        /// <returns></returns>
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

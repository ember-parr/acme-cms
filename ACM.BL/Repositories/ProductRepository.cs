using System;
namespace ACM.BL.Repositories
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            // HARD CODING DATA -- NO DATA ACCESS LAYER IN THIS PROJECT
            if (productId == 2)
            {
                product.CurrentPrice = 20.43M;
                product.ProductDescription = "silky smooth";
                product.ProductName = "Shoe Laces";
            }
            Object myObject = new object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        public bool Save(Product product)
        {
            // HARD CODED DATA
            // NO DATA ACCESS LAYER IN THIS PROJECT
            if (product != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

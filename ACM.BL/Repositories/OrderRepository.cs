using System;
namespace ACM.BL.Repositories
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            Console.WriteLine($"Order: {order.ToString()}");
            return order;
        }

        public bool Save(Order order)
        {
            var success = true;
            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {
                        // CALL AN INSERT STORED PROCEDURE
                    }
                    else
                    {
                        // CALL AN UPDATE STORED PROCEDURE
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}

using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Order() : this(0)
        {
        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public override string ToString()
        {
            return $"{OrderDate.Value.Date} ({OrderId})";
        }

        public bool Validate()
        {
            if (OrderDate == null)
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

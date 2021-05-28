using System; 
using System.Collections.Generic;
using ACM.BL.Models;
using Acme.Common;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
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

        public string Log() => $"{OrderId}: Date: {this.OrderDate.Value.Date} Status: {EntityState.ToString()}";

        /// <summary>
        /// Prints order date & order ID
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Order #:({OrderId}) placed on:{OrderDate.Value.Date}";
        }

        /// <summary>
        /// Checks for existing order date
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
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

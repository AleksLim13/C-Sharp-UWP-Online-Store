using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    abstract class Abstract_Order
    {
        private static List<Abstract_Order> orderList;
        private static int idCount;

        public Abstract_Order()
        {
        
        }//End C:*

        public Abstract_Order(int customerOrderId, int customerId, string product, int quantity, string size, double price)
        {
            CustomerOrderId = customerOrderId;
            CustomerId = customerId;
            Product = product;
            Quantity = quantity;
            Size = size;
            Price = price;
        }//End C:*

        internal List<Abstract_Order> OrderList { get => orderList; set => orderList = value; }
        
        public int CustomerOrderId { get; set; }

        public int CustomerId { get; set; }

        public string Product { get; set; }

        public int Quantity { get; set; }

        public string Size { get; set; }

        public double Price { get; set; }
        public static int IdCount { get => idCount; set => idCount = value; }

        public abstract string Print();

    }//End CL:*

}//End NS:*

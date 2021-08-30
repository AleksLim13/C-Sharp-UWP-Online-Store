using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    class PapaDarios_Order : Abstract_Order
    {
        public PapaDarios_Order()
        {
        }//End C:*

        public PapaDarios_Order(int customerOrderId, int customerId, string product, int quantity, string size, double price) : base(customerOrderId, customerId, product, quantity, size, price)
        {

        }//End C:*

        public override string Print()
        {
            return 
                   "Order Summary\n" +
                   "Customer Order Id: " + CustomerOrderId + ",\n" +
                   "Customer Id: " + CustomerId + ",\n" + 
                   "Product: " + Product + ",\n" + 
                   "Quantity: " + Quantity + ",\n" + 
                   "Size: " + Size + ",\n" + 
                   "Price: " + Price;

        }//End M:*

    }//End CL:*

}//End NS:*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    abstract class Abstract_CustomerOrderSql
    {
        private string cString;

        public string CString { get => cString; set => cString = value; }

        public Abstract_CustomerOrderSql(string cString)
        {
            CString = cString;
        }//End C:*

        public abstract IList<Abstract_Order> GetOrderList();
        public abstract IList<Abstract_Order> GetOrderById(int orderId);
        public abstract void  UpdatePrice(int orderId, double price);
        public abstract void UpdateProduct(int orderId, string product);
        public abstract void UpdateQuantity(int orderId, int quantity);
        public abstract void UpdateSize(int orderId, string size);
        public abstract void DeleteOrder(int orderId);
        public abstract IList<Abstract_User> GetUserList();
        public abstract IList<Abstract_User> GetUserById(int customerId);
        public abstract void UpdateName(string newName, int targetId);
        public abstract void UpdateEmail(string newEmail, int targetId);
        public abstract void UpdatePassword(string newPassword, int targetId);
        public abstract void UpdateUserName(string newUN, int targetId);
        public abstract void DeleteUser(int customerId);

        public abstract string ReadOrderById(int targetId);
        public abstract string ReadCustomerById(int targetId);
        public abstract  string PrintAllOrders();
        public abstract string PrintAllUsers();

        public abstract void InsertIntoCustomerOrder(int customerOrderId, int customerId, string product, int quantity, string size, double price);
        
        public abstract void InsertIntoCustomer(int customerId, string name, string userName, string email, string password);

        public abstract IList<Abstract_User> GetLastCustomer();

        public abstract IList<Abstract_Order> GetLastOrder();

    }//End C:*

}//End NS:*

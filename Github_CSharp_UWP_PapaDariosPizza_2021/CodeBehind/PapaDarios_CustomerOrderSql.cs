using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    class PapaDarios_CustomerOrderSql : Abstract_CustomerOrderSql
    {
        private string cString;

        public string CString1 { get => cString; set => cString = value; }

        public PapaDarios_CustomerOrderSql(string cString) : base(cString)
        {

        }//End C:*

        public override IList<Abstract_Order> GetOrderList() {

            List<Abstract_Order> codmList = new List<Abstract_Order>();

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();
                //SELECT CustomerOrderId, CustomerId, FirstName, LastName, [Description], Price FROM CustomerOrderDetail
                using (SqlCommand commannd = new SqlCommand(@"SELECT * from dbo.CustomerOrder", conn))
                {
                    using (SqlDataReader reader = commannd.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {

                                Abstract_Order codm2 = new PapaDarios_Order()
                                {
                                    CustomerOrderId = Convert.ToInt32(reader["CustomerOrderId"]),
                                    CustomerId = Convert.ToInt32(reader["CustomerId"]),
                                    Product = reader["Product"].ToString(),
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    Size = reader["Size"].ToString(),
                                    Price = Convert.ToDouble(reader["Price"])


                                };


                                codmList.Add(codm2);

                            }//End W:*

                        }//End I:*

                    }//End U:*

                }//End U:*

            }//End U:*
            return codmList;
        }//End M:*


        public override IList<Abstract_User> GetUserList()
        {

            List<Abstract_User> codmList = new List<Abstract_User>();

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                using (SqlCommand commannd = new SqlCommand(@"SELECT * from dbo.Customer", conn))
                {
                    using (SqlDataReader reader = commannd.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {

                                Abstract_User codm2 = new PapaDarios_User_Customer()
                                {
                                    Id = Convert.ToInt32(reader["CustomerId"]),
                                    Name = reader["CustomerName"].ToString(),
                                    UserName = reader["CustomerUserName"].ToString(),
                                    Email = reader["CustomerEmail"].ToString(),
                                    Password = reader["CustomerPassword"].ToString(),


                                };


                                codmList.Add(codm2);

                            }//End W:*

                        }//End I:*

                    }//End U:*

                }//End U:*

            }//End U:*
            return codmList;
        }//End M:*

        public override IList<Abstract_Order> GetOrderById(int orderId) {

            List<Abstract_Order> codmList = new List<Abstract_Order>();

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                using (SqlCommand commannd = new SqlCommand(@"SELECT * from dbo.CustomerOrder where CustomerOrderId = @orderId", conn))
                {
                    commannd.Parameters.Add("@orderId", SqlDbType.VarChar).Value = orderId;

                    using (SqlDataReader reader = commannd.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {

                                Abstract_Order codm2 = new PapaDarios_Order()
                                {
                                    CustomerOrderId = Convert.ToInt32(reader["CustomerOrderId"]),
                                    CustomerId = Convert.ToInt32(reader["CustomerId"]),
                                    Product = reader["Product"].ToString(),
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    Size = reader["Size"].ToString(),
                                    Price = Convert.ToDouble(reader["Price"]),

                                };


                                codmList.Add(codm2);

                            }//End W:*

                        }//End I:*

                    }//End U:*

                }//End U:*

            }//End U:*
            return codmList;
        }//End M:*

        public override void UpdatePrice(int orderId, double price) {

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();
                //SELECT CustomerOrderId, CustomerId, FirstName, LastName, [Description], Price FROM CustomerOrderDetail

                using (SqlCommand commannd = new SqlCommand(@"update dbo.CustomerOrderDetail set Price = @price where CustomerOrderId = @orderId", conn))
                {

                    commannd.Parameters.Add("@price", SqlDbType.VarChar).Value = price;
                    commannd.Parameters.Add("@orderId", SqlDbType.VarChar).Value = orderId;

                    SqlDataReader reader = commannd.ExecuteReader();

                }//End U:*

            }//End U:*

        }//End M:*
        public override void UpdateProduct(int orderId, string product) {

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                //SELECT CustomerOrderId, CustomerId, FirstName, LastName, [Description], Price FROM CustomerOrderDetail

                using (SqlCommand commannd = new SqlCommand(@"update dbo.CustomerOrder set Product = @product where CustomerOrderId = @orderId", conn))
                {

                    commannd.Parameters.Add("@product", SqlDbType.VarChar).Value = product;
                    commannd.Parameters.Add("@orderId", SqlDbType.VarChar).Value = orderId;

                    SqlDataReader reader = commannd.ExecuteReader();

                }//End U:*

            }//End U:*

        }//End M:*

        public override void UpdateQuantity(int orderId, int quantity) {

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                //SELECT CustomerOrderId, CustomerId, FirstName, LastName, [Description], Price FROM CustomerOrderDetail

                using (SqlCommand commannd = new SqlCommand(@"update dbo.CustomerOrder set Quantity = @quantity where CustomerOrderId = @orderId", conn))
                {

                    commannd.Parameters.Add("@quantity", SqlDbType.VarChar).Value = quantity;
                    commannd.Parameters.Add("@orderId", SqlDbType.VarChar).Value = orderId;

                    SqlDataReader reader = commannd.ExecuteReader();

                }//End U:*

            }//End U:*

        }//End M:*

        public override void UpdateSize(int orderId, string size) {

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                using (SqlCommand commannd = new SqlCommand(@"update dbo.CustomerOrder set Size = @size where CustomerOrderId = @orderId", conn))
                {

                    commannd.Parameters.Add("@size", SqlDbType.VarChar).Value = size;
                    commannd.Parameters.Add("@orderId", SqlDbType.VarChar).Value = orderId;

                    SqlDataReader reader = commannd.ExecuteReader();

                }//End U:*

            }//End U:*

        }//End M:*

        public override void DeleteOrder(int orderId) {

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                using (SqlCommand commannd = new SqlCommand(@"delete from dbo.CustomerOrder where CustomerOrderId = @orderId", conn))
                {


                    commannd.Parameters.Add("@orderId", SqlDbType.VarChar).Value = orderId;

                    SqlDataReader reader = commannd.ExecuteReader();

                }//End U:*

            }//End U:*
        }//End M:*
       

        public override IList<Abstract_User> GetUserById(int customerId) {

            List<Abstract_User> codmList = new List<Abstract_User>();

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                //SELECT CustomerOrderId, CustomerId, FirstName, LastName, [Description], Price FROM CustomerOrderDetail
                using (SqlCommand commannd = new SqlCommand(@"SELECT * from dbo.Customer where CustomerId = @customerId", conn))
                {
                    commannd.Parameters.Add("@customerId", SqlDbType.VarChar).Value = customerId;

                    using (SqlDataReader reader = commannd.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {

                                Abstract_User codm2 = new PapaDarios_User_Customer()
                                {
                                    Id = Convert.ToInt32(reader["CustomerId"]),
                                    Name = reader["CustomerName"].ToString(),
                                    UserName = reader["CustomerUserName"].ToString(),
                                    Email = reader["CustomerEmail"].ToString(),
                                    Password = reader["CustomerPassword"].ToString(),

                                };

                                codmList.Add(codm2);

                            }//End W:*

                        }//End I:*

                    }//End U:*

                }//End U:*

            }//End U:*
            return codmList;
        }//End M:*

        public override void UpdateName(string newName, int targetId) {
           

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();
                //SELECT CustomerOrderId, CustomerId, FirstName, LastName, [Description], Price FROM CustomerOrderDetail

                using (SqlCommand commannd = new SqlCommand(@"update dbo.Customer set CustomerName = @newName where CustomerId = @targetId", conn))
                {

                    commannd.Parameters.Add("@newName", SqlDbType.VarChar).Value = newName;
                    commannd.Parameters.Add("@targetId", SqlDbType.VarChar).Value = targetId;

                    SqlDataReader reader = commannd.ExecuteReader();

                }//End U:*

            }//End U:*
          
        }//End M:*

        public override void UpdateEmail(string newEmail, int targetId) {

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                using (SqlCommand commannd = new SqlCommand(@"update dbo.Customer set CustomerEmail = @newEmail where CustomerId = @targetId", conn))
                {

                    commannd.Parameters.Add("@newEmail", SqlDbType.VarChar).Value = newEmail;

                    commannd.Parameters.Add("@targetId", SqlDbType.VarChar).Value = targetId;

                    SqlDataReader reader = commannd.ExecuteReader();

                }//End U:*

            }//End U:*
        }//End M:*
        public override void UpdatePassword(string newPassword, int targetId) {

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                using (SqlCommand commannd = new SqlCommand(@"update dbo.Customer set Password = @newPassword where CustomerId = @targetId", conn))
                {

                    commannd.Parameters.Add("@newPassword", SqlDbType.VarChar).Value = newPassword;
                    commannd.Parameters.Add("@targetId", SqlDbType.VarChar).Value = targetId;

                    SqlDataReader reader = commannd.ExecuteReader();

                }//End U:*

            }//End U:*

        }//End M:*

        public override void UpdateUserName(string newUN, int targetId) {

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();
                //SELECT CustomerOrderId, CustomerId, FirstName, LastName, [Description], Price FROM CustomerOrderDetail

                using (SqlCommand commannd = new SqlCommand(@"update dbo.Customer set CustomerUserName = @newUN where CustomerOrderId = @targetId", conn))
                {

                    commannd.Parameters.Add("@newUN", SqlDbType.VarChar).Value = newUN;
                    commannd.Parameters.Add("@targetId", SqlDbType.VarChar).Value = targetId;

                    SqlDataReader reader = commannd.ExecuteReader();

                }//End U:*

            }//End U:*

        }//End M:*
        public override void DeleteUser(int customerId) {

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                using (SqlCommand commannd = new SqlCommand(@"delete from dbo.Customer where CustomerId = @customerId", conn))
                {

                    commannd.Parameters.Add("@customerId", SqlDbType.VarChar).Value = customerId;

                    SqlDataReader reader = commannd.ExecuteReader();

                }//End U:*

            }//End U:*

        }//End M:*

        public override string ReadOrderById(int targetId)
        {
            string result = "";

            Abstract_CustomerOrderSql codc = new PapaDarios_CustomerOrderSql(@"Data Source=.\;Initial Catalog=Spring2021Exam;Integrated Security=True");

            IList<Abstract_Order> codmList = codc.GetOrderById(targetId);

            if (codmList.Any())
            {
                Console.WriteLine("CustomerOrderId, CustomerId, Product, Quantity, Price FROM CustomerOrder");

                foreach (Abstract_Order locCodm in codmList)
                {
                    result +=
                                      locCodm.CustomerOrderId.ToString() + " " +
                                      locCodm.CustomerId.ToString() + " " +
                                      locCodm.Product.ToString() + " " +
                                      locCodm.Quantity.ToString() + " " +
                                      locCodm.Price.ToString() + ",\n\n";

                }//End FE:*

                return result;

            }//End I:*
            return null;
        }//End M:*

        public override string ReadCustomerById(int targetId)
        {

           
                string result = "";

                Abstract_CustomerOrderSql codc = new PapaDarios_CustomerOrderSql(@"Data Source=.\;Initial Catalog=Spring2021Exam;Integrated Security=True");

                IList<Abstract_User> codmList = codc.GetUserById(targetId);

                if (codmList.Any())
                {
                    Console.WriteLine("CustomerId, CustomerName, CustomerUserName, CustomerEmail, CustomerPassword FROM Customer");

                    foreach (Abstract_User locCodm in codmList)
                    {
                        result +=
                                          locCodm.Id.ToString() + " " +
                                          locCodm.Name.ToString() + " " +
                                          locCodm.UserName.ToString() + " " +
                                          locCodm.Email.ToString() + " " +
                                          locCodm.Password.ToString() + ",\n\n";

                    }//End FE:*
                    return result;

                }//End I:*
                return null;

        }//End M:*

        public override string PrintAllOrders()
        {
            string result = "";

            Abstract_CustomerOrderSql codc = new PapaDarios_CustomerOrderSql(@"Data Source=.\;Initial Catalog=Spring2021Exam;Integrated Security=True");

            IList<Abstract_Order> codmList = codc.GetOrderList();

            if (codmList.Any())
            {
                Console.WriteLine("CustomerOrderId, CustomerId, Product, Quantity, [Size], Price FROM CustomerOrder");

                foreach (Abstract_Order locCodm in codmList)
                {
                    result +=
                                      locCodm.CustomerOrderId.ToString() + " " +
                                      locCodm.CustomerId.ToString() + " " +
                                      locCodm.Product.ToString() + " " +
                                      locCodm.Quantity.ToString() + " " +
                                      locCodm.Size.ToString() + " " +
                                      locCodm.Price.ToString() + ",\n\n";

                }//End FE:*
                return result;
            }//End I:*
            return null;
        }//End M:*

        public override string PrintAllUsers()
        {
            string result = "";

            Abstract_CustomerOrderSql codc = new PapaDarios_CustomerOrderSql(@"Data Source=.\;Initial Catalog=Spring2021Exam;Integrated Security=True");

            IList<Abstract_User> codmList = codc.GetUserList();

            if (codmList.Any())
            {
                Console.WriteLine("CustomerOrderId, CustomerId, Product, Quantity, [Size], Price FROM CustomerOrder");

                foreach (Abstract_User locCodm in codmList)
                {
                    result +=
                                      locCodm.Id.ToString() + " " +
                                      locCodm.Name.ToString() + " " +
                                      locCodm.UserName.ToString() + " " +
                                      locCodm.Email.ToString() + " " +
                                      locCodm.Password.ToString() + ",\n\n";

                }//End FE:*
                return result;
            }//End I:*


            return null;
        }//End M:*

        public override void InsertIntoCustomerOrder(int customerOrderId, int customerId, string product, int quantity, string size, double price)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                using (SqlCommand commannd = new SqlCommand(@"insert into dbo.CustomerOrder (CustomerOrderId, CustomerId, Product, Quantity, Size, Price) values (@customerOrderId, @customerId, @product, @quantity, @size, @price)", conn))
                {

                    commannd.Parameters.Add("@customerOrderId", SqlDbType.VarChar).Value = customerOrderId;
                    commannd.Parameters.Add("@customerId", SqlDbType.VarChar).Value = customerId;
                    commannd.Parameters.Add("@product", SqlDbType.VarChar).Value = product;
                    commannd.Parameters.Add("@quantity", SqlDbType.VarChar).Value = quantity;
                    commannd.Parameters.Add("@size", SqlDbType.VarChar).Value = size;
                    commannd.Parameters.Add("@price", SqlDbType.VarChar).Value = price;

                    SqlDataReader reader = commannd.ExecuteReader();

                }//End U:*

            }//End U:*
        }//End M:*

        public override void InsertIntoCustomer(int customerId, string name, string userName, string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                using (SqlCommand commannd = new SqlCommand(@"insert into dbo.Customer (CustomerId, CustomerName, CustomerUserName, CustomerEmail, CustomerPassword) values (@customerId, @name, @userName, @email, @password)", conn))
                {

                    commannd.Parameters.Add("@customerId", SqlDbType.VarChar).Value = customerId;
                    commannd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    commannd.Parameters.Add("@userName", SqlDbType.VarChar).Value = userName;
                    commannd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    commannd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;


                    SqlDataReader reader = commannd.ExecuteReader();

                }//End U:*

            }//End U:*
        }//End M:*

        public override IList<Abstract_User> GetLastCustomer()
        {

            List<Abstract_User> codmList = new List<Abstract_User>();

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                //SELECT CustomerOrderId, CustomerId, FirstName, LastName, [Description], Price FROM CustomerOrderDetail
                using (SqlCommand commannd = new SqlCommand(@"SELECT TOP 1 * FROM dbo.Customer ORDER BY CustomerId DESC", conn))
                {


                    using (SqlDataReader reader = commannd.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {

                                Abstract_User codm2 = new PapaDarios_User_Customer()
                                {
                                    Id = Convert.ToInt32(reader["CustomerId"]),
                                    Name = reader["CustomerName"].ToString(),
                                    UserName = reader["CustomerUserName"].ToString(),
                                    Email = reader["CustomerEmail"].ToString(),
                                    Password = reader["CustomerPassword"].ToString(),

                                };

                                codmList.Add(codm2);

                            }//End W:*

                        }//End I:*

                    }//End U:*

                }//End U:*

            }//End U:*

            return codmList;

        }//End M:*

        public override IList<Abstract_Order> GetLastOrder()
        {
            List<Abstract_Order> codmList = new List<Abstract_Order>();

            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();

                using (SqlCommand commannd = new SqlCommand(@"SELECT TOP 1 * FROM dbo.CustomerOrder ORDER BY CustomerOrderId DESC", conn))
                {


                    using (SqlDataReader reader = commannd.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {

                                Abstract_Order codm2 = new PapaDarios_Order()
                                {
                                    CustomerOrderId = Convert.ToInt32(reader["CustomerOrderId"]),
                                    CustomerId = Convert.ToInt32(reader["CustomerId"]),
                                    Product = reader["Product"].ToString(),
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    Size = reader["Size"].ToString(),
                                    Price = Convert.ToDouble(reader["Price"]),

                                };


                                codmList.Add(codm2);

                            }//End W:*

                        }//End I:*

                    }//End U:*

                }//End U:*

            }//End U:*
            return codmList;
        }//End M:*

    }//End CL:*

}//End NS:*

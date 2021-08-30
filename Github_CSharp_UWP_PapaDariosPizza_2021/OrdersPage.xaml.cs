using PapaDariosPizza.CodeBehind;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PapaDariosPizza
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrdersPage : Page
    {

        private static Abstract_Order orderManager;
        private static bool varOrderManagerSetup;
        private static bool varOrderListSetup;
        private static int orderCount; 
        

        public OrdersPage()
        {
            this.InitializeComponent();

            if (SignInPage.SignIn != null &&  SignInPage.SignIn.CurrentUser != null) {
                SignedInBox.Text = "Current User: " + SignInPage.SignIn.CurrentUser.Name;
            }//End I:*

            if (orderManager != null && orderManager.OrderList.Count != 0) {
                OrderCountBox.Text = "Order Count: " + orderCount.ToString();
            }//End I:*
            

            if (varOrderManagerSetup == false)
            {
                SetOrderManagerBtn.Visibility = Visibility.Visible;
            }//End I:*
            else {
                SetOrderManagerBtn.Visibility = Visibility.Collapsed;
            }//End E:*

            if (varOrderListSetup == false)
            {
                SetOrderListBtn.Visibility = Visibility.Visible;
            }//End I:*
            else {
                SetOrderListBtn.Visibility = Visibility.Collapsed;
            }//End E:*

        }//End C:*

        public static void ReadLastOrderRun()
        {
            try
            {

                Abstract_CustomerOrderSql codc = new PapaDarios_CustomerOrderSql(@"Data Source=.\;Initial Catalog=Spring2021Exam;Integrated Security=True");

                IList<Abstract_Order> codmList = codc.GetLastOrder();

                if (codmList.Any())
                {
                    Console.WriteLine("CustomerOrderId, CustomerId, Product, Quantity, Price FROM CustomerOrder");

                    foreach (Abstract_Order locCodm in codmList)
                    {
                        Console.WriteLine(
                                          locCodm.CustomerOrderId + " " +
                                          locCodm.CustomerId + " " +
                                          locCodm.Product + " " +
                                          locCodm.Quantity + " " +
                                          locCodm.Price
                                          );
                    }//End FE:*

                }//End I:*

            }//End TRY:*

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }//End CAT:*

        }//End M:*

        public void InsertCustomerOrder(int orderId, int customerId, string product, int quantity, string size, double price)
        {
            try
            {

                Abstract_CustomerOrderSql codc = new PapaDarios_CustomerOrderSql(@"Data Source=.\;Initial Catalog=Spring2021Exam;Integrated Security=SSPI");

                codc.InsertIntoCustomerOrder(orderId, customerId, product, quantity, size, price);

            }//End TRY:*

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }//End CAT:*

        }//End M:*

        public static int OrderCount { get => orderCount; set => orderCount = value; }
        internal static Abstract_Order OrderManager { get => orderManager; set => orderManager = value; }
        public static bool VarOrderManagerSetup { get => varOrderManagerSetup; set => varOrderManagerSetup = value; }
        public static bool VarOrderListSetup { get => varOrderListSetup; set => varOrderListSetup = value; }
        public static int OrderCount1 { get => orderCount; set => orderCount = value; }

        public void HomeBtn_Click(Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }//End M


        public void RefreshBtn_Click(Object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OrdersPage));
        }//End M:*

        public void SetOrderManagerBtn_Click(Object sender, RoutedEventArgs e)
        {
            orderManager = new PapaDarios_Order();
            varOrderManagerSetup = true;
            SetOrderManagerBtn.Visibility = Visibility.Collapsed;
        }//End M:*

        public void SetOrderListBtn_Click(Object sender, RoutedEventArgs e)
        {
            if (orderManager != null) {
                orderManager.OrderList = new List<Abstract_Order>();
                varOrderListSetup = true;
                SetOrderListBtn.Visibility = Visibility.Collapsed;
            }//End I:*
            
        }//End M:*

        public void OrderBtn_Click(Object sender, RoutedEventArgs e)
        {

            //Note: Checking for pizza selections 
            try {

                if (SignInPage.SignIn.CurrentUser != null &&
                    varOrderManagerSetup == true &&
                    varOrderListSetup == true) {

                  

                    List<String> strOrderList = new List<string>();

                    if (PizzaBox.SelectedIndex == 0)
                    {
                   
                        strOrderList.Add("Pizza Type:Pepperoni");
                     
                    }//End I:*


                    if (PizzaBox.SelectedIndex == 1)
                    {
                        
                        strOrderList.Add("Pizza Type:Cheese");
                        
                    }//End I:*

                    if (PizzaBox.SelectedIndex == 2)
                    {
                        
                        strOrderList.Add("Pizza Type:Veggie");
                    
                    }//End I:*

                    if (PizzaBox.SelectedIndex == 3)
                    {
                     
                        strOrderList.Add("Pizza Type:Canadian");
                        
                    }//End I:*


                    //Note: Checking for pizza sizes now
                    if (PizzaSizeBox.SelectedIndex == 0)
                    {
                      
                        strOrderList.Add("Pizza Size:Small");
                   
                    }//End I:*

                    if (PizzaSizeBox.SelectedIndex == 1)
                    {
                      
                        strOrderList.Add("Pizza Size:Medium");
                   
                    }//End I:*

                    if (PizzaSizeBox.SelectedIndex == 2)
                    {
                      
                        strOrderList.Add("Pizza Size:Large");
                     
                    }//End I:*


                    if (PizzaAmountBox.Text != "")
                    {
                        strOrderList.Add("Pizza Amount:" + PizzaAmountBox.Text);
                        int iAmount = Convert.ToInt32(PizzaAmountBox.Text);
                   
                        
                    }//End I:*


                    //Note: Checking for drink selections
                    if (DrinkBox.SelectedIndex == 0)
                    {
                    
                        strOrderList.Add("Drink Type:Coke");
                     
                    }//End I:*

                    if (DrinkBox.SelectedIndex == 1)
                    {
                      
                        strOrderList.Add("Drink Type:Diet Coke");
                      
                    }//End I:*

                    if (DrinkBox.SelectedIndex == 2)
                    {
                     
                        strOrderList.Add("Drink Type:7 Up");
                      
                    }//End I:*

                    if (DrinkBox.SelectedIndex == 3)
                    {
                   
                        strOrderList.Add("Drink Type:Ginger Ale");
                    
                    }//End I:*

                    //Note: Checking for drinks sizes now
                    if (DrinkSizeBox.SelectedIndex == 0)
                    {
                      
                        strOrderList.Add("Drink Size:Small");
                    
                    }//End I:*

                    if (DrinkSizeBox.SelectedIndex == 1)
                    {
                     
                        strOrderList.Add("Drink Size:Medium");
                     
                    }//End I:*

                    if (DrinkSizeBox.SelectedIndex == 2)
                    {
                        
                        strOrderList.Add("Drink Size:Large");
                    
                    }//End I:*

                    if (DrinkAmountBox.Text != "")
                    {
                        strOrderList.Add("Drink Amount:" + DrinkAmountBox.Text);
                    
                    }//End I:*


                    //Note: Checking for sanwich selections

                    if (SandwichBox.SelectedIndex == 0)
                    {
                       
                        strOrderList.Add("Sandwich Type:Chicken");
                   
                    }//End I:*

                    if (SandwichBox.SelectedIndex == 1)
                    {
                      
                        strOrderList.Add("Sandwich Type:Beef");
                    
                    }//End I:*

                    if (SandwichBox.SelectedIndex == 2)
                    {
                      
                        strOrderList.Add("Sandwich Type:Turkey");
                     
                    }//End I:*

                    if (SandwichBox.SelectedIndex == 3)
                    {
                    
                        strOrderList.Add("Sandwich Type:Veggie");
                       
                    }//End I:*

                    //Note: Checking for sandwiches sizes now
                    if (SandwichSizeBox.SelectedIndex == 0)
                    {
                    
                        strOrderList.Add("Sandwich Size:Small");
                     
                    }//End I:*

                    if (SandwichSizeBox.SelectedIndex == 1)
                    {
                      
                        strOrderList.Add("Sandwich Size:Medium");
                     
                    }//End I:*

                    if (SandwichSizeBox.SelectedIndex == 2)
                    {
                     
                        strOrderList.Add("Sandwich Size:Large");
                       
                    }//End I:*

                    if (SandwichAmountBox.Text != "")
                    {
                        strOrderList.Add("Sandwich Amount:" + SandwichAmountBox.Text);
                    
                    }//End I:*

                    //Note: Checking for wings selections 

                    if (WingsBox.SelectedIndex == 0)
                    {
                     
                        strOrderList.Add("Wings Type:Mild");
                      
                    }//End I:*

                    if (WingsBox.SelectedIndex == 1)
                    {
                     
                        strOrderList.Add("Wings Type:Medium");
                    
                    }//End I:*

                    if (WingsBox.SelectedIndex == 2)
                    {
                     
                        strOrderList.Add("Wings Type:Hot");
                   
                    }//End I:*

                    if (WingsBox.SelectedIndex == 3)
                    {
                      
                        strOrderList.Add("Wings Type:Honey Garlic");
                    
                    }//End I:*

                    //Note: Checking for wings sizes now
                    if (WingsSizeBox.SelectedIndex == 0)
                    {
                     
                        strOrderList.Add("Wings Size:Small");
                    
                    }//End I:*

                    if (WingsSizeBox.SelectedIndex == 1)
                    {
                     
                        strOrderList.Add("Wings Size:Medium");
                    
                    }//End I:*

                    if (WingsSizeBox.SelectedIndex == 2)
                    {
                    
                        strOrderList.Add("Wings Size:Large");
                    }//End I:*

                    if (WingsAmountBox.Text != "")
                    {
                        strOrderList.Add("Wings Amount:" + WingsAmountBox.Text);
                    }//End I:*


                    //Note: Checking for fries selections 

                    if (FriesBox.SelectedIndex == 0)
                    {
                  
                        strOrderList.Add("Fries Type:Regular");
                    }//End I:*

                    if (FriesBox.SelectedIndex == 1)
                    {
                       
                        strOrderList.Add("Fries Type:Gravy");
                    }//End I:*

                    if (FriesBox.SelectedIndex == 2)
                    {
                    
                        strOrderList.Add("Fries Type:Bacon");
                    }//End I:*

                    if (FriesBox.SelectedIndex == 3)
                    {
                      
                        strOrderList.Add("Fries Type:Poutine");
                    }//End I:*

                    //Note: Checking for fries sizes now
                    if (FriesSizeBox.SelectedIndex == 0)
                    {
                    
                        strOrderList.Add("Fries Size:Small");
                    }//End I:*

                    if (FriesSizeBox.SelectedIndex == 1)
                    {
                  
                        strOrderList.Add("Fries Size:Medium");
                    }//End I:*

                    if (FriesSizeBox.SelectedIndex == 2)
                    {
                   
                        strOrderList.Add("Fries Size:Large");
                      
                    }//End I:*

                    if (FriesAmountBox.Text != "")
                    {
                        strOrderList.Add("Fries Amount:" + FriesAmountBox.Text);
                     
                    }//End I:*


                    //Note: Checking for deserts selections

                    if (DesertBox.SelectedIndex == 0)
                    {
                    
                        strOrderList.Add("Desert Type:Jalum");
                    }//End I:*

                    if (DesertBox.SelectedIndex == 1)
                    {
                    
                        strOrderList.Add("Desert Type:Modak");
                    
                    }//End I:*

                    if (DesertBox.SelectedIndex == 2)
                    {
                    
                        strOrderList.Add("Desert Type:Sandesh");
                     
                    }//End I:*

                    if (DesertBox.SelectedIndex == 3)
                    {
                      
                        strOrderList.Add("Desert Type:Payasam");
                    
                    }//End I:*

                    //Note: Checking for deserts sizes now
                    if (DesertSizeBox.SelectedIndex == 0)
                    {
                    
                        strOrderList.Add("Desert Size:Small");
                    }//End I:*

                    if (DesertSizeBox.SelectedIndex == 1)
                    {
                       
                        strOrderList.Add("Desert Size:Medium");
                     
                    }//End I:*

                    if (DesertSizeBox.SelectedIndex == 2)
                    {
                    
                        strOrderList.Add("Desert Size:Large");
                    }//End I:*

                    if (DesertAmountBox.Text != "")
                    {
                        strOrderList.Add("Desert Amount:" + DesertAmountBox.Text);
                    }//End I:*

                    List<CategoryAndValue> splitList = new List<CategoryAndValue>();

                    for (int i = 0; i < strOrderList.Count; i++) {
                        string[] splits = strOrderList[i].Split(":");
                        CategoryAndValue cav = new CategoryAndValue(splits[0], splits[1]);
                        splitList.Add(cav);
                    }//End F:*
                    
                    int iterations = splitList.Count / 3;

                    int count1 = 0;
                    int count2 = 1;
                    int count3 = 2;

                    for (int i = 0; i < iterations; i++)
                    {

                        Abstract_Order order = new PapaDarios_Order();

                        order.Product = splitList[count1].Value;
                        order.Size = splitList[count2].Value;
                        order.Quantity = Convert.ToInt32(splitList[count3].Value);

                        count1 += 3;
                        count2 += 3;
                        count3 += 3;

                        order.CustomerId = SignInPage.SignIn.CurrentUser.Id;

                        order.CustomerOrderId = orderCount;

                       orderManager.OrderList.Add(order);

                    }//End F:*

                    orderCount++;

                    Output.Text = "";
                    
                    for (int i = 0; i < orderManager.OrderList.Count; i++)
                    {

                        Output.Text += "Order Summary\n" +
                                         "Order Id: " + orderManager.OrderList[i].CustomerOrderId + ",\n" +
                                         "Customer Id: " + orderManager.OrderList[i].CustomerId + ",\n" +
                                         "Product: " + orderManager.OrderList[i].Product + ",\n" +
                                         "Size: " + orderManager.OrderList[i].Size + ",\n" +
                                         "Quantity: " + orderManager.OrderList[i].Quantity + "\n\n";
                    }//End F:*

                    OrderCountBox.Text = "Order Count: " + orderCount.ToString();
                     
                }//End I:*

                if (SignInPage.SignIn.CurrentUser == null) {
                    Output.Text = "I'm sorry, you must sign in before placing a order.";
                }//End I:*

            }//End TRY:*

            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }//End M:*

        }//End M:*

        public void GetOrderBtn_Click(Object sender, RoutedEventArgs e)
        {
            try {

                if (GetUserOrder.Text != "" &&
                    orderManager != null &&
                    orderManager.OrderList.Count != 0)
                {

                    for (int i = 0; i < orderManager.OrderList.Count; i++)
                    {

                        if (Int32.Parse(GetUserOrder.Text) == orderManager.OrderList[i].CustomerOrderId)
                        {

                            Output.Text = orderManager.OrderList[i].Print();

                        }//End I:*

                    }//End F:*

                }//End I:*

            }//End TRY:*

            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }//End CAT:*

        }//End M:*

    }//End CL:*

}//End NS:*
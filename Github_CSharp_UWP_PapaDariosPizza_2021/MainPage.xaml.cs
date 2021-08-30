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
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PapaDariosPizza
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static string aboutUs;

        public MainPage()
        {
            this.InitializeComponent();
            GetFile_Click();
        }//End C:*

        public void OrdersBtn_Click(Object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OrdersPage));
        }//End M:*

        public void AboutBtn_Click(Object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(AboutPage));
        }//End M:*

        public void RegisterBtn_Click(Object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(RegisterPage));
        }//End M:*

        public void SignInBtn_Click(Object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(SignInPage));
        }//End M:*

        public void AdminBtn_Click(Object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(AdminPage));
        }//End M:*

        public void AccountsBtn_Click(Object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(AccountsPage));
        }//End M:*

        public void SuggestionsBtn_Click(Object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(SuggestionsPage));
        }//End M:*

        public void ContactBtn_Click(Object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(ContactPage));
        }//End M:*

        public async void GetFile_Click()
        {

            try
            {

                string strAboutUs = "";

                var aboutUsFile = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///PapaDarios_AboutUs.txt"));
                using (var inputStream = await aboutUsFile.OpenReadAsync())
                using (var classicStream = inputStream.AsStreamForRead())
                using (var streamReader = new StreamReader(classicStream))

                {
                    while (streamReader.Peek() >= 0)
                    {
                        strAboutUs += streamReader.ReadLine();

                    }//End W:*

                    MainPage.aboutUs = strAboutUs; 

                }//End U:*


            }//End TRY:*

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }//End CAT:*

        }//End M:*

    }//End CL:*

}//End NS:*

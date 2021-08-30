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
    public sealed partial class RegisterPage : Page
    {
        private static Abstract_Register registerManager;
        private static Boolean varRegistryManagerSetup;
        private static Boolean varRegistryListSetup;

        internal static Abstract_Register RegisterManager { get => registerManager; set => registerManager = value; }

        public RegisterPage()
        {
            this.InitializeComponent();

            if (varRegistryManagerSetup == false)
            {
                SetRegistryManagerBtn.Visibility = Visibility.Visible;

            }//End I:*

            else
            {
                SetRegistryManagerBtn.Visibility = Visibility.Collapsed;
            }//End E:*

            if (varRegistryListSetup == false)
            {
                SetRegistryListBtn.Visibility = Visibility.Visible;
            }//End I:*

            else
            {
                SetRegistryListBtn.Visibility = Visibility.Collapsed;
            }//End E:*

        }//End M:*

        public void HomeBtn_Click(Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }//End M:*

        public void SetRegistryManagerBtn_Click(Object sender, RoutedEventArgs e)
        {
            registerManager = new PapaDarios_Registry();
            OutputVarSetup.Text = "Success, registry manager was initialized.";
            SetRegistryManagerBtn.Visibility = Visibility.Collapsed;
            varRegistryManagerSetup = true; 
        }//End M:*

        public void SetRegisterListBtn_Click(Object sender, RoutedEventArgs e)
        {
            if (registerManager != null) {
                registerManager.Registry = new List<Abstract_User>();
                OutputVarSetup.Text = "Registry list belonging to registry manager was initialized successfully.";
                SetRegistryListBtn.Visibility = Visibility.Collapsed;
                varRegistryListSetup = true;
            }//End I:*
        }//End M:*

        public void RegisterBtn_Click(Object sender, RoutedEventArgs e)
        {
            if (Name.Text != "" && UserName.Text != "" && Password.Text != "" & Email.Text != "" &&
                varRegistryManagerSetup == true && varRegistryListSetup == true) {

                Abstract_User user =  registerManager.CreateUser(Name.Text, UserName.Text, Email.Text, Password.Text);

                Output.Text = user.Print();

            }//End I:*

        }//End M:*

    }//End CL:*

}//End NS:*

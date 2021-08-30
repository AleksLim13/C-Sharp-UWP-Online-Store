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
    public sealed partial class SignInPage : Page
    {

        private static Abstract_SignIn signIn;
        private static bool varSetupSignInManager;
        private static bool varSetupSignInList;
        private static bool varSetupSignInCurrentUser;


        public SignInPage()
        {
            this.InitializeComponent();

            if (varSetupSignInManager == false)
            {
                SetSigninManagerBtn.Visibility = Visibility.Visible;
            }//End I:*

            else {
                SetSigninManagerBtn.Visibility = Visibility.Collapsed;
            }//End E:*

            if (varSetupSignInList == false)
            {
                SetSignInListBtn.Visibility = Visibility.Visible;
            }//End I:*

            else
            {
                SetSignInListBtn.Visibility = Visibility.Collapsed;
            }//End E:*

            if (varSetupSignInCurrentUser == false)
            {
                SetSignInCurrentUserBtn.Visibility = Visibility.Visible;
            }//End I:*

            else
            {
                SetSignInCurrentUserBtn.Visibility = Visibility.Collapsed;
            }//End E:*

        }//End C:*

        internal static Abstract_SignIn SignIn { get => signIn; set => signIn = value; }

        public void HomeBtn_Click(Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }//End M:*

        public void SetSignInManagerBtn_Click(Object sender, RoutedEventArgs e)
        {
            signIn = new PapaDarios_SignIn();
            OutputVarSetup.Text = "Success, Sign In Manager was initialized.";
            SetSigninManagerBtn.Visibility = Visibility.Collapsed;
            varSetupSignInManager = true; 
        }//End M:*

        public void SetSignInListBtn_Click(Object sender, RoutedEventArgs e)
        {
            if (signIn != null) {
                signIn.SignedInList = new List<Abstract_User>();
                OutputVarSetup.Text = "That went well. Sign In List was initialized.";
                SetSignInListBtn.Visibility = Visibility.Collapsed;
                varSetupSignInList = true;
            }//End I:*

        }//End M:*

        public void SetSignInCurrentUserBtn_Click(Object sender, RoutedEventArgs e)
        {
            if (signIn != null) {
                signIn.CurrentUser = new PapaDarios_User_Customer();
                OutputVarSetup.Text = "Boo Ya! Current User object was initialized.";
                SetSignInCurrentUserBtn.Visibility = Visibility.Collapsed;
                varSetupSignInCurrentUser = true;
            }//End I:*
            
        }//End M:*

        public void SignInBtn_Click(Object sender, RoutedEventArgs e)
        {
            try {

                if (UserName.Text != "" && Password.Text != "")
                {


                    int check = signIn.SignIn(UserName.Text, Password.Text);

                    if (check == 0)
                    {
                        Output.Text = "I'm sorry, either the User Name or Password was incorrect or you may not be registered in our system.";
                    }//End I:*

                    else if (check == 1)
                    {
                        Output.Text = "Welcome " + SignInPage.SignIn.CurrentUser.Name;
                    }//End EI:*

                }//End I:*

            }//End TRY:*

            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }//End CAT:*

        }//End M:*

    }//End CL:*

}//End NS:*

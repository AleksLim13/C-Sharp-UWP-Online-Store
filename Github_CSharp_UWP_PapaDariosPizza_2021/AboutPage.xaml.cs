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
using PapaDariosPizza.CodeBehind;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PapaDariosPizza
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AboutPage : Page
    {
        
      

        public AboutPage()
        {
            this.InitializeComponent();
            MissionStatement.Text = MainPage.aboutUs;
        }//End C:*

        public void HomeBtn_Click(Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }//End M:*

    }//End C:*

}//End NS:*

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ComplainLodgeResolve
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void enter_Click_1(object sender, RoutedEventArgs e)
        {
           string passwords = password.Password;
            if (username.Text == "admin" && passwords == "hello" )
            {
                loginscreen.Visibility = Visibility.Collapsed;
                userpage.Visibility = Visibility.Collapsed;
                adminpage.Visibility = Visibility.Visible;
            }
            else if (username.Text == "tejas" && passwords == "hello")
            {
                loginscreen.Visibility = Visibility.Collapsed;
                adminpage.Visibility = Visibility.Collapsed;
                userpage.Visibility = Visibility.Visible;
            }
            else 
            {
                MessageDialog msg = new MessageDialog("Invalid Username/Password...Please Try Again","Login Error");
                msg.ShowAsync();
            }
        }

        private void settings_Click_1(object sender, RoutedEventArgs e)
        {
            adminpage.Visibility = Visibility.Collapsed;
            settingscreen.Visibility = Visibility.Visible;
        }

        private void update_Click_1(object sender, RoutedEventArgs e)
        {
            adminpage.Visibility = Visibility.Collapsed;
            updatescreen.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            adminpage.Visibility = Visibility.Visible;
            updatescreen.Visibility = Visibility.Collapsed;

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            adminpage.Visibility = Visibility.Visible;
            settingscreen.Visibility = Visibility.Collapsed;
        }

        private void miscellaneous_Click_1(object sender, RoutedEventArgs e)
        {
            miscscreen.Visibility = Visibility.Visible;
            adminpage.Visibility = Visibility.Collapsed;
        }

        private void number_Click_1(object sender, RoutedEventArgs e)
        {
            list.Visibility=Visibility.Visible;
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            newscreen.Visibility = Visibility.Collapsed;
            adminpage.Visibility = Visibility.Visible;
            miscscreen.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            adminpage.Visibility = Visibility.Collapsed;
            userpage.Visibility = Visibility.Collapsed;
            loginscreen.Visibility = Visibility.Visible;
            username.Text = "";
            password.Password = "";
        }

        private void new_Click_1(object sender, RoutedEventArgs e)
        {
            newscreen.Visibility = Visibility.Visible;
            adminpage.Visibility = Visibility.Collapsed;
        }

        private void monitor_Click_1(object sender, RoutedEventArgs e)
        {
            monitor.Opacity = 30;
            compl.Visibility = Visibility.Visible;
            text1.Visibility = Visibility.Visible;
            save.Visibility = Visibility.Visible;
        }

        private void mouse_keyboard_Click_1(object sender, RoutedEventArgs e)
        {
            mouse_keyboard.Opacity = 30;
            compl.Visibility = Visibility.Visible;
            text1.Visibility = Visibility.Visible;
            save.Visibility = Visibility.Visible;
        }

        private void CPU_Click_1(object sender, RoutedEventArgs e)
        {
            CPU.Opacity = 30;
            compl.Visibility = Visibility.Visible;
            text1.Visibility = Visibility.Visible;
            save.Visibility = Visibility.Visible;
        }

        private void other_Click_1(object sender, RoutedEventArgs e)
        {
            other.Opacity = 30;
            compl.Visibility = Visibility.Visible;
            text1.Visibility = Visibility.Visible;
            save.Visibility = Visibility.Visible;
        }

        private void save_Click_1(object sender, RoutedEventArgs e)
        {
            MessageDialog saved = new MessageDialog("Your Complain Is Been Filed Successfully");
            saved.ShowAsync();
            reset();
        }
        public void reset()
        {
            compl.Text = "";
            compl.Visibility = Visibility.Collapsed;
            text1.Visibility = Visibility.Collapsed;
            save.Visibility = Visibility.Collapsed;
            CPU.Opacity = 100;
            monitor.Opacity = 100;
            other.Opacity = 100;
            mouse_keyboard.Opacity = 100;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (userbox.Text == "Admin" || userbox.Text == "admin")
            {
                if (passbox.Password == "Admin" || passbox.Password == "admin")
                {
                    MessageBox.Show("Login successful");
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials");

            }
        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    peekbox.Visibility=Visibility.Visible;

        //}

        private void showbutton_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            peekbox.Text = System.Convert.ToString(passbox.Password);
            peekbox.Visibility = Visibility.Visible;
            passbox.Visibility = Visibility.Hidden;
        }

        private void showbutton_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            peekbox.Visibility = Visibility.Collapsed;
            passbox.Visibility = Visibility.Visible;
        }
    }
}

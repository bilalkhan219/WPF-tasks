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
using System.Collections.ObjectModel;

namespace taske3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> list1 = new ObservableCollection<string>();
        ObservableCollection<string> list2 = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            listbox1.ItemsSource = list1;
            listbox2.ItemsSource = list2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(value1box.Text))
            {

            }
            else
            {
                list1.Add(value1box.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(value2box.Text))
            {

            }
            else
            {
                list2.Add(value2box.Text);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            list2.Add(System.Convert.ToString(listbox1.SelectedItem));
            list1.Remove(System.Convert.ToString(listbox1.SelectedItem));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            list1.Add(System.Convert.ToString(listbox2.SelectedItem));
            list2.Remove(System.Convert.ToString(listbox1.SelectedItem));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            foreach(string s in list1)
            {
                list2.Add(s);
            }
            list1.Clear();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            foreach (string s in list2)
            {
                list1.Add(s);
            }
            list2.Clear();
            list2.Clear();
        }
    }
}

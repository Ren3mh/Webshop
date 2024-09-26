using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Webshop.Model;

namespace Webshop.View
{
    /// <summary>
    /// Interaction logic for ShoppingWindow.xaml
    /// </summary>
    public partial class ShoppingWindow : Window
    {
        public ShoppingWindow()
        {
            //string cs = "Server=rene-server1.database.windows.net;Database=Webshop1;Trusted_Connection=False;User Id=rene-server1Admin;Password=DatabaseEr1Fase!;";


            DataContext = this;
            string projectDirectory = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "WebShopDB.db");
            string cs = $"Data Source={projectDirectory}";

            List<String> strings = new List<String>();
            strings.Add("Dette er en test");

            ProductRepository pr = new ProductRepository(cs);
            ObservableCollection<Product> products = new ObservableCollection<Product>(pr.GetAll());
            InitializeComponent();

            

            bt_Pay.IsEnabled = false;
            String[] PaymentMethods = { "Kreditkort", "Mobilepay", "Paypal" };

            cb_PaymentMethod.ItemsSource = PaymentMethods;
        }

        private void cb_PaymentMethod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bt_Pay.IsEnabled = cb_PaymentMethod_SelectionChanged != null;
        }
                
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            string cs = "Server=rene-server1.database.windows.net;Database=Webshop1;Trusted_Connection=True;";
            ProductRepository pr = new ProductRepository(cs);
            var products = new ObservableCollection<Product>(pr.GetAll());
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Webshop.View
{
    /// <summary>
    /// Interaction logic for ShoppingWindow.xaml
    /// </summary>
    public partial class ShoppingWindow : Window
    {
        public ShoppingWindow()
        {
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

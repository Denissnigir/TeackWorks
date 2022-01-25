﻿using System;
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
using TeackWorks.Model;
using TeackWorks.View.Windows;

namespace TeackWorks.View.Pages.OrderConstructor
{
    /// <summary>
    /// Логика взаимодействия для AcceptOrderPage.xaml
    /// </summary>
    public partial class AcceptOrderPage : Page
    {
        public AcceptOrderPage(string price, string discount)
        {
            InitializeComponent();
            PriceTB.Text = price;
            DiscountTB.Text = discount;
            MainGrid.DataContext = FirstPage.newOrder;
            var client = Context._con.Client.FirstOrDefault(p => p.Id == FirstPage.newOrder.ClientId);
            NameTB.Text = client.FirstName;
        }

        private void AcceptOrder(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PhoneTB.Text))
            {
                Context._con.NewOrder.Add(FirstPage.newOrder);
                Context._con.SaveChanges();
                MessageBox.Show("Заявка успешно оформлена, с вями свяжутся в ближайшее время!");
                FirstPage.newOrder = null;
                OrderConstructorWindow.window.Close();
            }
            else
            {
                MessageBox.Show("Введите контактные данные!");
            }
            
        }
    }
}

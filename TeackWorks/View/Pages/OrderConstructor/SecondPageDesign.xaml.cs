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

namespace TeackWorks.View.Pages.OrderConstructor
{
    /// <summary>
    /// Логика взаимодействия для SecondPageDesign.xaml
    /// </summary>
    public partial class SecondPageDesign : Page
    {
        public SecondPageDesign()
        {
            InitializeComponent();
            DiscountTB.Text = "Скидка: 2000 руб.";
            PriceTB.Text = "Цена: 1000 руб.";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var service = Context._con.Service.FirstOrDefault(p => p.Id == 5);
            decimal? price = 2000 + service.Price;
            DiscountTB.Text = "Скидка: 4000 руб.";
            PriceTB.Text = $"Цена: {price} руб.";
            FirstPage.newOrder.ServiceId = service.Id;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            var service = Context._con.Service.FirstOrDefault(p => p.Id == 6);
            decimal? price = 2000 + service.Price;
            DiscountTB.Text = "Скидка: 4000 руб.";
            PriceTB.Text = $"Цена: {price} руб.";
            FirstPage.newOrder.ServiceId = service.Id;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            var service = Context._con.Service.FirstOrDefault(p => p.Id == 7);
            decimal? price = 2000 + service.Price;
            DiscountTB.Text = "Скидка: 4000 руб.";
            PriceTB.Text = $"Цена: {price} руб.";
            FirstPage.newOrder.ServiceId = service.Id;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            var service = Context._con.Service.FirstOrDefault(p => p.Id == 8);
            decimal? price = 2000 + service.Price;
            DiscountTB.Text = "Скидка: 4000 руб.";
            PriceTB.Text = $"Цена: {price} руб.";
            FirstPage.newOrder.ServiceId = service.Id;
        }

        private void GoForward(object sender, RoutedEventArgs e)
        {
            if (DiscountTB.Text == "Скидка: 4000 руб.")
            {
                NavigationService.Navigate(new AcceptOrderPage(PriceTB.Text, DiscountTB.Text));
            }
            else
            {
                MessageBox.Show("Выберите тип дизайна!");
            }
        }
    }
}

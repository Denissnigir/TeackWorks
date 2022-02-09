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
using TeackWorks.Model;
using TeackWorks.View.Windows;

namespace TeackWorks.View.Pages.OrderConstructor
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        public static Order newOrder { get; set; }
        public FirstPage()
        {
            InitializeComponent();
            newOrder = new Order();
            newOrder.IdClient = AuthorizationWIndow.client.Id;
            newOrder.DateClose = DateTime.Now;
            newOrder.Status = false;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var service = Context._con.Service.FirstOrDefault(p => p.Id == 1);
            newOrder.IdService = service.Id;
            DiscountTB.Text = "Скидка: 2000 руб.";
            PriceTB.Text = "Цена: 1500 руб.";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            var service = Context._con.Service.FirstOrDefault(p => p.Id == 2);
            newOrder.IdService = service.Id;
            DiscountTB.Text = "Скидка: 2000 руб.";
            PriceTB.Text = "Цена: 1000 руб.";
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            var service = Context._con.Service.FirstOrDefault(p => p.Id == 3);
            newOrder.IdService = service.Id;
            DiscountTB.Text = "Скидка: 2000 руб.";
            PriceTB.Text = "Цена: 2500 руб.";
        }

        private void GoForward(object sender, RoutedEventArgs e)
        {
            if(DiscountTB.Text == "Скидка: 2000 руб.")
            {
                NavigationService.Navigate(new AcceptOrderPage(PriceTB.Text, DiscountTB.Text));
            }
            else
            {
                MessageBox.Show("Выберите услугу!");
            }
        }
    }
}

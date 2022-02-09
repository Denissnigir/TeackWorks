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

namespace TeackWorks.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        List<Order> orders = new List<Order>();
        public OrderPage()
        {
            InitializeComponent();
            if(AuthorizationWIndow.client.IdRole == 3)
            {
                orders = Context._con.Order.ToList().Where(p => p.Status == true).ToList();
            }
            else
            {
                orders = Context._con.Order.ToList();
            }
            OrdersLB.ItemsSource = orders;
        }

        private void AllProjects(object sender, RoutedEventArgs e)
        {
            if (AuthorizationWIndow.client.IdRole == 3)
            {
                orders = Context._con.Order.ToList().Where(p => p.Status == true).ToList();
            }
            else
            {
                orders = Context._con.Order.ToList();
            }
            OrdersLB.ItemsSource = orders;
        }

        private void Development(object sender, RoutedEventArgs e)
        {
            if(AuthorizationWIndow.client.IdRole == 3)
            {
                orders = Context._con.Order.ToList().Where(p => p.IdService == 1 && p.Status == true).ToList();
            }
            else
            {
                orders = Context._con.Order.ToList().Where(p => p.IdService == 1).ToList();
            }
            OrdersLB.ItemsSource = orders;
        }

        private void Design(object sender, RoutedEventArgs e)
        {
            if (AuthorizationWIndow.client.IdRole == 3)
            {
                orders = Context._con.Order.ToList().Where(p => p.IdService == 2 && p.Status == true).ToList();
            }
            else
            {
                orders = Context._con.Order.ToList().Where(p => p.IdService == 2).ToList();
            }
            OrdersLB.ItemsSource = orders;
        }

        private void OrdersLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Order curOrder = OrdersLB.SelectedItem as Order;
            if(curOrder != null)
            {
                if (curOrder.Status == false)
                {
                    NavigationService.Navigate(new OrderEditDetails(curOrder));
                }
                else
                {
                    NavigationService.Navigate(new OrderDetails(curOrder));
                }
            }
        }
    }
}

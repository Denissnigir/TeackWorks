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
            orders = Context._con.Order.ToList();
            OrdersLB.ItemsSource = orders;
        }

        private void AllProjects(object sender, RoutedEventArgs e)
        {
            orders = Context._con.Order.ToList();
            OrdersLB.ItemsSource = orders;
        }

        private void Development(object sender, RoutedEventArgs e)
        {
            orders = Context._con.Order.ToList().Where(p => p.Service.IdTypeService == 1).ToList();
            OrdersLB.ItemsSource = orders;
        }

        private void Design(object sender, RoutedEventArgs e)
        {
            orders = Context._con.Order.ToList().Where(p => p.Service.IdTypeService == 2).ToList();
            OrdersLB.ItemsSource = orders;
        }
    }
}

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
    /// Логика взаимодействия для OrderDetails.xaml
    /// </summary>
    public partial class OrderDetails : Page
    {
        Order curOrder { get; set; }
        List<OrderPicture> orderPictures = new List<OrderPicture>();
        public OrderDetails(Order order)
        {
            InitializeComponent();
            curOrder = order;
            InfoGrid.DataContext = curOrder;
            orderPictures = Context._con.OrderPicture.ToList().Where(p => p.IdOrder == curOrder.Id).ToList();
            PhotoLB.ItemsSource = orderPictures;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderPage());
        }
    }
}

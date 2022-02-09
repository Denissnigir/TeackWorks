using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для OrderEditDetails.xaml
    /// </summary>
    public partial class OrderEditDetails : Page
    {
        Order curOrder { get; set; }
        List<OrderPicture> orderPictures = new List<OrderPicture>();
        public OrderEditDetails(Order order)
        {
            InitializeComponent();
            curOrder = order;
            InfoGrid.DataContext = curOrder;
            orderPictures = Context._con.OrderPicture.ToList().Where(p => p.IdOrder == curOrder.Id).ToList();
            PhotoLB.ItemsSource = orderPictures;
        }

        private void AddPhoto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            dialog.Multiselect = true;
            if ((bool)dialog.ShowDialog())
            {
                foreach(var image in dialog.FileNames)
                {
                    OrderPicture orderPicture = new OrderPicture();
                    orderPicture.IdOrder = curOrder.Id;
                    orderPicture.PhotoOrder = File.ReadAllBytes(image);
                    orderPictures.Add(orderPicture);
                    PhotoLB.ItemsSource = orderPictures.ToList();
                }
            }
        }

        private void SaveOrder(object sender, RoutedEventArgs e)
        {
            if(orderPictures.Count != 0)
            {
                foreach(var photo in orderPictures)
                {
                    OrderPicture orderPicture = new OrderPicture();
                    orderPicture.IdOrder = curOrder.Id;
                    orderPicture.PhotoOrder = photo.PhotoOrder;
                    Context._con.OrderPicture.Add(orderPicture);
                    Context._con.SaveChanges();
                }
                curOrder.IdPersonal = AuthorizationWIndow.client.Id;
                curOrder.DateClose = DateTime.Now;
                curOrder.Status = true;
                Context._con.SaveChanges();
                MessageBox.Show("Заказ успешно изменён!");
                NavigationService.Navigate(new OrderPage());
            }
            else
            {
                MessageBox.Show("Добавьте фото!");
            }
            
        }
    }
}

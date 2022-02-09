using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            var client = AuthorizationWIndow.client;
            NameTB.Text = client.FIO;
        }

        private void AcceptOrder(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PhoneTB.Text))
            {
                Regex regexPhone = new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$");
                Regex regexEmail = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
                if (regexPhone.IsMatch(PhoneTB.Text) || regexEmail.IsMatch(PhoneTB.Text))
                {
                    switch (FirstPage.newOrder.IdService)
                    {
                        case 1:
                            FirstPage.newOrder.Price = 1000;
                            break;
                        case 2:
                            FirstPage.newOrder.Price = 1500;
                            break;
                        case 3:
                            FirstPage.newOrder.Price = 2500;
                            break;
                    }
                    Context._con.Order.Add(FirstPage.newOrder);
                    Context._con.SaveChanges();
                    MessageBox.Show("Заявка успешно оформлена, с вями свяжутся в ближайшее время!");
                    FirstPage.newOrder = null;
                    OrderConstructorWindow.window.Close();
                }
                else
                {
                    MessageBox.Show("Неверный формат ввода номера телефона или Email!");
                }
                
            }
            else
            {
                MessageBox.Show("Введите контактные данные!");
            }
            
        }
    }
}

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
using System.Windows.Shapes;
using TeackWorks.Model;

namespace TeackWorks.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        Client client { get; set; }
        public RegisterWindow()
        {
            InitializeComponent();
            client = new Client();
            MainGrid.DataContext = client;
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(client.FirstName) && !string.IsNullOrWhiteSpace(client.LastName) && !string.IsNullOrWhiteSpace(client.Login) && !string.IsNullOrWhiteSpace(PasswordTB.Password))
            {
                client.Password = PasswordTB.Password;
                Context._con.Client.Add(client);
                Context._con.SaveChanges();
                MessageBox.Show("Вы успешно зарегестрировались!");
                AuthorizationWIndow authorizationWIndow = new AuthorizationWIndow();
                authorizationWIndow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все данные!");
            }
            
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                AuthorizationWIndow authorizationWIndow = new AuthorizationWIndow();
                authorizationWIndow.Show();
                this.Close();
            }
        }
    }
}

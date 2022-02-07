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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            MainGrid.DataContext = AuthorizationWIndow.client;
        }

        private void OpenConstructor(object sender, RoutedEventArgs e)
        {
            OrderConstructorWindow orderConstructorWindow = new OrderConstructorWindow();
            orderConstructorWindow.ShowDialog();
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                AuthorizationWIndow authorizationWIndow = new AuthorizationWIndow();
                authorizationWIndow.Show();
                AuthorizationWIndow.client = null;
                MainMenuWindow.menuWindow.Close();
            }
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(TB1.Text) && !string.IsNullOrWhiteSpace(TB2.Text) && !string.IsNullOrWhiteSpace(TB3.Text))
            {
                Context._con.SaveChanges();
                MessageBox.Show("Данные изменены!");
            }
            else
            {
                MessageBox.Show("Не оставляйте поля пустыми!");
            }
            
        }
    }
}

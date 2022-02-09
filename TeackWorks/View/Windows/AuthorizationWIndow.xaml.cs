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
    /// Логика взаимодействия для AuthorizationWIndow.xaml
    /// </summary>
    public partial class AuthorizationWIndow : Window
    {
        public static User client { get; set; }
        public AuthorizationWIndow()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            var user = Context._con.User.ToList()
                                          .Where(p => p.UserName == LoginTB.Text && p.Password == PasswordTB.Password)
                                          .FirstOrDefault();
            if(user != null)
            {
                client = user;
                MessageBox.Show("Вы успешно авторизовались!");
                MainMenuWindow mainMenuWindow = new MainMenuWindow();
                mainMenuWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            this.Close();
        }
    }
}

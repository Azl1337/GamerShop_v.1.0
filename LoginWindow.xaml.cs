using GamerShop_v1._0.Models;
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

namespace GamerShop_v1._0
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            List<Client> users = GamerShopEntities.GetContext().Clients.ToList();
            Client user = users.FirstOrDefault(p => p.ClientLogin == TBoxLogin.Text && p.ClientPassword == PBoxPassword.Password);

            StringBuilder error = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TBoxLogin.Text))
                error.AppendLine("Введите логин");
            if (string.IsNullOrWhiteSpace(PBoxPassword.Password))
                error.AppendLine("Введите пароль");
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            if (user != null)
            {
                int role = (int)user.IdRole;
                Models.Manager.clientId = (int)user.IdClient;

                MainWindow mainWindow = new MainWindow(role);
                mainWindow.Owner = this;
                this.Hide();
                mainWindow.Show();
            }

            else if (user == null)
            {
                MessageBox.Show("Неверный пароль или логин.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                PBoxPassword.Clear();
            }
        }

        private void WindowIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            string log = TBoxLogin.Text;
            string pas = PBoxPassword.Password;
            if (ChkBox.IsChecked == true)
            {
                TBoxLogin.Text = log;
                PBoxPassword.Password = pas;
            }
            else
            {
                TBoxLogin.Text = "";
                PBoxPassword.Password = "";
            }
        }

        private void BtnRegistrationClick(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Owner = this;
            this.Hide();
            registrationWindow.Show();
        }

        private void BtnRecoverClick(object sender, RoutedEventArgs e)
        {
            List<Client> users = GamerShopEntities.GetContext().Clients.ToList();
            Client user = users.FirstOrDefault(p => p.ClientLogin == TBoxLogin.Text);

            StringBuilder error = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TBoxLogin.Text))
                error.AppendLine("Необходимо ввести логин.");
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (user != null)
            {
                RecoverWindow recoverWindow = new RecoverWindow(user);
                recoverWindow.Owner = this;
                this.Hide();
                recoverWindow.Show();
            }

            else if (user == null)
            {
                MessageBox.Show("\nЛогин введен не верно или его не существует.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                PBoxPassword.Clear();
            }
        }
    }
}

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
    /// Логика взаимодействия для RecoverWindow.xaml
    /// </summary>
    public partial class RecoverWindow : Window
    {
        public string _oldPassword;
        Client _currentClient = new Client();
        public RecoverWindow(Client selectedClient)
        {
            InitializeComponent();

            if (selectedClient != null)
                _currentClient = selectedClient;

            DataContext = _currentClient;
            
            _oldPassword = _currentClient.ClientPassword;
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            if (BtnOK.IsEnabled)
            {
                _currentClient.ClientPassword = TBoxNewPassword.Text;

                if (_oldPassword == TBoxNewPassword.Text)
                {
                    MessageBox.Show("Новый пароль схож с действующим парлем!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                try
                {
                    GamerShopEntities.GetContext().SaveChanges();
                    MessageBox.Show("Пароль изменен!", "Изменение", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                    Owner.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult x = MessageBox.Show("Вы действительно хотите выйти?",
            "Выйти", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (x == MessageBoxResult.OK)
                this.Close();
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void BtnCheckClick(object sender, RoutedEventArgs e)
        {
            int code;

            bool _correctInput = int.TryParse(TBoxIdenficatoinCode.Text, out code);

            List<Client> users = GamerShopEntities.GetContext().Clients.ToList();
            Client user = users.FirstOrDefault(p => p.ClientLogin == _currentClient.ClientLogin
            && p.ClientIdentification == code);

            StringBuilder error = new StringBuilder();

            if (string.IsNullOrWhiteSpace(TBoxIdenficatoinCode.Text))
                error.AppendLine("Введите код восстановления.");
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Ошибка восстановления!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (user != null)
            {
                TBoxNewPassword.IsEnabled = true;

                MessageBox.Show("Проверка проведена успешно! \nВведите новый пароль, который состоит из не менее 6 символов.", "Успешно", 
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else if (user == null)
            {
                MessageBox.Show("Неверный логин или код восстановления.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TBoxNewPasswordTextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBoxNewPassword.Text.Length >= 6)
                BtnOK.IsEnabled = true;
            else
                BtnOK.IsEnabled = false;
        }
    }
}

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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private Client _currentClient = new Client();
        int identificator;

        public RegistrationWindow()
        {
            InitializeComponent();

            DataContext = _currentClient;
            //CBoxClientRole.ItemsSource = GamerShopEntities.GetContext().Roles.ToList();
        }

        private void BtnOkClick(object sender, RoutedEventArgs e)
        {
            StringBuilder s = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentClient.ClientLogin))
                s.AppendLine("Поле логин пустое");
            if (string.IsNullOrWhiteSpace(_currentClient.ClientPassword))
                s.AppendLine("Поле пароль пустое");
            else if (_currentClient.ClientPassword.Length < 6)
                s.AppendLine("Пароль состоит из менее 6 символов");
            if (string.IsNullOrWhiteSpace(_currentClient.ClientLastName))
                s.AppendLine("Поле фамилия пустое");
            if (string.IsNullOrWhiteSpace(_currentClient.ClientName))
                s.AppendLine("Поле имя пустое");
            if (string.IsNullOrWhiteSpace(_currentClient.ClientPatronymic))
                s.AppendLine("Поле отчество пустое");
            if (string.IsNullOrWhiteSpace(TBoxIdetificationCode.Text))
                s.AppendLine("Код восстановления не сгенерирован! Чтобы его сгенерировать нажмите Код!");


            if (s.Length > 0)
            {
                MessageBox.Show(s.ToString(), "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (_currentClient.IdClient == 0)
            {
                _currentClient.IdRole = 3;
                _currentClient.ClientIdentification = identificator;
                GamerShopEntities.GetContext().Clients.Add(_currentClient);
            }

            try
            {
                GamerShopEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
                Owner.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult x = MessageBox.Show("Вы действительно хотите выйти?",
                "Выйти", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (x == MessageBoxResult.OK)
                this.Close();
        }

        private void BtnGenerateClick(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            identificator = rnd.Next(100000, 999999);

            TBoxIdetificationCode.Text = Convert.ToString(identificator);

            MessageBox.Show("Ваш код сгенерирован! \nУбедительная просьба - сохраните код восстановления! " +
                "При необходимости, он поможет вам восстановить ваш аккаунт!", "Код сгенерирован", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            Owner.Show();
        }
    }
}

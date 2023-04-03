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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GamerShop_v1._0.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddOrEditClient.xaml
    /// </summary>
    public partial class AddOrEditClient : Page
    {
        private Client _currentClient = new Client();
        int identificator;

        public AddOrEditClient(Client selectClient)
        {
            InitializeComponent();

            if (selectClient != null)
            {
                _currentClient = selectClient;
                BtnGenerate.Visibility = Visibility.Collapsed;
                LIdentificationCode.Visibility = Visibility.Visible;
            }

            if (Manager.clientRole == 3)
            {
                LClientRole.Visibility = Visibility.Collapsed;
                CBoxClientRole.Visibility = Visibility.Collapsed;
            }

            DataContext = _currentClient;
            CBoxClientRole.ItemsSource = GamerShopEntities.GetContext().Roles.ToList();
        }

        private void BtnOkClick(object sender, RoutedEventArgs e)
        {
            StringBuilder s = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentClient.ClientLogin))
                s.AppendLine("Поле логин пустое");
            if (string.IsNullOrWhiteSpace(_currentClient.ClientPassword))
                s.AppendLine("Поле пароль пустое");
            if (string.IsNullOrWhiteSpace(_currentClient.ClientLastName))
                s.AppendLine("Поле фамилия пустое");
            if (string.IsNullOrWhiteSpace(_currentClient.ClientName))
                s.AppendLine("Поле имя пустое");
            if (string.IsNullOrWhiteSpace(_currentClient.ClientPatronymic))
                s.AppendLine("Поле отчество пустое");
            if (_currentClient.Role == null)
                s.AppendLine("Роль не выбрана");
            if (string.IsNullOrWhiteSpace(TBoxIdetificationCode.Text))
                s.AppendLine("Код восстановления не сгенерирован! Чтобы его сгенерировать нажмите Код!");

            if (s.Length > 0)
            {
                MessageBox.Show(s.ToString(), "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (_currentClient.IdClient == 0)
            {
                _currentClient.ClientIdentification = identificator;
                GamerShopEntities.GetContext().Clients.Add(_currentClient);
            }

            try
            {
                GamerShopEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
                Manager.mainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult x = MessageBox.Show("Создание (/изменения) не будут применены. Вы действительно хотите выйти?",
                "Выйти", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (x == MessageBoxResult.OK)
                Manager.mainFrame.GoBack();
        }

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                GamerShopEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            }
        }

        private void BtnGenerateClick(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            identificator = rnd.Next(100000, 999999);

            TBoxIdetificationCode.Text = Convert.ToString(identificator);
        }
    }
}

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
using GamerShop_v1._0.Models;

namespace GamerShop_v1._0.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientListPage.xaml
    /// </summary>
    public partial class ClientListPage : Page
    {
        public ClientListPage()
        {
            InitializeComponent();
        }


        private void BtnEditClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddOrEditClient((sender as Button).DataContext as Client));
        }

        private void BtnAddClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddOrEditClient(null));
        }

        private void BtnDeleteClick(object sender, RoutedEventArgs e)
        {
            var selectedClients = DGridClient.SelectedItems.Cast<Client>().ToList();
            List<Client> client = selectedClients;
            Client adminCheck = client.FirstOrDefault(p => p.IdClient > 0);

            MessageBoxResult messageBoxResult = MessageBox.Show($"Удалить {selectedClients.Count()} записей???", 
                "Удаление", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.OK)
            {
                if (adminCheck.IdClient == 1)
                {
                    MessageBox.Show("Удалить главного администратора нельзя!","Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                try
                {
                    GamerShopEntities.GetContext().Clients.RemoveRange(selectedClients);
                    GamerShopEntities.GetContext().SaveChanges();
                    MessageBox.Show("Записи удалены", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    List<Client> clients = GamerShopEntities.GetContext().Clients.OrderBy(p => p.IdClient).ToList();
                    DGridClient.ItemsSource = clients;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                GamerShopEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                List<Client> clients = GamerShopEntities.GetContext().Clients.OrderBy(p => p.IdClient).ToList();
                DGridClient.ItemsSource = clients;
            }
        }
    }
}

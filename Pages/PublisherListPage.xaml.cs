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
    /// Логика взаимодействия для PublisherListPage.xaml
    /// </summary>
    public partial class PublisherListPage : Page
    {
        public PublisherListPage()
        {
            InitializeComponent();
        }

        private void BtnAddClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddOrEditPublisher(null));
        }
        private void BtnEditClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddOrEditPublisher((sender as Button).DataContext as Publisher));
        }

        private void BtnDeleteClick(object sender, RoutedEventArgs e)
        {
            var selectedPublisher = DGridPublisher.SelectedItems.Cast<Publisher>().ToList();
            MessageBoxResult messageBoxResult = MessageBox.Show($"Удалить {selectedPublisher.Count()} записей???", "Удаление", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.OK)
            {
                try
                {
                    GamerShopEntities.GetContext().Publishers.RemoveRange(selectedPublisher);
                    GamerShopEntities.GetContext().SaveChanges();
                    MessageBox.Show("Записи удалены", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    List<Publisher> publishers = GamerShopEntities.GetContext().Publishers.OrderBy(p => p.IdPublisher).ToList();
                    DGridPublisher.ItemsSource = publishers;
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
                List<Publisher> publishers = GamerShopEntities.GetContext().Publishers.OrderBy(p => p.IdPublisher).ToList();
                DGridPublisher.ItemsSource = publishers;
            }
        }
    }
}

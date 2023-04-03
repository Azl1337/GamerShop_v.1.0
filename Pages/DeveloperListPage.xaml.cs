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
    /// Логика взаимодействия для DeveloperListPage.xaml
    /// </summary>
    public partial class DeveloperListPage : Page
    {
        public DeveloperListPage()
        {
            InitializeComponent();
        }

        private void BtnAddClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddOrEditDeveloper(null));
        }

        private void BtnDeleteClick(object sender, RoutedEventArgs e)
        {
            var selectedDeveloper = DGridDeveloper.SelectedItems.Cast<Developer>().ToList();
            MessageBoxResult messageBoxResult = MessageBox.Show($"Удалить {selectedDeveloper.Count()} записей???", "Удаление", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.OK)
            {
                try
                {
                    GamerShopEntities.GetContext().Developers.RemoveRange(selectedDeveloper);
                    GamerShopEntities.GetContext().SaveChanges();
                    MessageBox.Show("Записи удалены", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    List<Developer> developers = GamerShopEntities.GetContext().Developers.OrderBy(p => p.IdDeveloper).ToList();
                    DGridDeveloper.ItemsSource = developers;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void BtnEditClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddOrEditDeveloper((sender as Button).DataContext as Developer));
        }

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                GamerShopEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                List<Developer> developers = GamerShopEntities.GetContext().Developers.OrderBy(p => p.IdDeveloper).ToList();
                DGridDeveloper.ItemsSource = developers;
            }
        }
    }
}

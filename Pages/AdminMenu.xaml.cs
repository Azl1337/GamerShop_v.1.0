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
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Page
    {
        public AdminMenu(int role)
        {
            InitializeComponent();
            
            if(role == 3)
            {
                BtnClient.Visibility = Visibility.Collapsed;
                BtnStorySelles.Visibility = Visibility.Collapsed;
                BtnDevelopers.Visibility = Visibility.Collapsed;
                BtnPublishers.Visibility = Visibility.Collapsed;
            }

        }

        private void BtnCatalogClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new CatalogPage());
        }

        private void BtnClientClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new ClientListPage());
        }

        private void BtnStoryClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new SellesStoryPage());
        }

        private void BtnAboutDevClick(object sender, RoutedEventArgs e)
        {
            AboutDeveloperWindow adw = new AboutDeveloperWindow();
            adw.Show();
        }

        private void BtnProfileClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new UserProfile());
        }

        private void BtnPublisherClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new PublisherListPage());
        }

        private void BtnDeveloperClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new DeveloperListPage());
        }
    }
}

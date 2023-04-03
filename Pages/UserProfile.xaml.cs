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
    /// Логика взаимодействия для UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Page
    {
        private Client _currentClient = new Client();
        public UserProfile()
        {
            InitializeComponent();

            DataContext = _currentClient;

            LoadData();
        }

        void LoadData()
        {
            List<Client> users = GamerShopEntities.GetContext().Clients.ToList();
            Client user = users.FirstOrDefault(p => p.IdClient == Manager.clientId);

            LabelLogin.Content = user.ClientLogin;
            TBoxLastName.Text = user.ClientLastName;
            TBoxName.Text = user.ClientName;
            TBoxPatronymic.Text = user.ClientPatronymic;

            List<Sale> sales = GamerShopEntities.GetContext().Sales.ToList();
            Sale sUserId = sales.FirstOrDefault(p => p.IdClient == Manager.clientId);

            LBoxGame.ItemsSource = GamerShopEntities.GetContext().Sales.Where(p => p.IdClient == Manager.clientId).ToList();
        }

        private void BtnChangeInfoClick(object sender, RoutedEventArgs e)
        {
            List<Client> users = GamerShopEntities.GetContext().Clients.ToList();
            Client user = users.FirstOrDefault(p => p.IdClient == Manager.clientId);

            Manager.mainFrame.Navigate(new AddOrEditClient(user));
        }

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                GamerShopEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                LoadData();
            }
        }
    }
}

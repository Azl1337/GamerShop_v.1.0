using GamerShop_v1._0.Models;
using GamerShop_v1._0.Pages;
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
    /// Логика взаимодействия для GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        private Game _currentGame = new Game();
        private Client _currentUser = new Client();
        private Sale _currentSale = new Sale();
        private Models.Key _currentKey = new Models.Key();
        public GamePage(Game selectedGame)
        {
            InitializeComponent();

            Manager.gameId = selectedGame.IdGame;

            if (selectedGame != null)
                _currentGame = selectedGame;

            if (Manager.clientRole != 1)
                SPanelKey.Visibility = Visibility.Collapsed;

            DataContext = _currentGame;

            LoadData(selectedGame);
        }

        void LoadData(Game selectedGame)
        {
            var game = Manager.gameId;

            var keys = GamerShopEntities.GetContext().Keys.Where(p => p.IdGame == game).ToList();
            //var key = keys.FirstOrDefault(p => p.IsSoldOut == false);

            var keysCount = keys.Where(p => p.IsSoldOut == false).ToList();


            if (keysCount.Count == 0)
            {
                LNotEnough.Visibility = Visibility.Visible;
                BtnBuy.Visibility = Visibility.Collapsed;
            }
            else
            {
                LNotEnough.Visibility = Visibility.Collapsed;
                BtnBuy.Visibility = Visibility.Visible;
            }
        }

        private void BtnKeyClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new KeyPage((sender as Button).DataContext as Game));
        }

        private void BtnBackClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.GoBack();
        }

        private void BtnBuyClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult x = MessageBox.Show("Вы действительно купить?",
                    "Выйти", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (x == MessageBoxResult.Yes)
            {
                var user = Manager.clientId;
                var game = Manager.gameId;

                List<Client> users = GamerShopEntities.GetContext().Clients.ToList();
                _currentUser = users.FirstOrDefault(p => p.IdClient == user);
                var keys = GamerShopEntities.GetContext().Keys.Where(p => p.IdGame == game).ToList();
                var key = keys.FirstOrDefault(p => p.IsSoldOut == false);

                //var coin = eve.Coin - _currentUser.Coin;

                //StringBuilder s = new StringBuilder();
                //if (_currentUser.Coin == null)
                //    s.AppendLine("У вас не хватает монет");
                //if (_currentUser.Coin < eve.Coin)
                //    s.AppendLine("У вас не хватает монет");
                //if (_currentUser.Coin == 0)
                //    s.AppendLine("У вас нет монет");

                //MessageBox.Show($"{_currentUser.Coin}");

                //if (s.Length > 0)
                //{
                //    MessageBox.Show(s.ToString());
                //    return;
                //}

                if (_currentSale.IdSale == 0)
                {
                    _currentSale.SaleDate = DateTime.Now;
                    //_currentUser.Coin = _currentUser.Coin - coin;
                    _currentSale.IdKey = key.IdKey;
                    _currentSale.IdClient = user;
                    GamerShopEntities.GetContext().Sales.Add(_currentSale);

                    _currentKey = key;
                    _currentKey.IsSoldOut = true;
                }
                try
                {
                    GamerShopEntities.GetContext().SaveChanges();
                    MessageBox.Show($"Поздравляем с покупкой!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                LoadData(_currentGame);
            }
        }

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                GamerShopEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                LoadData(_currentGame);
            }
        }
    }
}

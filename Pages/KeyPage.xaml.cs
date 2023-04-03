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
    /// Логика взаимодействия для KeyPage.xaml
    /// </summary>
    public partial class KeyPage : Page
    {
        private Game _currentGame = new Game();
        private Models.Key _currentKey = new Models.Key();

        public KeyPage(Game selectedGame)
        {
            InitializeComponent();

            if (selectedGame != null)
                _currentGame = selectedGame;

            DataContext = _currentKey;

            LoadData(selectedGame);
        }

        void LoadData(Game selectedGame)
        {
            DGridKeys.ItemsSource = GamerShopEntities.GetContext().Keys.Where(p => p.IdGame == selectedGame.IdGame).OrderBy(p => p.IdKey).ToList();
            LabelGameTitle.Content = selectedGame.GameTitle;
            LabelGamePrice.Content = selectedGame.GamePrice;
            GridGame.DataContext = selectedGame;
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.GoBack();
        }

        private void BtnAdd(object sender, RoutedEventArgs e)
        {
            if (TBoxAddKey.Text.Length == 6)
            {
                _currentKey.IdGame = Manager.gameId;
                _currentKey.IsSoldOut = Manager.defaultKeyStatus;

                if (_currentKey.IdKey == 0)
                    GamerShopEntities.GetContext().Keys.Add(_currentKey);

                try
                {
                    GamerShopEntities.GetContext().SaveChanges();
                    MessageBox.Show("Ключ добавлен!", "Добавлено", MessageBoxButton.OK, MessageBoxImage.Information);
                    TBoxAddKey.Text = "";
                    LoadData(_currentGame);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
                MessageBox.Show("Введите код состоящий из 6 символов, включающий в себя буквы латинского алфавита и цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                GamerShopEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            }
        }
    }
}

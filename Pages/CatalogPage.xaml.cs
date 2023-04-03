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
    /// Логика взаимодействия для CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        public CatalogPage()
        {
            InitializeComponent();
            
            var genre = GamerShopEntities.GetContext().Genres.OrderBy(p => p.GenreTitle).ToList();
            genre.Insert(0, new Genre
            {
                GenreTitle = "Все жанры"
            });
            ComboGenre.ItemsSource = genre;
            ComboGenre.SelectedIndex = 0;
            LViewGames.ItemsSource = GamerShopEntities.GetContext().Games.OrderBy(p => p.GameTitle).ToList();

            if (Manager.clientRole == 3)
            {
                BtnAddNewGame.Visibility = Visibility.Collapsed;
                BtnDeleteGame.Visibility = Visibility.Collapsed;
                BtnEdit.Visibility = Visibility.Collapsed;
            }
        }

        private void TBoxSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }

        private void ComboGenreSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                GamerShopEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                LViewGames.ItemsSource = GamerShopEntities.GetContext().Games.OrderBy(p => p.GameTitle).ToList();
            }
        }

        private void UpdateData()
        {
            var currentGods = GamerShopEntities.GetContext().Games.OrderBy(p => p.GameTitle).ToList();
            if (ComboGenre.SelectedIndex > 0)
                currentGods = currentGods.Where(p => p.IdGenre == (ComboGenre.SelectedItem as Genre).IdGenre).ToList();
            currentGods = currentGods.Where(p => p.GameTitle.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

            LViewGames.ItemsSource = currentGods;
        }

        private void BtnEditClick(object sender, RoutedEventArgs e)
        {
            if (LViewGames.SelectedIndex >= 0)
            {
                var game = (LViewGames.SelectedItem as Game);
                Manager.mainFrame.Navigate(new AddOrEditGame(game));
            }
        }

        private void BtnAddNewGameClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddOrEditGame(null));
        }

        private void BtnDeleteGameClick(object sender, RoutedEventArgs e)
        {
            var selectedGame = LViewGames.SelectedItems.Cast<Game>().ToList();
            MessageBoxResult messageBoxResult = MessageBox.Show($"Удалить {selectedGame.Count()} игру из списка???", "Удаление", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.OK)
            {
                try
                {
                    GamerShopEntities.GetContext().Games.RemoveRange(selectedGame);
                    GamerShopEntities.GetContext().SaveChanges();
                    MessageBox.Show("Записи удалены", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    List<Game> games = GamerShopEntities.GetContext().Games.OrderBy(p => p.GameTitle).ToList();
                    LViewGames.ItemsSource = games;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void LViewGamesMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LViewGames.SelectedIndex >= 0)
            {
                var game = (LViewGames.SelectedItem as Game);
                Manager.gameId = game.IdGame;
                Manager.mainFrame.Navigate(new GamePage(game));
            }
        }
    }
}

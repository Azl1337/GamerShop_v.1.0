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
    /// Логика взаимодействия для SellesStoryPage.xaml
    /// </summary>
    public partial class SellesStoryPage : Page
    {
        private Game _currentGame = new Game();
        private Client _currentClient = new Client();
        public SellesStoryPage()
        {
            InitializeComponent();
            DGridSells.ItemsSource = GamerShopEntities.GetContext().Sales.OrderBy(p => p.SaleDate).ToList();
        }

        //private void DGridSellsSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //IGame.Source = _currentGame.GamePhoto;
        //LabelGameTitle.Content = _currentGame.GameTitle;
        //}

    }
}

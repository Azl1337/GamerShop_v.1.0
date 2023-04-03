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
using GamerShop_v1._0.Pages;
using GamerShop_v1._0.Models;

namespace GamerShop_v1._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(int role)
        {
            InitializeComponent();

            Manager.clientRole = role;

            MainFrame.Navigate(new CatalogPage());
            Manager.mainFrame = MainFrame;
            MenuFrame.Navigate(new AdminMenu(role));
        }

        private void WindowClosed(object sender, EventArgs e)
        {
                this.Close();
                Owner.Show();
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult x = MessageBox.Show("Вы действительно хотите выйти?",
                "Выйти", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (x == MessageBoxResult.Cancel)
               e.Cancel = true;
        }
    }
}

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
    /// Логика взаимодействия для AddOrEditDeveloper.xaml
    /// </summary>
    public partial class AddOrEditDeveloper : Page
    {
        private Developer _currentDeveloper = new Developer();

        public AddOrEditDeveloper(Developer selectedDeveloper)
        {
            InitializeComponent();

            if (selectedDeveloper != null)
                _currentDeveloper = selectedDeveloper;

            DataContext = _currentDeveloper;
        }

        private void BtnOkClick(object sender, RoutedEventArgs e)
        {
            StringBuilder s = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentDeveloper.NameDevCorp))
                s.AppendLine("Поле название компании пустое");
            //if (string.IsNullOrWhiteSpace(_currentDeveloper.DevDescription))
            //    s.AppendLine("Поле описание пустое");
            if (string.IsNullOrWhiteSpace(_currentDeveloper.DevDirectorLastName))
                s.AppendLine("Поле фамилия основателя пустое");
            if (string.IsNullOrWhiteSpace(_currentDeveloper.DevDirectorName))
                s.AppendLine("Поле имя основателя пустое");
            if (DPickerCompanyWasFounded.SelectedDate == null)
                DPickerCompanyWasFounded.SelectedDate = DateTime.Now;

            if (s.Length > 0)
            {
                MessageBox.Show(s.ToString(), "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (_currentDeveloper.IdDeveloper == 0)
                GamerShopEntities.GetContext().Developers.Add(_currentDeveloper);

            try
            {
                GamerShopEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
                Manager.mainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult x = MessageBox.Show("Создание (/изменения) не будут применены. Вы действительно хотите выйти?",
                "Выйти", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (x == MessageBoxResult.OK)
                Manager.mainFrame.GoBack();
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

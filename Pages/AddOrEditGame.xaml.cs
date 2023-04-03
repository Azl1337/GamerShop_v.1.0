using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace GamerShop_v1._0.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddOrEditGame.xaml
    /// </summary>
    public partial class AddOrEditGame : Page
    {
        private Game _currentGame = new Game();
        private string _filePath = null;
        private string _photoName = null;
        private string _fileCompare = null;
        private static string _currentDirectory = Directory.GetCurrentDirectory() + @"\Images\";

        public AddOrEditGame(Game selectedGame)
        {
            InitializeComponent();
            
            if (selectedGame != null)
                _currentGame = selectedGame;
            
            DataContext = _currentGame;
            _photoName = _currentGame.GamePhoto;
            _fileCompare = _filePath;

            CBoxGameGenre.ItemsSource = GamerShopEntities.GetContext().Genres.ToList();
            CBoxGameDeveloper.ItemsSource = GamerShopEntities.GetContext().Developers.ToList();
            CBoxGamePublisher.ItemsSource = GamerShopEntities.GetContext().Publishers.ToList();
        }

        private void BtnOkClick(object sender, RoutedEventArgs e)
        {
            StringBuilder s = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentGame.GameTitle))
                s.AppendLine("Поле название пустое");
            if (_currentGame.Genre == null)
                s.AppendLine("Жанр не выбран");
            if (string.IsNullOrWhiteSpace(_currentGame.GameDescription))
                s.AppendLine("Поле описание пустое");
            if (_currentGame.Developer == null)
                s.AppendLine("Разработчик не выбран");
            if (_currentGame.Publisher == null)
                s.AppendLine("Издатель не выбран");
            if (string.IsNullOrWhiteSpace(_currentGame.GamePrice))
                s.AppendLine("Поле цена пустое");
            if (_currentGame.GameEvaluation is null ||
                _currentGame.GameEvaluation < 0 ||
                _currentGame.GameEvaluation > 10)
                s.AppendLine("Оценка игре выставлена некорректно, либо выставлена диапазоном" +
                    "ниже 0 или выше 10");
            if (string.IsNullOrWhiteSpace(_photoName))
                s.AppendLine("Фото не выбрано");

            if (s.Length > 0)
            {
                MessageBox.Show(s.ToString(), "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (_currentGame.IdGame == 0) 
            {
                string photo = ChangePhotoName();
                string dest = _currentDirectory + photo;
                File.Copy(_filePath, dest);
                _currentGame.GamePhoto = photo;
                GamerShopEntities.GetContext().Games.Add(_currentGame); 
            }

            try
            {
                if (_filePath != null)
                {
                    string photo = ChangePhotoName();
                    string dest = _currentDirectory + photo;
                    if (_filePath != _fileCompare)
                    {
                        File.Copy(_filePath, dest);
                        _currentGame.GamePhoto = photo;
                    }
                }
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

        private void BtnLoadPhotoClick(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "Выберите картинку";
                op.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files(*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                if (op.ShowDialog() == true)
                {
                    FileInfo fileInfo = new FileInfo(op.FileName);
                    if (fileInfo.Length > (1024 * 1024 * 2))
                    {
                        throw new Exception("Размер файла должен быть меньше 2Мб");
                    }
                    GamePhoto.Source = new BitmapImage(new Uri(op.FileName));
                    _photoName = op.SafeFileName;
                    _filePath = op.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                _filePath = null;
            }
        }

        string ChangePhotoName()
        {
            string x = _currentDirectory + _photoName;
            string photoname = _photoName;
            int i = 0;
            if (File.Exists(x))
            {
                while (File.Exists(x))
                {
                    i++;
                    x = _currentDirectory + i.ToString() + photoname;
                }
                photoname = i.ToString() + photoname;
            }
            return photoname;
        }
    }
}

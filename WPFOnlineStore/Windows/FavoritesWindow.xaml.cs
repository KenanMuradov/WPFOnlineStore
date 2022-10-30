using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using WPFOnlineStore.Models;

namespace WPFOnlineStore.Windows
{
    /// <summary>
    /// Логика взаимодействия для FavoritesWindow.xaml
    /// </summary>
    public partial class FavoritesWindow : Window
    {
        public ObservableCollection<ProductItem> Favorites { get; set; }

        public FavoritesWindow(ObservableCollection<ProductItem> favorites)
        {
            InitializeComponent();

            DataContext = this;

            Favorites = favorites;
        }
    }
}

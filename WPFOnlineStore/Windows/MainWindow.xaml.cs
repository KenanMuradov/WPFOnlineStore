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
using WPFOnlineStore.UserControls;
using WPFOnlineStore.Models;

namespace WPFOnlineStore.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ProductItem> Basket { get; set; }
        public ObservableCollection<ProductItem> Favorites { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Basket = new();
            Favorites = new();

            DataContext = this;

            wpProducts.Children.Add(new UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0),Favorites,Basket));
            wpProducts.Children.Add(new UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0),Favorites,Basket));
            wpProducts.Children.Add(new UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0),Favorites,Basket));
            wpProducts.Children.Add(new UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0),Favorites,Basket));
            wpProducts.Children.Add(new UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0),Favorites,Basket));
            wpProducts.Children.Add(new UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0),Favorites,Basket));
            wpProducts.Children.Add(new UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0),Favorites,Basket));
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow window = new();

            if (window.ShowDialog() == true)
            {
                if (window.ProductItem != null)
                    wpProducts.Children.Insert(0,new UC_ProductItem(window.ProductItem, Favorites, Basket));
            }
        }

        private void BtnBasket_Click(object sender, RoutedEventArgs e)
        {
            BasketWindow window = new(Basket);

            window.ShowDialog();
        }

        private void BtnFavorites_Click(object sender, RoutedEventArgs e)
        {
            FavoritesWindow window = new(Favorites);

            window.ShowDialog();
        }
    }
}

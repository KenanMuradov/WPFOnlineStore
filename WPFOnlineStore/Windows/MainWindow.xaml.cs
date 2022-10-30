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
using WPFOnlineStore.FakeRepo;

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

            foreach (var p in FakeRepository.ProductItems)
                wpProducts.Children.Add(new UC_ProductItem(p, Favorites, Basket));
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow window = new();

            if (window.ShowDialog() == true)
            {
                if (window.ProductItem != null)
                    wpProducts.Children.Insert(0, new UC_ProductItem(window.ProductItem, Favorites, Basket));
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

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                foreach (var control in wpProducts.Children.OfType<UC_ProductItem>())
                    control.Visibility = Visibility.Visible;

                return;
            }


            foreach (var control in wpProducts.Children.OfType<UC_ProductItem>())
            {
                if (!control.ProductItem.Product.Name!.ToLower().Contains(txtSearch.Text.ToLower()))
                    control.Visibility = Visibility.Collapsed;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
                ButtonSearch_Click(sender, e);
        }
    }
}

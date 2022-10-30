using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFOnlineStore.Models;
using WPFOnlineStore.Windows;

namespace WPFOnlineStore.UserControls;
public partial class UC_ProductItem : UserControl
{
    ObservableCollection<ProductItem> _basket;
    ObservableCollection<ProductItem> _favorites;

    public ProductItem ProductItem { get; set; }

    public UC_ProductItem(ProductItem productItem, ObservableCollection<ProductItem> favorites, ObservableCollection<ProductItem> basket)
    {
        InitializeComponent();

        DataContext = this;

        ProductItem = productItem;
        _basket = basket;
        _favorites = favorites;
    }

    private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        ProductInfoWindow window = new(ProductItem);
        window.Show();
    }

    private void BtnAddToBasket_Click(object sender, RoutedEventArgs e)
    {
        if(!_basket.Contains(ProductItem))
            _basket.Add(ProductItem);
    }

    private void BtnAddToFavorites_Click(object sender, RoutedEventArgs e)
    {
        if (!_favorites.Contains(ProductItem))
            _favorites.Add(ProductItem);
        else
            _favorites.Remove(ProductItem);
    }
}

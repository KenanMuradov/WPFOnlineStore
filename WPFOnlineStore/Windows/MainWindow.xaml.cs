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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ProductItem> Products { get; set; }
        public ObservableCollection<ProductItem> Basket { get; set; }
        public ObservableCollection<ProductItem> Favorites { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Products = new();
            Basket = new();
            Favorites = new();

            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));
            wpProducts.Children.Add(new UserControls.UC_ProductItem(new ProductItem(new Product("Cola", "Coca Cola", "None", "America", "Goods", "https://avatars.mds.yandex.net/i?id=26e3a28b6987baeb1878764b9b11b059-5665039-images-thumbs&n=13"), 20, 31, 0)));

        }



    }
}

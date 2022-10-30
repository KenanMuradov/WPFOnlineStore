using System.Windows.Controls;
using WPFOnlineStore.Models;
using WPFOnlineStore.Windows;

namespace WPFOnlineStore.UserControls;
public partial class UC_ProductItem : UserControl
{
    public ProductItem ProductItem { get; set; }

    public UC_ProductItem(ProductItem productItem)
    {
        InitializeComponent();

        DataContext = this;

        ProductItem = productItem;
    }

    private void UserControl_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        ProductInfoWindow window = new(ProductItem);
        window.Show();
    }
}

using System.Windows.Controls;
using WPFOnlineStore.Models;

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
}

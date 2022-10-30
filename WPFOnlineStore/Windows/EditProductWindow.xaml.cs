using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WPFOnlineStore.Models;

namespace WPFOnlineStore.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditProductInfo.xaml
    /// </summary>
    public partial class EditProductInfo : Window
    {



        public ProductItem ProductItem { get; set; }

        public EditProductInfo(ProductItem productItem)
        {
            ProductItem = productItem;

            DataContext = this;

            InitializeComponent();
        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new();

            foreach (var txt in MainGrid.Children.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    sb.Append($"All Fields must be filled\n");
                    break;
                }
            }

            if (!Regex.IsMatch(txtProductPrice.Text, @"^([0-9]+([,][0-9]*)?|[,][0-9]+)$"))
                sb.Append($"Incorrect Format For Price\n");

            if (!Regex.IsMatch(txtProductCount.Text, @"^(0|[1-9][0-9]*)$"))
                sb.Append($"Incorrect Format For Count\n");

            if (!Regex.IsMatch(txtProductDiscount.Text, @"^([0-9]+([,][0-9]*)?|[,][0-9]+)$"))
                sb.Append($"Incorrect Format For Discount\n");


            if (sb.Length > 0)
            {
                MessageBox.Show($"{sb}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            foreach (var txt in MainGrid.Children.OfType<TextBox>())
            {
                BindingExpression be = txt.GetBindingExpression(TextBox.TextProperty);
                be.UpdateSource();
            }

            DialogResult = true;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e) => DialogResult = false;
    }
}

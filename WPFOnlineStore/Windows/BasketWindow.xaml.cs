using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WPFOnlineStore.Windows;

public partial class BasketWindow : Window,INotifyPropertyChanged
{

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    public event PropertyChangedEventHandler? PropertyChanged;

    private double _totalCost;

    public double TotalCost
    {
        get { return _totalCost; }
        set 
        { 
            _totalCost = value; 
            NotifyPropertyChanged();
        }
    }



    public ObservableCollection<ProductItem> Basket {get; set; }

    public BasketWindow(ObservableCollection<ProductItem> basket)
    {

        InitializeComponent();

        DataContext = this;

        Basket = basket;

        foreach (var p in basket)
            TotalCost += p.Price;
    }


    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (TotalCost == 0)
        {
            MessageBox.Show("First Add Products to Basket", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
        }


        StringBuilder sb = new();


        foreach (var p in Basket)
            sb.Append($"{ p.Product.Name}\n");

        sb.Append($"Your Total Cost is: {TotalCost}");

        var result = MessageBox.Show($"{sb}", "Information", MessageBoxButton.YesNo, MessageBoxImage.Question);

        if (result == MessageBoxResult.Yes)
        {
            MessageBox.Show("Thanks for choosing us","Information",MessageBoxButton.OK,MessageBoxImage.Information);

            foreach (var p in Basket)
                --p.Count;

            Basket.Clear();
            TotalCost = 0;
        }
            
    }
}

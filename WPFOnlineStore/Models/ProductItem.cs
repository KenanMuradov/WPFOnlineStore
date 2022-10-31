using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFOnlineStore.Models;

public class ProductItem : INotifyPropertyChanged
{

    public event PropertyChangedEventHandler? PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


    private uint _count;

    public uint Count
    {
        get { return _count; }
        set 
        { 
            _count = value; 
            NotifyPropertyChanged();
        }
    }


    public Product Product { get; set; }
    public double Price { get; set; }
    public double Discount { get; set; }

    public ProductItem(Product product, uint count, double price, double discount)
    {
        Product = product;
        Count = count;
        Price = price;
        Discount = discount;
    }

}

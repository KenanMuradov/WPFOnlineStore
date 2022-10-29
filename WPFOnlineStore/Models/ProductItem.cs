using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFOnlineStore.Models;

public class ProductItem
{

    public Product Product { get; set; }
    public uint Count { get; set; }
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

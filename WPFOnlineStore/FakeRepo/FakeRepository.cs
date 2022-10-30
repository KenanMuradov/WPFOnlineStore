using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFOnlineStore.Models;

namespace WPFOnlineStore.FakeRepo;

public static class FakeRepository
{
    public static List<ProductItem> ProductItems { get; } = new()
    {
        new ProductItem(new Product("Samsung S22 Ultra", "Samsung", "Korea", "Electronics", "https://avatars.mds.yandex.net/i?id=1fa6fba40f9ff0d90be3889f8345e746-4210949-images-thumbs&n=13"), 200, 2099, 0),
        new ProductItem(new Product("CyberPunk 2077 Jacket", "Sendle", "America", "Clothes", "https://i.ebayimg.com/00/s/ODAwWDgwMA==/z/Mj0AAOSwLEJgP3LI/$_57.JPG?set_id=8800005007"), 24, 89, 10),
        new ProductItem(new Product("Samsung S22 Ultra", "Samsung", "Korea", "Electronics", "https://avatars.mds.yandex.net/i?id=1fa6fba40f9ff0d90be3889f8345e746-4210949-images-thumbs&n=13"), 200, 2099, 0),
        new ProductItem(new Product("Oni Mask", "Unkown", "Japan", "Entertainment", "https://i.etsystatic.com/isla/869fe4/31292052/isla_fullxfull.31292052_q2h5p33j.jpg?version=0"), 134, 15, 2),
        new ProductItem(new Product("CyberPunk 2077 Jacket", "Sendle", "America", "Clothes", "https://i.ebayimg.com/00/s/ODAwWDgwMA==/z/Mj0AAOSwLEJgP3LI/$_57.JPG?set_id=8800005007"), 24, 89, 10),
        new ProductItem(new Product("Oni Mask", "Unkown", "Japan", "Entertainment", "https://i.etsystatic.com/isla/869fe4/31292052/isla_fullxfull.31292052_q2h5p33j.jpg?version=0"), 134, 15, 2),
        new ProductItem(new Product("CyberPunk 2077 Jacket", "Sendle", "America", "Clothes", "https://i.ebayimg.com/00/s/ODAwWDgwMA==/z/Mj0AAOSwLEJgP3LI/$_57.JPG?set_id=8800005007"), 24, 89, 10),
        new ProductItem(new Product("Samsung S22 Ultra", "Samsung", "Korea", "Electronics", "https://avatars.mds.yandex.net/i?id=1fa6fba40f9ff0d90be3889f8345e746-4210949-images-thumbs&n=13"), 200, 2099, 0),
        new ProductItem(new Product("CyberPunk 2077 Jacket", "Sendle", "America", "Clothes", "https://i.ebayimg.com/00/s/ODAwWDgwMA==/z/Mj0AAOSwLEJgP3LI/$_57.JPG?set_id=8800005007"), 24, 89, 10),
        new ProductItem(new Product("Oni Mask", "Unkown", "Japan", "Entertainment", "https://i.etsystatic.com/isla/869fe4/31292052/isla_fullxfull.31292052_q2h5p33j.jpg?version=0"), 134, 15, 2),

    };
}

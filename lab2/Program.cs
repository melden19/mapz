//  MELNIK DENIS
//  1PI-16b
//  LAB 2
//  VARIANT 13
//  ADAPTER             - Legacy shop item, new shop item
//  FACADE              - Rozetka
//  FLYWEIGHT           - Shop item category(ShopItemFactory)

using System.Collections.Generic;
using OnlineShop;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rozetka rozetka = new Rozetka();

            List<IShopItem> shopItemsList = new List<IShopItem>() {
                ShopItemFactory.createShopItem("Laptop1", "High perfomance laptop", "path/to/image1", CategoryType.ELECTRONIC),
                ShopItemFactory.createShopItem("Laptop2", "Medium perfomance laptop", "path/to/image2", CategoryType.ELECTRONIC),
                ShopItemFactory.createShopItem("Laptop3", "Low perfomance laptop", "path/to/image3", CategoryType.ELECTRONIC),
                ShopItemFactory.createShopItem("Shoes", "44 size", "path/to/image4", CategoryType.CLOTHES),
                ShopItemFactory.createShopItem("T-shirt", "35 size", "path/to/image5", CategoryType.CLOTHES),
                ShopItemFactory.createShopItem("Toy", "Fot kids", "path/to/image6", CategoryType.UNEXISTED_CATEGORY),
                ShopItemFactory.createLegacyShopItem("Headphones", "64OM"),
            };

            shopItemsList.ForEach(item => {
                rozetka.addNewItem(item);
            });

            rozetka.printShopItems();
        }
    }
}
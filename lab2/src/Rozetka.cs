using System;
using System.Collections.Generic;

namespace OnlineShop {
    class Rozetka {
        private List<IShopItem> items = new List<IShopItem>();

        private readonly ShopItemValidator validator = new ShopItemValidator();
        private readonly ShopItemCompressor compressor = new ShopItemCompressor();

        public void addNewItem(IShopItem item) {
            try {
                validator.validate(item);
                compressor.compress(item);

                items.Add(item);
            } catch (Exception e) {
                Console.WriteLine($"Failed to add an image with message: {e.Message}");
            }
        }

        public void printShopItems() {
            this.items.ForEach((i => i.Print()));
        }
        public string getItemsList() {
            return String.Join("\n", this.items);
        }
    }
}
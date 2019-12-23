using System;

namespace OnlineShop {
    interface IShopItem {
        string Name { get; set; }
        string Description { get; set; }
        ShopItemImage Image { get; set; }
        Category Category { get; set; }
        void someRlyImportantMethod(dynamic data);
        void Print();
    }

    class ShopItem : IShopItem {
        private string name;
        private string description;
        private ShopItemImage image;
        private Category category;

        public string Name          { get => name;          set => name = value; }
        public string Description   { get => description;   set => description = value; }
        public ShopItemImage Image  { get => image;         set => image = value; }
        public Category Category  { get => category;         set => category = value; }

        public ShopItem(string name, string description, ShopItemImage image, Category category) {
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.Category = category;
        }

        public override string ToString() {
            return $"{Category}\t\t\t{Name}\t\t{Description}\t\t{Image}";
        }

        public void Print () {
            Console.WriteLine("{0,10}{1,15}{2,30}{3,20}",
                Category,
                Name,
                Description,
                Image
            );
        }

        public void someRlyImportantMethod(dynamic data) {
            Console.WriteLine("Some inportant stuff...");
        }
    }

    class ShopItemValidator {
        public void validate(IShopItem item) {
            bool failes = false;

            //  item validations

            if (failes) {
                throw new System.Exception("New item validation failes. Can`t add");
            }
        }
    }

    class ShopItemCompressor {
        public IShopItem compress(IShopItem item) {
            this.compressImage(item.Image);
            return item;
        }

        private void compressImage(ShopItemImage image) {
            image.compressed = true;
        }
    }
}

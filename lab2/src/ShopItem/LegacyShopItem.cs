using System;

namespace OnlineShop {
    class LegacyShopItem {
        public string legacyName;
        public string legacyDescription;

        public LegacyShopItem(string name, string description) {
            this.legacyName = name;
            this.legacyDescription = description;
        }

        public void someLegacyRlyImportantMethod(dynamic data) {
            Console.WriteLine("Some important stuff...");
        }
    }

    class LegacyShopItemAdapter : IShopItem {
        private LegacyShopItem legacyShopItem;

        private string name;
        private string description;
        private ShopItemImage image;
        private Category category;

        public string Name              { get => name;          set => name = value; }
        public string Description       { get => description;   set => description = value; }
        public ShopItemImage Image      { get => image;         set => image = value; }
        public Category Category        { get => category;      set => category = value; }

        public LegacyShopItemAdapter(LegacyShopItem item) {
            this.legacyShopItem = item;

            this.Name = item.legacyName;
            this.Description = item.legacyDescription;
            this.Image = new ShopItemImage("Not found image", "path/to/not_found");
            this.Category = ShopItemFactory.getCategory(CategoryType.NO_CATEGORY);
        }

        public void someRlyImportantMethod(dynamic someNewDataFormat) {
            Object legacyDataFormat = this.formatNewFormat(someNewDataFormat);
            this.legacyShopItem.someLegacyRlyImportantMethod(legacyDataFormat);
        }

        private dynamic formatNewFormat(dynamic newData) {
            dynamic legacyDataFormat = newData;
            return legacyDataFormat;
        }

        public override string ToString() {
            return $"{Name} - {Description}";
        }

        public void Print () {
            Console.WriteLine("{0,10}{1,15}{2,30}{3,20}",
                Category,
                Name,
                Description,
                Image
            );
        }
        
    }
}

using System;
using System.Collections.Generic;

namespace OnlineShop {
    enum CategoryType {
        ELECTRONIC,
        CLOTHES,
        UNEXISTED_CATEGORY,
        NO_CATEGORY
    }

    static class ShopItemFactory {
        static Dictionary<CategoryType, Category> categories = new Dictionary<CategoryType, Category>() {
            { CategoryType.ELECTRONIC,  new Category("electronic",  new HighResImage("electronic banner", "path/to/image")) },
            { CategoryType.CLOTHES,     new Category("clothes",     new HighResImage("clothes banner", "path/to/image"))    },
            { CategoryType.NO_CATEGORY, new Category("undefined",   new HighResImage("not found banner", "path/to/image"))  },
        };

        public static IShopItem createShopItem(string name, string description, string imagePath, CategoryType category) {
            return new ShopItem(
                name,
                description,
                new ShopItemImage($"{name}-image", imagePath),
                ShopItemFactory.getCategory(category)
            );
        }

        public static IShopItem createLegacyShopItem(string name, string description) {
            return new LegacyShopItemAdapter(
                new LegacyShopItem(
                    name,
                    description
                )
            );
        }

        public static Category getCategory(CategoryType category) {
            try {
                return ShopItemFactory.categories[category];
            } catch (Exception e) {
                if (e is KeyNotFoundException) {
                    return ShopItemFactory.categories[CategoryType.NO_CATEGORY];
                }
                throw e;
            }
        }
    }
}
using System;

namespace OnlineShop {
    class Category {
        public readonly string name;
        public readonly HighResImage someHighResBanner;

        public Category(string name, HighResImage banner) {
            this.name = name;
            this.someHighResBanner = banner;
        }

        public override string ToString() {
            return this.name;
        }
    }
}
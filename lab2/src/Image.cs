namespace OnlineShop {
    class Image {
        public readonly string name;
        public readonly string image;

        public Image(string name, string image) {
            this.name = name;
            this.image = image;
        }
    }

    class HighResImage : Image {
        public HighResImage(string name, string image) : base(name, image) {}
    }
    
    class ShopItemImage : Image {
        public bool compressed = false;

        public ShopItemImage(string name, string image) : base(name, image) {}

        public override string ToString() {
            return this.image;
        }
    }
}

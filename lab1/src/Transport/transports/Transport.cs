using lab1;

namespace Transport {
    interface ITransport {
        int getPrice();
        string getManufacturer();
    }

    public abstract class Transport : ITransport {
        public Transport() {
            Budget.getInstance().logPurchase(this.getPrice(), this);
        }

        public abstract int getPrice();
        public abstract string getManufacturer();
    }
}
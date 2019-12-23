namespace Transport {
    interface ITram : ITransport {
        int getPassengersCount();
    }

    class DomesticTram : Transport, ITram {

        public override int getPrice() {
            return 500;
        }

        public override string getManufacturer() {
            return "Ukraine";
        }

        public int getPassengersCount() {
            return 100;
        }

    }

    class ImportedTram : Transport, ITram {
        private readonly string importer;

        public ImportedTram(string importer) : base() {
            this.importer = importer;
        }

        public override int getPrice() {
            return 1000;
        }

        public override string getManufacturer() {
            return this.importer;
        }

        public int getPassengersCount() {
            return 50;
        }

    }
}

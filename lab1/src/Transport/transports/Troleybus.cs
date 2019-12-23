namespace Transport {
    interface ITroleybus : ITransport {
        int getPassengersCount();
    }

    class DomesticTroleybus : Transport, ITroleybus {

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

    class ImportedTroleybus : Transport, ITroleybus {
        private readonly string importer;

        public ImportedTroleybus(string importer) : base() {
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

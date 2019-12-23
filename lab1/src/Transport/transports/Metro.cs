namespace Transport {
    interface IMetro : ITransport {
        int getCarriageCount();
    }

    class DomesticMetro : Transport, IMetro {
        public override int getPrice() {
            return 500;
        }

        public override string getManufacturer() {
            return "Ukraine";
        }

        public int getCarriageCount() {
            return 8;
        }
    }

    class ImportedMetro : Transport, IMetro {
        private readonly string importer;

        public ImportedMetro(string importer) : base() {
            this.importer = importer;
        }

        public override int getPrice() {
            return 10000;
        }
        
        public override string getManufacturer() {
            return this.importer;
        }

        public int getCarriageCount() {
            return 10;
        }
    }
}

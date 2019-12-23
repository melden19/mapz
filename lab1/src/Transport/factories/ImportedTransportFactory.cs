namespace Transport {

    class ImportedTransportFactory : ITransportFactory {
        private readonly string importer;

        public ImportedTransportFactory(string importer) {
            this.importer = importer;
        }

        public IMetro createMetro() {
            return new ImportedMetro(this.importer);
        }
        public ITram createTram() {
            return new ImportedTram(this.importer);
        }
        public ITroleybus createTroleybus() {
            return new ImportedTroleybus(this.importer);
        }
    }
}
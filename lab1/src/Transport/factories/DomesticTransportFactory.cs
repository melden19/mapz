namespace Transport {

    class DomesticTransportFactory : ITransportFactory {

        public IMetro createMetro() {
            return new DomesticMetro();
        }
        public ITram createTram() {
            return new DomesticTram();
        }
        public ITroleybus createTroleybus() {
            return new DomesticTroleybus();
        }
    }
}
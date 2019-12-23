namespace Transport {
    interface ITransportFactory {
        IMetro createMetro();
        ITram createTram();
        ITroleybus createTroleybus();
    }
}

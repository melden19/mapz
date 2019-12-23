using System;
using Transport;

namespace lab1
{
    class Budget {
        static private Budget instance;

        static public Budget getInstance() {
            if (instance == null) {
                instance = new Budget();
            }
            return instance;
        }

        private int limit;
        private int used = 0;

        public void setLimit(int limit) {
            this.limit = limit;
        }

        public void logPurchase(int cost, Transport.Transport transport) {
            this.used =+ cost;
            if (this.used > this.limit) {
                throw new BudgetExeededExeption(transport);
            }
        }
    }
}

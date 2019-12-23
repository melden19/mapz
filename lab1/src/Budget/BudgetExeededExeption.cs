using System;

namespace Transport {

    public class BudgetExeededExeption : Exception
    {
        public BudgetExeededExeption(Transport transport)
            : base($"Failed to create transport {transport.ToString()}, budget exeeded") {}
    }
}
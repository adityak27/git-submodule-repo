using System;
using OperationsDef;

namespace OperationsImpl
{
    public class Operations : IOperations
    {
        Logger.Logger logger;

        public Operations()
        {
            logger = Logger.Logger.GetLogger(@"C:\OperationsLog.txt");
        }

        public int Add(int val1, int val2)
        {
            return val1 + val2;
        }

        public int Divide(int val1, int val2)
        {
            return val1 / val2;
        }

        public int Multiply(int val1, int val2)
        {
            return val1 * val2;
        }

        public int Subtract(int val1, int val2)
        {
            return val1 - val2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsDef
{
    public interface IOperations
    {
        int Add(int val1, int val2);

        int Subtract(int val1, int val2);

        int Multiply(int val1, int val2);

        int Divide(int val1, int val2);
    }

    public enum OperationType
    {
        Add,
        Subtract,
        Divide,
        Multiply
    }
}

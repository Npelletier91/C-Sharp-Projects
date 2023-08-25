using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingOptional
{
    public class OperationMethod
    {
        
        public int operation (int number1, int number2 = 0)
        {
            return number1 + number2;
        }
    }
}

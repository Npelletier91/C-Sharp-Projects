using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingOptional
{
    public class OperationMethod
    {
        
        public int operation (int number1)
        {
            return number1 + 10;
        }
        public int operation (int number1 , int number2)
        {
            return number1 + number2;
        }
    }
}

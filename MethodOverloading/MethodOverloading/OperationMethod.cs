using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class OperationMethod
    {
        Random random = new Random();
        public int RandomNumber { get; private set; }

        public int operation (int number)
        {
            return number - 5;
        }
        public int operation (Decimal number)
        {
            return Convert.ToInt32(number) * 1000;
        }
        public int operation (String number)
        {
            int randomNum = random.Next(0, 1000);
            RandomNumber = randomNum;
            return Convert.ToInt32(number) * randomNum;
        }
    }
}

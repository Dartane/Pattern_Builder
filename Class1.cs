using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeChecker
{

    public class Class1
    {
        public static bool ValidatePrice(int price)
        {
            if(price == 0 || price < 0 ) return false;
            return true;
        }
    }
}

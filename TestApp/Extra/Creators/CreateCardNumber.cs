using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLandBank.Extra.Creators
{
    public class CreateCardNumber
    {
        public static long CreateNumberCard()
        {
            Random random = new Random();
            long cardNumber = 1200000 + random.Next(10000, 99999);
            return cardNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLandBank.Extra.Creators
{
    public class CreateNationalCodeNumber
    {
        public static long GetNationalNumber()
        {
            Random random = new Random();
            long nationalNumberVar = 110000;
            nationalNumberVar = random.Next(1000, 9999);
            return nationalNumberVar; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLandBank.Extra.Creators
{
    public class CreateRandomId
    {
        public static int GetId()
        {
            Random random = new Random();
            return random.Next(1000,9999);
        }
    }
}

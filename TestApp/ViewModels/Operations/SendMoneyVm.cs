using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLandBank.ViewModels.Operations
{
    public class SendMoneyVm
    {
        public long UserCardNumber { get; set; }
        public long SecendUserCardNumber { get; set; }
        public decimal Money { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLandBank.Models.UserModels
{
    public class UserEditVm
    {
        public string NewUsername { get; set; }
        public string NewPassword { get; set; }
        public long CardNumber { get; set; }

    }
}

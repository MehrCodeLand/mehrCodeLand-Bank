using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models.UserModels;

namespace CodeLandBank.Core.Engins
{
    public class Engin
    {
        public string Username { get; set; }
        public long  NationalCodeNumber { get; set; }
        public bool UserIsLogin { get; set; } = false;
        public long CardNumber { get; set; }
        public bool IsBan { get; set; }

        
    }
}

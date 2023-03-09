using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models.UserModels
{
    public class User
    {
        public int MyUserId { get; set; }
        public string Usrename { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public long NationalNumber { get; set; }
        public long CardNumber { get; set; }
        public decimal Money { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public bool IsBan { get; set; } = false;
    }
}

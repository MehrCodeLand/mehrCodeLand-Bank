using CodeLandBank.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models.UserModels;

namespace CodeLandBank.Core.Repositories
{
    public class BankRepository : IBankServices
    {
        private readonly string _path = "";
        public int CreateUsersData()
        {
            IList<User> user = new List<User>();
            return 0;
        }

        private IList<User> CreateUsers()
        {
            IList<User> users = new List<User>();
             return users;
        }
    }
}

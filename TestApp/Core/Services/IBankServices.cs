using CodeLandBank.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models.UserModels;

namespace CodeLandBank.Core.Services
{
    public interface IBankServices
    {
        int CreateUsersData();
        int ValidationLogininputs(LoginUserVm loginVm);
        int LoginUser(LoginUserVm loginUser);

    }
}

using CodeLandBank.Core.Services;
using CodeLandBank.Extra.Creators;
using CodeLandBank.Extra.Security;
using CodeLandBank.Models.UserModels;
using CodeLandBank.ViewModels.Operations;
using CodeLandBank.ViewModels.UserViewModels;
using Newtonsoft.Json;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models.UserModels;

/*
 369 -> succsess
 1001 -> data is valid
 */


namespace CodeLandBank.Core.Repositories
{
    public class BankRepository : IBankServices
    {
        private readonly string _path = @"C:\BankJsonUsers\UsersJsonFile.json";

        #region Create Data And JSON File
        public int CreateUsersData()
        {
            int result;
            IList<User> users = new List<User>();
            users = CreateUsers();

            result = CreateFolderFile();
            // if file was created , we will not create that again
            if (result == 1001)
            {
                return 1001;
            }


            result = WriteToJsonFile(ConvertUsersToString(users));


            return result;
        }
        private IList<User> CreateUsers()
        {
            IList<User> users = new List<User>();
            var personGenerator = new PersonNameGenerator();

            #region Create User

            var fName = personGenerator.GenerateRandomFirstName();
            User user1 = new User()
            {
                MyUserId = CreateRandomId.GetId(),
                FirstName = fName.ToUpper(),
                LastName = personGenerator.GenerateRandomLastName().ToUpper(),
                Usrename = fName.ToLower(),
                Password = HashPasswordC.EncodePasswordMd5("1245"),
                NationalNumber = CreateNationalCodeNumber.GetNationalNumber(),
                CardNumber = CreateCardNumber.CreateNumberCard(),
                Money = 20000,
            };

            fName = personGenerator.GenerateRandomFirstName();
            User user2 = new User()
            {
                MyUserId = CreateRandomId.GetId(),
                FirstName = fName.ToUpper(),
                LastName = personGenerator.GenerateRandomLastName().ToUpper(),
                Usrename = fName.ToLower(),
                Password = HashPasswordC.EncodePasswordMd5("1245"),
                NationalNumber = CreateNationalCodeNumber.GetNationalNumber(),
                CardNumber = CreateCardNumber.CreateNumberCard(),
                Money = 20000,
            };

            fName = personGenerator.GenerateRandomFirstName();
            User user3 = new User()
            {
                MyUserId = CreateRandomId.GetId(),
                FirstName = fName.ToUpper(),
                LastName = personGenerator.GenerateRandomLastName().ToUpper(),
                Usrename = fName.ToLower(),
                Password = HashPasswordC.EncodePasswordMd5("1245"),
                NationalNumber = CreateNationalCodeNumber.GetNationalNumber(),
                CardNumber = CreateCardNumber.CreateNumberCard(),
                Money = 20000,
            };


            fName = personGenerator.GenerateRandomFirstName();
            User user4 = new User()
            {
                MyUserId = CreateRandomId.GetId(),
                FirstName = fName.ToUpper(),
                LastName = personGenerator.GenerateRandomLastName().ToUpper(),
                Usrename = fName.ToLower(),
                Password = HashPasswordC.EncodePasswordMd5("1245"),
                NationalNumber = CreateNationalCodeNumber.GetNationalNumber(),
                CardNumber = CreateCardNumber.CreateNumberCard(),
                Money = 20000,
            };

            fName = personGenerator.GenerateRandomFirstName();
            User user5 = new User()
            {
                MyUserId = CreateRandomId.GetId(),
                FirstName = fName.ToUpper(),
                LastName = personGenerator.GenerateRandomLastName().ToUpper(),
                Usrename = fName.ToLower(),
                Password = HashPasswordC.EncodePasswordMd5("1245"),
                NationalNumber = CreateNationalCodeNumber.GetNationalNumber(),
                CardNumber = CreateCardNumber.CreateNumberCard(),
                Money = 20000,
            };


            fName = personGenerator.GenerateRandomFirstName();
            User user6 = new User()
            {
                MyUserId = CreateRandomId.GetId(),
                FirstName = fName.ToUpper(),
                LastName = personGenerator.GenerateRandomLastName().ToUpper(),
                Usrename = fName.ToLower(),
                Password = HashPasswordC.EncodePasswordMd5("1245"),
                NationalNumber = CreateNationalCodeNumber.GetNationalNumber(),
                CardNumber = CreateCardNumber.CreateNumberCard(),
                Money = 20000,
            };

            fName = personGenerator.GenerateRandomFirstName();
            User user7 = new User()
            {
                MyUserId = CreateRandomId.GetId(),
                FirstName = fName.ToUpper(),
                LastName = personGenerator.GenerateRandomLastName().ToUpper(),
                Usrename = fName.ToLower(),
                Password = HashPasswordC.EncodePasswordMd5("1245"),
                NationalNumber = CreateNationalCodeNumber.GetNationalNumber(),
                CardNumber = CreateCardNumber.CreateNumberCard(),
                Money = 20000,
            };

            fName = personGenerator.GenerateRandomFirstName();
            User user8 = new User()
            {
                MyUserId = CreateRandomId.GetId(),
                FirstName = fName.ToUpper(),
                LastName = personGenerator.GenerateRandomLastName().ToUpper(),
                Usrename = fName.ToLower(),
                Password = HashPasswordC.EncodePasswordMd5("1245"),
                NationalNumber = CreateNationalCodeNumber.GetNationalNumber(),
                CardNumber = CreateCardNumber.CreateNumberCard(),
                Money = 20000,
            };

            #endregion

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);
            users.Add(user6);
            users.Add(user7);
            users.Add(user8);


            return users;

        }
        private string ConvertUsersToString( IList<User> users)
        {
            var usersString = JsonConvert.SerializeObject(users, Formatting.Indented);
            return usersString;
        }
        private int CreateFolderFile()
        {
            if (!File.Exists(_path))
            {
                System.IO.Directory.CreateDirectory(@"C:\BankJsonUsers");
                var myFile = File.Create(@"C:\BankJsonUsers\UsersJsonFile.json");
                myFile.Close();
                return 369;
            }else
            {
                return 1001;
            }

            //else
            //{
            //    File.Delete(_path);
            //    System.IO.Directory.Delete(@"C:\BankJsonUsers");
            //    CreateFolderFile();
            //}
        }
        // 369 -> Success
        private int WriteToJsonFile(string usersStr )
        {
            File.WriteAllText(_path, usersStr);
            
            return 369;
        }
        private string ReadAllUsers()
        {
            var allUsersBankStr = File.ReadAllText(_path);
            return  allUsersBankStr ;
        }
        private IList<User> ConvertToUsers()
        {
            var allUsersBankStr = ReadAllUsers();
            IList<User> users = new List<User>();
            users = JsonConvert.DeserializeObject<IList<User>>(allUsersBankStr);
            return users;
        }

        #endregion


        #region Login User

        // 423-> number
        // 323-> username
        public int ValidationLogininputs(LoginUserVm loginVm)
        {
            bool isNumber = loginVm.Username.All(char.IsDigit);
            if (isNumber)
            {
                return 423;
            }
            else
            {
                return 323;
            }
        }


        // 2323 -> login Done
        // 4433 -> login faild
        // 1923 -> Somthings Wrong
        public int LoginUser(LoginUserVm loginUser)
        {
            IList<User> users = new List<User>();
            users = ConvertToUsers();

            // time to cheack password and username


            User isLogin = users.SingleOrDefault(u => u.Usrename == loginUser.Username || u.NationalNumber == loginUser.NationalCodeNumber);
            if(isLogin != null)
            {
                if(isLogin.Password == loginUser.Password)
                {
                    return 2323;
                }
            }
            else
            {
                return 4433;
            }
            return 4433;
        }




        #endregion

        #region Finding Staff

        // -123 -> Not Found
        public long FindCardNumber(LoginUserVm loginUser)
        {
            IList<User> users = ConvertToUsers();

            User user = users.SingleOrDefault(u => u.NationalNumber == loginUser.NationalCodeNumber || u.Usrename == loginUser.Username);
            if(user != null)
            {
                return user.CardNumber; 
            }

            return -123;

        }
        public User FindUserByCardNumber(long cardNumber)
        {
            IList<User> users = ConvertToUsers();

            User user = users.SingleOrDefault(U => U.CardNumber == cardNumber);
            return user;
            
        }


        // -111 -> username is exist
        // 111 -> username is not exist
        public int IsUsernameExist(string username)
        {
            IList<User> users = ConvertToUsers();

            User user = users.SingleOrDefault(u => u.Usrename == username);
            if(user != null) { return -111; }
            return 111 ;
        }



        #endregion

        #region Edit User

        public int EditUser(UserEditVm userEdit)
        {
            IList<User> users = ConvertToUsers();
            IList<User> forDeleteUser = new List<User>();


            // old User
            User myEditUser = users.SingleOrDefault(u => u.CardNumber == userEdit.CardNumber);

            // for delete 
            forDeleteUser.Add(myEditUser);

            //1-update data
            myEditUser.Usrename = userEdit.NewUsername;
            if (userEdit.NewPassword != null)
            {
                myEditUser.Password = userEdit.NewPassword;
            }

            // DleteUser --> new users list and without old one
            // then we update our users
            users = RemoveUser(forDeleteUser);
            users.Add(myEditUser);

            //3 save new data 
            SaveNewUsers(users);


            return 20065;
        }

        private IList<User> RemoveUser(IList<User> deleteUsers )
        {
            IList<User> users = ConvertToUsers();
            foreach(var user in deleteUsers)
            {
                users.Remove(users.SingleOrDefault(u => u.CardNumber == user.CardNumber));
            }

            return users;
        }
        private void SaveNewUsers(IList<User> users)
        {
            // convert to string
            var userStr = JsonConvert.SerializeObject(users);

            // delete last file
            if (File.Exists(_path))
            {
                File.Delete(_path);
            }

            // create new file
            var myFile = File.Create(@"C:\BankJsonUsers\UsersJsonFile.json");
            myFile.Close();

            File.WriteAllText(_path, userStr);


        }




        #endregion

        #region Send Money


        /*
         * -531 -> secend User Not Found
         * -867 -> money is to high
         * -923 -> Your Money Less than that money you want
         * -9999 -> Same Users
         * 999 -> TRUE
         */

        public int ValidationSendMoneyData(SendMoneyVm sendMoney)
        {
            if(sendMoney.SecendUserCardNumber == sendMoney.UserCardNumber) { return -9999; }
            IList<User> users = ConvertToUsers();
            User secendUser = users.SingleOrDefault(u => u.CardNumber == sendMoney.SecendUserCardNumber);
            User user = users.SingleOrDefault(u => u.CardNumber == sendMoney.UserCardNumber);

            if(secendUser == null) { return -531;  }
            else if(sendMoney.Money > 10000 ) { return -867;  }

            var isMoneyexist = user.Money - sendMoney.Money;
            if(isMoneyexist < 500) { return -923;  };


            return 999 ;

        }
        public int DoTradeMoney(SendMoneyVm sendMoney)
        {
            IList<User> users = ConvertToUsers();
            IList<User> deleteUsers = new List<User>();
            IList<User> saveUsers = new List<User>();


            User firstUser = users.SingleOrDefault(u => u.CardNumber == sendMoney.UserCardNumber);
            User secendUser = users.SingleOrDefault(u => u.CardNumber == sendMoney.SecendUserCardNumber);

            // For Delete User
            deleteUsers.Add(firstUser);
            deleteUsers.Add(secendUser);

            // Trade
            firstUser.Money -= sendMoney.Money;
            secendUser.Money += sendMoney.Money;

            // add Users
            saveUsers = DeleteUsers(deleteUsers);
            saveUsers.Add(firstUser);
            saveUsers.Add(secendUser);

            // Save Data
            SaveNewData(saveUsers);

            return 2234;
        }
        #endregion

        #region Save User Section
        private IList<User> DeleteUsers(IList<User> deleteUsers)
        {
            IList<User> users = ConvertToUsers();
            foreach( User deleteUser in deleteUsers)
            {
                users.Remove(users.SingleOrDefault(u => u.CardNumber == deleteUser.CardNumber));
            }

            return users;
        }
        private void SaveNewData( IList<User> users )
        {
            var usersStr = JsonConvert.SerializeObject(users , Formatting.Indented);

            // delete last file
            if (File.Exists(_path))
            {
                File.Delete(_path);
            }

            // create new file
            var myFile = File.Create(@"C:\BankJsonUsers\UsersJsonFile.json");
            myFile.Close();

            File.WriteAllText(_path, usersStr);
        }
        #endregion
    }

}

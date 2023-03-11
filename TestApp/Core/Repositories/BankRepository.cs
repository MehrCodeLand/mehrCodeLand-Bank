using CodeLandBank.Core.Services;
using CodeLandBank.Extra.Creators;
using CodeLandBank.Extra.Security;
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
        public int CreateUsersData()
        {
            int result; 
            IList<User> users = new List<User>();
            users = CreateUsers();

            result = CreateFolderFile();
            // if file was created , we will not create that again
            if(result == 1001)
            {
                return 1001;
            }


            result = WriteToJsonFile(ConvertUsersToString(users));


            return result;
        }

        #region Create Data And JSON File

        private IList<User> CreateUsers()
        {
            IList<User> users = new List<User>();
            var personGenerator = new PersonNameGenerator();

            #region Create_User

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
            foreach(var user in users)
            {
                if ((user.Password == loginUser.Password) && ((loginUser.Username == user.Usrename) || (loginUser.NationalCodeNumber == user.NationalNumber)))
                {
                    // user login Now!
                    return 2323;
                }
                else
                {
                    return 4433;
                }
            }

            return 1923;
        }


        #endregion
        // 323 -> Username is Username
        // 423 -> Username is National Code


    }

}

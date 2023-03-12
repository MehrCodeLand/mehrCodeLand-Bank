using CodeLandBank.Core.Engins;
using CodeLandBank.Core.Services;
using CodeLandBank.Extra.Security;
using CodeLandBank.Forms.ErrorsForms;
using CodeLandBank.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp;
using TestApp.Forms.BankForms;

namespace CodeLandBank.Forms.BankForms
{
    public partial class LoginFm : Form
    {
        private readonly IBankServices _bank;
        private Engin _engin;
        public LoginFm( IBankServices bank , Engin engin)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            int result; 
            _bank = bank;
            _engin = engin;
            result = _bank.CreateUsersData();
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainFm main = new MainFm();
            this.Close();
            main.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            int result; 

            LoginUserVm login = new LoginUserVm()
            {
                Username = UsernameTextBox.Text,
                Password = PasswordtextBox.Text,
            };

            // Validation Password & Username
            if (login.Password.Length < 4)
            {
                string message = "Your password wich you\n" +
                    " Enter, was short!\n";
                MessageBox.Show(message);
                Thread.Sleep(400);

                LoginFm reloadLoginFm = new LoginFm(_bank , _engin);
                reloadLoginFm.Show();
                Thread.Sleep(250);
                this.Close();

            }else if(login.Username.Length < 2)
            {
                string message = "Your Username wich you\n" +
                     " Enter, was short!\n";
                MessageBox.Show(message);
                Thread.Sleep(400);

                LoginFm reloadLoginFm = new LoginFm(_bank , _engin);
                reloadLoginFm.Show();
                Thread.Sleep(250);
                this.Close();
            }
            else
            {

                // validfation data
                // 2323 -> login Done
                // 4433 -> login faild
                // 1923 -> Somthings Wrong
                // 423-> NationalNumber code
                // 323-> username



                result = _bank.ValidationLogininputs(login);

                // National Code or Username
                if (result != 323)
                {
                    // we have national number code 
                    login.NationalCodeNumber = Convert.ToInt32(login.Username);
                    login.Password = HashPasswordC.EncodePasswordMd5(login.Password);
                    login.Username = null;

                    int loginResult = _bank.LoginUser(login);
                    if (loginResult == 1932)
                    {
                        var message = "Somthings Wrong, please try again!";
                        MessageBox.Show(message);

                        // somthings wrong
                        LoginFm loginFm = new LoginFm(_bank, _engin);
                        loginFm.Show();
                        Thread.Sleep(400);
                        this.Close();

                    }
                    else if (loginResult == 4433)
                    {
                        // login faild
                        var message = "Losing Faild,Please try again.\n";
                        MessageBox.Show(message);
                        LoginFm loginFm = new LoginFm(_bank, _engin);
                        loginFm.Show();
                        Thread.Sleep(300);
                        this.Close();
                    }
                    else if (loginResult == 2323)
                    {
                        var cardNumber = _bank.FindCardNumber(login);
                        if (cardNumber == -123)
                        {
                            WeHaveSomeProblemFm problemFm = new WeHaveSomeProblemFm();
                            problemFm.Show();
                            this.Close();
                        }
                        // login done
                        _engin.UserIsLogin = true;
                        _engin.NationalCodeNumber = login.NationalCodeNumber;
                        _engin.Username = login.Username;
                        _engin.CardNumber = cardNumber;

                        var message = "   Done!   \n";
                        MessageBox.Show(message);
                        UserPannelFm userPannel = new UserPannelFm( _bank , _engin);
                        userPannel.Show();
                        Thread.Sleep(300);
                        this.Close();
                    }
                }
                else
                {
                    // 101 -> Null 
                    // we have username <str>
                    login.Password = HashPasswordC.EncodePasswordMd5(login.Password);
                    login.NationalCodeNumber = 101;

                    int loginResult = _bank.LoginUser(login);
                    if (loginResult == 1932)
                    {
                        var message = "Somthings Wrong, please try again!";
                        MessageBox.Show(message);

                        // somthings wrong
                        LoginFm loginFm = new LoginFm(_bank, _engin);
                        loginFm.Show();
                        Thread.Sleep(400);
                        this.Close();
                    }
                    else if (loginResult == 4433)
                    {
                        // login faild
                        var message = "Losing Faild,Please try again.\n";
                        MessageBox.Show(message);
                        LoginFm loginFm = new LoginFm(_bank, _engin);
                        loginFm.Show();
                        Thread.Sleep(300);
                        this.Close();
                    }
                    else if (loginResult == 2323)
                    {
                        var cardNumber = _bank.FindCardNumber(login);
                        if(cardNumber == -123)
                        {
                            WeHaveSomeProblemFm problemFm = new WeHaveSomeProblemFm();
                            problemFm.Show();
                            this.Close();
                        }
                        // login done
                        _engin.UserIsLogin = true;
                        _engin.NationalCodeNumber = login.NationalCodeNumber;
                        _engin.Username = login.Username;
                        _engin.CardNumber = cardNumber;

                        var message = "   Done!   \n";
                        MessageBox.Show(message);
                        UserPannelFm userPannel = new UserPannelFm( _bank , _engin);
                        userPannel.Show();
                        Thread.Sleep(300);
                        this.Close();
                    }
                }
            }
        }
    }
}

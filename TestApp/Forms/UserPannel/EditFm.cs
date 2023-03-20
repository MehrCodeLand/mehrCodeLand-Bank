using CodeLandBank.Core.Engins;
using CodeLandBank.Core.Services;
using CodeLandBank.Extra.Security;
using CodeLandBank.Forms.BankForms;
using CodeLandBank.Forms.ErrorsForms;
using CodeLandBank.Models.UserModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLandBank.Forms.UserPannel
{
    public partial class EditFm : Form
    {
        private IBankServices _bank;
        private Engin _engin;

        public EditFm( IBankServices bank , Engin engin)
        {
            _bank = bank;
            _engin = engin;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            FillData();

        }

        private void FillData()
        {
            usernameData.Text = _engin.Username;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (!passwordCheackB.Checked)
            {
                // user dont want to change password.
                int result = ValidationData(usernameData.Text);
                if(result != 12021)
                {
                    ShowResult(result);
                }
                else
                {
                    // ready to update user
                    UserEditVm userEdit = new UserEditVm()
                    {
                        NewUsername = usernameData.Text.ToLower(),
                        CardNumber = _engin.CardNumber,
                    };
                    result = _bank.EditUser(userEdit);
                    if (result == 20065)
                    {
                        Application.Restart();
                    }
                }
            }
            else
            {
                int result = ValidationData(usernameData.Text, PasswordBox.Text, RepasswordBox.Text);
                if(result != 12021)
                {
                    ShowResult(result);
                }
                else
                {
                    // ready to update data 
                    UserEditVm userEdit = new UserEditVm()
                    {
                        NewUsername = usernameData.Text.ToLower(),
                        NewPassword = HashPasswordC.EncodePasswordMd5(PasswordBox.Text),
                        CardNumber = _engin.CardNumber,
                    };
                    result =  _bank.EditUser(userEdit);
                    if(result == 20065)
                    {
                        Application.Restart();
                    }
                }
            }

        }

        // 890 -> username is null or small
        // 990 -> password is null or small
        // 550 -> repaswword and password is not same 
        // 12021 -> OK
        private void ShowResult(int result)
        {
            var message = "";
            // our respound to wrong data
            if (result == 890)
            {
                message = "username is to small!";
                MessageBox.Show(message);

                EditFm editFm = new EditFm(_bank, _engin);
                editFm.Show();
                Thread.Sleep(300);
                this.Close();
            }
            else if (result == 990)
            {
                message = "password is to small!";
                MessageBox.Show(message);

                EditFm editFm = new EditFm(_bank, _engin);
                editFm.Show();
                Thread.Sleep(300);
                this.Close();
            }
            else if (result == 550)
            {
                message = "Password and RePassword is not same!";
                MessageBox.Show(message);

                EditFm editFm = new EditFm(_bank, _engin);
                editFm.Show();
                Thread.Sleep(300);
                this.Close();
            }
            else if (result == -11)
            {
                message = "Usernaem is exist!";
                MessageBox.Show(message);

                EditFm editFm = new EditFm(_bank, _engin);
                editFm.Show();
                Thread.Sleep(300);
                this.Close();
            }
            else if (result == 12021)
            {
                WeHaveSomeProblemFm weHave = new WeHaveSomeProblemFm();
                weHave.Show();
                Thread.Sleep(120);
                this.Close();
            }
        }
        private int ValidationData(string newUsername)
        {
            if (newUsername == null || newUsername.Length < 2 || newUsername.Length > 12) { return 890; }
            // is username exist ?? 
            int result = _bank.IsUsernameExist(newUsername);
            if (result == -111) { return -111; }

            return 12021;
        }
        private int ValidationData( string newUsername , string newPassword , string Repassword)
        {
            if(newUsername == null || newUsername.Length < 2 || newUsername.Length > 12 ) { return 890;  }
            else if(newPassword == null || newPassword.Length < 4) { return 990; }
            else if(Repassword != newPassword) { return 550; }


            // is username exist ?? 
            int result = _bank.IsUsernameExist(newUsername);
            if(result == -111) { return -111; }
            else if(result == 111) { return 111; }
            return 12021; 
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            UserPannelFm pannelFm = new UserPannelFm(_bank, _engin);
            pannelFm.Show();
            Thread.Sleep(200);
            this.Close();
        }
    }
}

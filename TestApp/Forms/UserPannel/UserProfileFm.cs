using CodeLandBank.Core.Engins;
using CodeLandBank.Core.Services;
using CodeLandBank.Forms.BankForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Models.UserModels;

namespace CodeLandBank.Forms.UserPannel
{
    public partial class UserProfileFm : Form
    {
        private IBankServices _bank;
        private Engin _engin;
        public UserProfileFm( IBankServices bank , Engin engin)
        {
            _bank = bank;
            _engin = engin;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            FillData();
        }

        private User FindUser()
        {
            User user = _bank.FindUserByCardNumber(_engin.CardNumber);
            return user;
        }
        private void FillData()
        {
            User user = FindUser();

            usernameData.Text = user.Usrename;
            cardNumberbox.Text = user.CardNumber.ToString();
            nationalCodeNumberbox.Text = user.NationalNumber.ToString();
            MoneyBox.Text = user.Money.ToString();
            FirstNameBox.Text = user.FirstName.ToString();
            LastNameBox.Text = user.LastName.ToString();


        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            UserPannelFm userPannel = new UserPannelFm( _bank , _engin );
            userPannel.Show();
            Thread.Sleep(300);
            this.Close();
        }
    }
}

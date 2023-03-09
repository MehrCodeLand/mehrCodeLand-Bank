using CodeLandBank.Core.Services;
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
        public LoginFm( IBankServices bank)
        {
            int result; 
            _bank = bank;
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

        }
    }
}

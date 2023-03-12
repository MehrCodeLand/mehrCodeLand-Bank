using CodeLandBank.Core.Engins;
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
using TestApp.Forms.BankForms;

namespace CodeLandBank.Forms.BankForms
{
    public partial class UserPannelFm : Form
    {
        private IBankServices _bank;
        private Engin _engin;
        public UserPannelFm( IBankServices bank , Engin engin)
        {
            _bank = bank;
            _engin = engin;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            FillAutoData();
        }

        private void FillAutoData()
        {
            usernameData.Text = _engin.Username;
            cardNumberbox.Text = _engin.CardNumber.ToString();
        }
        private void Back_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void seeYourProfileBtn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var message = "Bye...";
            MessageBox.Show(message);
            Thread.Sleep(500);

            Application.Exit();
        }
    }
}

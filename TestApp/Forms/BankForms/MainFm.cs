using CodeLandBank.Core.Repositories;
using CodeLandBank.Extra.Creators;
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

namespace TestApp.Forms.BankForms
{
    public partial class MainFm : Form
    {
        public MainFm()
        {
            CreateRandomName.GetName();
            InitializeComponent();
        }

        public void CreateData()
        {

        }
        private void MehrCodeLandBtn_Click(object sender, EventArgs e)
        {
            var url = "https://github.com/MehrCodeLand";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;
            System.Diagnostics.Process.Start(psi);

        }
        private void WomanLifeFreedomBtn_Click(object sender, EventArgs e)
        {
            var url = "https://en.wikipedia.org/wiki/Woman,_Life,_Freedom";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;
            System.Diagnostics.Process.Start(psi);
        }
        private void BankNameBtn_Click(object sender, EventArgs e)
        {
            string message = "Hi\n" +
                "Created by Mehrshad-MehrCodeLand\n" +
                "2023-1401\n";
            MessageBox.Show(message);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginFm loginFm = new LoginFm( new BankRepository() );
            loginFm.Show();
            Thread.Sleep(300);
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

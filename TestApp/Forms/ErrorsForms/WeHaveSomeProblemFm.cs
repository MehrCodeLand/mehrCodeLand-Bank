using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLandBank.Forms.ErrorsForms
{
    public partial class WeHaveSomeProblemFm : Form
    {
        public WeHaveSomeProblemFm()
        {
            InitializeComponent();
        }

        private void restartAppbtn_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            Application.Restart();
        }
    }
}

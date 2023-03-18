using CodeLandBank.Core.Engins;
using CodeLandBank.Core.Services;
using CodeLandBank.Forms.BankForms;
using CodeLandBank.ViewModels.Operations;
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
    public partial class SendMoneyFm : Form
    {
        private IBankServices _bank;
        private Engin _engin;
        public SendMoneyFm( IBankServices bank , Engin engin)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            _bank = bank;
            _engin = engin;
            InitializeComponent();
        }

        private void SendMoneyFm_Load(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            UserPannelFm userPannel = new UserPannelFm(_bank, _engin);
            userPannel.Show();
            Thread.Sleep(200);
            this.Close();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            // validation Data [Str and data Type]
            int result = ValidationDataType();
            ShowResult(result);

            /*
             * Is CardNumber Exist ?
             * Is Money Exsist ?
             * Is Secend User Ban ?
             * Is User Have Thats money ?
             * Then Do That ... [ DO! ]
             */

            SendMoneyVm sendMoney = new SendMoneyVm()
            {
                UserCardNumber = _engin.CardNumber,
                SecendUserCardNumber = Convert.ToInt32(SecendUserNumberTB.Text),
                Money = Convert.ToInt32(MoneyTB.Text),
            };

            result = _bank.ValidationSendMoneyData( sendMoney );
            ShowResult(result);
             
            // TODO: Time To do trade
        }


        private int ValidationDataType()
        {
            var secendCardNumber = SecendUserNumberTB.Text;
            var moneyTb = MoneyTB.Text;

            if (!moneyTb.All(char.IsDigit)) { return -3001;  }
            else if(!secendCardNumber.All(char.IsDigit)) { return -2001;  }


            return 4001 ;
        }

        /*
         * -2001 -> CardNumber is Str
         * -3001 -> Money is Str
         *  4001 -> All Data type are correct 
         */
        /*
        * -531 -> secend User Not Found
        * -867 -> money is to high
        * -923 -> Your Money Less than that money you want
        * 999 -> TRUE
        */

        private void ShowResult( int result)
        {
            var message = "";
            if(result == -3001)
            {
                message = "Cheack Money Box Again!";
                MessageBox.Show(message);

                SendMoneyFm sendMoneyFm = new SendMoneyFm(_bank, _engin);
                sendMoneyFm.Show();
                Thread.Sleep(100);
                this.Close();

            }else if(result == -2001)
            {
                message = "Cheack Secend Card Again Box Again!";
                MessageBox.Show(message);

                SendMoneyFm sendMoneyFm = new SendMoneyFm(_bank, _engin);
                sendMoneyFm.Show();
                Thread.Sleep(100);
                this.Close();
            }else if( result == -531)
            {
                message = "Secend User Not Found!";
                MessageBox.Show(message);

                SendMoneyFm sendMoneyFm = new SendMoneyFm(_bank, _engin);
                sendMoneyFm.Show();
                Thread.Sleep(100);
                this.Close();
            }
            else if(result == -867)
            {
                message = "Money Is To Hight";
                MessageBox.Show(message);

                SendMoneyFm sendMoneyFm = new SendMoneyFm(_bank, _engin);
                sendMoneyFm.Show();
                Thread.Sleep(100);
                this.Close();
            }
            else if(result == -923)
            {
                message = "You Have No Money For do this trade.";
                MessageBox.Show(message);

                SendMoneyFm sendMoneyFm = new SendMoneyFm(_bank, _engin);
                sendMoneyFm.Show();
                Thread.Sleep(100);
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamblingGame
{
    public partial class Form1 : Form
    {
        private int money;
        private int spendAmount;

        public Form1()
        {
            InitializeComponent();
            OutputToLog("Casino has opened");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void GambleBtn_Click(object sender, EventArgs e)
        {

        }

        private void AmountTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogText_TextChanged(object sender, EventArgs e)
        {

        }

        private void spendAmountTxt_ValueChanged(object sender, EventArgs e)
        {
            int amount = Decimal.ToInt32(spendAmountTxt.Value);
            if (amount <= money)
            {
                spendAmount = amount;
            }
            else
            {
                OutputToLog("You are too broke, i have corrected your input to what you have.");
                spendAmount = money;
            }

        }

        private void OutputToLog(string msg)
        {
            DateTime DT = DateTime.Parse("31/12/2006 07:00:00 AM");
            LogText.AppendText(Environment.NewLine + DT.ToString("H:mm:ss") + $" {msg}");
        }
    }
}

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
        private int money = 100;
        private int spendAmount;
        private int selectedNumber = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initial actions
            OutputToLog("Casino has opened");
            label1.Text = $"{money.ToString()}€";
        }


        private void GambleBtn_Click(object sender, EventArgs e)
        {
            if (selectedNumber == -1) OutputToLog("Select a number first"); return;
            Random random = new Random();
            int rng = random.Next(1, 3);


            if (selectedNumber == rng)
            {
                // Win logic
                OutputToLog("You won!!!");
            }
            else
            {
                // Lose logic
                OutputToLog("You have lost, lol.");
            }
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
                spendAmountTxt.Value = money;
            }

        }

        private void OutputToLog(string msg)
        {
            DateTime DT = DateTime.Parse("31/12/2006 07:00:00 AM");
            LogText.AppendText(Environment.NewLine + DT.ToString("H:mm:ss") + $": {msg}");
        }

        private void SetButtonsColor(int btn)
        {
            for (int i = 0; i < 3; i++)
            {
                if (i != btn) ;
                    // MAKE A LIST FOR BUTTONS AND ADD THEM TO IT
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedNumber != -1) return; // just making sure it hasnt been already selected
            selectedNumber = 3;
            button3.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedNumber != -1) return; // just making sure it hasnt been already selected
            selectedNumber = 2;
            button2.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedNumber != -1) return; // just making sure it hasnt been already selected
            selectedNumber = 1;
            button1.BackColor = Color.Gray;
        }
        private void AmountTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void LogText_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}

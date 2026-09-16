using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

        private List<Button> btns = new List<Button>();

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


        private void SetButton(int buttonIndex, Button button)
        {
            btns.Add(button);

            selectedNumber = buttonIndex;

            OutputToLog($"You selected number {buttonIndex}");

            SetButtonsColor(button);
        }

        private void SetButtonsColor(Button btnPressed)
        {
            foreach (Button button in btns)
            {
                if (button == btnPressed)
                {
                    button.BackColor = Color.Gray;
                }
                else
                {
                    button.BackColor = Color.White;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) => SetButton(3, button3);
        private void button2_Click(object sender, EventArgs e) => SetButton(2, button2);
        private void button1_Click(object sender, EventArgs e) => SetButton(1, button1);
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

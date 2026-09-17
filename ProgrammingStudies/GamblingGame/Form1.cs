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
        private int betAmount;
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
            UpdateUi();
        }


        private void GambleBtn_Click(object sender, EventArgs e)
        {
            if (selectedNumber == -1)
            {
                OutputToLog("Select a number first");
                return;
            }
            else if (betAmount <= 0)
            {
                OutputToLog("Bet something atleast.");
                return;
            }

            Random random = new Random();
            int rng = random.Next(1, 4);

            OutputToLog($"rng: {rng.ToString()}. selected: {selectedNumber}");

            if (selectedNumber == rng)
            {
                // Win logic
                int winAmount = betAmount * 2;
                money += winAmount;
                OutputToLog($"You won! Casino has deposited {winAmount.ToString()}€");
            }
            else
            {
                // Lose logic
                money -= betAmount;
                OutputToLog($"You have lost, lol. -{betAmount}€");

                if (money <= 0)
                {
                    // No more money logic
                    OutputToLog("Damn, you are broke gg");
                }
            }
            UpdateUi();

        }



        private void UpdateUi()
        {
            // Update users balance
            balanceLabel.Text = $"Balance: {money.ToString()}€";
        }
        private void betAmountTxt_ValueChanged(object sender, EventArgs e)
        {
            int amount = Decimal.ToInt32(betAmountTxt.Value);
            if (amount <= money)
            {
                betAmount = amount;
            }
            else
            {
                OutputToLog("You are too broke, i have corrected your input to what you have.");
                betAmount = money;
                betAmountTxt.Value = money;
            }

        }
        private void OutputToLog(string msg)
        {
            DateTime DT = DateTime.Parse(DateTime.Now.ToString());
            LogText.AppendText(Environment.NewLine + DT.ToString("H:mm:ss") + $": {msg}");
            LogText.ScrollToCaret();
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
                    button.BackColor = Color.FromArgb(255,200,200,200);
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

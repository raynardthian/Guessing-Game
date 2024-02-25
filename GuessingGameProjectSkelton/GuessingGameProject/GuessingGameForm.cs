using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessingGameProject
{
    public partial class GuessingGameForm : Form
    {
        public static GuessingGameForm objGuessing = new GuessingGameForm();
        int intNumber = 0, intNumberTries = 0;
        Boolean blnStartFlag=false, blnSuccess=false;
        public GuessingGameForm()
        {
            InitializeComponent();
        }
        
        private int CompareWithNumber(int intInput)
        {
            if (intInput == intNumber)
            {
                return 0;
            }
            else if (intInput < intNumber)
            {
                return -1;
            }
            else
                return 1;
        }
        private int GetNumber()
        {
            double dblValue;
            Random ranObj = new Random();
            dblValue = ranObj.NextDouble();
            return ((int)(100 * dblValue));

        }
        
        private bool CheckValidInput (int intInput)
        {
            if ((intInput >= 0) && (intInput <= 100))
                return true;
            else
                return false;
            
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            
            intNumber = GetNumber();
            blnStartFlag = true;
            intNumberTries = 0;
            blnSuccess = false;
            inputTextBox.Text = "";
            messageLabel.Text = "The game has started now!";
            numTriesLabel.Text = "0";
            inputTextBox.Focus();
        }

        private void GuessingGameForm_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            DateLabel.Text = dtNow.ToString();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            History.objHistory.Show();
            objGuessing = this;
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int intTemp;
            int intStatus , intCount;
            
            if (blnStartFlag == false)
            {
                MessageBox.Show("Please click the start button to start the game");
                return;
            }
            try
            {
                intTemp = int.Parse(inputTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter your guessing number!");
                return;
            }
            if(CheckValidInput(intTemp)==false)
            {
                messageLabel.Text = "Invalid Input Number!!!";
            }
            else if ((intNumberTries >= 8) || (blnSuccess == true))
            {
                blnStartFlag = false;
                messageLabel.Text = "The game is already ended.\nClick the Start button for another game!";
            }
            else
            {
                intNumberTries++;
                numTriesLabel.Text = intNumberTries.ToString();
                intStatus = CompareWithNumber(intTemp);
                progressBar1.Increment(1);
                
                if(intStatus == 0)
                {
                    messageLabel.Text = "Congratulation! It's correct";
                    blnSuccess = true;
                    File.AppendAllText("History.txt", intNumberTries+"; ");
                    
                }
                else if (intStatus==-1)
                {
                    messageLabel.Text = "Too Low!!!";
                }
                else
                {
                    messageLabel.Text = "Too High!!!";
                }
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameProject
{
    public partial class History : Form
    {
        public static History objHistory = new History();
        public History()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            
        }

        private void History_Load(object sender, EventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GuessingGameForm.objGuessing.Show();
            objHistory = this;
            this.Hide();
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            File.Delete("History.txt");
            File.AppendAllText("History.txt", "");
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            string strHistory;
            StreamReader streamHistory = new StreamReader("History.txt", true);
            strHistory = streamHistory.ReadLine();
            historyLabel.Text = strHistory;
            streamHistory.Close();
        }
    }
}

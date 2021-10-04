using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace binaryIDE2._0
{
    public partial class two : Form
    {
        public two()
        {
            InitializeComponent();
        }
        public void inputTaker2_TextChanged(object sender, EventArgs e)
        {
            string input = inputTaker2.Text;
            //int input;
            //string finalInput;

            //int.TryParse(rawInput, out input);
            Convert.ToInt64("input", 2).ToString();
            //finalInput = input.ToString();
            
            ans2.Text = input;
        }
        private void darkButton2_Click(object sender, EventArgs e)
        {
            sike2.Text = "Lol you wish";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            one c = new one();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
        //useless shit
        private void sike2_Click(object sender, EventArgs e)
        {
            
        }
        private void two_Load(object sender, EventArgs e)
        {

        }
        private void ans2_Click(object sender, EventArgs e)
        {

        }

    }
}

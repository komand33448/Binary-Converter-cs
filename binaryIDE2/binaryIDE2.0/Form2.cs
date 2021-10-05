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
            //det var mening at den her del skulle lave binary til decimal
            //men har nu valgt at lægge den på hyllen for nu
            string input = inputTaker2.Text;
            Int64 test2 = Convert.ToInt64(input);  
            
            ans2.Text = test2.ToString();
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

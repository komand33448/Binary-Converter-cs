using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace binaryIDE2._0
{
    public partial class one : Form
    {
        public one()
        {
            InitializeComponent();
        }        
        private void darkButton_Click(object sender, EventArgs e)
        {
            sike.Text = "Lol you wish";            
        }
        private void inputTaker_TextChanged_1(object sender, EventArgs e)
        {
            int remainder;
            int userInputG;
            string result = string.Empty;
            string userInputB = inputTaker.Text;
            int.TryParse(userInputB, out userInputG);

            while (userInputG > 0)
            {
                remainder = userInputG % 2;
                userInputG /= 2;
                result = remainder.ToString() + result;                
            }
            
            ans.Text = result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            two c = new two();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
        //useless shit 
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void sike_Click(object sender, EventArgs e)
        {

        }
        private void II_Click(object sender, EventArgs e)
        {

        }        
    }
}

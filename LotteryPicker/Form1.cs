using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryPicker
{ 
    public partial class LotteryNumberPicker : Form
    {
        Random randGen = new Random();
        int numValue1,numValue2,numValue3,numValue4,numValue5,numValue6;
        const int MAX = 50;
        public LotteryNumberPicker()
        {
            numValue1 = randGen.Next(1, MAX);
            numValue2 = randGen.Next(1, MAX);
            numValue3 = randGen.Next(1, MAX);
            numValue4 = randGen.Next(1, MAX);
            numValue5 = randGen.Next(1, MAX);
            numValue6 = randGen.Next(1, MAX);
            InitializeComponent();
        }

        private void numberButton_Click(object sender, EventArgs e)
        {

            while (numValue1 == numValue2) 
            {
                numValue2 = randGen.Next(1, MAX);
            }

            while (numValue3 == numValue1)
            {
                numValue3 = randGen.Next(1, MAX);
            }

            while (numValue4 == numValue3)
            {
                numValue4 = randGen.Next(1, MAX);
            }

            while (numValue5 == numValue2)
            {
                numValue5 = randGen.Next(1, MAX);
            }

            while (numValue6 == numValue1)
            {
                numValue6 = randGen.Next(1, MAX);
            }

            outputLabel.Text = Convert.ToString(numValue1) + " " + Convert.ToString (numValue2) + " " + Convert.ToString(numValue3) + " " ;
            outputLabel.Text += Convert.ToString(numValue4) + " " + Convert.ToString (numValue5) + " " + Convert.ToString(numValue6); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciSequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double numberToShow = 0;
        double pastNumber = 0;
        double lastNumber = 1;
        int count = 0;

        private void buttonNextNumber_Click(object sender, EventArgs e)
        {
            textBoxCurrentNumber.Text = numberToShow.ToString();
            numberToShow = lastNumber + pastNumber;
            lastNumber = pastNumber;
            pastNumber = numberToShow;

            count++;
            textBoxNumInSequence.Text = count.ToString();
            
        }
    }
}

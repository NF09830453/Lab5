using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form2 : Form
    {
        public Form2(double current, double calculatedResult)
        {
            InitializeComponent();
            label1.Text = "Current Value: " + current.ToString();
            if (calculatedResult < 0)
            {
                label2.Text = "Result: Invalid N/A";
            }
            else
            {
                label2.Text = "Result: " + calculatedResult.ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        FileReader fr = new FileReader();
        FactoryIF fif = new Factory();
        OperationIF op;
        string[] modules;
        public Form1()
        {
            InitializeComponent();
            modules = fr.ReadFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(modules);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModule = comboBox1.SelectedItem.ToString();
            op = fif.CreateOp(selectedModule);
            op.PerformOp();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

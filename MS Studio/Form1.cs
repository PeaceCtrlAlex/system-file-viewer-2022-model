using System;
using System.Windows.Forms;

namespace MS_Studio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Services openform = new Services();
            openform.Show();
        }
    }
}

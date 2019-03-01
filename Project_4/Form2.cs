// Austin Pickart
// Project_4 - Simple Quiz

using System;
using System.Windows.Forms;

namespace Project_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private int count = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            // disable timer and hide this form, open quiz form
            timer.Enabled = false;
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;        
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {               
                button1_Click(sender, e);           
            }
        }

    }
}

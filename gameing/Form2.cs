using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 button2 = new Form3();
            button2.Tag = this;
            button2.Show();
            Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 button1 = new Form4();
            button1.Tag = this;
            button1.Show();
            Hide();

        }
    }
}

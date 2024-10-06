using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btn1");
        }

        private void button1_Click2(object sender, EventArgs e)
        {
            MessageBox.Show("btn1_clicked2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += new System.EventHandler(button1_Click2);
        }
    }
}

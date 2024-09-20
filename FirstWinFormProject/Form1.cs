using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("hi");
            lb1.Text = "hello world!";
            button1.SetBounds(0, 0, 100, 100);
            button1.Click += MyButton_Click;

        }


        private void button2_Click(object sender, EventArgs e)
        {

            label3.Text = "btn1 clicked!";
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }
    }
}

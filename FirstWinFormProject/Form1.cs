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
            //button1.SetBounds(0, 0, 100, 100);
            //button1.Click += MyButton_Click;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {


            label3.Text = "btn1 clicked!";
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("checkbox clicked!","checkbox!");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length >= 4)
            {
               DialogResult res = MessageBox.Show("login?", "login", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
               if(DialogResult.OK == res)
                {
                    //try to login
                    MessageBox.Show("try login..");
                    if(textBox1.Text == "test" && textBox2.Text == "1234")
                    {
                        MessageBox.Show("login success!");
                    }
                    else
                    {
                        MessageBox.Show("login failed..");
                    }
                }

            }
        }
    }
}

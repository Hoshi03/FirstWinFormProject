using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Control
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gasgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("툴바 클릭");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.화면_캡처_2024_09_20_231220;
        }

        static int i = 0;

        public static string tmp()
        {
            i++;
            return i.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show(tmp());
        }




    }
}

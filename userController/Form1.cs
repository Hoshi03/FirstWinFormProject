using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.myClick += new EventHandler(btnEvent);
            userControl11.label1text = "hi";
            userControl12.label1text = "hello";
        }

        private void btnEvent(object sender, EventArgs e)
        {
            MessageBox.Show("외부 이벤트 !");
        }
    }
}

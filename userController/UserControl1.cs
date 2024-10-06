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
    public partial class UserControl1 : UserControl
    {

        public EventHandler myClick;
        public UserControl1()
        {
            InitializeComponent();
        }

        public string label1text
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.제목_없음2;
            EventHandler handler = myClick;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

    }
}

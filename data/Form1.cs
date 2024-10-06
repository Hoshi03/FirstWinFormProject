using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataColumn dc = new DataColumn();
            dc.ColumnName = "int";
            dc.DataType = typeof(Int32);

            DataColumn dc2 = new DataColumn();
            dc2.ColumnName = "name";
            dc2.DataType = typeof(string);

            dt.Columns.Add(dc);
            dt.Columns.Add(dc2);


            dt.Rows.Add(1, "ho");
            dt.Rows.Add(2, "hoshi");
            dt.Rows.Add(3, "data");

            //데이터그리드뷰에 데이터 소스를 위에서 작성한 데이터컬럼으로 연결
            dataGridView1.DataSource = dt;

            //데이터셋에 데이터테이블 추가
            DataSet ds = new DataSet("myDataSet");
            ds.Tables.Add(dt);
            ds.Tables.Add(dt2);

            // 원하는 테이블을 인덱스로 지정해서 가져오기 가능
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}

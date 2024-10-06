using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        //db연동을 위한 클래스
        private SqlConnection sqlConnection = null;
        //ip, 포트, db이름, id, pw 순으로 connectionstring에 삽입
        private string connectionString = "SERVER=" + ConfigurationManager.AppSettings["IP"] +","+ ConfigurationManager.AppSettings["PORT"] +
            ";DATABASE=" + ConfigurationManager.AppSettings["DATABASE"] + ";UID=" + ConfigurationManager.AppSettings["UID"] +
            ";PASSWORD="+ConfigurationManager.AppSettings["PASSWORD"];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(connectionString);
            button4_Click(null, null);
        }

        //db 연결
        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                MessageBox.Show("연결 성공!");

            }

            catch (Exception ex)
            {
                MessageBox.Show("연결 실패! " + ex.ToString());

            }
        }
        
        //db 연결 해제
        private void btn2_Click(object sender, EventArgs e)
        {

            try
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                    MessageBox.Show("db 연결 해제");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("db 연결 해제 실패! " + ex.ToString());

            }
        }

        // 데이터 전체조회
        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            //using 구문 내부에서만 db와 연결되서 동작하고 using 구문을 벗어나면 close() 메서드로 연결을 끊은 것과 동일하게 동작한다
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                //단순 조회의 경우에는 락을 해제해서 사용했다
                string selectQuery = "SELECT * FROM BOOKS(NOLOCK)";
				//sqladapter 사용 방식
				//sqladpater를 사용해서 자동으로 연결 후, 쿼리 실행, 연결 끊기
				SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, sqlConnection);
				adapter.Fill(ds, "BOOKS");
			}

			////데이터소스 채워주기
			dataGridView1.DataSource = ds.Tables[0];
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            //db에서 해당 행의 특의 도메인을 가져오는 쿼리
            string bookNo = dataGridView1.Rows[e.RowIndex].Cells["BOOKNO"].Value.ToString();
            string bookName = dataGridView1.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
            textBox1.Text = bookNo;
            textBox4.Text = bookNo;
            textBox2.Text = bookName;
        }

        //삭제
		private void button1_Click(object sender, EventArgs e)
		{
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string bookNo = textBox1.Text;
                string selectQuery = "DELETE FROM BOOKS WHERE BOOKNO = " + bookNo;
                SqlCommand  sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = selectQuery;
                sqlCommand.ExecuteNonQuery();
                //실행 후 전체조회 이벤트 발생해서 테이블 갱신시켜주기
                button4_Click(null, null);
            }
        }

        //업데이트
		private void button2_Click(object sender, EventArgs e)
		{
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string bookNo = textBox4.Text;
                string selectQuery = "UPDATE BOOKS SET NAME = '" + textBox3.Text + "' WHERE BOOKNO = " + bookNo;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = selectQuery;
                sqlCommand.ExecuteNonQuery();
                //실행 후 전체조회 이벤트 발생해서 테이블 갱신시켜주기
                button4_Click(null, null);

            }
        }

        //저장, 저장 프로시저 방식
		private void button3_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();
				string bookNo = textBox6.Text;
				string bookName = textBox5.Text;
				string bookCode = textBox7.Text;

				// 저장 프로시저를 가져오고 파라미터 입력해서 실행
                SqlCommand command = new SqlCommand("InsertBOOKS", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@BOOKNO", SqlDbType.VarChar);
                p1.Direction = ParameterDirection.Input;
                p1.Value = bookNo;
                command.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@BOOKNAME", SqlDbType.VarChar);
                p2.Direction = ParameterDirection.Input;
                p2.Value = bookName;
                command.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@BOOKCODE", SqlDbType.VarChar);
                p3.Direction = ParameterDirection.Input;
                p3.Value = bookCode;
                command.Parameters.Add(p3);

                command.ExecuteNonQuery();
                Console.WriteLine("[프로시저호출]InsertBOOKS");
                button4_Click(null, null);

            }
		}
	}
}

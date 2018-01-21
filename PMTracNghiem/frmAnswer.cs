using PMTracNghiem.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTracNghiem
{
    public partial class frmAnswer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HAN-PC;Initial Catalog=login;User ID=sa;Password=han@123");
        SqlDataAdapter da;
        SqlCommand com;
        bool isMOI = false;
        DBconnect db = new DBconnect();
        DataTable dt = new DataTable();
        GetData _gd = new GetData();
        public static class ID
        {
            public static string MDA;
            public static string TDA;
            public static int MCH = frmQuestion.IDCH.MCH;
            public static string DA;
        }
        public frmAnswer()
        {
            InitializeComponent();
        }
        public void loadgrib() /// load câu hỏi lên bảng
        {

            db.OpenCnn();
            string sql = "Select * from DAPAN where QMCH='" + ID.MCH + "'"; 
            dataGridView1.Rows.Clear();
            dt = db.ExecuteSelect(sql);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "false";
                dataGridView1.Rows[n].Cells[1].Value = item["AMDA"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = ID.MCH;
                dataGridView1.Rows[n].Cells[3].Value = item["ATDA"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["DA"].ToString();
                            }
            db.CloseCnn();
        }
       
        private void insertDB()
        {
            if (txtda.Text == "" || rtbtda.Text == "" || txtttc.Text == "")
                MessageBox.Show("Lỗi Không Có Mã");
            else
            {
                try
                {
                    con.Open();
                    ID.DA = txtda.Text;
                    ID.TDA = rtbtda.Text;
                    ID.MDA = txtttc.Text;
                    string sql = "Insert into Dapan(AMDA,ATDA,QMCH,DA) values('" + ID.MDA + "','" + ID.TDA + "','" + ID.MCH + "','" + ID.DA+"')";
                    com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    loadgrib();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); MessageBox.Show("Đã trùng mã đáp án ");
                }

            }
        }
        private void updateDB()
        {
            try
            {
                _gd.updateDA(ID.TDA, ID.DA , ID.MDA);
                loadgrib();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); MessageBox.Show("Đã trùng mã đáp án ");
            }



        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            ID.TDA = rtbtda.Text;
            ID.DA = txtda.Text;
            if (isMOI)
                insertDB();
            else
                updateDB();

            btnluu.Enabled = false;
            rtbtda.Enabled = false;
            txtttc.Enabled = false;
            btnsua.Enabled = true;
           
            txtda.Clear();
            rtbtda.Clear();
            txtda.Clear();
        }



        private void btnsua_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;//hien nut luu
            rtbtda.Enabled = true;
            txtttc.Enabled = true;
            txtda.Enabled = true;
            btnsua.Enabled = false;
           
            isMOI = false;
            txtttc.Clear();
            txtda.Clear();
            rtbtda.Clear();
        }

      

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát ??!!","Thoát",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtttc.Text = row.Cells[1].Value.ToString();
                rtbtda.Text = row.Cells[3].Value.ToString();
                txtda.Text = row.Cells[2].Value.ToString();
                ID.MDA = txtttc.Text;
                
            }
        }

        private void frmAnswer_Load(object sender, EventArgs e)
        {
            loadgrib();
            btnluu.Enabled = false;//an khi load du lieu
            rtbtda.Enabled = false;//textbox ko cho nhập liệu
            txtttc.Enabled = false;
            txtmch.Text = ID.MCH.ToString();
            txtda.Enabled = false;
        }
    }
}

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
    public partial class frmQuestion : Form
    {
        bool isMOI = false;
        //SqlConnection _cnn = new SqlConnection(@"Data Source=HAN-PC;Initial Catalog=login;User ID=sa;Password=han@123");
        //SqlDataAdapter _da;
        //SqlCommand _cmd;
        DataTable dt = new DataTable();
        DBconnect db = new DBconnect();
    //      string tencauhoi;
    //    string macauhoi;
        GetData _gd = new GetData();
        SqlDataReader _dr;
        public frmQuestion()
        {
            InitializeComponent();
        }
        public static class IDCH
        {
            public static int MCH;
            public static string TCH;
            public static string DAD;
        }
        private void btn_QuesAdd_Click(object sender, EventArgs e)
        {
            btn_QuesSave.Enabled = true;//hien nut luu
            rtbQues.Enabled = true;
            txtmch.Enabled =false;
            txtdad.Enabled = true;
            btn_QuesUpdate.Enabled = false;
            btn_QuesAdd.Enabled = false;
            btn_QuesDelete.Enabled = false;
            isMOI = true;
            txtmch.Clear();
            rtbQues.Clear();
            txtdad.Clear();
            LoadMCH();
            txtmch.Text = Convert.ToString(IDCH.MCH);
        }

        private void btn_QuesSave_Click(object sender, EventArgs e)
        {
            if (isMOI)
                insertDB();
            else
                updateDB();

            btn_QuesSave.Enabled = false;
            rtbQues.Enabled = false;
            txtmch.Enabled = false;
            txtdad.Enabled = false;
            btn_QuesUpdate.Enabled = true;
            btn_QuesAdd.Enabled = true;
            btn_QuesDelete.Enabled = true;
            txtmch.Clear();
            rtbQues.Clear();
            txtdad.Clear();

        }

        private void btn_QuesUpdate_Click(object sender, EventArgs e)
        {
          //  btnluu.Enabled = true;//hien nut luu
            btn_QuesSave.Enabled = true;//hien nut luu
            rtbQues.Enabled = true;
            txtmch.Enabled = true;
            txtdad.Enabled = true;
            btn_QuesUpdate.Enabled = false;
            btn_QuesAdd.Enabled = false;
            btn_QuesDelete.Enabled = false;
            isMOI = false;
           
        }
        public void LoadMCH()
        {
            _dr = _gd.loadMCH();
            if (_dr.Read() == true)
            {
                IDCH.MCH = Convert.ToInt32(_dr[0].ToString());
                IDCH.MCH = IDCH.MCH + 1;
            }
            db.CloseCnn();
        }
        private void insertDB()
        {
           
            if (txtdad.Text == "" || rtbQues.Text == "")
                MessageBox.Show("Lỗi Không Có Mã");
            else
            {
                try
                {
                    IDCH.TCH = rtbQues.Text;
                    IDCH.DAD = txtdad.Text;
                    _gd.insertCH(IDCH.MCH,IDCH.TCH,IDCH.DAD);
                    loadgrib();
                    frmAnswer f = new frmAnswer();
                    f.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); MessageBox.Show("Đã trùng mã câu hỏi ");
                }

            }

        }
        private void updateDB()
        {
            IDCH.TCH = rtbQues.Text;
            IDCH.MCH = Convert.ToInt32(txtmch.Text);
            IDCH.DAD = txtdad.Text;
            try
            {
                _gd.updateCH(IDCH.MCH,IDCH.TCH, IDCH.DAD);
                loadgrib();
                frmAnswer f = new frmAnswer();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void frmQuestion_Load(object sender, EventArgs e)
        {
            loadgrib();
            btn_QuesSave.Enabled = false;//an khi load du lieu
            rtbQues.Enabled = false;//textbox ko cho nhập liệu
            txtmch.Enabled = false;
            txtdad.Enabled = false;
        }
        public void loadgrib() /// load câu hỏi lên bảng
        {
            
            db.OpenCnn();
            string sql = "select * from  CAUHOI"; 
            dgvQuest.Rows.Clear();
            dt = db.ExecuteSelect(sql);
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvQuest.Rows.Add();
                dgvQuest.Rows[n].Cells[0].Value = "false";
                dgvQuest.Rows[n].Cells[1].Value = item["QMCH"].ToString();
                dgvQuest.Rows[n].Cells[2].Value = item["QTCH"].ToString();
                dgvQuest.Rows[n].Cells[3].Value = item["QDAD"].ToString();
            }
            db.CloseCnn();
            }

        private void btn_QuesDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvQuest.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    int MCH = Convert.ToInt32(item.Cells[1].Value.ToString());
                    _gd.DeleteCH(MCH);
                    loadgrib();
                }
            }
        }
        }
}


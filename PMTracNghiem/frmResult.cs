using PMTracNghiem.BUSI;
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
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }
        BindingSource _bs = new BindingSource();
        DBconnect db = new DBconnect();
        FTest _ft = new FTest();
        FResult  _fr = new FResult();
        DataTable _dt = new DataTable();
        SqlDataReader _dr;
        
        public static class IDR
        {
            public static int MKT = frmExam.IDinfor.MKT;
            public static int MND = frmLogin.IDinfor.MND;
            public static string MDT=frmExam.IDinfor.MDT;
            public static int QMCH;
            public static string MDAND;
            public static string NgayThi=frmExam.IDinfor.Ngaythi;
        }
        bool flag = false;
        public void LoadName()
        {
            db.OpenCnn();
            _dr = _ft.LoadName(IDR.MND);
            if (_dr.Read() == true)
            {
                txtUName.Text = _dr[0].ToString();
                txtLName.Text = _dr[1].ToString();
                txtEmail.Text = _dr[2].ToString();
                IDR.MND = Convert.ToInt32(_dr[3].ToString());
            }
            db.CloseCnn();
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            LoadName();
            loadgrib();
        }
        private void loadgrib()
        {
            string DA;
            db.OpenCnn();
            string sql = "select STT,a.QTCH,QDAD, MDAND,isnull(danhgia,'') As Danhgia from (select  STT,b.QMCH,QDAD,QTCH from cauhoi a, CTDETHI b where a.QMCH = b.QMCH and MDT='" + IDR.MDT + "') a left join (select QMCH,MDAND,DANHGIA from TRALOIND where MND=" + IDR.MND + "and MKT=" + IDR.MKT + ") b on a.QMCH=b.QMCH order by stt ";
            //MessageBox.Show(sql);
            dtg.Rows.Clear();
            _dt = db.ExecuteSelect(sql);
            foreach (DataRow item in _dt.Rows)
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item["STT"].ToString();
                dtg.Rows[n].Cells[1].Value = item["QTCH"].ToString();
                dtg.Rows[n].Cells[2].Value = item["QDAD"].ToString();
                dtg.Rows[n].Cells[3].Value = item["MDAND"].ToString();
                if (item["DANHGIA"].ToString() == "1")
                    DA = "Đúng";
                else
                    DA = "Sai";
                dtg.Rows[n].Cells[4].Value = DA;

            }
            db.CloseCnn();
            int kq = 0;
            if (flag == false) 
            {
                //string sql1 = "select MND,count(MND) from TRALOIND where danhgia like '%Đúng%' and MND=" + IDR.MND + "and MKT=" + IDR.MKT + "and MDT='" + IDR.MDT + "' group by MND";
                string sql1 = "select count(MND) from TRALOIND where danhgia like '%1%' and MND=" + IDR.MND + "and MKT=" + IDR.MKT + "and MDT='" + IDR.MDT + "' group by MND";
                //  MessageBox.Show(sql1);
                _dt = db.ExecuteSelect(sql1);
                foreach (DataRow dr in _dt.Rows)
                {
                    if (_dt.Rows[0][0].ToString() != null)
                        kq = Int32.Parse(dr[1].ToString()); /// 16 [1]
                }
                txtdiem.Text = kq.ToString();
                _fr.insert(IDR.MND, IDR.MKT, IDR.MDT, IDR.NgayThi, kq);
                flag = true;
            }
            
            //float Diem=0;
            //Diem=;
            MessageBox.Show("Đúng:"+Convert.ToString(kq)+"/20");

        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            //gọi form báo cáo kết quả ra 
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát ??!!", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtdiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

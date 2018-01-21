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
    public partial class frmExam : Form
    {
        SqlDataReader _dr;
        DBconnect db = new DBconnect();
        Bussiness.GetData gd = new Bussiness.GetData();
        DataTable _dt = new DataTable();
        BindingSource _bsCT = new BindingSource();
        BindingSource _bsMH = new BindingSource();
        bool Loai;
        public static class IDinfor
        {
            public static string MDT;
            public static int MKT;
            public static string Ngaythi;
        }

        private int exMKT;
        public frmExam()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (rdb_Chinhthuc.Checked == true)
                IDinfor.MDT = cbb_CT.Text;
            else
                if(rdb_Minhhoa.Checked == true)
                    IDinfor.MDT= cbb_MH.Text;
            
            //MessageBox.Show(IDinfor.MDT);
            this.Hide();
            IDinfor.MKT = exMKT;
            //MessageBox.Show(Convert.ToString(IDinfor.MKT));
            //dtp_Ngaythi.Text 
             IDinfor.Ngaythi= DateTime.Now.ToString("yyyy.MM.dd");
            //MessageBox.Show(dtp_Ngaythi.Text);
             gd.insert(IDinfor.MKT, frmLogin.IDinfor.MND, IDinfor.MDT, IDinfor.Ngaythi);

        }

        
        public void LoadMKTnext()
        {
            _dr = gd.LoadMKT();
            if (_dr.Read() == true)
            {
                exMKT = Convert.ToInt32(_dr[0].ToString());
                exMKT = exMKT + 1;
            }
            db.CloseCnn();
        }

        private void frmExam_Load(object sender, EventArgs e)
        {
            txt_MND.Text = Convert.ToString(frmLogin.IDinfor.MND);
            LoadMKTnext();
            txt_MKT.Text = Convert.ToString(exMKT);
            
              
        }
        bool flagCT = false;
        bool flagMH = false;
        private void rdb_Chinhthuc_CheckedChanged(object sender, EventArgs e)
        {
            cbb_CT.Enabled = true;
            if (flagCT == false)
            {
                if (rdb_Chinhthuc.Checked == true)
                {
                    cbb_MH.Enabled = false;
                    cbb_CT.Items.Clear();
                    Loai = true;
                    _dt = gd.kt(Loai);
                    _bsCT.DataSource = _dt;
                    cbb_CT.DataBindings.Add("Text", _bsCT, "MDT");
                    flagCT = true;
                }
            }
            else
                cbb_MH.Enabled = false;
        }

        private void rdb_Minhhoa_CheckedChanged(object sender, EventArgs e)
        {
            cbb_MH.Enabled = true;
            if (flagMH == false)
            {
                if (rdb_Minhhoa.Checked == true)
                {
                    cbb_CT.Enabled = false;
                    cbb_CT.Items.Clear();
                    Loai = false;
                    _dt = gd.kt(Loai);
                    _bsMH.DataSource = _dt;
                    cbb_MH.DataBindings.Add("Text", _bsMH, "MDT");
                    flagMH = true;
                }
            }
            else
                cbb_CT.Enabled = false;

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

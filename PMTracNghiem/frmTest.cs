using PMTracNghiem.BUSI;
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
    public partial class frmTest : Form
    {
        public bool themoi = false;
        int min = 0, sec =30, ms = 0;

        DBconnect db = new DBconnect();
        //BindingSource _bs = new BindingSource();
        FTest _ft = new FTest();
        DataTable _dt = new DataTable();
        DataTable _dt1 = new DataTable();
        SqlDataReader _dr;
        public static class ID
        {
            public static int MKT = frmExam.IDinfor.MKT ;
            public static int MND = frmLogin.IDinfor.MND;
            public static string MDT = frmExam.IDinfor.MDT;
            public static int QMCH;
            public static string MDAND;
        }
        void setButton(bool val)
        {
            btn_Start.Enabled = val;
            btn_SaveQues.Enabled = !val;
            btn_Preview.Enabled = !val;
            btn_Submit.Enabled = !val;
           
        }

        public frmTest()
        {
            frmExam f = new frmExam();
            f.ShowDialog();
           
            InitializeComponent();
         }
        public void LoadName()
        {
            db.OpenCnn();
            _dr = _ft.LoadName(ID.MND);
            if (_dr.Read() == true)
            {
                txtUName.Text = _dr[0].ToString();
                txtLName.Text = _dr[1].ToString();
                txtEmail.Text = _dr[2].ToString();
                ID.MND = Convert.ToInt32(_dr[3].ToString());
            }
            db.CloseCnn();
        }
        private void btn_Start_Click_1(object sender, EventArgs e)
        {
            themoi = true;
            setButton(false);
            timer1.Start();
           
        }
        void ShowCauHoi()
        {
            lstQ.Items.Clear();
            _dt = _ft.ShowCauhoi(ID.MDT);
            for (int i = 0; i < _dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lstQ.Items.Add(_dt.Rows[i][0].ToString());      // STT
                lvi.SubItems.Add(_dt.Rows[i][1].ToString());    //Thông tin câu hỏi
                lvi.SubItems.Add(_dt.Rows[i][2].ToString());    //Mã Câu hỏi
                lvi.SubItems.Add(_dt.Rows[i][3].ToString());    //Mã Đề Thi
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_min.Text = min.ToString("00");
            lbl_sec.Text = sec.ToString("00");
            //if (_ft.Tick(min,sec,ms)==)
            //{
            //    timer1.Stop();
            //    MessageBox.Show("Đã đếm xong!", "Thông Báo!");
            //    btn_Start.Enabled = false;
            //}
            if (min > 0)
            {
                if (sec > 0)
                {
                    if (ms > 0)
                    {
                        ms--;
                    }
                    else
                    {
                        if (ms < 10)
                        {
                            ms = 10;
                            sec--;
                        }
                    }
                }
                else
                {
                    sec = 59;
                    min--;
                }
            }
            else if (min == 0)
            {
                if (sec > 0)
                {
                    if (ms > 0)
                    {
                        ms--;
                    }
                    else
                    {
                        ms = 10;
                        sec--;
                    }
                }
                else
                {
                    ms--;
                }

            }

            if (min == 0 && sec == 0 && ms == -1)
            {
                timer1.Stop();
                btn_Submit_Click(sender,e);
                MessageBox.Show("Đã đếm xong!", "Thông Báo!");
                btn_Start.Enabled = false;
            }


        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            LoadName();
            ShowCauHoi();
            btn_Start.Enabled = true;
            btn_SaveQues.Enabled = false;
            btn_Preview.Enabled = false;
            btn_Submit.Enabled = false;
            btn_Start_Click_1(sender, e);
          
        }

        private void lstQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.OpenCnn();
            if (lstQ.SelectedIndices.Count > 0)
            {
                txtQ.Text = lstQ.SelectedItems[0].SubItems[1].Text;
                ListViewItem lvi = lstQ.SelectedItems[0];
               
                ID.MDT = lstQ.SelectedItems[0].SubItems[3].Text;
                ID.QMCH = Convert.ToInt32(lstQ.SelectedItems[0].SubItems[2].Text);
                loadgrib(lstQ.SelectedItems[0].SubItems[2].Text);
            }
            db.CloseCnn();
        }
        private void loadgrib(string text)
        {
            db.OpenCnn();
            string sql = "select DA,ATDA from  DAPAN  where QMCH ='" + text + "'";
            dataGridView1.Rows.Clear();
            _dt = db.ExecuteSelect(sql);
            foreach (DataRow item in _dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "false";
                dataGridView1.Rows[n].Cells[1].Value = item["DA"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["ATDA"].ToString();
            }
            db.CloseCnn();
            //_dt = db.ExecuteSelect(sql);

            //_bs.DataSource = _dt;

            //dataGridView1.DataSource = _bs;
        }

        private void btn_SaveQues_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    ID.MDAND = item.Cells[1].Value.ToString();
                    _ft.delete(ID.MND, ID.MKT, ID.MDT, ID.QMCH);
                    _ft.insert(ID.MND, ID.MKT, ID.MDT, ID.QMCH, ID.MDAND,null);
                }
            }
            MessageBox.Show("Lưu Thành Công!");
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btn_SaveQues.Enabled = false;
            db.OpenCnn();
            _dt = _ft.ShowQDAD(ID.MDT);
            int idch;
            string QDAD = "";
            foreach (DataRow dr in _dt.Rows)
            {
                idch = Convert.ToInt32(dr["QMCH"].ToString());
                QDAD = dr["QDAD"].ToString();
                //Bang kiemtra
                string MDAND = "";
                _dt1 = _ft.Traloind(ID.MND, ID.MKT, ID.MDT, idch);
                foreach (DataRow dr1 in _dt1.Rows)
                {
                    if (_dt1.Rows[0][0].ToString() != null)
                    {
                        MDAND = dr1["MDAND"].ToString();
                    }
                   
                }
                string strdanhgia = "";
                
                if (MDAND == QDAD) 
                    strdanhgia = "1";
                else
                    strdanhgia = "0";
              
                //_ft.delete(IDinfor.MND, IDinfor.MKT, IDinfor.MDT, IDinfor.QMCH);
               _ft.update(ID.MND, ID.MKT, ID.MDT, idch, ID.MDAND, strdanhgia);
                //string query = "Insert into TRALOIND(MND,MKT,MDT,QMCH,MDAND) values(" + MND + "," + MKT + ",'" + MDT + "'," + QMCH + ",'" + MDAND + "')";
               //MessageBox.Show(strdanhgia);
               //MessageBox.Show(Convert.ToString(ID.QMCH));
            }
            db.CloseCnn();
            frmResult f = new frmResult();
            f.Show();
            
        }

        
        private void btn_Preview_Click(object sender, EventArgs e)
        {
            
            frmPreResult fpr = new frmPreResult();
            fpr.Show();
        }

      }
}

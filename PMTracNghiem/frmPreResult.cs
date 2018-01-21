using PMTracNghiem.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTracNghiem
{
    public partial class frmPreResult : Form
    {
        public frmPreResult()
        {
            InitializeComponent();
        }
        BindingSource _bs = new BindingSource();
        DBconnect db = new DBconnect();
      //  FTest _ft = new FTest();
        FResult _fr = new FResult();
        DataTable _dt = new DataTable();
        SqlDataReader _dr;
        public static class IDinfor
        {
            public static int MKT = frmTest.ID.MKT;
            public static int MND = frmLogin.IDinfor.MND;
            public static string MDT=frmExam.IDinfor.MDT;
            public static int QMCH;
            public static string MDAND;
            public static int STT;
            public static string QTCH;
            public static string QDAD;
        }
        public void LoadName()
        {
            db.OpenCnn();
            _dr = _fr.LoadName(IDinfor.MND);
            if (_dr.Read() == true)
            {
                txtUName.Text = _dr[0].ToString();
                txtLName.Text = _dr[1].ToString();
                txtEmail.Text = _dr[2].ToString();
                IDinfor.MND = Convert.ToInt32(_dr[3].ToString());
            }
            db.CloseCnn();
        }
        public void LoadData(int MND,string MDT)
        {
            
            
            //_dt = db.Execute(sql);

            //_bs.DataSource = _dt;

            //dtgpr.DataSource = _bs;
            db.OpenCnn();
          //  string sql = "select STT, a.QMCH,b.QTCH,QDAD,isnull(c.mdand,'') as mdand from ctdethi a left join CAUHOI b on a.QMCH = b.QMCH left join TRALOIND c on a.qmch = c.qmch where MND=" + MND + "and a.mdt = '" + MDT + "'order by stt";
            string sql = "select STT,a.QTCH, MDAND from (select QMCH,MDAND from TRALOIND where MND="+MND+"and MKT="+IDinfor.MKT+") b left join (select  STT,b.QMCH,QTCH from cauhoi a, CTDETHI b where a.QMCH = b.QMCH and MDT='"+MDT+"') a on b.QMCH=a.QMCH order by stt ";
            //messagebox.show(sql);
            dtgpr.Rows.Clear();
            _dt = db.ExecuteSelect(sql);
            foreach (DataRow item in _dt.Rows)
            {
                int n = dtgpr.Rows.Add();
                dtgpr.Rows[n].Cells[0].Value = item["STT"].ToString();
                dtgpr.Rows[n].Cells[1].Value = item["QTCH"].ToString();
              //  dtgpr.Rows[n].Cells[2].Value = item["QTCH"].ToString();
                dtgpr.Rows[n].Cells[2].Value = item["MDAND"].ToString();
            }
            db.CloseCnn();
        }


      

        private void frmPreResult_Load(object sender, EventArgs e)
        {
            LoadName();
          LoadData(IDinfor.MND,IDinfor.MDT);
          //  LoadData(IDinfor.MND,IDinfor.STT,IDinfor.QMCH,IDinfor.QTCH,IDinfor.QDAD,IDinfor.MDT,IDinfor.MDAND);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

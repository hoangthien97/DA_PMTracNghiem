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
    public partial class frmLogin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DBconnect db = new DBconnect();
        PMTracNghiem.Bussiness.FLogin _fl = new PMTracNghiem.Bussiness.FLogin();
        SqlDataReader _dr;
       
        public Form frm = null;
        
        public bool bOK = false;
        private bool KiemTra(string strName)
        {
            bool flag = false;
            foreach (Form frmKT in frm.MdiChildren)
            {
                if (frmKT.Name == strName)
                {
                    frmKT.Activate();
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static class IDinfor
        {
            public static int MND;
            public static bool PQ = false;
        }

        public bool PQ ()
        {
            //Phân Quyền để vào hiện các button
            return true;
        }
        public frmLogin()
        {
            InitializeComponent();
            gr1.Enabled = false;
            gr2.Enabled = false;
            gr3.Enabled = false;

        }

        private void ckbShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowpass.Checked)
                txt_LogPassword.UseSystemPasswordChar = false;
            else
                txt_LogPassword.UseSystemPasswordChar = true;
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            if (!KiemTra("frmRegister"))
            {
                frmRegister frmDK = new frmRegister();
                frmDK.Show();
            }
        }

        //public void showfrmmain()
        //{
        //    frmMain fM = new frmMain();
        //    fM.Activate();
        //    fM.Show();
        //}
         private void btn_LogLogin_Click(object sender, EventArgs e)
        {
            if (txt_LogUsername.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập tên đăng nhập!");
                return;
            }
            if (txt_LogPassword.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                return;
            }
            #region
            String user = txt_LogUsername.Text;
            String pass = txt_LogPassword.Text;
            try
            {
                SqlDataReader _dr;
                _dr = _fl.LoadData(user, pass);
                if (_dr.Read() == true)
                {
                    txt_LogUsername.Text = "";
                    txt_LogPassword.Text = "";
                    lbl4.Enabled = false;
                    gr1.Enabled = true;
                    gr2.Enabled = true;
                    gr3.Enabled = true;
                    bOK = true;
                    txtMaNV.Text = _dr[0].ToString();
                    txt_PerFirstName.Text = _dr[1].ToString();
                    txt_PerLastName.Text = _dr[2].ToString();
                    //txt.Text = _dr[3].ToString();// Date
                    
                    string gt=_dr[4].ToString();//Gt
                    if (gt == "Nam")
                        rdbNam.Checked = true;
                    else
                    {
                        if (gt == "Nữ")
                            rdbNu.Checked = true;
                        else
                            rdbKh.Checked = true;
                     }
                    txt_PerEmail.Text = _dr[5].ToString();
                    txt_PerUserName.Text = _dr[6].ToString();
                    IDinfor.MND = Convert.ToInt32(_dr[0].ToString());
                }
                    
                else
                {
                    //??ng nh?p th?t b?i
                    lblNotificate.Text = "Account Or Password Is Not Correct";
                    txt_LogUsername.Text = "";
                    txt_LogPassword.Text = "";

                }
                db.CloseCnn();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion    
        }

        

        private void btn_Test_Click(object sender, EventArgs e)
        {
            if (!KiemTra("frmTest"))
            {
                frmTest t = new frmTest();
                t.MdiParent = frm;
                t.Show();
            }
        }
        private void Messeagebox()
        {
            MessageBox.Show("Bạn không có quyền hạn vào đây", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_Question_Click(object sender, EventArgs e)
        {
            if (!KiemTra("frmQuestion"))
            {
                if (IDinfor.PQ == true)
                {
                    frmQuestion t = new frmQuestion();
                    t.MdiParent = frm;
                    t.Show();
                }
                else
                {
                    Messeagebox();
                }
            }

        }

        private void btn_Answers_Click(object sender, EventArgs e)
        {
            if (!KiemTra("frm"))
            {
                if (IDinfor.PQ == true)
                {

                }
            }

        }

        private void btn_Exams_Click(object sender, EventArgs e)
        {
            if (!KiemTra("frmQuestion"))
            {
                if (IDinfor.PQ == true)
                {
                    frmQuestion t = new frmQuestion();
                    t.MdiParent = frm;
                    t.Show();
                }
                else
                {
                    Messeagebox();
                }
            }
        }

        private void btn_Menbers_Click(object sender, EventArgs e)
        {
            if (!KiemTra("frmMembers"))
            {
                if (IDinfor.PQ == true)
                {
                    frmMembers t = new frmMembers();
                    t.MdiParent = frm;
                    t.Show();
                }
                else
                {
                    Messeagebox();
                }
            }
        }

        private void btn_Personal_Click(object sender, EventArgs e)
        {
            if (!KiemTra("frmMembers"))
            {
                    frmMembers t = new frmMembers();
                    t.MdiParent = frm;
                    t.Show();
            }
        }

       

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
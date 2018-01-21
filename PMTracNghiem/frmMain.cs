using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMTracNghiem.BUSI;
using System.Runtime.InteropServices;

namespace PMTracNghiem
{
   
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmLogin frm = new frmLogin();
        public frmMain()
        {
            InitializeComponent();
            frm.MdiParent = this;
            frm.frm = this;
            frm.Show();
        }
        private void ShowfrmMain()
        {
            frmMain f = new frmMain();
            f.ShowDialog();
        }

        private bool KiemTra(string strName)
        {
            bool flag = false;
            foreach (Form frmKT in this.MdiChildren)
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
        private void Messeagebox()
        {
            MessageBox.Show(" Bạn chưa đăng nhập vào hệ thống !!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_US_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Properties.Settings.Default.Language == "en-US")
            {
                MessageBox.Show("Actived.");
            }
            else
            {
                Properties.Settings.Default.Language = "en-US";
                Properties.Settings.Default.Save();
                MessageBox.Show("Please restart the application to complete the English setting.", "Notificate");
                Thread thread = new Thread(new ThreadStart(ShowfrmMain)); //Tạo luồng mới
                thread.Start(); //Khởi chạy luồng
                thread.Abort();// ngắt luồng
                Application.Restart();               
            }
        }

        private void btn_VN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Properties.Settings.Default.Language == "vi-VN")
            {
                MessageBox.Show("Tiếng Việt đang được sử dụng.");
            }
            else
            {
                Properties.Settings.Default.Language = "vi-VN";
                Properties.Settings.Default.Save();
                MessageBox.Show("Hãy khởi động lại ứng dụng để hoàn tất cài đặt tiếng Việt.", "Thông báo");
                Thread thread = new Thread(new ThreadStart(ShowfrmMain)); //Tạo luồng mới
                thread.Start(); //Khởi chạy luồng
                thread.Abort(); // ngắt luồng
                Application.Restart();
            }
        }

        //public void btn_Login_Click(object sender, EventArgs e)
        //{
        //    frmLogin l = new frmLogin();
        //    l.StartPosition = FormStartPosition.CenterScreen;
        //    l.WindowState = FormWindowState.Maximized;
        //    l.MdiParent = this;
        //    l.Show();
        //}

        //public void btn_Register_Click(object sender, EventArgs e)
        //{
        //    frmRegister r = new frmRegister();
        //    r.StartPosition = FormStartPosition.CenterScreen;
        //    r.WindowState = FormWindowState.Maximized;
        //    r.MdiParent = this;
        //    r.Show();
        //}

        //private void btn_MemberList_Click(object sender, EventArgs e)
        //{
        //    frmMembers m = new frmMembers();
        //    m.StartPosition = FormStartPosition.CenterScreen;
        //    m.WindowState = FormWindowState.Normal;
        //    m.MdiParent = this;
        //    m.Show();
        //}

        //private void btn_Questions_Click(object sender, EventArgs e)
        //{
        //    frmQuestion q = new frmQuestion();
        //    q.StartPosition = FormStartPosition.CenterScreen;
        //    q.WindowState = FormWindowState.Normal;
        //    q.MdiParent = this;
        //    q.Show();
        //}

        //private void btn_Test_Click(object sender, EventArgs e)
        //{
        //    frmTest t = new frmTest();
        //    t.StartPosition = FormStartPosition.CenterScreen;
        //    t.WindowState = FormWindowState.Normal;
        //    t.MdiParent = this;
        //    t.Show();
        //}

        //private void btn_Result_Click(object sender, EventArgs e)
        //{
        //    frmResult rs = new frmResult();
        //    rs.StartPosition = FormStartPosition.CenterScreen;
        //    rs.WindowState = FormWindowState.Normal;
        //    rs.MdiParent = this;
        //    rs.Show();
        //}

        private void btn_MainLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!frm.bOK)
            {
                Messeagebox();
                return;

            }
            if (!KiemTra("frmLogin"))
            {
                frmLogin l = new frmLogin();
                l.ShowDialog();
            }
            //frmLogin l = new frmLogin();
            //l.StartPosition = FormStartPosition.CenterScreen;
            //l.WindowState = FormWindowState.Normal;
            //l.MdiParent = this;
            //l.Show();           
            
        }

        private void btn_MainReg_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!KiemTra("frmRegister"))
            {
                frmRegister frmDK = new frmRegister();
                frmDK.ShowDialog();
            }
            //frmRegister r = new frmRegister();
            //r.StartPosition = FormStartPosition.CenterScreen;
            //r.WindowState = FormWindowState.Normal;
            //r.Show();
        }

        private void btn_MainMember_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!frm.bOK)
            {
                Messeagebox();
                return;

            }
            if (!KiemTra("frmMembers"))
            {
                frmMembers m = new frmMembers();
                m.ShowDialog();
            }
            //frmMembers m = new frmMembers();
            //m.StartPosition = FormStartPosition.CenterScreen;
            //m.WindowState = FormWindowState.Normal;
            //m.MdiParent = this;
            //m.Show();
        }

        private void btn_MainQues_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!frm.bOK)
            {
                Messeagebox();
                return;

            }
            if (!KiemTra("frmQuestion"))
            {
                frmQuestion q = new frmQuestion();
                q.ShowDialog();
            }
            //frmQuestion q = new frmQuestion();
            //q.StartPosition = FormStartPosition.CenterScreen;
            //q.WindowState = FormWindowState.Normal;
            //q.MdiParent = this;
            //q.Show();
        }

        private void btn_MainTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!frm.bOK)
            {
                Messeagebox();
                return;

            }
            if (!KiemTra("frmTest"))
            {
                frmTest t = new frmTest();
                t.ShowDialog();
            }
            //frmTest t = new frmTest();
            //t.StartPosition = FormStartPosition.CenterScreen;
            //t.WindowState = FormWindowState.Normal;
            //t.MdiParent = this;
            //t.Show();
        }

        private void btn_MainResult_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!frm.bOK)
            {
                Messeagebox();
                return;

            }
            if (!KiemTra("frmResult"))
            {
                frmResult rs = new frmResult();
                rs.ShowDialog();
            }
            //frmResult rs = new frmResult();
            //rs.StartPosition = FormStartPosition.CenterScreen;
            //rs.WindowState = FormWindowState.Normal;
            //rs.MdiParent = this;
            //rs.Show();
        }

        private void btn_MainPass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!frm.bOK)
            {
                Messeagebox();
                return;

            }
            if (!KiemTra("frmResult"))
            {
                frmChangePass cp = new frmChangePass();
                cp.ShowDialog();
            }
            //frmChangePass cp = new frmChangePass();
            //cp.StartPosition = FormStartPosition.CenterScreen;
            //cp.WindowState = FormWindowState.Normal;
            //cp.MdiParent = this;
            //cp.Show();
        }
        #region button tool 
        private void btn_MainMin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_MainMax_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_DevTeam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!KiemTra("frmTeamDev"))
            {
                frmTeamDev dev = new frmTeamDev();
                dev.ShowDialog();
            }
        }

        private void btn_Soft_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!KiemTra("frmSoftware"))
            {
                frmSoftware sof = new frmSoftware();
                sof.ShowDialog();
            }
            
        }
        public void setbutton(bool val)
        {
            btn_MainLogout.Enabled = !val;
            btn_MainPass.Enabled = !val;
            btn_MainMember.Enabled = !val;
            btn_MainResult.Enabled = !val;
            btn_MainTest.Enabled = !val;
            btn_MainQues.Enabled = !val;
            btn_MainLogin.Enabled = val;
            btn_MainReg.Enabled = val;
           // MessageBox.Show("boool" +Convert.ToString(val));
            //dau tien run cai này??? enable tất cả button
        }
        #endregion
        public void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không ????", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        
    }
}

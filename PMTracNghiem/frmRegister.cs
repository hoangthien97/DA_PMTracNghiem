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
    public partial class frmRegister : Form
    {
        protected int regMND;
        protected string regHo = "";
        protected string regTen = "";
        protected string regNgaySinh = "";
        protected string regEmail = "";
        protected string regGioiTinh = "";
        protected string regTDN = "";
        protected string regMK = "";
        FLogin _fl = new FLogin();
        SqlDataReader _dr;
        DBconnect db = new DBconnect();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void txt_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))  //isDigit() kiểm tra xem ký tự vừa nhập vào textbox có phải là ký tự số hay không
            {
                e.Handled = true;
                if (Properties.Settings.Default.Language == "vi-VN")
                    MessageBox.Show("Họ tên phải là ký tự chữ.", "Thông Báo ");
                else
                    MessageBox.Show("Full name must be alphabetic.", "Notificate");
            }
        }

        private void txt_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))  //isDigit() kiểm tra xem ký tự vừa nhập vào textbox có phải là ký tự số hay không
            {
                e.Handled = true;
                if (Properties.Settings.Default.Language == "vi-VN")
                    MessageBox.Show("Họ tên phải là ký tự chữ.", "Thông Báo ");
                else
                    MessageBox.Show("Full name must be alphabetic.", "Notificate");
            }
        }
        public void LoadMNDnext()
        {
            _dr = _fl.LoadMNDNEXT();
            if (_dr.Read() == true)
            {
                regMND = Convert.ToInt32(_dr[0].ToString());
                regMND = regMND + 1;
            }
            db.CloseCnn();
        }


        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            regHo = txt_FirstName.Text;
            regTen = txt_LastName.Text;
            regNgaySinh = dtp_Birth.Text;
            regEmail = txt_Email.Text;
            regTDN = txt_CreUserName.Text;
            regMK = txt_Password.Text;
            if (rdb1.Checked == true)
                regGioiTinh = "Nam";
            else
            {
                if (rdbN.Checked == true)
                    regGioiTinh = "Nữ";
                else
                    regGioiTinh = "Khác";
            }
            if (regHo.Length == 0 || regTen.Length == 0 || regGioiTinh.Length == 0 || regEmail.Length == 0 || regTDN.Length == 0 || regMK.Length == 0)
            {
                MessageBox.Show("Bạn nhập thiếu thông tin cần thiết !!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadMNDnext();
            //Kiem tra GioiTinh
            if (txt_Password.Text == txt_Repassword.Text)
            {
                _fl.InsertND(regMND, regHo, regTen, regNgaySinh, regGioiTinh, regEmail, regTDN, regMK);

                MessageBox.Show("Bạn Đã Đăng Ký Thành Công!");
            }
            else
                MessageBox.Show("Password không trùng khớp");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không ????", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}

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
using static PMTracNghiem.frmLogin;

namespace PMTracNghiem
{
    public partial class frmMembers : Form
    {
        public bool themoi = false;
        DBconnect db = new DBconnect();
        //BindingSource _bs = new BindingSource();
        FMember _fm = new FMember();
        DataTable _dt = new DataTable();
      
        SqlDataReader _dr;
        public frmMembers()
        {
            InitializeComponent();
            ShowUser();
        }

        void setbutton(bool val)
        {
           
            btn_MemDelete.Enabled = val;
            btn_MemUpdate.Enabled = val;
            btn_MemSave.Enabled = !val;
        }

        void setnull()
        {
            txt_MemHo.Text = "";
            txt_MemEmail.Text = "";
            txt_Memtdn.Text = "";
            txt_MemTen.Text = "";
        }

        private void btn_MemSearch_Click(object sender, EventArgs e)
        {
            frmSearch s = new frmSearch();
            s.Show();
        }
        void ShowUser()
        {
            lstUser.Items.Clear();
            _dt = _fm.ShowUser();
            for (int i = 0; i < _dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lstUser.Items.Add(_dt.Rows[i][0].ToString());      // ID user
                lvi.SubItems.Add(_dt.Rows[i][1].ToString());    //Hoj
                lvi.SubItems.Add(_dt.Rows[i][2].ToString());    //Tên
                lvi.SubItems.Add(_dt.Rows[i][3].ToString());    //ngày sinh
                lvi.SubItems.Add(_dt.Rows[i][4].ToString()); // gioi tinh
                lvi.SubItems.Add(_dt.Rows[i][5].ToString()); // email
                lvi.SubItems.Add(_dt.Rows[i][6].ToString()); // tên đăng nhập
            }
        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUser.SelectedIndices.Count > 0)
            {
                txt_MemHo.Text = lstUser.SelectedItems[0].SubItems[1].Text;
              txt_MemTen.Text = lstUser.SelectedItems[0].SubItems[2].Text;
                dtp_MemBirth.Text = lstUser.SelectedItems[0].SubItems[3].Text;
                txt_MemEmail.Text = lstUser.SelectedItems[0].SubItems[5].Text;
                cb_Memgt.Text = lstUser.SelectedItems[0].SubItems[4].Text;
                txt_Memtdn.Text = lstUser.SelectedItems[0].SubItems[6].Text;
            }
        }


        private void btn_MemSave_Click(object sender, EventArgs e)
        {
            string ngay = string.Format("{0:dd/MM/yyyy}", dtp_MemBirth.Value);
            if (themoi)
            {
                _fm.ThemMem(txt_MemHo.Text, txt_MemTen.Text, ngay, cb_Memgt.SelectedItem.ToString(), txt_MemEmail.Text, txt_Memtdn.Text);
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {

            }
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PMTNLX_16_1_V1DataSet.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.dB_PMTNLX_16_1_V1DataSet.NGUOIDUNG);

        }

        private void btn_MemDelete_Click(object sender, EventArgs e)
        {
            if (lstUser.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("!!","!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr== DialogResult.Yes)
                {
                    _fm.XoaMem(Convert.ToInt32(lstUser.SelectedItems[0].SubItems[0].Text));
                    lstUser.Items.RemoveAt(lstUser.SelectedIndices[0]);
                    setnull();
                    MessageBox.Show("Xoá Thành công !!!!");
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn dữ liệu để xóa ??");
                }
            }
        }
    }
}

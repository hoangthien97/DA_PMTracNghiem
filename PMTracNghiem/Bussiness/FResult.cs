using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PMTracNghiem.Bussiness
{
    class FResult
    {
        DBconnect db;
        public FResult()
        {
            db = new DBconnect();
        }
        public SqlDataReader LoadName(int MND)
        {
            string query = "Select TEN,HO,EMAIL,MND from NGUOIDUNG where MND =" + MND + "";
            // string query = "Select TEN,HO,EMAIL,MND from NGUOIDUNG where TEN ='b'";
            SqlDataReader dr = db.ExcuteReader(query);
            return dr;
        }
        public void insert(int MND, int MKT, string MDT,string Ngaythi,int Diem)
        {
            db.OpenCnn();
            string sql = "Insert into KETQUA(MND,MKT,MDT,NgayThi,Diem) values(" + MND + "," + MKT + ",'" + MDT + "','" + Ngaythi + "'," + Diem + ")";
            db.ExecuteNonQuery(sql);
        }
    }
}

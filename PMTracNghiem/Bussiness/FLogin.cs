using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMTracNghiem.Bussiness
{
    class FLogin
    {
        DBconnect db = new DBconnect();
        public FLogin()
        {
            db = new DBconnect();
        }
        public SqlDataReader LoadData(String TDN, String MK)
        {
            db.OpenCnn();
            string query = "Select MND,HO,TEN,NGAYSINH,GIOITINH,EMAIL,TDN,MK from NGUOIDUNG where TDN ='" + TDN + "'and MK='" + MK + "'";
            // string query = "Select TEN,HO,EMAIL,MND from NGUOIDUNG where TEN ='b'";
            SqlDataReader dr = db.ExcuteReader(query);
            return dr;
        }
        public SqlDataReader LoadMNDNEXT()
        {
            db.OpenCnn();
            string query = "select Max(MND) from Nguoidung";
            // string query = "Select TEN,HO,EMAIL,MND from NGUOIDUNG where TEN ='b'";
            SqlDataReader dr = db.ExcuteReader(query);
            return dr;
        }
        public void InsertND(int MND, string Ho, string Ten, string Ngaysinh, string GioiTinh, string Email,string TDN,string MK)
        {
            string sql = "INSERT [dbo].[NGUOIDUNG] ([MND], [HO], [TEN], [NGAYSINH], [GIOITINH], [EMAIL], [TDN], [MK], [PQ]) VALUES (" + MND + ", N'" + Ho + "', N'" + Ten + "', CAST('" + Ngaysinh + "' AS SmallDateTime), N'" + GioiTinh + "', N'"+Email+"', N'" + TDN + "', N'" + MK + "', 0)";
            //string sql = "Insert into NGUOIDUNG(MND,MKT,MDT,QMCH,MDAND) values(" + MND + "," + MKT + ",'" + MDT + "'," + QMCH + ",'" + MDAND + "')";
            db.ExecuteNonQuery(sql);
        }
        public SqlDataReader LoadName(string TDN,string MK)
        {
            db.OpenCnn();
            String sql = "Select MND,TDN,MK from NGUOIDUNG where TDN='" + TDN + "' And MK='" + MK + "'";
            SqlDataReader dr = db.ExcuteReader(sql);
            return dr;
        }

        public SqlDataReader CheckPQ(string TDN, string MK)
        {
            db.OpenCnn();
            String sql = "Select PQ from NGUOIDUNG where TDN='" + TDN + "' And MK='" + MK + "'";
            SqlDataReader dr = db.ExcuteReader(sql);
            return dr;
        }

    }
}

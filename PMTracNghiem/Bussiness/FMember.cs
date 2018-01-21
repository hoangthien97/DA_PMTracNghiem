using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static PMTracNghiem.frmLogin;

namespace PMTracNghiem.Bussiness
{
    class FMember
    {
        DBconnect db; //= new DBconnect();
        public FMember()
        {
            db = new DBconnect();
        }
        public DataTable ShowUser()
        {
            // string query = "select  STT , QTCH, b.QMCH, a.MDT  from DETHI a , CAUHOI b , CTDETHI c where a.MDT = c.MDT and c.QMCH = b.QMCH and a.MDT = '" + MDT + "' order by STT asc ";
            string query = "select MND , HO , TEN , NGAYSINH , GIOITINH , EMAIL , TDN from NGUOIDUNG";
            DataTable data = db.Execute(query);
            return data;
        }
        //public DataTable ShowQDAD(string MDT)
        //{
        //    string query = "select  STT,b.QMCH, QDAD from cauhoi a, CTDETHI b where a.QMCH = b.QMCH and MDT='" + MDT + "'order by STT asc";
        //    //string query = "select  a.QMCH, QDAD from cauhoi a, CTDETHI b where a.QMCH = b.QMCH and MDT='"+MDT+"'";
        //    DataTable data = db.Execute(query);

        //    return data;

        //public DataTable Traloind(int MND, int MKT, string MDT, int QMCH)
        //{
        //    string query = "select  * from TRALOIND where MND =" + MND + "and MKT=" + MKT + "and MDT='" + MDT + "'and QMCH=" + QMCH + "";
        //    DataTable data = db.Execute(query);
        //    return data;
        //}

        //public DataTable Show()
        //{
        //    string sql = "Select * from CauHoi";
        //    DataTable 
        //}
        //public sqldatareader loadname(int mnd)
        //{
        //    string query = "select ten,ho,email,mnd from nguoidung where mnd =" + mnd + "";
        //    // string query = "select ten,ho,email,mnd from nguoidung where ten ='b'";
        //    sqldatareader dr = db.excutereader(query);
        //    return dr;
        //}
        public void ThemMem(string HO, string TEN, string NGAYSINH, string GIOITINH, string EMAIL, string TDN)
        {
            //db.OpenCnn();
            string sql = string.Format("Insert into NGUOIDUNG(Ho,TEN,NGAYSINH,GIOITINH,EMAIL,TDN) values(" + HO + "," + TEN + "," + NGAYSINH + "," + GIOITINH + "," + EMAIL + "," + TDN + ")");
           // string sql = string.Format("Insert into NGUOIDUNG values (N'{1}',N'{2}','{3}',N'{4}',N'{5},N'{6}')", MND ,HO, TEN, NGAYSINH, GIOITINH, EMAIL, TDN);
            db.ExecuteNonQuery(sql);
        }

        public void XoaMem(int MND)
        {
            string sql = "delete from NGUOIDUNG where MND = " + IDinfor.MND;
            db.ExecuteNonQuery(sql);
        }
        //public void update(int MND, int MKT, string MDT, int QMCH, string MDAND, string Danhgia)
        //{
        //    db.OpenCnn();
        //    string sql = "update TRALOIND set DANHGIA = '" + Danhgia + "'where MND =" + MND + "and MKT=" + MKT + "and MDT='" + MDT + "'and QMCH=" + QMCH + "";

        //    db.ExecuteNonQuery(sql);
        //}

        //public void delete(int MND, int MKT, string MDT, int QMCH)
        //{
        //    //Xóa trước khi lưu câu hỏi vào hệ thống.
        //    db.OpenCnn();
        //    string sql = "Delete from TRALOIND where MND=" + MND + "and MKT=" + MKT + "and MDT='" + MDT + "'and QMCH=" + QMCH + "";
        //    db.ExecuteNonQuery(sql);
        //}
    }
}


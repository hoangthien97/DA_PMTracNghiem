using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace PMTracNghiem.Bussiness
{
    class GetData
    {
        DBconnect db = new DBconnect();

        public SqlDataReader LoadMKT()
        {
            string query = "select max(MKT) from KIEMTRA";
            // string query = "Select TEN,HO,EMAIL,MND from NGUOIDUNG where TEN ='b'";
            SqlDataReader dr = db.ExcuteReader(query);
            return dr;
        }
        public DataTable kt(bool loai)
        {
            string query = "select * from DETHI where LOAI='"+loai+"'";
            DataTable data = db.ExecuteSelect(query);
            return data;
        }
        public void insert(int mkt, int mnd, string mdt, string ngaythi)
        {
            string query= "insert into KIEMTRA (mkt, mnd, mdt, ngaythi) values (" + mkt + "," + mnd + ",'" + mdt + "','"  + ngaythi + "')";
            //MessageBox.Show(query);
            db.ExecuteNonQuery(query);
        }

        public void insertCH(int MCH, string TCH, string DAD)
        {
            string sql = "Insert into CauHoi(QMCH,QTCH,QPIC,QDAD) values(" +MCH + ",'" +TCH + "','null','" + DAD + "')";
            MessageBox.Show(sql);
            db.ExecuteNonQuery(sql);
        }

        public void updateCH(int MCH, string TCH, string DAD)
        {
            string sql = "Update CAUHOI set QTCH=N'" + TCH + "', QDAD ='" + DAD + "'  where QMCH='" + MCH + "'";
            MessageBox.Show(sql);
            db.ExecuteNonQuery(sql);
        }
        public void DeleteCH(int MCH)
        {
            string sql = "Delete from CAUHOI where QMCH ='" + MCH + "'";
            MessageBox.Show(sql);
            db.ExecuteNonQuery(sql);
        }
        public SqlDataReader loadMCH()
        {
            db.OpenCnn();
            string query = "select Max(QMCH) from CAUHOI";
            // string query = "Select TEN,HO,EMAIL,MND from NGUOIDUNG where TEN ='b'";
            SqlDataReader dr = db.ExcuteReader(query);
            return dr;
        }
        public void updateDA(string TDA,string DA,string MDA)
        {
            string sql = "Update DAPAN set ATDA=N'" + TDA + "', DA ='"+DA+"'where AMDA='"+MDA+"'";
            MessageBox.Show(sql);
            db.ExecuteNonQuery(sql);
        }
    }
}

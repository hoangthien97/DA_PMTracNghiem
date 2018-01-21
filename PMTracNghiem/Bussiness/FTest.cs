using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PMTracNghiem.BUSI
{
    class FTest
    {
          DBconnect db; //= new DBconnect();
        public FTest()
        {
            db = new DBconnect();
        }
        public DataTable ShowCauhoi(string MDT)
        {
            string query = "select  STT , QTCH, b.QMCH, a.MDT  from DETHI a , CAUHOI b , CTDETHI c where a.MDT = c.MDT and c.QMCH = b.QMCH and a.MDT = '" + MDT + "' order by STT asc ";
            
            DataTable data = db.Execute(query);
            return data;
        }
        public DataTable ShowQDAD(string MDT)
        {
            string query = "select  STT,b.QMCH, QDAD from cauhoi a, CTDETHI b where a.QMCH = b.QMCH and MDT='" + MDT + "'order by STT asc";
            //string query = "select  a.QMCH, QDAD from cauhoi a, CTDETHI b where a.QMCH = b.QMCH and MDT='"+MDT+"'";
            DataTable data = db.Execute(query);
            
            return data;
        }
        public DataTable Traloind(int MND, int MKT, string MDT, int QMCH)
        {
            string query = "select  * from TRALOIND where MND =" + MND + "and MKT=" + MKT + "and MDT='" + MDT + "'and QMCH=" + QMCH +"";
            DataTable data = db.Execute(query);
            return data;
        }

        //public DataTable Show()
        //{
        //    string sql = "Select * from CauHoi";
        //    DataTable 
        //}
        public SqlDataReader LoadName(int MND)
        {
            string query = "Select TEN,HO,EMAIL,MND from NGUOIDUNG where MND ="+ MND +"";
           // string query = "Select TEN,HO,EMAIL,MND from NGUOIDUNG where TEN ='b'";
            SqlDataReader dr = db.ExcuteReader(query);
            return dr;
        }
        public void insert(int MND, int MKT, string MDT, int QMCH, string MDAND,string Danhgia)
        {
            db.OpenCnn();
            string sql = "Insert into TRALOIND(MND,MKT,MDT,QMCH,MDAND) values(" + MND + "," + MKT + ",'" + MDT + "'," + QMCH + ",'" + MDAND + "')";
            db.ExecuteNonQuery(sql);
        }
        public void update(int MND, int MKT, string MDT, int QMCH, string MDAND, string Danhgia)
        {
            db.OpenCnn();
            string sql = "update TRALOIND set DANHGIA = '" + Danhgia + "'where MND =" + MND + "and MKT=" + MKT + "and MDT='" + MDT + "'and QMCH=" + QMCH + "";

            db.ExecuteNonQuery(sql);
        }

        public void delete(int MND, int MKT, string MDT, int QMCH)
        {
            //Xóa trước khi lưu câu hỏi vào hệ thống.
            db.OpenCnn();
            string sql = "Delete from TRALOIND where MND=" + MND + "and MKT=" + MKT + "and MDT='" + MDT + "'and QMCH=" + QMCH + "";
            db.ExecuteNonQuery(sql);
        }
        
         

       /* public void tick(int min, int sec, int ms)
        {
            min = 0;
            sec = 2;
            ms = 0;
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
                return false;
            }
        }*/
    }
}

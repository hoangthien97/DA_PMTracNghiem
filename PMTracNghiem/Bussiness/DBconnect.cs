using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace PMTracNghiem
{
    class DBconnect
    {

        /// <summary>
        #region  Khai báo biến kết nối
        /// </summary>
        protected SqlConnection _cnn;
        protected SqlCommand _cmd;
        protected SqlDataAdapter _da;
        protected DataSet _ds;
        protected DataTable _dt;
        protected SqlDataReader dr;

        #endregion

        #region Open and close connect
        /// <summary>
        /// Hàm mở kết nối
        /// </summary> 

        public void OpenCnn()
        {
            string connectionString = (@"Data Source=SYNZ\SQLEXPRESS;Initial Catalog=DB_PMTNLX_16_1_V1;Integrated Security=True");
           
            //string connectionString = (@"Data Source=HAN-PC;Initial Catalog=DB_PMTNLX_12_1_V1;Integrated Security=True");
            _cnn = new SqlConnection(connectionString);
            try
            {
                if (_cnn.State == ConnectionState.Closed || _cnn.State == ConnectionState.Broken)
                {
                    _cnn.Open();
                }
            }
            catch (System.Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error to connect database, please check again \n\n  Information:\n- " + e.Message, "Error...", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                _cnn.Close();
                _cnn.Dispose();
            }
        }

        /// <summary>
        /// Hàm đóng kết nối
        /// </summary>
        public void CloseCnn()
        {
            try
            {
                if (_cnn.State == ConnectionState.Open)
                {
                    _cnn.Close();
                    _cnn.Dispose();
                }
            }
            catch { }
        }

        #endregion
        
        #region Các hàm xử lý database ( Thêm, Xóa, Sửa, Cập nhật)
        //public DBconnect()
        //{
        //    string strCnn = @"Data Source=HAN-PC;Initial Catalog=DB_PMTNLX_12_1_V1;Integrated Security=True";
        //    _cnn = new SqlConnection(strCnn);
        //}

            public DataTable Execute(string sqlStr)
            {
                OpenCnn();
                _da = new SqlDataAdapter(sqlStr, _cnn);
                _ds = new DataSet();
                _da.Fill(_ds);
                return _ds.Tables[0];
            }
            public void ExecuteNonQuery(string strSQL)
            {
                OpenCnn();  //Mo ket noi
                _cmd = new SqlCommand(strSQL, _cnn);
                _cmd.CommandType = CommandType.Text;
                _cmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua
                CloseCnn();//Dong ket noi
            }

            public SqlDataReader ExcuteReader(string strSQL)
            {
                OpenCnn();
                _cmd = new SqlCommand(strSQL, _cnn);
                _cmd.CommandType = CommandType.Text;
                dr= _cmd.ExecuteReader();
                return dr;
        }         
         
            public DataTable ExecuteSelect(string sql)
            {
                OpenCnn();
                _dt = new DataTable();
                _da = new SqlDataAdapter(sql, _cnn);
                _da.Fill(_dt);
                return _dt;
            }

        #endregion


            #region Lỗi 
        /*
            //public SqlConnection openConnect()
        //{
        //    string connectString = Properties.Settings.Default.DB_PMTNLX_NEWConnectionString;
        //    return new SqlConnection(connectString);
        //}

        public DBconnect()
        {
            string strCnn = @"Data Source=HAN-PC;Initial Catalog=DB_PMTNLX_NEW;User ID=sa;Password=han@123";
            sqlConn = new SqlConnection(strCnn);
        }
        // Phuong thuc de thuc hien cau lenh strSQL truy vân du lieu
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open(); //Mo ket noi
            sqlcmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua
            sqlConn.Close();//Dong ket noi
        }

        //public DataTable ExecuteSelect(string sql)
        //{
        //    DataTable dt = new DataTable();

        //    SqlDataAdapter adapter = new SqlDataAdapter(sql, openConnect());
        //    adapter.Fill(dt);

        //    return dt;
        //}*/
        #endregion 
    
            public SqlConnection connectionString { get; set; }
    }
}

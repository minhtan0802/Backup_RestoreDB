using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Backup_Restore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataAdapter da;
        public static String dbName;//lưu tên DB

        public static String servername = "LAPTOP-V0HI7R3V\\SERVER";
        public static String username = "";
        public static String password = "";
        public static String database = "tempdb";
        public static String mlogin = "";

        public static int nambatdau = 2016;// để tự động tính dựa vào năm này
        public static int flagRestore = 0;//để kiểm tra user có phục hồi?
        public static string strDefaultPath = "C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SERVER\\MSSQL\\Backup\\";
        public static int banSaoLuu;
        public static string selectRows;
        public static frmMain frmChinh;

        public static String nameDEV;
        public static frmDangNhap frmDN;
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Server=" + Program.servername + ";" +
                "database= tempdb ;" + "User id=" + Program.mlogin + ";Password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(string cmd, string connectionString)
        {
            conn.Close();
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable (string cmd, string connectionString)
        {
            conn = new SqlConnection(connectionString);
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            Program.conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(string cmd, string connectionString, string errstr)
        {
            conn = new SqlConnection(connectionString);
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;//10 phut
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                int error = sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException e)
            {
                if (e.Message.Contains("Error converting datatype varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở file Excel");
                else MessageBox.Show(errstr+e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conn.Close();
                return e.State;

            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDN = new frmDangNhap();
            Application.Run(frmDN);
        }
    }
}

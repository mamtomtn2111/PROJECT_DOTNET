using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_DuAn;

namespace DAL_DuAn
{
    public class D_QuanLyDuAn
    {
        public static DataTable GetDataQuanLyDuAn()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("select * from QuanLyDuAn", Conn);
            //command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static DataTable GetDataSinhVienQuanLyDuAn(string MaDuAn)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            string sqlcmd = "select MSV, TenSV, Lop, SDT, DiaChi from SinhVien where MaDuAn = '"+MaDuAn+"'";
            SqlCommand command = new SqlCommand(sqlcmd, Conn);
            /*command.CommandType = CommandType.StoredProcedure;*/
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void ThemQuanLyDuAn(QuanLyDuAnDTO qlda)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            String sqlcmd = "insert into QuanLyDuAn values('"+qlda.MaDuAn1+"','"+qlda.TGBD1+"','"+qlda.TGKT1+"',N'"+qlda.MoTa1+"')";
            SqlCommand command = new SqlCommand(sqlcmd, Conn);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void SuaQuanLyDuAn(QuanLyDuAnDTO qlda)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            String sqlcmd = "update QuanLyDuAn set TGBD = '"+qlda.TGBD1+"', TGKT = '"+qlda.TGKT1+"', MoTa = N'"+qlda.MoTa1+"' where MaDuAn = '"+qlda.MaDuAn1+"'";
            SqlCommand command = new SqlCommand(sqlcmd, Conn);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void XoaQuanLyDuAn(string MaDuAn)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            String sqlcmd = "delete QuanLyDuAn where MaDuAn = '"+MaDuAn+"'";
            SqlCommand command = new SqlCommand(sqlcmd, Conn);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}

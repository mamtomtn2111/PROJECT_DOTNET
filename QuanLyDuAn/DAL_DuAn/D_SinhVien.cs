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
    public class D_SinhVien
    {
        public static DataTable GetDataSinhVien()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("select * from SinhVien",Conn);
            //command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void ThemSinhVien(SinhVienDTO SinhVien)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            String sqlcmd = "insert into SinhVien values('" + SinhVien.MSV1 + "','" + SinhVien.MaDuAn1 + "',N'" + SinhVien.TenSV1 + "',N'" + SinhVien.Lop1 + "','" + SinhVien.SDT1 + "',N'" + SinhVien.DiaChi1 + "')";
            SqlCommand command = new SqlCommand(sqlcmd, Conn);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void SuaSinhVien(SinhVienDTO SinhVien)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            String sqlcmd = "update SinhVien set MaDuAn = N'"+SinhVien.MaDuAn1+"', TenSV = N'"+SinhVien.TenSV1+"', Lop = '"+SinhVien.Lop1+"', SDT = N'"+SinhVien.SDT1+"', DiaChi = N'"+SinhVien.DiaChi1+"' where MSV = '"+SinhVien.MSV1+"'";
            SqlCommand command = new SqlCommand(sqlcmd, Conn);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void XoaSinhVien(string MaSinhVien)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            String sqlcmd = "delete SinhVien where MSV = '"+MaSinhVien+"'";
            SqlCommand command = new SqlCommand(sqlcmd, Conn);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}

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
    public class D_DuAn
    {
        public static DataTable GetDataDuAn()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("select * from DuAn",Conn);
            //command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void ThemDuAn(DuAnDTO DuAn)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            String sqlcmd = "insert into DuAn values('" + DuAn.MaDuAn1 + "',N'" + DuAn.TenDuAn1 + "',N'" + DuAn.CoVan1 + "',N'" + DuAn.ThongTinCoVan1 + "','"+DuAn.SDTCoVan1+"',N'"+DuAn.NoiDungDuAn1+"')";
            SqlCommand command = new SqlCommand(sqlcmd, Conn);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void SuaDuAn(DuAnDTO DuAn)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            String sqlcmd = "update DuAn set TenDuAn = N'"+DuAn.TenDuAn1+"', CoVan = N'"+DuAn.CoVan1+"', ThongTinCoVan = N'"+DuAn.ThongTinCoVan1+"', SDTCoVan =N'"+DuAn.SDTCoVan1+"', NoiDungDuAn = N'"+DuAn.NoiDungDuAn1+"' where MaDuAn = '"+DuAn.MaDuAn1+"'";
            SqlCommand command = new SqlCommand(sqlcmd, Conn);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void XoaDuAn(string MaDuAn)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            String sqlcmd = "delete DuAn where MaDuAn = '"+MaDuAn+"'";
            SqlCommand command = new SqlCommand(sqlcmd, Conn);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}

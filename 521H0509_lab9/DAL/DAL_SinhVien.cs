using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SinhVien
    {
        DTO_SinhVien p;

        public DAL_SinhVien(string MaSoSinhVien, string HoTen, string QueQuan, DateTime NgaySinh, string HocLuc)
        {
            p = new DTO_SinhVien(MaSoSinhVien, HoTen, QueQuan, NgaySinh, HocLuc);
        }

        public void addQuery()
        {
            string query = "INSERT INTO SinhVien VALUES ('" + p._MaSoSinhVien + "', N'" + p._HoTen + "', N'" + p._QueQuan + "', '" + p._NgaySinh.ToString("yyyy-MM-dd") + "', N'" + p._HocLuc + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE SinhVien SET HoTen = N'" + p._HoTen + "', QueQuan = N'" + p._QueQuan + "', NgaySinh = '" + p._NgaySinh.ToString("yyyy-MM-dd") + "', HocLuc = N'" + p._HocLuc + "' WHERE MaSoSinhVien = '" + p._MaSoSinhVien + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM SinhVien WHERE MaSoSinhVien = '" + p._MaSoSinhVien + "'";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string query = "SELECT * FROM SinhVien";
            return Connection.selectQuery(query);
        }



        //get Datatable desc order
        public DataTable getProjectDesc()
        {
            string s = "select top 1 PID from Project order by PID desc";
            return Connection.selectQuery(s);
        }
    } 




    public class DAL_Detai
    {
         
        DTO_detai p;

        public DAL_Detai(string MaSoDeTai, string TenDeTai, string ChuNhiemDeTai, decimal KinhPhi)
        {
            p = new DTO_detai(MaSoDeTai , TenDeTai , ChuNhiemDeTai , KinhPhi );
        }

        public void addDeTai()
        {
            string query = "INSERT INTO DeTai (MaSoDeTai, TenDeTai, ChuNhiemDeTai, KinhPhi) " +
                           "VALUES ('" + p._MaSoDeTai + "', N'" + p._TenDeTai + "', N'" + p._ChuNhiemDeTai + "', " + p._KinhPhi + ")";
            Connection.actionQuery(query);
        }
        public DataTable GetDeTaiBySinhVien(string maSoSinhVien)
        {
            string query = "SELECT DeTai.* FROM DeTai " +
               "INNER JOIN SinhVien_DeTai ON DeTai.MaSoDeTai = SinhVien_DeTai.MaSoDeTai " +
               "WHERE SinhVien_DeTai.MaSoSinhVien = '" + maSoSinhVien + "'";
            return Connection.selectQuery(query);
        }


        // Update an existing project in the p table
        public void updateDeTai()
        {
            string query = "UPDATE DeTai SET TenDeTai = N'" + p._TenDeTai + "', ChuNhiemDeTai = N'" + p._ChuNhiemDeTai + "', KinhPhi = " + p._KinhPhi + " WHERE MaSoDeTai = '" + p._MaSoDeTai + "'";
            Connection.actionQuery(query);
        }

        // Delete a project from the DeTai table
        public void deleteDeTai(string MaSoDeTai)
        {
            string query = "DELETE FROM DeTai WHERE MaSoDeTai = '" + MaSoDeTai + "'";
            Connection.actionQuery(query);
        }

        // Retrieve all projects from the DeTai table
        public DataTable getAllDeTai()
        {
            string query = "SELECT * FROM DeTai";
            return Connection.selectQuery(query);
        }


        //get Datatable desc order
        public DataTable getProjectDesc()
        {
            string s = "select top 1 PID from Project order by PID desc";
            return Connection.selectQuery(s);
        }
    }
}

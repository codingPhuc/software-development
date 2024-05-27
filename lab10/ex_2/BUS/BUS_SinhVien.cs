using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_SinhVien
    {
        DAL_SinhVien p;

        public BUS_SinhVien(string MaSoSinhVien, string HoTen, string QueQuan, DateTime NgaySinh, string HocLuc)
        {
            p = new DAL_SinhVien(MaSoSinhVien, HoTen, QueQuan, NgaySinh, HocLuc);
        }


        public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuere()
        {
            p.updateQuery();
        }

        public void deleteQuery()
        {
            p.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return p.selectQuery();
        } 
        public List<String> selectStudentNumber() {
            
            DataTable dt = p.selectQuery();
            List<String> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["MaSoSinhVien"].ToString());
            }
            return list;
        }

        public string getPID()
        {
            DataTable tb = p.getProjectDesc();
            if(tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(2, 3)) + 1;
                if (stt < 10)
                    res = "PO00" + stt.ToString();
                else if (stt < 100)
                    res = "PO0" + stt.ToString();
                else
                    res = "PO" + stt.ToString();
                return res;
            }
            else
            {
                return "PO001";
            }
        }
    }
    public class BUS_Detai
    {
        DAL_Detai p;

        public BUS_Detai(string MaSoDeTai, string TenDeTai, string ChuNhiemDeTai, decimal KinhPhi)
        {
            p = new DAL_Detai(MaSoDeTai, TenDeTai, ChuNhiemDeTai, KinhPhi);
        }
        public DataTable GetDeTaiBySinhVien(string massv)
        {
            return p.GetDeTaiBySinhVien(massv);
        }


        public DataTable selectQuery()
        {
            return p.getAllDeTai();
        }

        public void addDeTai()
        {
            p.addDeTai();
        }
    }
}

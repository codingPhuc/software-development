using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SinhVien
    {
        private string MaSoSinhVien, HoTen, QueQuan, HocLuc;
        private DateTime NgaySinh;

        public string _MaSoSinhVien
        {
            get { return MaSoSinhVien; }
            set { MaSoSinhVien = value; }
        }

        public string _HoTen
        {
            get { return HoTen; }
            set { HoTen = value; }
        }

        public string _QueQuan
        {
            get { return QueQuan; }
            set { QueQuan = value; }
        }

        public DateTime _NgaySinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }

        public string _HocLuc
        {
            get { return HocLuc; }
            set { HocLuc = value; }
        }

        public DTO_SinhVien(string MaSoSinhVien, string HoTen, string QueQuan, DateTime NgaySinh, string HocLuc)
        {
            this.MaSoSinhVien = MaSoSinhVien;
            this.HoTen = HoTen;
            this.QueQuan = QueQuan;
            this.NgaySinh = NgaySinh;
            this.HocLuc = HocLuc;
        }
    }

    public class DTO_detai
    {
        private string MaSoDeTai, TenDeTai, ChuNhiemDeTai;
        private decimal KinhPhi;

        public string _MaSoDeTai
        {
            get { return MaSoDeTai; }
            set { MaSoDeTai = value; }
        }

        public string _TenDeTai
        {
            get { return TenDeTai; }
            set { TenDeTai = value; }
        }

        public string _ChuNhiemDeTai
        {
            get { return ChuNhiemDeTai; }
            set { ChuNhiemDeTai = value; }
        }

        public decimal _KinhPhi
        {
            get { return KinhPhi; }
            set { KinhPhi = value; }
        }

        public DTO_detai(string MaSoDeTai, string TenDeTai, string ChuNhiemDeTai, decimal KinhPhi)
        {
            this.MaSoDeTai = MaSoDeTai;
            this.TenDeTai = TenDeTai;
            this.ChuNhiemDeTai = ChuNhiemDeTai;
            this.KinhPhi = KinhPhi;
        }
    }

}

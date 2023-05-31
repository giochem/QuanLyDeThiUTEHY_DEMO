using System;

namespace DTO
{
    public class NguoiDung_DeThi_DTO
    {
        public NguoiDung_DeThi_DTO ( ) { }
        public int ID { get; set; }
        public int ID_NguoiDung { get; set; }
        public int ID_DeThi { get; set; }
        public int DiemThi { get; set; }
        public DateTime BatDau { get; set; }
        public DateTime KetThuc { get; set; }
    }
}

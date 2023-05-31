using System;

namespace DTO
{
    public class DeThi_DTO
    {
        public DeThi_DTO ( ) { }
        public int ID { get; set; }
        public int ID_MonHoc { get; set; }
        public string TieuDe { get; set; }
        public int SoCauHoi { get; set; }
        public int ThoiGian { get; set; }
        public int SoCauToiThieu { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
    }
}

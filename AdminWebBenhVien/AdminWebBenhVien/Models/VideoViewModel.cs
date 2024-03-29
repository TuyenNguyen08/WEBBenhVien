﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminWebBenhVien.Models
{
    public class VideoViewModel
    {
        public int Id { get; set; }
        public string TieuDe { get; set; }
        public string GioiThieu { get; set; }
        public string DuongDanFile { get; set; }
        public bool IsYoutube { get; set; }
        public bool NoiBat { get; set; }
        public int? LuotXem { get; set; }
        public int FkNgonNgu { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string UserNguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? Stt { get; set; }
        public string HinhAnh { get; set; }

    }
}

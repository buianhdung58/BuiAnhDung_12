using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BuiAnhDung_12.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string MaTinhThanh { get; set; }
    }
}
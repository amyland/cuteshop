using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteShop.Model.Models
{
    [Table ("NhanVien")]
    public class NhanViens
    {
        [Key]
        public string MaNV { set; get; }

        [Required]
        public string Username { set; get; }

        [Required]
        public string Passwords { set; get; }

        [Required]
        public string TenNV { set; get; }

        [Required]
        public string DiaChi { set; get; }

        [Required]
        public string DienThoai { set; get; }

        [Required]
        public bool Statuss { set; get; }
    }
}

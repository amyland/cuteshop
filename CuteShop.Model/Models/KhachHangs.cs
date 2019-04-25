using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteShop.Model.Models
{
    [Table("KhachHang")]
    public class KhachHangs
    {
        [Key]
        public string MaKH { set; get; }

        [Required]
        public string TenKH { set; get; }

        [Required]
        public string DiaChi { set; get; }

        [Required]
        public string DienThoai { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteShop.Model.Models
{
    [Table ("NhatKyHT")]
    class NhatKyHTs
    {
        [Key]
        public string MaHDBan { set; get; }

        [Required]
        public string MaKH { set; get; }

        [Required]
        public string MaNV { set; get; }

        [Key]
        public string MaHang { set; get; }

        [Required]
        public DateTime? NgayBan { set; get; }

        [Required]
        public float? TongTien { set; get; }
    }
}

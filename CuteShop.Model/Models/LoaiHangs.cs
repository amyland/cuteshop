using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteShop.Model.Models
{
    [Table ("LoaiHang")]
    public class LoaiHangs
    {
        [Key]
        public string MaHang { set; get; }

        [Required]
        public string MaHH { set; get; }

        [ForeignKey("MaHH")]
        public virtual HangHoas HangHoas { set; get; }

        [Required]
        public string TenHang { set; get; }

        [Required]
        public float SoLuong { set; get; }

        [Required]
        public float DonGiaNhap { set; get; }

        [Required]
        public float DonGiaBan { set; get; }
    }
}

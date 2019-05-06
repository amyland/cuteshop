using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteShop.Model.Models
{
    [Table("DonHang")]
    public class DonHangs
    {
        [Key]
        public string MaHDBan { set; get; }

        [Required]
        public string MaHang { set; get; }

        [ForeignKey("MaHang")]
        public virtual LoaiHangs LoaiHangs { set; get; }

        [Required]
        public string MaNV { set; get; }

        [ForeignKey("MaNV")]
        public virtual NhanViens NhanViens { set; get; }

        [Required]
        public float SoLuong { set; get; }

        [Required]
        public float DonGia { set; get; }

        [Required]
        public float ThanhTien { set; get; }

        [Required]
        public string MaKH { set; get; }

        [ForeignKey("MaKH")]
        public virtual KhachHangs KhachHangs { set; get; }
    }
}

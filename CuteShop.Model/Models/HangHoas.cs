using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteShop.Model.Models
{
    [Table ("HangHoa")]
    public class HangHoas
    {
        [Key]
        public string MaHH { set; get; }

        [Required]
        public string TenHH { set; get; }
    }
}

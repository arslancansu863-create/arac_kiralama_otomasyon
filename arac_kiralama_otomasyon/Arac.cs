using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_kiralama_otomasyon
{
    [Table("Table_arac")]
    internal class Arac
    {
        [Key]
        public int arac_id { get; set; }
        [Required, MaxLength(50)]
        public string arac_marka { get; set; }

        [Required] [MaxLength(50)]
        public string arac_model { get; set; }

        [Required] [MaxLength(20)]
        public string arac_plaka { get; set; }

        [Required]
        public decimal arac_gunlukfiyat { get; set; }

        [Required]
        public bool arac_durum { get; set; }
        public virtual ICollection <Arac> Aracs { get; set; }
    }
}

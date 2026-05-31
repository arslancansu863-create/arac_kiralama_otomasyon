using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_kiralama_otomasyon
{
    [Table("Table_kiralama")]
    internal class Kiralama
    {
        [Key]
        public int kiralama_id { get; set; }

        [ForeignKey("Musteri")]
        public int musteri_id { get; set; }

        [ForeignKey("Arac")]
        public int arac_id { get; set; }

        [ForeignKey("Personel")]
        public int personel_id { get; set; }

        [Required]
        public DateTime alis_tarihi { get; set; }

        [Required]
        public DateTime teslim_tarihi { get; set; }

        [Required]
        public int gun_sayisi { get; set; }

        [Required]
        public decimal toplam_tutar { get; set; }

        [Required]
        [MaxLength(20)]
        public string kiralama_durum { get; set; }

        public virtual Musteri Musteri { get; set; }
        public virtual Arac Arac { get; set; }
        public virtual Personel Personel { get; set; }
    }
}

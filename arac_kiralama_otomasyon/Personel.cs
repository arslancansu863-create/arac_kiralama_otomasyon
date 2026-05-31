using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_kiralama_otomasyon
{
    [Table("Table_personel")]
    internal class Personel
    {
        [Key] // Birincil Anahtar
        public int personel_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string personel_ad { get; set; }

        [Required]
        [MaxLength(50)]
        public string personel_soyad { get; set; }

        [Required]
        [MaxLength(30)]
        public string kullanici_ad { get; set; }

        [Required]
        [MaxLength(30)]
        public string kullanici_sifre { get; set; }

        [Required]
        [MaxLength(20)]
        public string kullanici_yetki { get; set; }

        public virtual ICollection<Kiralama> Kiralamalar { get; set; }
    }
}

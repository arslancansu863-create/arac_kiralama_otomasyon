using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace arac_kiralama_otomasyon
{
    [Table("Table_musteri")]
    internal class Musteri
    {
        [Key]
        public int musteri_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string musteri_ad { get; set; }

        [Required]
        [MaxLength(50)]
        public string musteri_soyad { get; set; }

        [Required]
        [MaxLength(50)]
        public string musteri_telefon { get; set; }

        [Required]
        [MaxLength(50)]
        public string musteri_mail { get; set; }

        [Required]
        [MaxLength(50)]
        public string musteri_tc { get; set; }

        [Required]
        [MaxLength(50)]
        public string musteri_ehliyetno { get; set; }

        public virtual ICollection <Kiralama> Kiralamas { get; set; } 

    }
}

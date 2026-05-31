using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace arac_kiralama_otomasyon
{

    internal class MusteriDbContext : DbContext
    {
        public MusteriDbContext() : base("name=MusteriDbContext")
        {

        }

        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }
    }
}

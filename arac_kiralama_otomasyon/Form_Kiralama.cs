using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace arac_kiralama_otomasyon
{
    public partial class Form_Kiralama : Form
    {
        public Form_Kiralama()
        {
            InitializeComponent();
        }

        MusteriDbContext db = new MusteriDbContext();

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var list = db.Kiralamalar
            .Include(k => k.Musteri)
            .Include(k => k.Arac)
            .Include(k => k.Personel)
            .Select(k => new
            {
                KiralamaId = k.kiralama_id,
                MüşteriAdı = k.Musteri.musteri_ad,
                MüşteriSoyadı = k.Musteri.musteri_soyad,
                AraçMarka = k.Arac.arac_marka,
                AraçModel = k.Arac.arac_model,
                Plaka = k.Arac.arac_plaka,
                Personel = k.Personel.personel_ad + " " + k.Personel.personel_soyad,
                AlışTarihi = k.alis_tarihi,
                TeslimTarihi = k.teslim_tarihi,
                GünSayısı = k.gun_sayisi,
                ToplamTutar = k.toplam_tutar,
                Durum = k.kiralama_durum
            })
            .ToList();


                dataGridView1.DataSource = list;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void Form_Kiralama_Load(object sender, EventArgs e)
        {
            try
            {
                combo_musteri.DataSource = db.Musteris 
                    .OrderBy(m => m.musteri_ad)
                    .Select(m => new
                    {
                        m.musteri_id,
                        MusteriAdSoyad = m.musteri_ad + " " + m.musteri_soyad
                    })
                    .ToList();

                combo_musteri.DisplayMember = "MusteriAdSoyad";
                combo_musteri.ValueMember = "musteri_id";
                combo_arac.DataSource = db.Araclar
                    .OrderBy(a => a.arac_marka)
                    .Select(a => new
                    {
                        a.arac_id,
                        AracBilgisi = a.arac_marka + " " + a.arac_model + " - " + a.arac_plaka + " (" + a.arac_gunlukfiyat + " TL)"
                    })
                    .ToList();

                combo_arac.DisplayMember = "AracBilgisi";
                combo_arac.ValueMember = "arac_id";


                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                combo_musteri.DataSource = db.Musteris 
                    .OrderBy(m => m.musteri_ad) 
                    .Select(m => new
                    {
                        m.musteri_id, 
                        FullName = m.musteri_ad + " " + m.musteri_soyad 
                    })
                    .ToList();

                combo_musteri.DisplayMember = "FullName"; 
                combo_musteri.ValueMember = "musteri_id"; 

                combo_arac.DataSource = db.Araclar
                    .OrderBy(a => a.arac_marka) 
                    .Select(a => new
                    {
                        a.arac_id, 
                        ProductInfo = a.arac_marka + " " + a.arac_model + " - " + a.arac_gunlukfiyat + " TL (" + a.arac_durum + ")"
                    })
                    .ToList();

                combo_arac.DisplayMember = "ProductInfo"; 
                combo_arac.ValueMember = "arac_id";

                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }
    }
    
}

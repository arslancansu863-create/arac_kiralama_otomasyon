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
                
                int selectedCustomerId = (int)combo_musteri.SelectedValue;
                int selectedProductId = (int)combo_arac.SelectedValue;
                int selectedPersonelId = 1;

               
                var newRecord = new Kiralama
                {
                    musteri_id = selectedCustomerId,
                    arac_id = selectedProductId,
                    personel_id = selectedPersonelId,
                    alis_tarihi = DateTime.Now,
                    teslim_tarihi = DateTime.Now.AddDays(3),
                    gun_sayisi = 3,
                    toplam_tutar = 4500.00m, 
                    kiralama_durum = "aktif"
                };
                db.Kiralamalar.Add(newRecord);
                db.SaveChanges();

                MessageBox.Show("Kayıt başarıyla eklendi.");

                
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show(
                    "Silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    var recordToDelete = db.Kiralamalar.Find(selectedId);

                    if (recordToDelete != null)
                    {
                        db.Kiralamalar.Remove(recordToDelete);
                        db.SaveChanges();
                        MessageBox.Show("Kayıt başarıyla silindi.");
                        btn_listele.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rd_1.Checked)
                {
                    var result = db.Kiralamalar
                        .GroupBy(cp => new
                        {
                            cp.Musteri.musteri_id,
                            cp.Musteri.musteri_ad,
                            cp.Musteri.musteri_soyad

                        })

                        .Select(g => new
                        {
                            FullName = g.Key.musteri_ad + " " + g.Key.musteri_soyad,
                            TotalCount = g.Count()
                        })

                        .OrderByDescending(x => x.TotalCount)
                        .FirstOrDefault();
                    if (result != null)
                    {
                        lbl_1.Text = $"{result.FullName}{result.TotalCount}ürün almış";
                    }

                    else
                    { lbl_1.Text = "Kayıt bulunamadı."; }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void rd_2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rd_2.Checked)
                {
                    var result = db.Kiralamalar
                        .Include(cp => cp.Arac)
                        .GroupBy(cp => new
                        {
                            cp.Musteri.musteri_id,
                            cp.Musteri.musteri_ad,
                            cp.Musteri.musteri_soyad
                        })

                        .Select(g => new
                        {
                            FullName = g.Key.musteri_ad + " " + g.Key.musteri_soyad,
                            TotalPrice = g.Sum(cp => cp.Arac.arac_gunlukfiyat)
                        })

                        .OrderByDescending(x => x.TotalPrice)
                        .FirstOrDefault();

                    if (result != null)
                    {
                        lbl_2.Text = $"{result.FullName}{result.TotalPrice}TL";
                    }

                    else
                    {
                        lbl_2.Text = "Kayıt bulunamadı.";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata = {ex.Message}");
            }
        }
    }
    
}

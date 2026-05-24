using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace arac_kiralama_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MusteriDbContext db = new MusteriDbContext();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var Musteris = db.Musteris.ToList();
                dataGridView1.DataSource = Musteris;

                dataGridView1.Columns["musteri_id"].HeaderText = "MüşteriID";
                dataGridView1.Columns["musteri_ad"].HeaderText = "MüşteriAdı";
                dataGridView1.Columns["musteri_soyad"].HeaderText = "MüşteriSoyadı";
                dataGridView1.Columns["musteri_mail"].HeaderText = "Mail";
                dataGridView1.Columns["musteri_telefon"].HeaderText = "Telefon";
                dataGridView1.Columns["musteri_tc"].HeaderText = "TC";
                dataGridView1.Columns["musteri_ehliyetno"].HeaderText = "Ehliyet No";

                dataGridView1.Columns["musteri_Id"].Visible = false;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                Musteri newMusteri = new Musteri()
                {
                    musteri_ad = txt_isim.Text,
                    musteri_soyad = txt_soyad.Text,
                    musteri_telefon = txt_telefon.Text,
                    musteri_mail = txt_mail.Text,
                    musteri_tc = txt_tc.Text,
                    musteri_ehliyetno = txt_ehliyetno.Text 
                };

                db.Musteris.Add(newMusteri);
                db.SaveChanges();

                MessageBox.Show("Yeni Müşteri Eklendi!");
                btn_listele.PerformClick();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata = {ex.Message}");
            }
        }
    }
}

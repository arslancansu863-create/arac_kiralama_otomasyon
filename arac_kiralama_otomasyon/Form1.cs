using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dataGridView1.DataSource = db.Musteris.ToList();
        }
    }
}

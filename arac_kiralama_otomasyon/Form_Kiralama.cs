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
    public partial class Form_Kiralama : Form
    {
        public Form_Kiralama()
        {
            InitializeComponent();
        }

        MusteriDbContext db = new MusteriDbContext();
    }
}

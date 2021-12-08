using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goster_Click(object sender, EventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.Show(); // birden fazla kez açılabilir

        }

        private void gosterPOP_Click(object sender, EventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.ShowDialog(); //Yeni açılan ekran kapanmadan işlem yapılamaz

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult resultEnum = MessageBox.Show("Form içindeki verileri Silmek istediğinizden emin misiniz?", "Form Temizleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultEnum==DialogResult.Yes)
            {
                formTemizle();
                formElemanIndexTemizle();

            }
        }
    }
}

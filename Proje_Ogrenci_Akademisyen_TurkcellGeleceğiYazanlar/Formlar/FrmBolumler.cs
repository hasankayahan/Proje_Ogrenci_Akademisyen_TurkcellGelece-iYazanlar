using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje_Ogrenci_Akademisyen_TurkcellGeleceğiYazanlar.Entity;

namespace Proje_Ogrenci_Akademisyen_TurkcellGeleceğiYazanlar.Formlar
{
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        OgrenciSinavEntities db = new OgrenciSinavEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtBolumAd.Text == "")
            {
                errorProvider1.SetError(TxtBolumAd, "Bölüm Adı Boş Geçilemez");
            }
            else
            {
                TblBolum t = new TblBolum();
                t.BolumAd = TxtBolumAd.Text;
                db.TblBolum.Add(t);
                db.SaveChanges();
                MessageBox.Show("Bölüm Ekleme İşlemi Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

    }
}

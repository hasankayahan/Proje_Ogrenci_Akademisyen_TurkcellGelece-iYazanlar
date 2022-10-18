using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ogrenci_Akademisyen_TurkcellGeleceğiYazanlar.Formlar
{
    public partial class FrmHarita : Form
    {
        public FrmHarita()
        {
            InitializeComponent();
        }

        private void PnlDersListesi_Click(object sender, EventArgs e)
        {
            FrmDersListesi frm = new FrmDersListesi();
            frm.Show();
            
        }

        private void PnlBolumListesi_Click(object sender, EventArgs e)
        {
            FrmBolumListesi fr = new FrmBolumListesi();
            fr.Show();

        }

        private void PnlYeniBölüm_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
        }

        private void PnlNotlarFormu_Click(object sender, EventArgs e)
        {
            FrmNotlar fr = new FrmNotlar();

            fr.Show();
        }

        private void PnlOgrenciFormu_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr = new FrmOgrenci();
            fr.Show();
        }

        private void PnlOgrenciKayıt_Click(object sender, EventArgs e)
        {
            FrmOgrenciKayıt fr = new FrmOgrenciKayıt();
            fr.Show();
        }

        private void PnlYeniDers_Click(object sender, EventArgs e)
        {

            FrmYeniDers fr = new FrmYeniDers();
            fr.Show();
        }

        private void PnlYardım_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje Turkcell Geleceği Yazanlar Eğitim Kapsamında Hazırlanmıştır. Müfredatın son projesinde amacımız şu ana kadar öğrenmiş olduğumuz konuların büyük bir kısmını içeren örnek bir veri tabanlı proje uygulaması geliştirmektir. Projemize akademisyen için kullanıcı adı 0000 şifre 000 şeklindedir.Akademisyen panelinden öğrenci, ders, bölüm, sınav notları gibi işlemlerin tamamı gerçekleştirilebilir. Sisteme giriş yapan öğrenci sadece kendisine ait bilgileri ve sınav notlarını görüntüler.","Yardım Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void PnlCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proje_Ogrenci_Akademisyen_TurkcellGeleceğiYazanlar.Entity;

namespace Proje_Ogrenci_Akademisyen_TurkcellGeleceğiYazanlar.Formlar
{
    public partial class FrmOgrenciKayıt : Form
    {
        public FrmOgrenciKayıt()
        {
            InitializeComponent();
        }
        //Data Source=HASANS\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True

        SqlConnection baglanti = new SqlConnection("Data Source=HASANS\\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True");
        OgrenciSinavEntities db = new OgrenciSinavEntities();
        private void FrmOgrenciKayıt_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblBolum",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "BolumID";
            comboBox1.DisplayMember = "BolumAd";
            comboBox1.DataSource = dt;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //textBox1.Text = comboBox1.SelectedValue.ToString();
            if (TxtSifre.Text == TxtSifreTekrar.Text)
            {
                TblOgrenci t = new TblOgrenci();
                t.OgrAd = TxtAd.Text;
                t.OgrSoyad = TxtSoyad.Text;
                t.OgrNumara = TxtNumara.Text;
                t.OgrMail = TxtMail.Text;
                t.OgrResim = TxtResim.Text;
                t.OgrSifre = TxtSifre.Text;
                t.OgrBolum = int.Parse(comboBox1.SelectedValue.ToString());
                db.TblOgrenci.Add(t);
                db.SaveChanges();
                MessageBox.Show("Öğrenci Bilgileri Sisteme Başarılı Bir Şekilde Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifreler Uyumsuz. Lütfen Kontrol Ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void BtnResimSeç_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            TxtResim.Text = openFileDialog1.FileName;
        }
    }
}

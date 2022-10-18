﻿using System;
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
    public partial class FrmOgrenciPanel : Form
    {
        public FrmOgrenciPanel()

        {
            InitializeComponent();
        }
        public string numara;
        OgrenciSinavEntities db = new OgrenciSinavEntities();
        int ogrenciid;
        private void FrmOgrenciPanel_Load(object sender, EventArgs e)
        {
            TxtNumara.Text = numara;
            TxtAd.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrAd).FirstOrDefault();
            TxtSoyad.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrSoyad).FirstOrDefault();
            TxtMail.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrMail).FirstOrDefault();
            TxtSifre.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrSifre).FirstOrDefault();
            TxtBolum.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrBolum).FirstOrDefault().ToString();
            ogrenciid = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrID).FirstOrDefault();


            var sinavnotları = (from x in db.TblNotlar
                                select new
                                {
                                    x.TblDersler.DersAd,
                                    x.Sinav1,
                                    x.Sinav2,
                                    x.Sinav3,
                                    x.Quiz1,
                                    x.Quiz2,
                                    x.Proje,
                                    x.Ortalama,
                                    x.Ogrenci
                                }).Where(y => y.Ogrenci == ogrenciid).ToList();
            dataGridView1.DataSource = sinavnotları;
            dataGridView1.Columns["Ogrenci"].Visible = false;
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (TxtYeniSifre1.Text == TxtYeniSifre2.Text) 
                {
                var deger = db.TblOgrenci.Find(ogrenciid);
                deger.OgrSifre = TxtYeniSifre1.Text;
                db.SaveChanges();
                MessageBox.Show("Şifre Başarılı Bir Şekilde Gerçekleşti");
                    }
            else
            {
                MessageBox.Show("Girdğiniz yeni şifreler birbiriyle uyuşmuyor");
            }
            

        }
    }
}

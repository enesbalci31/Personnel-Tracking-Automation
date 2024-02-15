using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiberKayit
{
    public partial class guncelle : Form
    {
        SiberKayitEntities vt = new SiberKayitEntities();
        public int kullaniciid;
        public event EventHandler dataguncelleme;
        public guncelle()
        {
            InitializeComponent();
        }
        public guncelle(int id)
        {
            InitializeComponent();

            kullaniciid = id;
        }
        private void guncelle_Load(object sender, EventArgs e)
        {
            bilgiler();
        }

        public void bilgiler()
        {

            var ziyaretci = vt.siber.FirstOrDefault(p => p.id == kullaniciid);

            if (ziyaretci != null)
            {
                txt_adi.Text = ziyaretci.adi;
                txt_soyadi.Text = ziyaretci.Soyadi;
                txt_tc.Text = ziyaretci.TcNo;
            }
            else
            {
                MessageBox.Show("Seçilen Ziyaretçi Bulunamadı.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yeniad = txt_adi.Text;
            string yeniSoyad = txt_soyadi.Text;
            string tc = txt_tc.Text;

            DialogResult sonuc = MessageBox.Show("Seçili Ziyaretçiyi Güncellemek İstediğinizden Emin Misiniz?", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    islemler gunc = new islemler();
                    gunc.guncelle(kullaniciid, yeniad, yeniSoyad, tc);
                    guncelmi(EventArgs.Empty);
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        protected virtual void guncelmi(EventArgs e)
        {
            dataguncelleme?.Invoke(this, e); 
        }
    }
}

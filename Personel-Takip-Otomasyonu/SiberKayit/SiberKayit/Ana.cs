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
    public partial class Ana : Form
    {
        SiberKayitEntities vt = new SiberKayitEntities();
        private int kullaniciid;

        public Ana()
        {
            InitializeComponent();
        }

     


        private void button1_Click(object sender, EventArgs e)
        {
            string tc = txt_tc.Text;
            string adi = txt_adi.Text;
            string soyadi = txt_soyadi.Text;
            DateTime giris = DateTime.Now;



            try
            {

                if (tc.Length != 11)
                {
                    MessageBox.Show("Geçerli Bir Tc Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    islemler ekle = new islemler();
                    ekle.kayit(adi, soyadi, tc, giris);
                    temizle();
                    listele();
                }
                    
            }

            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Meydana Geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                temizle();
            }

        }

        public void temizle()
        {
            txt_adi.Text = string.Empty;
            txt_soyadi.Text = string.Empty;
            txt_tc.Text = string.Empty; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listele();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            lbl_saat.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
            lbl_tarih.Text = DateTime.Now.ToLongDateString();
            KeyPreview = true;


        }
        public void listele()
        {
            dataGridView1.DataSource = vt.siber.ToList();
            dataGridView1.Columns["id"].HeaderText = "Personel No";
            dataGridView1.Columns["tcNo"].HeaderText = "TC No";
            dataGridView1.Columns["adi"].HeaderText = "Adı";
            dataGridView1.Columns["soyadi"].HeaderText = "Soyadı";
            dataGridView1.Columns["girisTarihi"].HeaderText = "Giriş Tarihi";
            dataGridView1.Columns["cikisTarihi"].HeaderText = "Çıkış Tarihi";
            dataGridView1.Columns["tcNo"].DisplayIndex = 3;
            dataGridView1.Columns["id"].Width = 100;
            dataGridView1.Columns["tcNo"].Width = 130;
            dataGridView1.Columns["adi"].Width = 130;
            dataGridView1.Columns["soyadi"].Width = 130;
            dataGridView1.Columns["girisTarihi"].Width = 130;
            dataGridView1.Columns["cikisTarihi"].Width = 130;
        }


        private void txt_tc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (columnName == "cikisTarihi" && e.Value == null)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int secilenid = (int)row.Cells["id"].Value;
                var secilenKayit = vt.siber.FirstOrDefault(x => x.id == secilenid);
                if (secilenKayit != null)
                {
                    var sorgu = vt.siber.Where(x => x.id == secilenid && x.cikisTarihi != null).ToList();

                    if (sorgu.Count > 0)
                    {
                        MessageBox.Show("Kişi Zaten Çıkış Yapmış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {


                        secilenKayit.cikisTarihi = DateTime.Now;
                        vt.SaveChanges();
                        listele();



                    }

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            string aramaKelimesi = txt_arama.Text.ToLower();

            var filtrelenmisVeri = vt.siber.Where(x =>
                x.TcNo.ToLower().Contains(aramaKelimesi) ||
                x.adi.ToLower().Contains(aramaKelimesi) ||
                x.Soyadi.ToLower().Contains(aramaKelimesi)
            ).ToList();

            dataGridView1.DataSource = filtrelenmisVeri;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
           


        }

        private void dataguncelle(object sender, EventArgs e)
        {
            listele();

            int guncelid = ((guncelle)sender).kullaniciid;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells["id"].Value) == guncelid)
                {
                    row.Cells["adi"].Value = ((guncelle)sender).txt_adi.Text;
                    row.Cells["soyadi"].Value = ((guncelle)sender).txt_soyadi.Text;
                    row.Cells["tcNo"].Value = ((guncelle)sender).txt_tc.Text;
                    break;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
          


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.ToShortTimeString();

        }

        private void Ana_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {

                        int id = (int)row.Cells["id"].Value;
                    var secilenkayit = vt.siber.FirstOrDefault(x => x.id == id);

                    var kisi = vt.siber.Where(x => x.id == id && x.cikisTarihi == null);

                    if(kisi.Count()>0)
                    {
                        secilenkayit.cikisTarihi = DateTime.Now;
                        vt.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Kişi Zaten Çıkış Yapmış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }



                }

                    listele();
                
            }

            if(e.KeyCode==Keys.Delete)
            {
                DialogResult sonuc = MessageBox.Show("Seçilen Kayıtları Silmek İstediğinizden Emin Misiniz?", "Kayıtları Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {

                        int id = (int)row.Cells["id"].Value;


                        islemler sil = new islemler();
                        sil.sil(id);


                    }

                    listele();
                }
            }
            



        }
        

        private void Ana_KeyPress(object sender, KeyPressEventArgs e)
        {






        }

        private void txt_soyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
          
        }

        private void btn_gunc_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int secilenid = (int)row.Cells["id"].Value;
                guncelle gunc = new guncelle(secilenid);
                gunc.dataguncelleme += dataguncelle;
                gunc.Show();
            }
        }

        private void btn_silme_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                DialogResult sonuc = MessageBox.Show("seçili kaydı silmek istediğinizden emin misiniz?", "kayıt silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow row = dataGridView1.CurrentRow;
                        int secilenid = (int)row.Cells["id"].Value;
                        islemler sil = new islemler();
                        sil.sil(secilenid);
                        listele();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("bir hata meydana geldi!", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("lütfen bir satır seçiniz!", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_secilenlerikaydet_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                int id = (int)row.Cells["id"].Value;
                string adi = row.Cells["adi"].Value.ToString();
                string soyadi = row.Cells["soyadi"].Value.ToString();
                string tc = row.Cells["tcNo"].Value.ToString();
                DateTime girisTarihi = DateTime.Now;

                islemler tekrarKaydet = new islemler();
                tekrarKaydet.kayit(adi, soyadi, tc, girisTarihi);
            }

            listele();
        }

        private void btn_hepsinisil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçilen Kayıtları Silmek İstediğinizden Emin Misiniz?", "Kayıtları Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    int id = (int)row.Cells["id"].Value;


                    islemler sil = new islemler();
                    sil.sil(id);


                }

                listele();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
                this.Close();
        }

        private void btn_ekle_MouseHover(object sender, EventArgs e)
        {
            btn_ekle.BackColor = Color.LightGreen;
            btn_ekle.FlatStyle = FlatStyle.Flat;
            btn_ekle.FlatAppearance.BorderColor = Color.Green;
        }

        private void btn_ekle_MouseLeave(object sender, EventArgs e)
        {
            btn_ekle.BackColor = Color.WhiteSmoke;
            btn_ekle.FlatStyle = FlatStyle.Flat;
            btn_ekle.FlatAppearance.BorderColor = Color.WhiteSmoke;
        }

        private void btn_silme_MouseHover(object sender, EventArgs e)
        {
            btn_silme.BackColor = ColorTranslator.FromHtml("#ee2c2c");
            btn_silme.FlatStyle = FlatStyle.Flat;
            btn_silme.FlatAppearance.BorderColor = Color.Red;
        }

        private void btn_silme_MouseLeave(object sender, EventArgs e)
        {
            btn_silme.BackColor = Color.WhiteSmoke;
            btn_silme.FlatStyle = FlatStyle.Flat;
            btn_silme.FlatAppearance.BorderColor = Color.WhiteSmoke;

        }

        private void btn_gunc_MouseHover(object sender, EventArgs e)
        {
            btn_gunc.BackColor = Color.Yellow;
            btn_gunc.FlatStyle = FlatStyle.Flat;
            btn_gunc.FlatAppearance.BorderColor = Color.Yellow;
        }

        private void btn_gunc_MouseLeave(object sender, EventArgs e)
        {
            btn_gunc.BackColor = Color.WhiteSmoke;
            btn_gunc.FlatStyle = FlatStyle.Flat;
            btn_gunc.FlatAppearance.BorderColor = Color.WhiteSmoke;
        }

        private void btn_secilenlerikaydet_MouseHover(object sender, EventArgs e)
        {
            btn_secilenlerikaydet.BackColor = Color.LightGreen;
            btn_secilenlerikaydet.FlatStyle = FlatStyle.Flat;
            btn_secilenlerikaydet.FlatAppearance.BorderColor = Color.Green;
        }

        private void btn_secilenlerikaydet_MouseLeave(object sender, EventArgs e)
        {
            btn_secilenlerikaydet.BackColor = Color.WhiteSmoke;
            btn_secilenlerikaydet.FlatStyle = FlatStyle.Flat;
            btn_secilenlerikaydet.FlatAppearance.BorderColor = Color.WhiteSmoke;
        }

        private void btn_hepsinisil_MouseHover(object sender, EventArgs e)
        {
            btn_hepsinisil.BackColor = ColorTranslator.FromHtml("#ee2c2c");
            btn_hepsinisil.FlatStyle = FlatStyle.Flat;
            btn_hepsinisil.FlatAppearance.BorderColor = Color.Red;
        }

        private void btn_hepsinisil_MouseLeave(object sender, EventArgs e)
        {
            btn_hepsinisil.BackColor = Color.WhiteSmoke;
            btn_hepsinisil.FlatStyle = FlatStyle.Flat;
            btn_hepsinisil.FlatAppearance.BorderColor = Color.WhiteSmoke;
        }
    }
    
 }

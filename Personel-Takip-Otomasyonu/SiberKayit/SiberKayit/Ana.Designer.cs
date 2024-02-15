
namespace SiberKayit
{
    partial class Ana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana));
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_adi = new System.Windows.Forms.Label();
            this.lbl_soyadi = new System.Windows.Forms.Label();
            this.btn_gunc = new System.Windows.Forms.Button();
            this.btn_silme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_secilenlerikaydet = new System.Windows.Forms.Button();
            this.btn_hepsinisil = new System.Windows.Forms.Button();
            this.baslik = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager1 = new SiberKayit.SiberKayitDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tc.Location = new System.Drawing.Point(74, 286);
            this.txt_tc.MaxLength = 11;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(311, 30);
            this.txt_tc.TabIndex = 0;
            this.txt_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tc_KeyPress);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ekle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_ekle.Image = global::SiberKayit.Properties.Resources.kaydet2;
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ekle.Location = new System.Drawing.Point(39, 545);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(145, 56);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Kaydet";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.button1_Click);
            this.btn_ekle.MouseLeave += new System.EventHandler(this.btn_ekle_MouseLeave);
            this.btn_ekle.MouseHover += new System.EventHandler(this.btn_ekle_MouseHover);
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyadi.Location = new System.Drawing.Point(72, 459);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(313, 30);
            this.txt_soyadi.TabIndex = 5;
            this.txt_soyadi.TextChanged += new System.EventHandler(this.txt_soyadi_TextChanged);
            // 
            // txt_adi
            // 
            this.txt_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adi.Location = new System.Drawing.Point(72, 367);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(313, 30);
            this.txt_adi.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(605, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 746);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick_1);
            // 
            // txt_arama
            // 
            this.txt_arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_arama.Location = new System.Drawing.Point(858, 168);
            this.txt_arama.MaxLength = 11;
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(479, 30);
            this.txt_arama.TabIndex = 12;
            this.txt_arama.TextChanged += new System.EventHandler(this.txt_arama_TextChanged);
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_tarih.Location = new System.Drawing.Point(34, 52);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(79, 29);
            this.lbl_tarih.TabIndex = 15;
            this.lbl_tarih.Text = "label6";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_saat.Location = new System.Drawing.Point(34, 9);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(79, 29);
            this.lbl_saat.TabIndex = 19;
            this.lbl_saat.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tc.ForeColor = System.Drawing.Color.White;
            this.lbl_tc.Location = new System.Drawing.Point(69, 238);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(91, 29);
            this.lbl_tc.TabIndex = 2;
            this.lbl_tc.Text = "Tc No:";
            // 
            // lbl_adi
            // 
            this.lbl_adi.AutoSize = true;
            this.lbl_adi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adi.ForeColor = System.Drawing.Color.White;
            this.lbl_adi.Location = new System.Drawing.Point(67, 324);
            this.lbl_adi.Name = "lbl_adi";
            this.lbl_adi.Size = new System.Drawing.Size(51, 29);
            this.lbl_adi.TabIndex = 7;
            this.lbl_adi.Text = "Ad:";
            // 
            // lbl_soyadi
            // 
            this.lbl_soyadi.AutoSize = true;
            this.lbl_soyadi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyadi.ForeColor = System.Drawing.Color.White;
            this.lbl_soyadi.Location = new System.Drawing.Point(69, 407);
            this.lbl_soyadi.Name = "lbl_soyadi";
            this.lbl_soyadi.Size = new System.Drawing.Size(93, 29);
            this.lbl_soyadi.TabIndex = 8;
            this.lbl_soyadi.Text = "Soyad:";
            // 
            // btn_gunc
            // 
            this.btn_gunc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_gunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_gunc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gunc.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_gunc.Image = global::SiberKayit.Properties.Resources.gunc2;
            this.btn_gunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gunc.Location = new System.Drawing.Point(387, 545);
            this.btn_gunc.Name = "btn_gunc";
            this.btn_gunc.Size = new System.Drawing.Size(155, 56);
            this.btn_gunc.TabIndex = 21;
            this.btn_gunc.Text = "Güncelle";
            this.btn_gunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gunc.UseVisualStyleBackColor = false;
            this.btn_gunc.Click += new System.EventHandler(this.btn_gunc_Click);
            this.btn_gunc.MouseLeave += new System.EventHandler(this.btn_gunc_MouseLeave);
            this.btn_gunc.MouseHover += new System.EventHandler(this.btn_gunc_MouseHover);
            // 
            // btn_silme
            // 
            this.btn_silme.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_silme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_silme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_silme.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_silme.Image = global::SiberKayit.Properties.Resources.silme2;
            this.btn_silme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_silme.Location = new System.Drawing.Point(215, 545);
            this.btn_silme.Name = "btn_silme";
            this.btn_silme.Size = new System.Drawing.Size(145, 56);
            this.btn_silme.TabIndex = 22;
            this.btn_silme.Text = "Sil";
            this.btn_silme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_silme.UseVisualStyleBackColor = false;
            this.btn_silme.Click += new System.EventHandler(this.btn_silme_Click);
            this.btn_silme.MouseLeave += new System.EventHandler(this.btn_silme_MouseLeave);
            this.btn_silme.MouseHover += new System.EventHandler(this.btn_silme_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SiberKayit.Properties.Resources.arama2;
            this.pictureBox1.Location = new System.Drawing.Point(798, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 63);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SiberKayit.Properties.Resources.Picsart_24_02_14_13_54_31_917;
            this.pictureBox2.Location = new System.Drawing.Point(-36, 633);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(521, 500);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // btn_secilenlerikaydet
            // 
            this.btn_secilenlerikaydet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_secilenlerikaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_secilenlerikaydet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_secilenlerikaydet.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_secilenlerikaydet.Image = global::SiberKayit.Properties.Resources.hepsinikaydet1;
            this.btn_secilenlerikaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_secilenlerikaydet.Location = new System.Drawing.Point(39, 626);
            this.btn_secilenlerikaydet.Name = "btn_secilenlerikaydet";
            this.btn_secilenlerikaydet.Size = new System.Drawing.Size(238, 67);
            this.btn_secilenlerikaydet.TabIndex = 25;
            this.btn_secilenlerikaydet.Text = "Seçilenleri Kaydet";
            this.btn_secilenlerikaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_secilenlerikaydet.UseVisualStyleBackColor = false;
            this.btn_secilenlerikaydet.Click += new System.EventHandler(this.btn_secilenlerikaydet_Click);
            this.btn_secilenlerikaydet.MouseLeave += new System.EventHandler(this.btn_secilenlerikaydet_MouseLeave);
            this.btn_secilenlerikaydet.MouseHover += new System.EventHandler(this.btn_secilenlerikaydet_MouseHover);
            // 
            // btn_hepsinisil
            // 
            this.btn_hepsinisil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_hepsinisil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_hepsinisil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hepsinisil.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_hepsinisil.Image = global::SiberKayit.Properties.Resources.Waste1;
            this.btn_hepsinisil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hepsinisil.Location = new System.Drawing.Point(304, 626);
            this.btn_hepsinisil.Name = "btn_hepsinisil";
            this.btn_hepsinisil.Size = new System.Drawing.Size(238, 67);
            this.btn_hepsinisil.TabIndex = 26;
            this.btn_hepsinisil.Text = "Seçilenleri Sil";
            this.btn_hepsinisil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hepsinisil.UseVisualStyleBackColor = false;
            this.btn_hepsinisil.Click += new System.EventHandler(this.btn_hepsinisil_Click);
            this.btn_hepsinisil.MouseLeave += new System.EventHandler(this.btn_hepsinisil_MouseLeave);
            this.btn_hepsinisil.MouseHover += new System.EventHandler(this.btn_hepsinisil_MouseHover);
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.BackColor = System.Drawing.Color.Transparent;
            this.baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.ForeColor = System.Drawing.Color.White;
            this.baslik.Location = new System.Drawing.Point(657, 68);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(921, 38);
            this.baslik.TabIndex = 27;
            this.baslik.Text = "Siber Isparta Gençlik Merkezi Personel Takip Otomasyonu";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SiberKayit.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(1902, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.siberTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = SiberKayit.SiberKayitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1942, 1081);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.btn_hepsinisil);
            this.Controls.Add(this.btn_secilenlerikaydet);
            this.Controls.Add(this.btn_silme);
            this.Controls.Add(this.btn_gunc);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.txt_arama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_soyadi);
            this.Controls.Add(this.lbl_adi);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ana";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ana_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ana_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_adi;
        private System.Windows.Forms.Label lbl_soyadi;
        private System.Windows.Forms.Button btn_gunc;
        private System.Windows.Forms.Button btn_silme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_secilenlerikaydet;
        private System.Windows.Forms.Button btn_hepsinisil;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.PictureBox pictureBox3;
        private SiberKayitDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}


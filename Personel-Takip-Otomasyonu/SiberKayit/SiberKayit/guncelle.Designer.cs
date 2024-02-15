
namespace SiberKayit
{
    partial class guncelle
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
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(322, 26);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(240, 22);
            this.txt_tc.TabIndex = 0;
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(322, 81);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(240, 22);
            this.txt_adi.TabIndex = 1;
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(322, 138);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(240, 22);
            this.txt_soyadi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "TcNo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyadı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.txt_tc);
            this.Name = "guncelle";
            this.Text = "guncelle";
            this.Load += new System.EventHandler(this.guncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_tc;
        public System.Windows.Forms.TextBox txt_adi;
        public System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
namespace GecmeKalmaUygulamasi
{
    partial class Form1
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
            this.lblDersSayisi = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.txtDersSayisi = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.pboxMutsuz = new System.Windows.Forms.PictureBox();
            this.pboxNormal = new System.Windows.Forms.PictureBox();
            this.pboxMutlu = new System.Windows.Forms.PictureBox();
            this.pboxCokMutlu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMutsuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMutlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCokMutlu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDersSayisi
            // 
            this.lblDersSayisi.AutoSize = true;
            this.lblDersSayisi.Location = new System.Drawing.Point(71, 41);
            this.lblDersSayisi.Name = "lblDersSayisi";
            this.lblDersSayisi.Size = new System.Drawing.Size(103, 13);
            this.lblDersSayisi.TabIndex = 0;
            this.lblDersSayisi.Text = "Başarısız Ders Sayısı";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(48, 74);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(126, 13);
            this.lblOrtalama.TabIndex = 1;
            this.lblOrtalama.Text = "Derslerin Ortalama Puanı:";
            // 
            // txtDersSayisi
            // 
            this.txtDersSayisi.Location = new System.Drawing.Point(212, 42);
            this.txtDersSayisi.Name = "txtDersSayisi";
            this.txtDersSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtDersSayisi.TabIndex = 2;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(212, 74);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 3;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(159, 129);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(61, 13);
            this.lblDurum.TabIndex = 4;
            this.lblDurum.Text = "_________";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(330, 41);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(111, 48);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // pboxMutsuz
            // 
            this.pboxMutsuz.Image = global::GecmeKalmaUygulamasi.Properties.Resources._004_sad;
            this.pboxMutsuz.Location = new System.Drawing.Point(360, 165);
            this.pboxMutsuz.Name = "pboxMutsuz";
            this.pboxMutsuz.Size = new System.Drawing.Size(97, 89);
            this.pboxMutsuz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMutsuz.TabIndex = 9;
            this.pboxMutsuz.TabStop = false;
            this.pboxMutsuz.Visible = false;
            // 
            // pboxNormal
            // 
            this.pboxNormal.Image = global::GecmeKalmaUygulamasi.Properties.Resources._001_confused;
            this.pboxNormal.Location = new System.Drawing.Point(257, 165);
            this.pboxNormal.Name = "pboxNormal";
            this.pboxNormal.Size = new System.Drawing.Size(97, 89);
            this.pboxNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxNormal.TabIndex = 8;
            this.pboxNormal.TabStop = false;
            this.pboxNormal.Visible = false;
            // 
            // pboxMutlu
            // 
            this.pboxMutlu.Image = global::GecmeKalmaUygulamasi.Properties.Resources._003_smile;
            this.pboxMutlu.Location = new System.Drawing.Point(154, 165);
            this.pboxMutlu.Name = "pboxMutlu";
            this.pboxMutlu.Size = new System.Drawing.Size(97, 89);
            this.pboxMutlu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMutlu.TabIndex = 7;
            this.pboxMutlu.TabStop = false;
            this.pboxMutlu.Visible = false;
            // 
            // pboxCokMutlu
            // 
            this.pboxCokMutlu.Image = global::GecmeKalmaUygulamasi.Properties.Resources._002_excited;
            this.pboxCokMutlu.Location = new System.Drawing.Point(51, 165);
            this.pboxCokMutlu.Name = "pboxCokMutlu";
            this.pboxCokMutlu.Size = new System.Drawing.Size(97, 89);
            this.pboxCokMutlu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCokMutlu.TabIndex = 6;
            this.pboxCokMutlu.TabStop = false;
            this.pboxCokMutlu.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 381);
            this.Controls.Add(this.pboxMutsuz);
            this.Controls.Add(this.pboxNormal);
            this.Controls.Add(this.pboxMutlu);
            this.Controls.Add(this.pboxCokMutlu);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.txtDersSayisi);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblDersSayisi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxMutsuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMutlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCokMutlu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDersSayisi;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.TextBox txtDersSayisi;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.PictureBox pboxCokMutlu;
        private System.Windows.Forms.PictureBox pboxMutlu;
        private System.Windows.Forms.PictureBox pboxNormal;
        private System.Windows.Forms.PictureBox pboxMutsuz;
    }
}


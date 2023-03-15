namespace SifreUretme
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
            this.chkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chkKucukHarf = new System.Windows.Forms.CheckBox();
            this.chkRakam = new System.Windows.Forms.CheckBox();
            this.chkOzelKarakter = new System.Windows.Forms.CheckBox();
            this.nuSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.nuSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.btnSifreUret = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbsifre = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nuSifreSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSifreUzunlugu)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBuyukHarf
            // 
            this.chkBuyukHarf.AutoSize = true;
            this.chkBuyukHarf.Location = new System.Drawing.Point(40, 12);
            this.chkBuyukHarf.Name = "chkBuyukHarf";
            this.chkBuyukHarf.Size = new System.Drawing.Size(79, 17);
            this.chkBuyukHarf.TabIndex = 0;
            this.chkBuyukHarf.Text = "Büyük Harf";
            this.chkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkKucukHarf
            // 
            this.chkKucukHarf.AutoSize = true;
            this.chkKucukHarf.Location = new System.Drawing.Point(40, 47);
            this.chkKucukHarf.Name = "chkKucukHarf";
            this.chkKucukHarf.Size = new System.Drawing.Size(80, 17);
            this.chkKucukHarf.TabIndex = 1;
            this.chkKucukHarf.Text = "Küçük Harf";
            this.chkKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chkRakam
            // 
            this.chkRakam.AutoSize = true;
            this.chkRakam.Location = new System.Drawing.Point(161, 12);
            this.chkRakam.Name = "chkRakam";
            this.chkRakam.Size = new System.Drawing.Size(60, 17);
            this.chkRakam.TabIndex = 2;
            this.chkRakam.Text = "Rakam";
            this.chkRakam.UseVisualStyleBackColor = true;
            // 
            // chkOzelKarakter
            // 
            this.chkOzelKarakter.AutoSize = true;
            this.chkOzelKarakter.Location = new System.Drawing.Point(161, 47);
            this.chkOzelKarakter.Name = "chkOzelKarakter";
            this.chkOzelKarakter.Size = new System.Drawing.Size(90, 17);
            this.chkOzelKarakter.TabIndex = 3;
            this.chkOzelKarakter.Text = "Özel Karakter";
            this.chkOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // nuSifreSayisi
            // 
            this.nuSifreSayisi.Location = new System.Drawing.Point(161, 81);
            this.nuSifreSayisi.Name = "nuSifreSayisi";
            this.nuSifreSayisi.Size = new System.Drawing.Size(120, 20);
            this.nuSifreSayisi.TabIndex = 4;
            // 
            // nuSifreUzunlugu
            // 
            this.nuSifreUzunlugu.Location = new System.Drawing.Point(161, 122);
            this.nuSifreUzunlugu.Name = "nuSifreUzunlugu";
            this.nuSifreUzunlugu.Size = new System.Drawing.Size(120, 20);
            this.nuSifreUzunlugu.TabIndex = 5;
            // 
            // btnSifreUret
            // 
            this.btnSifreUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreUret.Location = new System.Drawing.Point(22, 182);
            this.btnSifreUret.Name = "btnSifreUret";
            this.btnSifreUret.Size = new System.Drawing.Size(259, 36);
            this.btnSifreUret.TabIndex = 6;
            this.btnSifreUret.Text = "Şifre Üret";
            this.btnSifreUret.UseVisualStyleBackColor = true;
            this.btnSifreUret.Click += new System.EventHandler(this.btnSifreUret_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şifre Sayisi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre Uzunluğu:";
            // 
            // lbsifre
            // 
            this.lbsifre.FormattingEnabled = true;
            this.lbsifre.Location = new System.Drawing.Point(26, 237);
            this.lbsifre.Name = "lbsifre";
            this.lbsifre.Size = new System.Drawing.Size(255, 160);
            this.lbsifre.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 429);
            this.Controls.Add(this.lbsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSifreUret);
            this.Controls.Add(this.nuSifreUzunlugu);
            this.Controls.Add(this.nuSifreSayisi);
            this.Controls.Add(this.chkOzelKarakter);
            this.Controls.Add(this.chkRakam);
            this.Controls.Add(this.chkKucukHarf);
            this.Controls.Add(this.chkBuyukHarf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nuSifreSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSifreUzunlugu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBuyukHarf;
        private System.Windows.Forms.CheckBox chkKucukHarf;
        private System.Windows.Forms.CheckBox chkRakam;
        private System.Windows.Forms.CheckBox chkOzelKarakter;
        private System.Windows.Forms.NumericUpDown nuSifreSayisi;
        private System.Windows.Forms.NumericUpDown nuSifreUzunlugu;
        private System.Windows.Forms.Button btnSifreUret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbsifre;
    }
}


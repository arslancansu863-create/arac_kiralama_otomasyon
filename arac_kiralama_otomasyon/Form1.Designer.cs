namespace arac_kiralama_otomasyon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_ehliyetno = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.lbl_ehliyetno = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.grp_formlaragecis = new System.Windows.Forms.GroupBox();
            this.btn_form_krl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp_formlaragecis.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(556, 218);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(713, 218);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_güncelle.TabIndex = 2;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(565, 272);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(75, 23);
            this.btn_listele.TabIndex = 3;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(708, 272);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_isim);
            this.groupBox1.Controls.Add(this.txt_ehliyetno);
            this.groupBox1.Controls.Add(this.txt_tc);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.txt_telefon);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.lbl_ehliyetno);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.lbl_mail);
            this.groupBox1.Controls.Add(this.lbl_telefon);
            this.groupBox1.Controls.Add(this.lbl_soyad);
            this.groupBox1.Controls.Add(this.lbl_isim);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 283);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(243, 28);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(211, 20);
            this.txt_isim.TabIndex = 12;
            // 
            // txt_ehliyetno
            // 
            this.txt_ehliyetno.Location = new System.Drawing.Point(243, 196);
            this.txt_ehliyetno.Name = "txt_ehliyetno";
            this.txt_ehliyetno.Size = new System.Drawing.Size(211, 20);
            this.txt_ehliyetno.TabIndex = 11;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(243, 164);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(211, 20);
            this.txt_tc.TabIndex = 10;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(243, 130);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(211, 20);
            this.txt_mail.TabIndex = 9;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(243, 98);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(211, 20);
            this.txt_telefon.TabIndex = 8;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(243, 68);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(211, 20);
            this.txt_soyad.TabIndex = 7;
            // 
            // lbl_ehliyetno
            // 
            this.lbl_ehliyetno.AutoSize = true;
            this.lbl_ehliyetno.Location = new System.Drawing.Point(6, 204);
            this.lbl_ehliyetno.Name = "lbl_ehliyetno";
            this.lbl_ehliyetno.Size = new System.Drawing.Size(74, 13);
            this.lbl_ehliyetno.TabIndex = 5;
            this.lbl_ehliyetno.Text = "EHLİYET NO:";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(9, 172);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(24, 13);
            this.lbl_tc.TabIndex = 4;
            this.lbl_tc.Text = "TC:";
            this.lbl_tc.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(6, 137);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(35, 13);
            this.lbl_mail.TabIndex = 3;
            this.lbl_mail.Text = "MAİL:";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(6, 101);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(59, 13);
            this.lbl_telefon.TabIndex = 2;
            this.lbl_telefon.Text = "TELEFON:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(6, 71);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(47, 13);
            this.lbl_soyad.TabIndex = 1;
            this.lbl_soyad.Text = "SOYAD:";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(6, 36);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(25, 13);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "AD:";
            // 
            // grp_formlaragecis
            // 
            this.grp_formlaragecis.Controls.Add(this.btn_form_krl);
            this.grp_formlaragecis.Location = new System.Drawing.Point(565, 333);
            this.grp_formlaragecis.Name = "grp_formlaragecis";
            this.grp_formlaragecis.Size = new System.Drawing.Size(200, 100);
            this.grp_formlaragecis.TabIndex = 6;
            this.grp_formlaragecis.TabStop = false;
            this.grp_formlaragecis.Text = "FORMLARA GEÇİŞ";
            // 
            // btn_form_krl
            // 
            this.btn_form_krl.Location = new System.Drawing.Point(37, 35);
            this.btn_form_krl.Name = "btn_form_krl";
            this.btn_form_krl.Size = new System.Drawing.Size(140, 23);
            this.btn_form_krl.TabIndex = 0;
            this.btn_form_krl.Text = "FORM KİRALAMA";
            this.btn_form_krl.UseVisualStyleBackColor = true;
            this.btn_form_krl.Click += new System.EventHandler(this.btn_form_krl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.grp_formlaragecis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_formlaragecis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ehliyetno;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label lbl_ehliyetno;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.GroupBox grp_formlaragecis;
        private System.Windows.Forms.Button btn_form_krl;
    }
}


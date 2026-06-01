namespace arac_kiralama_otomasyon
{
    partial class Form_Kiralama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_arac = new System.Windows.Forms.ComboBox();
            this.combo_musteri = new System.Windows.Forms.ComboBox();
            this.lbl_arac = new System.Windows.Forms.Label();
            this.lbl_musteri = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_form_kiralama = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_arac);
            this.groupBox1.Controls.Add(this.combo_musteri);
            this.groupBox1.Controls.Add(this.lbl_arac);
            this.groupBox1.Controls.Add(this.lbl_musteri);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // combo_arac
            // 
            this.combo_arac.FormattingEnabled = true;
            this.combo_arac.Location = new System.Drawing.Point(156, 88);
            this.combo_arac.Name = "combo_arac";
            this.combo_arac.Size = new System.Drawing.Size(121, 21);
            this.combo_arac.TabIndex = 4;
            // 
            // combo_musteri
            // 
            this.combo_musteri.FormattingEnabled = true;
            this.combo_musteri.Location = new System.Drawing.Point(156, 48);
            this.combo_musteri.Name = "combo_musteri";
            this.combo_musteri.Size = new System.Drawing.Size(121, 21);
            this.combo_musteri.TabIndex = 3;
            // 
            // lbl_arac
            // 
            this.lbl_arac.AutoSize = true;
            this.lbl_arac.Location = new System.Drawing.Point(27, 88);
            this.lbl_arac.Name = "lbl_arac";
            this.lbl_arac.Size = new System.Drawing.Size(39, 13);
            this.lbl_arac.TabIndex = 2;
            this.lbl_arac.Text = "ARAÇ:";
            // 
            // lbl_musteri
            // 
            this.lbl_musteri.AutoSize = true;
            this.lbl_musteri.Location = new System.Drawing.Point(27, 48);
            this.lbl_musteri.Name = "lbl_musteri";
            this.lbl_musteri.Size = new System.Drawing.Size(59, 13);
            this.lbl_musteri.TabIndex = 1;
            this.lbl_musteri.Text = "MÜŞTERİ:";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(202, 143);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(128, 175);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(75, 23);
            this.btn_listele.TabIndex = 2;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(324, 174);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_form_kiralama
            // 
            this.btn_form_kiralama.Location = new System.Drawing.Point(607, 175);
            this.btn_form_kiralama.Name = "btn_form_kiralama";
            this.btn_form_kiralama.Size = new System.Drawing.Size(75, 23);
            this.btn_form_kiralama.TabIndex = 4;
            this.btn_form_kiralama.Text = "ANA FORM ";
            this.btn_form_kiralama.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_2);
            this.groupBox2.Controls.Add(this.lbl_1);
            this.groupBox2.Controls.Add(this.rd_2);
            this.groupBox2.Controls.Add(this.rd_1);
            this.groupBox2.Location = new System.Drawing.Point(454, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 178);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İSTATİSTİKLER";
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Location = new System.Drawing.Point(23, 42);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(85, 17);
            this.rd_1.TabIndex = 0;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "radioButton1";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Location = new System.Drawing.Point(23, 93);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(85, 17);
            this.rd_2.TabIndex = 1;
            this.rd_2.TabStop = true;
            this.rd_2.Text = "radioButton2";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_2_CheckedChanged);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(172, 46);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(35, 13);
            this.lbl_1.TabIndex = 2;
            this.lbl_1.Text = "label1";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(175, 104);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(35, 13);
            this.lbl_2.TabIndex = 3;
            this.lbl_2.Text = "label2";
            // 
            // Form_Kiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_form_kiralama);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Kiralama";
            this.Text = "Form_Kiralama";
            this.Load += new System.EventHandler(this.Form_Kiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_form_kiralama;
        private System.Windows.Forms.ComboBox combo_arac;
        private System.Windows.Forms.ComboBox combo_musteri;
        private System.Windows.Forms.Label lbl_arac;
        private System.Windows.Forms.Label lbl_musteri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.RadioButton rd_2;
        private System.Windows.Forms.RadioButton rd_1;
    }
}
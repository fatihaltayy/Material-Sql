namespace WindowsFormsApp1
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
            this.MalzemeKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MalzemeAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YıllıkSatıs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TedSure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTsure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMstok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBfiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYsatıs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMkodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MalzemeKodu,
            this.MalzemeAdı,
            this.YıllıkSatıs,
            this.BirimFiyat,
            this.MinStok,
            this.TedSure});
            this.dataGridView1.Location = new System.Drawing.Point(12, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(873, 186);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MalzemeKodu
            // 
            this.MalzemeKodu.HeaderText = "M.Kodu";
            this.MalzemeKodu.Name = "MalzemeKodu";
            this.MalzemeKodu.Width = 125;
            // 
            // MalzemeAdı
            // 
            this.MalzemeAdı.HeaderText = "M.Adı";
            this.MalzemeAdı.Name = "MalzemeAdı";
            this.MalzemeAdı.Width = 150;
            // 
            // YıllıkSatıs
            // 
            this.YıllıkSatıs.HeaderText = "Yıllık Satıs";
            this.YıllıkSatıs.Name = "YıllıkSatıs";
            this.YıllıkSatıs.Width = 150;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.HeaderText = "B.Fıyat";
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.Width = 150;
            // 
            // MinStok
            // 
            this.MinStok.HeaderText = "MinStok";
            this.MinStok.Name = "MinStok";
            // 
            // TedSure
            // 
            this.TedSure.HeaderText = "T.Süre";
            this.TedSure.Name = "TedSure";
            this.TedSure.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTsure);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMstok);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBfiyat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtYsatıs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMadı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMkodu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Bilgileri";
            // 
            // txtTsure
            // 
            this.txtTsure.Location = new System.Drawing.Point(455, 157);
            this.txtTsure.Name = "txtTsure";
            this.txtTsure.Size = new System.Drawing.Size(100, 20);
            this.txtTsure.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(339, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tedarik Süresi";
            // 
            // txtMstok
            // 
            this.txtMstok.Location = new System.Drawing.Point(455, 110);
            this.txtMstok.Name = "txtMstok";
            this.txtMstok.Size = new System.Drawing.Size(100, 20);
            this.txtMstok.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(378, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Min Stok";
            // 
            // txtBfiyat
            // 
            this.txtBfiyat.Location = new System.Drawing.Point(455, 63);
            this.txtBfiyat.Name = "txtBfiyat";
            this.txtBfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtBfiyat.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(367, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Birim Fiyat";
            // 
            // txtYsatıs
            // 
            this.txtYsatıs.Location = new System.Drawing.Point(168, 155);
            this.txtYsatıs.Name = "txtYsatıs";
            this.txtYsatıs.Size = new System.Drawing.Size(100, 20);
            this.txtYsatıs.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yıllık Satış";
            // 
            // txtMadı
            // 
            this.txtMadı.Location = new System.Drawing.Point(168, 108);
            this.txtMadı.Name = "txtMadı";
            this.txtMadı.Size = new System.Drawing.Size(100, 20);
            this.txtMadı.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Malzeme Adı";
            // 
            // txtMkodu
            // 
            this.txtMkodu.Location = new System.Drawing.Point(168, 61);
            this.txtMkodu.Name = "txtMkodu";
            this.txtMkodu.Size = new System.Drawing.Size(100, 20);
            this.txtMkodu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Kodu";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(625, 19);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(260, 40);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(625, 66);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(260, 43);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(625, 116);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(260, 43);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(625, 166);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(260, 43);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 226);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(311, 20);
            this.textBox7.TabIndex = 12;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTsure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMstok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBfiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYsatıs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMkodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MalzemeKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MalzemeAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn YıllıkSatıs;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedSure;
    }
}


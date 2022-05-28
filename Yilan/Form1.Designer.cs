namespace Yilan
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bocek = new System.Windows.Forms.PictureBox();
            this.pnloyun = new System.Windows.Forms.Panel();
            this.timerYilanHareketi = new System.Windows.Forms.Timer(this.components);
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bocek)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bocek);
            this.panel1.Controls.Add(this.pnloyun);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 540);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSure);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblPuan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 138);
            this.panel2.TabIndex = 6;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.Color.Tan;
            this.lblSure.Location = new System.Drawing.Point(866, 52);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(18, 19);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Tan;
            this.label5.Location = new System.Drawing.Point(800, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Süre : ";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.Color.Tan;
            this.lblPuan.Location = new System.Drawing.Point(109, 52);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(18, 19);
            this.lblPuan.TabIndex = 3;
            this.lblPuan.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(43, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puan : ";
            // 
            // bocek
            // 
            this.bocek.BackColor = System.Drawing.Color.ForestGreen;
            this.bocek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bocek.Image = global::Yilan.Properties.Resources.bocek1;
            this.bocek.Location = new System.Drawing.Point(600, 550);
            this.bocek.Name = "bocek";
            this.bocek.Size = new System.Drawing.Size(100, 50);
            this.bocek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bocek.TabIndex = 0;
            this.bocek.TabStop = false;
            // 
            // pnloyun
            // 
            this.pnloyun.BackgroundImage = global::Yilan.Properties.Resources.pnloyunback;
            this.pnloyun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnloyun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnloyun.Location = new System.Drawing.Point(12, 147);
            this.pnloyun.Name = "pnloyun";
            this.pnloyun.Size = new System.Drawing.Size(900, 380);
            this.pnloyun.TabIndex = 1;
            // 
            // timerYilanHareketi
            // 
            this.timerYilanHareketi.Tick += new System.EventHandler(this.timerYilanHareketi_Tick);
            // 
            // timerSaat
            // 
            this.timerSaat.Interval = 1000;
            this.timerSaat.Tick += new System.EventHandler(this.saat_Tick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Yilan.Properties.Resources.anasayfa;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_cikis);
            this.panel3.Controls.Add(this.btn_baslat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 540);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(433, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "prodbyEhre";
            // 
            // btn_cikis
            // 
            this.btn_cikis.AutoSize = true;
            this.btn_cikis.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cikis.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.PeachPuff;
            this.btn_cikis.Location = new System.Drawing.Point(734, 152);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(123, 64);
            this.btn_cikis.TabIndex = 1;
            this.btn_cikis.Text = "KAÇ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_baslat
            // 
            this.btn_baslat.AutoSize = true;
            this.btn_baslat.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_baslat.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_baslat.ForeColor = System.Drawing.Color.PaleGreen;
            this.btn_baslat.Location = new System.Drawing.Point(734, 77);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(123, 64);
            this.btn_baslat.TabIndex = 0;
            this.btn_baslat.Text = "BAŞLAT";
            this.btn_baslat.UseVisualStyleBackColor = false;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(933, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Yılannn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bocek)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnloyun;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timerYilanHareketi;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bocek;
    }
}


namespace otoparkÖdevi
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlist = new System.Windows.Forms.Button();
            this.lblBodrum = new System.Windows.Forms.Label();
            this.lbl1_kat = new System.Windows.Forms.Label();
            this.lbl2_kat = new System.Windows.Forms.Label();
            this.btnTcikar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(32, 59);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(117, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "aracları ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(242, 36);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(125, 23);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "arac cıkar";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(32, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 292);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(242, 185);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(199, 292);
            this.listBox2.TabIndex = 3;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(447, 185);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(199, 292);
            this.listBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "bodrum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "1.kat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "2.kat";
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(448, 59);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(125, 23);
            this.btnlist.TabIndex = 8;
            this.btnlist.Text = "Listele";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // lblBodrum
            // 
            this.lblBodrum.AutoSize = true;
            this.lblBodrum.Location = new System.Drawing.Point(29, 491);
            this.lblBodrum.Name = "lblBodrum";
            this.lblBodrum.Size = new System.Drawing.Size(0, 17);
            this.lblBodrum.TabIndex = 9;
            // 
            // lbl1_kat
            // 
            this.lbl1_kat.AutoSize = true;
            this.lbl1_kat.Location = new System.Drawing.Point(239, 491);
            this.lbl1_kat.Name = "lbl1_kat";
            this.lbl1_kat.Size = new System.Drawing.Size(0, 17);
            this.lbl1_kat.TabIndex = 10;
            // 
            // lbl2_kat
            // 
            this.lbl2_kat.AutoSize = true;
            this.lbl2_kat.Location = new System.Drawing.Point(444, 491);
            this.lbl2_kat.Name = "lbl2_kat";
            this.lbl2_kat.Size = new System.Drawing.Size(0, 17);
            this.lbl2_kat.TabIndex = 11;
            // 
            // btnTcikar
            // 
            this.btnTcikar.Location = new System.Drawing.Point(242, 78);
            this.btnTcikar.Name = "btnTcikar";
            this.btnTcikar.Size = new System.Drawing.Size(125, 23);
            this.btnTcikar.TabIndex = 12;
            this.btnTcikar.Text = "toplu arac cıkar";
            this.btnTcikar.UseVisualStyleBackColor = true;
            this.btnTcikar.Click += new System.EventHandler(this.btnTcikar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 560);
            this.Controls.Add(this.btnTcikar);
            this.Controls.Add(this.lbl2_kat);
            this.Controls.Add(this.lbl1_kat);
            this.Controls.Add(this.lblBodrum);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "CTF Otopark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Label lblBodrum;
        private System.Windows.Forms.Label lbl1_kat;
        private System.Windows.Forms.Label lbl2_kat;
        private System.Windows.Forms.Button btnTcikar;
    }
}


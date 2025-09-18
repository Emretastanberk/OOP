namespace musterikayit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAd = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            btnEkle = new Button();
            btnListele = new Button();
            dgvListele = new DataGridView();
            lblDurum = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListele).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAd.Location = new Point(46, 64);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(44, 26);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label2.Location = new Point(46, 125);
            label2.Name = "label2";
            label2.Size = new Size(80, 26);
            label2.TabIndex = 1;
            label2.Text = "Soyad: ";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(142, 63);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(142, 126);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(65, 222);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(120, 55);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "MÜŞTERİ EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(243, 221);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(119, 58);
            btnListele.TabIndex = 5;
            btnListele.TabStop = false;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // dgvListele
            // 
            dgvListele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListele.Location = new Point(439, 28);
            dgvListele.Name = "dgvListele";
            dgvListele.RowHeadersWidth = 51;
            dgvListele.Size = new Size(335, 402);
            dgvListele.TabIndex = 6;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(65, 330);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(50, 20);
            lblDurum.TabIndex = 7;
            lblDurum.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDurum);
            Controls.Add(dgvListele);
            Controls.Add(btnListele);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvListele).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Button btnEkle;
        private Button btnListele;
        private DataGridView dgvListele;
        private Label lblDurum;
    }
}

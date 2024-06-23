namespace outeLL.comV1
{
    partial class frmKisiKayit
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
            panel1 = new Panel();
            btn_Cikis = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTCKimlik = new TextBox();
            groupBox2 = new GroupBox();
            txtAd = new TextBox();
            groupBox3 = new GroupBox();
            txtSoyad = new TextBox();
            groupBox4 = new GroupBox();
            rbErkek = new RadioButton();
            rbKadın = new RadioButton();
            groupBox5 = new GroupBox();
            txtDogumTarihi = new TextBox();
            label2 = new Label();
            groupBox6 = new GroupBox();
            txtTelNo = new TextBox();
            groupBox7 = new GroupBox();
            txtMail = new TextBox();
            groupBox8 = new GroupBox();
            txtAciklama = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 187, 216);
            panel1.Controls.Add(btn_Cikis);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 40);
            panel1.TabIndex = 0;
            // 
            // btn_Cikis
            // 
            btn_Cikis.BackColor = Color.FromArgb(17, 55, 64);
            btn_Cikis.Cursor = Cursors.Hand;
            btn_Cikis.Dock = DockStyle.Right;
            btn_Cikis.FlatAppearance.BorderSize = 0;
            btn_Cikis.FlatStyle = FlatStyle.Flat;
            btn_Cikis.ForeColor = Color.White;
            btn_Cikis.Location = new Point(797, 0);
            btn_Cikis.Name = "btn_Cikis";
            btn_Cikis.Size = new Size(40, 40);
            btn_Cikis.TabIndex = 1;
            btn_Cikis.Text = "X";
            btn_Cikis.UseVisualStyleBackColor = false;
            btn_Cikis.Click += btn_Cikis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 1;
            label1.Text = "(outeLL.com)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTCKimlik);
            groupBox1.Location = new Point(12, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15, 3, 3, 3);
            groupBox1.Size = new Size(200, 49);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "TC KİMLİK NUMARASI";
            // 
            // txtTCKimlik
            // 
            txtTCKimlik.BorderStyle = BorderStyle.None;
            txtTCKimlik.Dock = DockStyle.Bottom;
            txtTCKimlik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTCKimlik.ForeColor = Color.FromArgb(17, 55, 64);
            txtTCKimlik.Location = new Point(15, 24);
            txtTCKimlik.Name = "txtTCKimlik";
            txtTCKimlik.Size = new Size(182, 22);
            txtTCKimlik.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAd);
            groupBox2.Location = new Point(258, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(15, 3, 3, 3);
            groupBox2.Size = new Size(200, 49);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "İSİM";
            // 
            // txtAd
            // 
            txtAd.BorderStyle = BorderStyle.None;
            txtAd.Dock = DockStyle.Bottom;
            txtAd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAd.ForeColor = Color.FromArgb(17, 55, 64);
            txtAd.Location = new Point(15, 24);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(182, 22);
            txtAd.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSoyad);
            groupBox3.Location = new Point(529, 68);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(15, 3, 3, 3);
            groupBox3.Size = new Size(200, 49);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "SOYİSİM";
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.None;
            txtSoyad.Dock = DockStyle.Bottom;
            txtSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoyad.ForeColor = Color.FromArgb(17, 55, 64);
            txtSoyad.Location = new Point(15, 24);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(182, 22);
            txtSoyad.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbKadın);
            groupBox4.Controls.Add(rbErkek);
            groupBox4.Location = new Point(12, 170);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(15, 3, 3, 3);
            groupBox4.Size = new Size(200, 35);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "CİNSİYET";
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Checked = true;
            rbErkek.FlatStyle = FlatStyle.Flat;
            rbErkek.Location = new Point(43, 4);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(75, 25);
            rbErkek.TabIndex = 0;
            rbErkek.TabStop = true;
            rbErkek.Text = "ERKEK";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadın
            // 
            rbKadın.AutoSize = true;
            rbKadın.FlatStyle = FlatStyle.Flat;
            rbKadın.Location = new Point(119, 4);
            rbKadın.Name = "rbKadın";
            rbKadın.Size = new Size(78, 25);
            rbKadın.TabIndex = 1;
            rbKadın.Text = "KADIN";
            rbKadın.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(txtDogumTarihi);
            groupBox5.Location = new Point(282, 174);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(15, 3, 3, 3);
            groupBox5.Size = new Size(200, 49);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "DOĞUM TARİHİ";
            // 
            // txtDogumTarihi
            // 
            txtDogumTarihi.BorderStyle = BorderStyle.None;
            txtDogumTarihi.Dock = DockStyle.Bottom;
            txtDogumTarihi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDogumTarihi.ForeColor = Color.FromArgb(17, 55, 64);
            txtDogumTarihi.Location = new Point(15, 24);
            txtDogumTarihi.Name = "txtDogumTarihi";
            txtDogumTarihi.Size = new Size(182, 22);
            txtDogumTarihi.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(26, 111, 166);
            label2.Location = new Point(132, 2);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "gg.aa.yyyy";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtTelNo);
            groupBox6.Location = new Point(544, 174);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(15, 3, 3, 3);
            groupBox6.Size = new Size(200, 49);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "TELEFON NUMARASI";
            // 
            // txtTelNo
            // 
            txtTelNo.BorderStyle = BorderStyle.None;
            txtTelNo.Dock = DockStyle.Bottom;
            txtTelNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelNo.ForeColor = Color.FromArgb(17, 55, 64);
            txtTelNo.Location = new Point(15, 24);
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(182, 22);
            txtTelNo.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtMail);
            groupBox7.Location = new Point(12, 238);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(15, 3, 3, 3);
            groupBox7.Size = new Size(200, 49);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            groupBox7.Text = "MAİL ADRESİ";
            // 
            // txtMail
            // 
            txtMail.BorderStyle = BorderStyle.None;
            txtMail.Dock = DockStyle.Bottom;
            txtMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMail.ForeColor = Color.FromArgb(17, 55, 64);
            txtMail.Location = new Point(15, 24);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(182, 22);
            txtMail.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txtAciklama);
            groupBox8.Location = new Point(282, 238);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(15, 3, 3, 3);
            groupBox8.Size = new Size(462, 49);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            groupBox8.Text = "AÇIKLAMA";
            // 
            // txtAciklama
            // 
            txtAciklama.BorderStyle = BorderStyle.None;
            txtAciklama.Dock = DockStyle.Bottom;
            txtAciklama.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAciklama.ForeColor = Color.FromArgb(17, 55, 64);
            txtAciklama.Location = new Point(15, 24);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(444, 22);
            txtAciklama.TabIndex = 0;
            // 
            // frmKisiKayit
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(837, 630);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmKisiKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "X";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_Cikis;
        private GroupBox groupBox1;
        private TextBox txtTCKimlik;
        private GroupBox groupBox2;
        private TextBox txtAd;
        private GroupBox groupBox3;
        private TextBox txtSoyad;
        private GroupBox groupBox4;
        private RadioButton rbErkek;
        private RadioButton rbKadın;
        private GroupBox groupBox5;
        private TextBox txtDogumTarihi;
        private Label label2;
        private GroupBox groupBox6;
        private TextBox txtTelNo;
        private GroupBox groupBox7;
        private TextBox txtMail;
        private GroupBox groupBox8;
        private TextBox txtAciklama;
    }
}

namespace Quiz10_20160627_MHRS
{
    partial class Form_UyeKayit
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
            this.btn_menuUyeKayit = new System.Windows.Forms.Button();
            this.btn_titleUyeKayit = new System.Windows.Forms.Button();
            this.cmb_cinsiyetHasta = new System.Windows.Forms.ComboBox();
            this.dtp_dogumTarihiHasta = new System.Windows.Forms.DateTimePicker();
            this.tbx_sifre2Hasta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_sifreHastaKayit = new System.Windows.Forms.TextBox();
            this.tbx_tcHastaKayit = new System.Windows.Forms.TextBox();
            this.tbx_soyadHasta = new System.Windows.Forms.TextBox();
            this.tbx_adHasta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.pb_resimSecHasta = new System.Windows.Forms.PictureBox();
            this.lbl_resimSecHasta = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resimSecHasta)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_menuUyeKayit
            // 
            this.btn_menuUyeKayit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_menuUyeKayit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_menuUyeKayit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_menuUyeKayit.FlatAppearance.BorderSize = 0;
            this.btn_menuUyeKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuUyeKayit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuUyeKayit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_menuUyeKayit.Location = new System.Drawing.Point(0, 510);
            this.btn_menuUyeKayit.Name = "btn_menuUyeKayit";
            this.btn_menuUyeKayit.Size = new System.Drawing.Size(350, 40);
            this.btn_menuUyeKayit.TabIndex = 26;
            this.btn_menuUyeKayit.Text = "Menü";
            this.btn_menuUyeKayit.UseVisualStyleBackColor = false;
            this.btn_menuUyeKayit.Click += new System.EventHandler(this.btn_menuUyeKayit_Click);
            // 
            // btn_titleUyeKayit
            // 
            this.btn_titleUyeKayit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleUyeKayit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titleUyeKayit.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleUyeKayit.FlatAppearance.BorderSize = 0;
            this.btn_titleUyeKayit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleUyeKayit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleUyeKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titleUyeKayit.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titleUyeKayit.ForeColor = System.Drawing.Color.White;
            this.btn_titleUyeKayit.Location = new System.Drawing.Point(0, 0);
            this.btn_titleUyeKayit.Name = "btn_titleUyeKayit";
            this.btn_titleUyeKayit.Size = new System.Drawing.Size(350, 60);
            this.btn_titleUyeKayit.TabIndex = 25;
            this.btn_titleUyeKayit.Text = "ÜYE KAYDI";
            this.btn_titleUyeKayit.UseVisualStyleBackColor = false;
            this.btn_titleUyeKayit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_titleUyeKayit_MouseDown);
            this.btn_titleUyeKayit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_titleUyeKayit_MouseMove);
            this.btn_titleUyeKayit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_titleUyeKayit_MouseUp);
            // 
            // cmb_cinsiyetHasta
            // 
            this.cmb_cinsiyetHasta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_cinsiyetHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_cinsiyetHasta.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_cinsiyetHasta.FormattingEnabled = true;
            this.cmb_cinsiyetHasta.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmb_cinsiyetHasta.Location = new System.Drawing.Point(3, 273);
            this.cmb_cinsiyetHasta.Name = "cmb_cinsiyetHasta";
            this.cmb_cinsiyetHasta.Size = new System.Drawing.Size(151, 23);
            this.cmb_cinsiyetHasta.TabIndex = 16;
            // 
            // dtp_dogumTarihiHasta
            // 
            this.dtp_dogumTarihiHasta.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_dogumTarihiHasta.Location = new System.Drawing.Point(3, 223);
            this.dtp_dogumTarihiHasta.Name = "dtp_dogumTarihiHasta";
            this.dtp_dogumTarihiHasta.Size = new System.Drawing.Size(151, 23);
            this.dtp_dogumTarihiHasta.TabIndex = 15;
            // 
            // tbx_sifre2Hasta
            // 
            this.tbx_sifre2Hasta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_sifre2Hasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_sifre2Hasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_sifre2Hasta.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_sifre2Hasta.Location = new System.Drawing.Point(3, 273);
            this.tbx_sifre2Hasta.Name = "tbx_sifre2Hasta";
            this.tbx_sifre2Hasta.Size = new System.Drawing.Size(164, 23);
            this.tbx_sifre2Hasta.TabIndex = 14;
            this.tbx_sifre2Hasta.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Şifre Doğrulama:";
            // 
            // tbx_sifreHastaKayit
            // 
            this.tbx_sifreHastaKayit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_sifreHastaKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_sifreHastaKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_sifreHastaKayit.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_sifreHastaKayit.Location = new System.Drawing.Point(3, 223);
            this.tbx_sifreHastaKayit.Name = "tbx_sifreHastaKayit";
            this.tbx_sifreHastaKayit.Size = new System.Drawing.Size(164, 23);
            this.tbx_sifreHastaKayit.TabIndex = 11;
            this.tbx_sifreHastaKayit.UseSystemPasswordChar = true;
            // 
            // tbx_tcHastaKayit
            // 
            this.tbx_tcHastaKayit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_tcHastaKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_tcHastaKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_tcHastaKayit.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_tcHastaKayit.Location = new System.Drawing.Point(3, 123);
            this.tbx_tcHastaKayit.Name = "tbx_tcHastaKayit";
            this.tbx_tcHastaKayit.Size = new System.Drawing.Size(164, 23);
            this.tbx_tcHastaKayit.TabIndex = 8;
            // 
            // tbx_soyadHasta
            // 
            this.tbx_soyadHasta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_soyadHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_soyadHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_soyadHasta.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_soyadHasta.Location = new System.Drawing.Point(3, 73);
            this.tbx_soyadHasta.Name = "tbx_soyadHasta";
            this.tbx_soyadHasta.Size = new System.Drawing.Size(164, 23);
            this.tbx_soyadHasta.TabIndex = 7;
            // 
            // tbx_adHasta
            // 
            this.tbx_adHasta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_adHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_adHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_adHasta.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_adHasta.Location = new System.Drawing.Point(3, 23);
            this.tbx_adHasta.Name = "tbx_adHasta";
            this.tbx_adHasta.Size = new System.Drawing.Size(164, 23);
            this.tbx_adHasta.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_kaydol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_kaydol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydol.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydol.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_kaydol.Location = new System.Drawing.Point(30, 3);
            this.btn_kaydol.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(290, 44);
            this.btn_kaydol.TabIndex = 12;
            this.btn_kaydol.Text = "Kaydol";
            this.btn_kaydol.UseVisualStyleBackColor = false;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // pb_resimSecHasta
            // 
            this.pb_resimSecHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_resimSecHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_resimSecHasta.Location = new System.Drawing.Point(3, 3);
            this.pb_resimSecHasta.Name = "pb_resimSecHasta";
            this.pb_resimSecHasta.Size = new System.Drawing.Size(164, 164);
            this.pb_resimSecHasta.TabIndex = 28;
            this.pb_resimSecHasta.TabStop = false;
            // 
            // lbl_resimSecHasta
            // 
            this.lbl_resimSecHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_resimSecHasta.AutoSize = true;
            this.lbl_resimSecHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_resimSecHasta.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_resimSecHasta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_resimSecHasta.Location = new System.Drawing.Point(53, 172);
            this.lbl_resimSecHasta.Name = "lbl_resimSecHasta";
            this.lbl_resimSecHasta.Size = new System.Drawing.Size(64, 15);
            this.lbl_resimSecHasta.TabIndex = 29;
            this.lbl_resimSecHasta.Text = "Resim Seç";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_cinsiyetHasta, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.tbx_adHasta, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtp_dogumTarihiHasta, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbx_soyadHasta, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbx_tcHastaKayit, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(170, 300);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pb_resimSecHasta, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_resimSecHasta, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbx_sifre2Hasta, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbx_sifreHastaKayit, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(180, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(170, 300);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btn_kaydol, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 460);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(350, 50);
            this.tableLayoutPanel3.TabIndex = 32;
            // 
            // Form_UyeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_menuUyeKayit;
            this.ClientSize = new System.Drawing.Size(350, 550);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_menuUyeKayit);
            this.Controls.Add(this.btn_titleUyeKayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_UyeKayit";
            this.Text = "Form_UyeKayit";
            ((System.ComponentModel.ISupportInitialize)(this.pb_resimSecHasta)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_menuUyeKayit;
        private System.Windows.Forms.Button btn_titleUyeKayit;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.TextBox tbx_sifreHastaKayit;
        private System.Windows.Forms.TextBox tbx_tcHastaKayit;
        private System.Windows.Forms.TextBox tbx_soyadHasta;
        private System.Windows.Forms.TextBox tbx_adHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_cinsiyetHasta;
        private System.Windows.Forms.DateTimePicker dtp_dogumTarihiHasta;
        private System.Windows.Forms.TextBox tbx_sifre2Hasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pb_resimSecHasta;
        private System.Windows.Forms.Label lbl_resimSecHasta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
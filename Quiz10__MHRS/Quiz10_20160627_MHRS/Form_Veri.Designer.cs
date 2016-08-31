namespace Quiz10_20160627_MHRS
{
    partial class Form_Veri
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_personelBilgi = new System.Windows.Forms.Label();
            this.cmb_departmanVeri = new System.Windows.Forms.ComboBox();
            this.cmb_bolumYaDaDoktor = new System.Windows.Forms.ComboBox();
            this.btn_titleVeri = new System.Windows.Forms.Button();
            this.btn_menuVeri = new System.Windows.Forms.Button();
            this.lbl_resimSecPersonel = new System.Windows.Forms.Label();
            this.pb_resimSecPersonel = new System.Windows.Forms.PictureBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_adminOturumuKapat = new System.Windows.Forms.Button();
            this.lbl_personelAd = new System.Windows.Forms.Label();
            this.lbl_personelSoyad = new System.Windows.Forms.Label();
            this.tbx_personelAd = new System.Windows.Forms.TextBox();
            this.tbx_personelSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_tcPersonel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_dogumTarihiPersonel = new System.Windows.Forms.DateTimePicker();
            this.cmb_cinsiyetPersonel = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resimSecPersonel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman:";
            // 
            // lbl_personelBilgi
            // 
            this.lbl_personelBilgi.AutoSize = true;
            this.lbl_personelBilgi.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelBilgi.Location = new System.Drawing.Point(3, 250);
            this.lbl_personelBilgi.Name = "lbl_personelBilgi";
            this.lbl_personelBilgi.Size = new System.Drawing.Size(46, 15);
            this.lbl_personelBilgi.TabIndex = 7;
            this.lbl_personelBilgi.Text = "Bölüm:";
            // 
            // cmb_departmanVeri
            // 
            this.cmb_departmanVeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_departmanVeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_departmanVeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_departmanVeri.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_departmanVeri.FormattingEnabled = true;
            this.cmb_departmanVeri.Location = new System.Drawing.Point(3, 223);
            this.cmb_departmanVeri.Name = "cmb_departmanVeri";
            this.cmb_departmanVeri.Size = new System.Drawing.Size(164, 23);
            this.cmb_departmanVeri.TabIndex = 8;
            this.cmb_departmanVeri.SelectionChangeCommitted += new System.EventHandler(this.cmb_departmanVeri_SelectionChangeCommitted);
            // 
            // cmb_bolumYaDaDoktor
            // 
            this.cmb_bolumYaDaDoktor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_bolumYaDaDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_bolumYaDaDoktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_bolumYaDaDoktor.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_bolumYaDaDoktor.FormattingEnabled = true;
            this.cmb_bolumYaDaDoktor.Location = new System.Drawing.Point(3, 273);
            this.cmb_bolumYaDaDoktor.Name = "cmb_bolumYaDaDoktor";
            this.cmb_bolumYaDaDoktor.Size = new System.Drawing.Size(164, 23);
            this.cmb_bolumYaDaDoktor.TabIndex = 12;
            // 
            // btn_titleVeri
            // 
            this.btn_titleVeri.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleVeri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titleVeri.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleVeri.FlatAppearance.BorderSize = 0;
            this.btn_titleVeri.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleVeri.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleVeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titleVeri.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titleVeri.ForeColor = System.Drawing.Color.White;
            this.btn_titleVeri.Location = new System.Drawing.Point(0, 0);
            this.btn_titleVeri.Name = "btn_titleVeri";
            this.btn_titleVeri.Size = new System.Drawing.Size(350, 60);
            this.btn_titleVeri.TabIndex = 22;
            this.btn_titleVeri.Text = "VERİ GİRİŞİ";
            this.btn_titleVeri.UseVisualStyleBackColor = false;
            this.btn_titleVeri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_titleVeriGiris_MouseDown);
            this.btn_titleVeri.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_titleVeriGiris_MouseMove);
            this.btn_titleVeri.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_titleVeriGiris_MouseUp);
            // 
            // btn_menuVeri
            // 
            this.btn_menuVeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_menuVeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_menuVeri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_menuVeri.FlatAppearance.BorderSize = 0;
            this.btn_menuVeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuVeri.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuVeri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_menuVeri.Location = new System.Drawing.Point(0, 510);
            this.btn_menuVeri.Name = "btn_menuVeri";
            this.btn_menuVeri.Size = new System.Drawing.Size(350, 40);
            this.btn_menuVeri.TabIndex = 23;
            this.btn_menuVeri.Text = "Menü";
            this.btn_menuVeri.UseVisualStyleBackColor = false;
            this.btn_menuVeri.Click += new System.EventHandler(this.btn_menuVeri_Click);
            // 
            // lbl_resimSecPersonel
            // 
            this.lbl_resimSecPersonel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_resimSecPersonel.AutoSize = true;
            this.lbl_resimSecPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_resimSecPersonel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_resimSecPersonel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_resimSecPersonel.Location = new System.Drawing.Point(53, 172);
            this.lbl_resimSecPersonel.Name = "lbl_resimSecPersonel";
            this.lbl_resimSecPersonel.Size = new System.Drawing.Size(64, 15);
            this.lbl_resimSecPersonel.TabIndex = 31;
            this.lbl_resimSecPersonel.Text = "Resim Seç";
            // 
            // pb_resimSecPersonel
            // 
            this.pb_resimSecPersonel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_resimSecPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_resimSecPersonel.Location = new System.Drawing.Point(3, 3);
            this.pb_resimSecPersonel.Name = "pb_resimSecPersonel";
            this.pb_resimSecPersonel.Size = new System.Drawing.Size(164, 164);
            this.pb_resimSecPersonel.TabIndex = 30;
            this.pb_resimSecPersonel.TabStop = false;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_kaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_kaydet.Location = new System.Drawing.Point(30, 3);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(290, 44);
            this.btn_kaydet.TabIndex = 32;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_adminOturumuKapat
            // 
            this.btn_adminOturumuKapat.BackColor = System.Drawing.Color.SlateGray;
            this.btn_adminOturumuKapat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_adminOturumuKapat.FlatAppearance.BorderSize = 0;
            this.btn_adminOturumuKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminOturumuKapat.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_adminOturumuKapat.ForeColor = System.Drawing.Color.White;
            this.btn_adminOturumuKapat.Location = new System.Drawing.Point(0, 53);
            this.btn_adminOturumuKapat.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_adminOturumuKapat.Name = "btn_adminOturumuKapat";
            this.btn_adminOturumuKapat.Size = new System.Drawing.Size(350, 44);
            this.btn_adminOturumuKapat.TabIndex = 33;
            this.btn_adminOturumuKapat.Text = "Oturumu Kapat";
            this.btn_adminOturumuKapat.UseVisualStyleBackColor = false;
            this.btn_adminOturumuKapat.Click += new System.EventHandler(this.btn_adminOturumuKapat_Click);
            // 
            // lbl_personelAd
            // 
            this.lbl_personelAd.AutoSize = true;
            this.lbl_personelAd.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelAd.Location = new System.Drawing.Point(3, 0);
            this.lbl_personelAd.Name = "lbl_personelAd";
            this.lbl_personelAd.Size = new System.Drawing.Size(25, 15);
            this.lbl_personelAd.TabIndex = 1;
            this.lbl_personelAd.Text = "Ad:";
            // 
            // lbl_personelSoyad
            // 
            this.lbl_personelSoyad.AutoSize = true;
            this.lbl_personelSoyad.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelSoyad.Location = new System.Drawing.Point(3, 50);
            this.lbl_personelSoyad.Name = "lbl_personelSoyad";
            this.lbl_personelSoyad.Size = new System.Drawing.Size(43, 15);
            this.lbl_personelSoyad.TabIndex = 2;
            this.lbl_personelSoyad.Text = "Soyad:";
            // 
            // tbx_personelAd
            // 
            this.tbx_personelAd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_personelAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_personelAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_personelAd.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_personelAd.Location = new System.Drawing.Point(3, 23);
            this.tbx_personelAd.Name = "tbx_personelAd";
            this.tbx_personelAd.Size = new System.Drawing.Size(164, 23);
            this.tbx_personelAd.TabIndex = 3;
            // 
            // tbx_personelSoyad
            // 
            this.tbx_personelSoyad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_personelSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_personelSoyad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_personelSoyad.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_personelSoyad.Location = new System.Drawing.Point(3, 73);
            this.tbx_personelSoyad.Name = "tbx_personelSoyad";
            this.tbx_personelSoyad.Size = new System.Drawing.Size(164, 23);
            this.tbx_personelSoyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "TC Kimlik No:";
            // 
            // tbx_tcPersonel
            // 
            this.tbx_tcPersonel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_tcPersonel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_tcPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_tcPersonel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_tcPersonel.Location = new System.Drawing.Point(3, 123);
            this.tbx_tcPersonel.Name = "tbx_tcPersonel";
            this.tbx_tcPersonel.Size = new System.Drawing.Size(164, 23);
            this.tbx_tcPersonel.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinsiyet:";
            // 
            // dtp_dogumTarihiPersonel
            // 
            this.dtp_dogumTarihiPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_dogumTarihiPersonel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_dogumTarihiPersonel.Location = new System.Drawing.Point(3, 223);
            this.dtp_dogumTarihiPersonel.Name = "dtp_dogumTarihiPersonel";
            this.dtp_dogumTarihiPersonel.Size = new System.Drawing.Size(164, 23);
            this.dtp_dogumTarihiPersonel.TabIndex = 18;
            // 
            // cmb_cinsiyetPersonel
            // 
            this.cmb_cinsiyetPersonel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_cinsiyetPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_cinsiyetPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_cinsiyetPersonel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_cinsiyetPersonel.FormattingEnabled = true;
            this.cmb_cinsiyetPersonel.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmb_cinsiyetPersonel.Location = new System.Drawing.Point(3, 273);
            this.cmb_cinsiyetPersonel.Name = "cmb_cinsiyetPersonel";
            this.cmb_cinsiyetPersonel.Size = new System.Drawing.Size(164, 23);
            this.cmb_cinsiyetPersonel.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_personelAd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_cinsiyetPersonel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.tbx_personelAd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_personelSoyad, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbx_personelSoyad, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbx_tcPersonel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dtp_dogumTarihiPersonel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 9);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(170, 300);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_kaydet, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_adminOturumuKapat, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 410);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 100);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_resimSecPersonel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pb_resimSecPersonel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.cmb_departmanVeri, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.cmb_bolumYaDaDoktor, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lbl_personelBilgi, 0, 5);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(180, 60);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(170, 300);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // Form_Veri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_menuVeri;
            this.ClientSize = new System.Drawing.Size(350, 550);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_menuVeri);
            this.Controls.Add(this.btn_titleVeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Veri";
            this.Text = "Form_Veri";
            this.Load += new System.EventHandler(this.Form_Veri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_resimSecPersonel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_personelBilgi;
        private System.Windows.Forms.ComboBox cmb_departmanVeri;
        private System.Windows.Forms.Button btn_titleVeri;
        private System.Windows.Forms.Button btn_menuVeri;
        private System.Windows.Forms.ComboBox cmb_bolumYaDaDoktor;
        private System.Windows.Forms.Label lbl_resimSecPersonel;
        private System.Windows.Forms.PictureBox pb_resimSecPersonel;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_adminOturumuKapat;
        private System.Windows.Forms.Label lbl_personelAd;
        private System.Windows.Forms.Label lbl_personelSoyad;
        private System.Windows.Forms.TextBox tbx_personelAd;
        private System.Windows.Forms.TextBox tbx_personelSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_tcPersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_dogumTarihiPersonel;
        private System.Windows.Forms.ComboBox cmb_cinsiyetPersonel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
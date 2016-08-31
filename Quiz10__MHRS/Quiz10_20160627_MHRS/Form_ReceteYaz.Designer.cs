namespace Quiz10_20160627_MHRS
{
    partial class Form_ReceteYaz
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
            this.tbx_hastaTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_profileGit = new System.Windows.Forms.Button();
            this.btn_titleReceteYaz = new System.Windows.Forms.Button();
            this.btn_receteOlustur = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ilacEkle = new System.Windows.Forms.Button();
            this.btn_receteKaydet = new System.Windows.Forms.Button();
            this.cmb_ilac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_ilaclar = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_hastaTc
            // 
            this.tbx_hastaTc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_hastaTc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_hastaTc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_hastaTc.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_hastaTc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbx_hastaTc.Location = new System.Drawing.Point(3, 73);
            this.tbx_hastaTc.Name = "tbx_hastaTc";
            this.tbx_hastaTc.Size = new System.Drawing.Size(169, 23);
            this.tbx_hastaTc.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hasta TC Kimlik No:";
            // 
            // btn_profileGit
            // 
            this.btn_profileGit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_profileGit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_profileGit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_profileGit.FlatAppearance.BorderSize = 0;
            this.btn_profileGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profileGit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_profileGit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_profileGit.Location = new System.Drawing.Point(0, 510);
            this.btn_profileGit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_profileGit.Name = "btn_profileGit";
            this.btn_profileGit.Size = new System.Drawing.Size(350, 40);
            this.btn_profileGit.TabIndex = 29;
            this.btn_profileGit.Text = "Profil Sayfama Dön";
            this.btn_profileGit.UseVisualStyleBackColor = false;
            this.btn_profileGit.Click += new System.EventHandler(this.btn_profileGit_Click);
            // 
            // btn_titleReceteYaz
            // 
            this.btn_titleReceteYaz.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleReceteYaz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titleReceteYaz.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleReceteYaz.FlatAppearance.BorderSize = 0;
            this.btn_titleReceteYaz.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleReceteYaz.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleReceteYaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titleReceteYaz.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titleReceteYaz.ForeColor = System.Drawing.Color.White;
            this.btn_titleReceteYaz.Location = new System.Drawing.Point(0, 0);
            this.btn_titleReceteYaz.Name = "btn_titleReceteYaz";
            this.btn_titleReceteYaz.Size = new System.Drawing.Size(350, 60);
            this.btn_titleReceteYaz.TabIndex = 28;
            this.btn_titleReceteYaz.Text = "REÇETE YAZ";
            this.btn_titleReceteYaz.UseVisualStyleBackColor = false;
            this.btn_titleReceteYaz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_titleReceteYaz_MouseDown);
            this.btn_titleReceteYaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_titleReceteYaz_MouseMove);
            this.btn_titleReceteYaz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_titleReceteYaz_MouseUp);
            // 
            // btn_receteOlustur
            // 
            this.btn_receteOlustur.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.btn_receteOlustur, 2);
            this.btn_receteOlustur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_receteOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_receteOlustur.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_receteOlustur.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_receteOlustur.Location = new System.Drawing.Point(30, 3);
            this.btn_receteOlustur.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.btn_receteOlustur.Name = "btn_receteOlustur";
            this.btn_receteOlustur.Size = new System.Drawing.Size(290, 44);
            this.btn_receteOlustur.TabIndex = 30;
            this.btn_receteOlustur.Text = "Reçete Oluştur";
            this.btn_receteOlustur.UseVisualStyleBackColor = false;
            this.btn_receteOlustur.Click += new System.EventHandler(this.btn_receteOlustur_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_ilacEkle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_receteOlustur, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_receteKaydet, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbx_hastaTc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmb_ilac, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtb_ilaclar, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 450);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // btn_ilacEkle
            // 
            this.btn_ilacEkle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.btn_ilacEkle, 2);
            this.btn_ilacEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ilacEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ilacEkle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ilacEkle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ilacEkle.Location = new System.Drawing.Point(30, 103);
            this.btn_ilacEkle.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.btn_ilacEkle.Name = "btn_ilacEkle";
            this.btn_ilacEkle.Size = new System.Drawing.Size(290, 44);
            this.btn_ilacEkle.TabIndex = 15;
            this.btn_ilacEkle.Text = "İlaç Ekle";
            this.btn_ilacEkle.UseVisualStyleBackColor = false;
            this.btn_ilacEkle.Click += new System.EventHandler(this.btn_ilacEkle_Click);
            // 
            // btn_receteKaydet
            // 
            this.btn_receteKaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.btn_receteKaydet, 2);
            this.btn_receteKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_receteKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_receteKaydet.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_receteKaydet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_receteKaydet.Location = new System.Drawing.Point(30, 403);
            this.btn_receteKaydet.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.btn_receteKaydet.Name = "btn_receteKaydet";
            this.btn_receteKaydet.Size = new System.Drawing.Size(290, 44);
            this.btn_receteKaydet.TabIndex = 18;
            this.btn_receteKaydet.Text = "Reçeteyi Kaydet";
            this.btn_receteKaydet.UseVisualStyleBackColor = false;
            this.btn_receteKaydet.Click += new System.EventHandler(this.btn_receteKaydet_Click);
            // 
            // cmb_ilac
            // 
            this.cmb_ilac.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_ilac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_ilac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_ilac.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ilac.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ilac.FormattingEnabled = true;
            this.cmb_ilac.ItemHeight = 15;
            this.cmb_ilac.Location = new System.Drawing.Point(178, 73);
            this.cmb_ilac.Name = "cmb_ilac";
            this.cmb_ilac.Size = new System.Drawing.Size(169, 23);
            this.cmb_ilac.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(178, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "İlaç Seçin:";
            // 
            // rtb_ilaclar
            // 
            this.rtb_ilaclar.BackColor = System.Drawing.Color.White;
            this.rtb_ilaclar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.rtb_ilaclar, 2);
            this.rtb_ilaclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_ilaclar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_ilaclar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rtb_ilaclar.Location = new System.Drawing.Point(3, 153);
            this.rtb_ilaclar.Name = "rtb_ilaclar";
            this.rtb_ilaclar.ReadOnly = true;
            this.rtb_ilaclar.Size = new System.Drawing.Size(344, 244);
            this.rtb_ilaclar.TabIndex = 31;
            this.rtb_ilaclar.Text = "";
            // 
            // Form_ReceteYaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_profileGit;
            this.ClientSize = new System.Drawing.Size(350, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_profileGit);
            this.Controls.Add(this.btn_titleReceteYaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ReceteYaz";
            this.Text = "Form_ReceteYaz";
            this.Load += new System.EventHandler(this.Form_ReceteYaz_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_profileGit;
        private System.Windows.Forms.Button btn_titleReceteYaz;
        private System.Windows.Forms.TextBox tbx_hastaTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_receteOlustur;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_ilacEkle;
        private System.Windows.Forms.ComboBox cmb_ilac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_receteKaydet;
        private System.Windows.Forms.RichTextBox rtb_ilaclar;
    }
}
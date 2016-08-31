namespace Quiz10_20160627_MHRS
{
    partial class Form_ProfilDoktor
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
            this.btn_titleProfil = new System.Windows.Forms.Button();
            this.btn_menuProfil = new System.Windows.Forms.Button();
            this.btn_izinAl = new System.Windows.Forms.Button();
            this.rtb_bilgilerDoktor = new System.Windows.Forms.RichTextBox();
            this.btn_receteYaz = new System.Windows.Forms.Button();
            this.btn_doktorOturumuKapat = new System.Windows.Forms.Button();
            this.btn_sifreDegistir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_titleProfil
            // 
            this.btn_titleProfil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleProfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titleProfil.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleProfil.FlatAppearance.BorderSize = 0;
            this.btn_titleProfil.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleProfil.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titleProfil.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titleProfil.ForeColor = System.Drawing.Color.White;
            this.btn_titleProfil.Location = new System.Drawing.Point(0, 0);
            this.btn_titleProfil.Name = "btn_titleProfil";
            this.btn_titleProfil.Size = new System.Drawing.Size(350, 60);
            this.btn_titleProfil.TabIndex = 26;
            this.btn_titleProfil.Text = "PROFİL DOKTOR";
            this.btn_titleProfil.UseVisualStyleBackColor = false;
            this.btn_titleProfil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_titleProfil_MouseDown);
            this.btn_titleProfil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_titleProfil_MouseMove);
            this.btn_titleProfil.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_titleProfil_MouseUp);
            // 
            // btn_menuProfil
            // 
            this.btn_menuProfil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_menuProfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_menuProfil.FlatAppearance.BorderSize = 0;
            this.btn_menuProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuProfil.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuProfil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_menuProfil.Location = new System.Drawing.Point(0, 510);
            this.btn_menuProfil.Name = "btn_menuProfil";
            this.btn_menuProfil.Size = new System.Drawing.Size(350, 40);
            this.btn_menuProfil.TabIndex = 25;
            this.btn_menuProfil.Text = "Menü";
            this.btn_menuProfil.UseVisualStyleBackColor = false;
            this.btn_menuProfil.Click += new System.EventHandler(this.btn_menuProfil_Click);
            // 
            // btn_izinAl
            // 
            this.btn_izinAl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_izinAl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_izinAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_izinAl.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_izinAl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_izinAl.Location = new System.Drawing.Point(30, 303);
            this.btn_izinAl.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.btn_izinAl.Name = "btn_izinAl";
            this.btn_izinAl.Size = new System.Drawing.Size(290, 44);
            this.btn_izinAl.TabIndex = 28;
            this.btn_izinAl.Text = "İzin Al";
            this.btn_izinAl.UseVisualStyleBackColor = false;
            this.btn_izinAl.Click += new System.EventHandler(this.btn_izinAl_Click);
            // 
            // rtb_bilgilerDoktor
            // 
            this.rtb_bilgilerDoktor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtb_bilgilerDoktor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rtb_bilgilerDoktor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_bilgilerDoktor.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_bilgilerDoktor.Location = new System.Drawing.Point(30, 25);
            this.rtb_bilgilerDoktor.Name = "rtb_bilgilerDoktor";
            this.rtb_bilgilerDoktor.ReadOnly = true;
            this.rtb_bilgilerDoktor.Size = new System.Drawing.Size(290, 200);
            this.rtb_bilgilerDoktor.TabIndex = 29;
            this.rtb_bilgilerDoktor.Text = "";
            // 
            // btn_receteYaz
            // 
            this.btn_receteYaz.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_receteYaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_receteYaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_receteYaz.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_receteYaz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_receteYaz.Location = new System.Drawing.Point(30, 253);
            this.btn_receteYaz.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.btn_receteYaz.Name = "btn_receteYaz";
            this.btn_receteYaz.Size = new System.Drawing.Size(290, 44);
            this.btn_receteYaz.TabIndex = 30;
            this.btn_receteYaz.Text = "Reçete Yaz";
            this.btn_receteYaz.UseVisualStyleBackColor = false;
            this.btn_receteYaz.Click += new System.EventHandler(this.btn_receteYaz_Click);
            // 
            // btn_doktorOturumuKapat
            // 
            this.btn_doktorOturumuKapat.BackColor = System.Drawing.Color.SlateGray;
            this.btn_doktorOturumuKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_doktorOturumuKapat.FlatAppearance.BorderSize = 0;
            this.btn_doktorOturumuKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doktorOturumuKapat.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doktorOturumuKapat.ForeColor = System.Drawing.Color.White;
            this.btn_doktorOturumuKapat.Location = new System.Drawing.Point(0, 403);
            this.btn_doktorOturumuKapat.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_doktorOturumuKapat.Name = "btn_doktorOturumuKapat";
            this.btn_doktorOturumuKapat.Size = new System.Drawing.Size(350, 40);
            this.btn_doktorOturumuKapat.TabIndex = 31;
            this.btn_doktorOturumuKapat.Text = "Oturumu Kapat";
            this.btn_doktorOturumuKapat.UseVisualStyleBackColor = false;
            this.btn_doktorOturumuKapat.Click += new System.EventHandler(this.btn_doktorOturumuKapat_Click);
            // 
            // btn_sifreDegistir
            // 
            this.btn_sifreDegistir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_sifreDegistir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sifreDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifreDegistir.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifreDegistir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_sifreDegistir.Location = new System.Drawing.Point(30, 353);
            this.btn_sifreDegistir.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.btn_sifreDegistir.Name = "btn_sifreDegistir";
            this.btn_sifreDegistir.Size = new System.Drawing.Size(290, 44);
            this.btn_sifreDegistir.TabIndex = 32;
            this.btn_sifreDegistir.Text = "Şifre Değiştir";
            this.btn_sifreDegistir.UseVisualStyleBackColor = false;
            this.btn_sifreDegistir.Click += new System.EventHandler(this.btn_sifreDegistir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_doktorOturumuKapat, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rtb_bilgilerDoktor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_receteYaz, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_sifreDegistir, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_izinAl, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 450);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // Form_ProfilDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_doktorOturumuKapat;
            this.ClientSize = new System.Drawing.Size(350, 550);
            this.Controls.Add(this.btn_menuProfil);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_titleProfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ProfilDoktor";
            this.Text = "Form_ProfilDoktor";
            this.Load += new System.EventHandler(this.Form_ProfilDoktor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_titleProfil;
        private System.Windows.Forms.Button btn_menuProfil;
        private System.Windows.Forms.Button btn_izinAl;
        private System.Windows.Forms.RichTextBox rtb_bilgilerDoktor;
        private System.Windows.Forms.Button btn_receteYaz;
        private System.Windows.Forms.Button btn_doktorOturumuKapat;
        private System.Windows.Forms.Button btn_sifreDegistir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
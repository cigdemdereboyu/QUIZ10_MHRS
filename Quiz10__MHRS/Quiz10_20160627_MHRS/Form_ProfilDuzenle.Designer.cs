namespace Quiz10_20160627_MHRS
{
    partial class Form_ProfilDuzenle
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
            this.tbx_yeniSifre2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_yeniSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_geriGuncelle = new System.Windows.Forms.Button();
            this.btn_titleGuncelle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_yeniSifre2
            // 
            this.tbx_yeniSifre2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_yeniSifre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_yeniSifre2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_yeniSifre2.Location = new System.Drawing.Point(3, 73);
            this.tbx_yeniSifre2.Name = "tbx_yeniSifre2";
            this.tbx_yeniSifre2.Size = new System.Drawing.Size(144, 20);
            this.tbx_yeniSifre2.TabIndex = 14;
            this.tbx_yeniSifre2.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Şifre Doğrulama:";
            // 
            // tbx_yeniSifre
            // 
            this.tbx_yeniSifre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_yeniSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_yeniSifre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_yeniSifre.Location = new System.Drawing.Point(3, 23);
            this.tbx_yeniSifre.Name = "tbx_yeniSifre";
            this.tbx_yeniSifre.Size = new System.Drawing.Size(144, 20);
            this.tbx_yeniSifre.TabIndex = 11;
            this.tbx_yeniSifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yeni Şifre:";
            // 
            // btn_geriGuncelle
            // 
            this.btn_geriGuncelle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_geriGuncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_geriGuncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_geriGuncelle.FlatAppearance.BorderSize = 0;
            this.btn_geriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geriGuncelle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geriGuncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_geriGuncelle.Location = new System.Drawing.Point(0, 230);
            this.btn_geriGuncelle.Name = "btn_geriGuncelle";
            this.btn_geriGuncelle.Size = new System.Drawing.Size(200, 40);
            this.btn_geriGuncelle.TabIndex = 32;
            this.btn_geriGuncelle.Text = "Geri Dön";
            this.btn_geriGuncelle.UseVisualStyleBackColor = false;
            this.btn_geriGuncelle.Click += new System.EventHandler(this.btn_geriGuncelle_Click);
            // 
            // btn_titleGuncelle
            // 
            this.btn_titleGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.btn_titleGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titleGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_titleGuncelle.FlatAppearance.BorderSize = 0;
            this.btn_titleGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_titleGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_titleGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titleGuncelle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titleGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_titleGuncelle.Location = new System.Drawing.Point(0, 0);
            this.btn_titleGuncelle.Name = "btn_titleGuncelle";
            this.btn_titleGuncelle.Size = new System.Drawing.Size(200, 60);
            this.btn_titleGuncelle.TabIndex = 31;
            this.btn_titleGuncelle.Text = "ŞİFRE DEĞİŞTİRME";
            this.btn_titleGuncelle.UseVisualStyleBackColor = false;
            this.btn_titleGuncelle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_titleGuncelle_MouseDown);
            this.btn_titleGuncelle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_titleGuncelle_MouseMove);
            this.btn_titleGuncelle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_titleGuncelle_MouseUp);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.Yellow;
            this.btn_guncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_guncelle.Location = new System.Drawing.Point(0, 180);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(200, 50);
            this.btn_guncelle.TabIndex = 34;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbx_yeniSifre2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbx_yeniSifre, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 100);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // Form_ProfilDuzenle
            // 
            this.AcceptButton = this.btn_guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_geriGuncelle;
            this.ClientSize = new System.Drawing.Size(200, 270);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_geriGuncelle);
            this.Controls.Add(this.btn_titleGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(400, 400);
            this.Name = "Form_ProfilDuzenle";
            this.Text = "Form_SifreDegistir";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_yeniSifre2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_yeniSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_geriGuncelle;
        private System.Windows.Forms.Button btn_titleGuncelle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
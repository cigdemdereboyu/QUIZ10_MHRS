namespace Quiz10_20160627_MHRS
{
    partial class Form_UyeGiris
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
            this.lbl_kaydol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_uyeGiris = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_sifreGiris = new System.Windows.Forms.TextBox();
            this.tbx_tcGiris = new System.Windows.Forms.TextBox();
            this.btn_titleUyeGiris = new System.Windows.Forms.Button();
            this.btn_menuUyeGiris = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_kaydol
            // 
            this.lbl_kaydol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kaydol.AutoSize = true;
            this.lbl_kaydol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_kaydol.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kaydol.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_kaydol.Location = new System.Drawing.Point(153, 2);
            this.lbl_kaydol.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_kaydol.Name = "lbl_kaydol";
            this.lbl_kaydol.Size = new System.Drawing.Size(44, 15);
            this.lbl_kaydol.TabIndex = 12;
            this.lbl_kaydol.Text = "Kaydol";
            this.lbl_kaydol.Click += new System.EventHandler(this.lbl_kaydol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "TC Kimlik No:";
            // 
            // btn_uyeGiris
            // 
            this.btn_uyeGiris.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_uyeGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_uyeGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uyeGiris.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeGiris.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_uyeGiris.Location = new System.Drawing.Point(30, 23);
            this.btn_uyeGiris.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.btn_uyeGiris.Name = "btn_uyeGiris";
            this.btn_uyeGiris.Size = new System.Drawing.Size(290, 44);
            this.btn_uyeGiris.TabIndex = 13;
            this.btn_uyeGiris.Text = "Giriş Yap";
            this.btn_uyeGiris.UseVisualStyleBackColor = false;
            this.btn_uyeGiris.Click += new System.EventHandler(this.btn_uyeGiris_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şifre:";
            // 
            // tbx_sifreGiris
            // 
            this.tbx_sifreGiris.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_sifreGiris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_sifreGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_sifreGiris.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_sifreGiris.Location = new System.Drawing.Point(3, 123);
            this.tbx_sifreGiris.Name = "tbx_sifreGiris";
            this.tbx_sifreGiris.Size = new System.Drawing.Size(194, 23);
            this.tbx_sifreGiris.TabIndex = 11;
            this.tbx_sifreGiris.UseSystemPasswordChar = true;
            // 
            // tbx_tcGiris
            // 
            this.tbx_tcGiris.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbx_tcGiris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_tcGiris.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_tcGiris.Location = new System.Drawing.Point(3, 23);
            this.tbx_tcGiris.Name = "tbx_tcGiris";
            this.tbx_tcGiris.Size = new System.Drawing.Size(194, 23);
            this.tbx_tcGiris.TabIndex = 10;
            // 
            // btn_titleUyeGiris
            // 
            this.btn_titleUyeGiris.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleUyeGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titleUyeGiris.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleUyeGiris.FlatAppearance.BorderSize = 0;
            this.btn_titleUyeGiris.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleUyeGiris.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleUyeGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titleUyeGiris.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titleUyeGiris.ForeColor = System.Drawing.Color.White;
            this.btn_titleUyeGiris.Location = new System.Drawing.Point(0, 0);
            this.btn_titleUyeGiris.Name = "btn_titleUyeGiris";
            this.btn_titleUyeGiris.Size = new System.Drawing.Size(350, 60);
            this.btn_titleUyeGiris.TabIndex = 22;
            this.btn_titleUyeGiris.Text = "ÜYE GİRİŞİ";
            this.btn_titleUyeGiris.UseVisualStyleBackColor = false;
            this.btn_titleUyeGiris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_titleUyeGiris_MouseDown);
            this.btn_titleUyeGiris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_titleUyeGiris_MouseMove);
            this.btn_titleUyeGiris.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_titleUyeGiris_MouseUp);
            // 
            // btn_menuUyeGiris
            // 
            this.btn_menuUyeGiris.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_menuUyeGiris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_menuUyeGiris.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_menuUyeGiris.FlatAppearance.BorderSize = 0;
            this.btn_menuUyeGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuUyeGiris.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuUyeGiris.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_menuUyeGiris.Location = new System.Drawing.Point(0, 510);
            this.btn_menuUyeGiris.Name = "btn_menuUyeGiris";
            this.btn_menuUyeGiris.Size = new System.Drawing.Size(350, 40);
            this.btn_menuUyeGiris.TabIndex = 23;
            this.btn_menuUyeGiris.Text = "Menü";
            this.btn_menuUyeGiris.UseVisualStyleBackColor = false;
            this.btn_menuUyeGiris.Click += new System.EventHandler(this.btn_menuUye_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbx_tcGiris, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbx_sifreGiris, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 200);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 150);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_uyeGiris, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_kaydol, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 440);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 70);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // Form_UyeGiris
            // 
            this.AcceptButton = this.btn_uyeGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_menuUyeGiris;
            this.ClientSize = new System.Drawing.Size(350, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btn_menuUyeGiris);
            this.Controls.Add(this.btn_titleUyeGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_UyeGiris";
            this.Text = "Form_Randevu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_kaydol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_uyeGiris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_sifreGiris;
        private System.Windows.Forms.TextBox tbx_tcGiris;
        private System.Windows.Forms.Button btn_titleUyeGiris;
        private System.Windows.Forms.Button btn_menuUyeGiris;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
namespace Quiz10_20160627_MHRS
{
    partial class Form_RandevuAl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_bolumRandevuAl = new System.Windows.Forms.ComboBox();
            this.cmb_doktorRandevuAl = new System.Windows.Forms.ComboBox();
            this.dtp_randevu = new System.Windows.Forms.DateTimePicker();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.cmb_saat = new System.Windows.Forms.ComboBox();
            this.btn_randevuAl = new System.Windows.Forms.Button();
            this.btn_menuRandevuAl = new System.Windows.Forms.Button();
            this.btn_titleRandevuAl = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bölüm seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Doktor seçin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tarih seçin:";
            // 
            // cmb_bolumRandevuAl
            // 
            this.cmb_bolumRandevuAl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_bolumRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_bolumRandevuAl.FormattingEnabled = true;
            this.cmb_bolumRandevuAl.Location = new System.Drawing.Point(3, 23);
            this.cmb_bolumRandevuAl.Name = "cmb_bolumRandevuAl";
            this.cmb_bolumRandevuAl.Size = new System.Drawing.Size(144, 21);
            this.cmb_bolumRandevuAl.TabIndex = 24;
            this.cmb_bolumRandevuAl.SelectionChangeCommitted += new System.EventHandler(this.cmb_bolumRandevuAl_SelectionChangeCommitted);
            // 
            // cmb_doktorRandevuAl
            // 
            this.cmb_doktorRandevuAl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_doktorRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_doktorRandevuAl.FormattingEnabled = true;
            this.cmb_doktorRandevuAl.Location = new System.Drawing.Point(3, 73);
            this.cmb_doktorRandevuAl.Name = "cmb_doktorRandevuAl";
            this.cmb_doktorRandevuAl.Size = new System.Drawing.Size(144, 21);
            this.cmb_doktorRandevuAl.TabIndex = 25;
            // 
            // dtp_randevu
            // 
            this.dtp_randevu.CalendarFont = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_randevu.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_randevu.Location = new System.Drawing.Point(3, 123);
            this.dtp_randevu.Name = "dtp_randevu";
            this.dtp_randevu.Size = new System.Drawing.Size(144, 23);
            this.dtp_randevu.TabIndex = 26;
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(3, 150);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(65, 15);
            this.lbl_saat.TabIndex = 29;
            this.lbl_saat.Text = "Saat seçin:";
            // 
            // cmb_saat
            // 
            this.cmb_saat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_saat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_saat.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_saat.FormattingEnabled = true;
            this.cmb_saat.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00"});
            this.cmb_saat.Location = new System.Drawing.Point(3, 173);
            this.cmb_saat.Name = "cmb_saat";
            this.cmb_saat.Size = new System.Drawing.Size(144, 23);
            this.cmb_saat.TabIndex = 28;
            // 
            // btn_randevuAl
            // 
            this.btn_randevuAl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_randevuAl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_randevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_randevuAl.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_randevuAl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_randevuAl.Location = new System.Drawing.Point(30, 3);
            this.btn_randevuAl.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.btn_randevuAl.Name = "btn_randevuAl";
            this.btn_randevuAl.Size = new System.Drawing.Size(290, 44);
            this.btn_randevuAl.TabIndex = 27;
            this.btn_randevuAl.Text = "Randevu Al";
            this.btn_randevuAl.UseVisualStyleBackColor = false;
            this.btn_randevuAl.Click += new System.EventHandler(this.btn_randevuAl_Click);
            // 
            // btn_menuRandevuAl
            // 
            this.btn_menuRandevuAl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_menuRandevuAl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_menuRandevuAl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_menuRandevuAl.FlatAppearance.BorderSize = 0;
            this.btn_menuRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuRandevuAl.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuRandevuAl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_menuRandevuAl.Location = new System.Drawing.Point(0, 510);
            this.btn_menuRandevuAl.Name = "btn_menuRandevuAl";
            this.btn_menuRandevuAl.Size = new System.Drawing.Size(350, 40);
            this.btn_menuRandevuAl.TabIndex = 29;
            this.btn_menuRandevuAl.Text = "Menü";
            this.btn_menuRandevuAl.UseVisualStyleBackColor = false;
            this.btn_menuRandevuAl.Click += new System.EventHandler(this.btn_menuRandevu_Click);
            // 
            // btn_titleRandevuAl
            // 
            this.btn_titleRandevuAl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleRandevuAl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titleRandevuAl.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleRandevuAl.FlatAppearance.BorderSize = 0;
            this.btn_titleRandevuAl.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleRandevuAl.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titleRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titleRandevuAl.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titleRandevuAl.ForeColor = System.Drawing.Color.White;
            this.btn_titleRandevuAl.Location = new System.Drawing.Point(0, 0);
            this.btn_titleRandevuAl.Name = "btn_titleRandevuAl";
            this.btn_titleRandevuAl.Size = new System.Drawing.Size(350, 60);
            this.btn_titleRandevuAl.TabIndex = 20;
            this.btn_titleRandevuAl.Text = "RANDEVU AL";
            this.btn_titleRandevuAl.UseVisualStyleBackColor = false;
            this.btn_titleRandevuAl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_titleRandevu_MouseDown);
            this.btn_titleRandevuAl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_titleRandevu_MouseMove);
            this.btn_titleRandevuAl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_titleRandevu_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cmb_saat, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_bolumRandevuAl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_saat, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtp_randevu, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmb_doktorRandevuAl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 175);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 200);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_randevuAl, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 460);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 50);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // Form_RandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_menuRandevuAl;
            this.ClientSize = new System.Drawing.Size(350, 550);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_menuRandevuAl);
            this.Controls.Add(this.btn_titleRandevuAl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RandevuAl";
            this.Text = "Form_RandevuAl";
            this.Load += new System.EventHandler(this.Form_RandevuAl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_bolumRandevuAl;
        private System.Windows.Forms.ComboBox cmb_doktorRandevuAl;
        private System.Windows.Forms.DateTimePicker dtp_randevu;
        private System.Windows.Forms.Button btn_randevuAl;
        private System.Windows.Forms.Button btn_menuRandevuAl;
        private System.Windows.Forms.Button btn_titleRandevuAl;
        private System.Windows.Forms.ComboBox cmb_saat;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
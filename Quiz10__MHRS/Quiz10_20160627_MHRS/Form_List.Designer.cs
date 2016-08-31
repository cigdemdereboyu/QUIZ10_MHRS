namespace Quiz10_20160627_MHRS
{
    partial class Form_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_personel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_titlePerList = new System.Windows.Forms.Button();
            this.btn_menuPerList = new System.Windows.Forms.Button();
            this.cmb_departman = new System.Windows.Forms.ComboBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_adminYardimci = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_personel
            // 
            this.dgv_personel.AllowUserToAddRows = false;
            this.dgv_personel.AllowUserToResizeRows = false;
            this.dgv_personel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_personel.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_personel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_personel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_personel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_personel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_personel, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_personel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_personel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_personel.EnableHeadersVisualStyles = false;
            this.dgv_personel.GridColor = System.Drawing.Color.White;
            this.dgv_personel.Location = new System.Drawing.Point(3, 53);
            this.dgv_personel.Name = "dgv_personel";
            this.dgv_personel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_personel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_personel.RowHeadersVisible = false;
            this.dgv_personel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_personel.Size = new System.Drawing.Size(644, 344);
            this.dgv_personel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Görüntülemek istediğiniz departmanı seçin:";
            // 
            // btn_titlePerList
            // 
            this.btn_titlePerList.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titlePerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titlePerList.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titlePerList.FlatAppearance.BorderSize = 0;
            this.btn_titlePerList.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titlePerList.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_titlePerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titlePerList.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titlePerList.ForeColor = System.Drawing.Color.White;
            this.btn_titlePerList.Location = new System.Drawing.Point(0, 0);
            this.btn_titlePerList.Name = "btn_titlePerList";
            this.btn_titlePerList.Size = new System.Drawing.Size(350, 60);
            this.btn_titlePerList.TabIndex = 21;
            this.btn_titlePerList.Text = "PERSONEL LİSTELE";
            this.btn_titlePerList.UseVisualStyleBackColor = false;
            this.btn_titlePerList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_titlePerList_MouseDown);
            this.btn_titlePerList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_titlePerList_MouseMove);
            this.btn_titlePerList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_titlePerList_MouseUp);
            // 
            // btn_menuPerList
            // 
            this.btn_menuPerList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_menuPerList.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_menuPerList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_menuPerList.FlatAppearance.BorderSize = 0;
            this.btn_menuPerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuPerList.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuPerList.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_menuPerList.Location = new System.Drawing.Point(0, 510);
            this.btn_menuPerList.Name = "btn_menuPerList";
            this.btn_menuPerList.Size = new System.Drawing.Size(350, 40);
            this.btn_menuPerList.TabIndex = 22;
            this.btn_menuPerList.Text = "Menü";
            this.btn_menuPerList.UseVisualStyleBackColor = false;
            this.btn_menuPerList.Click += new System.EventHandler(this.btn_menuPerList_Click);
            // 
            // cmb_departman
            // 
            this.cmb_departman.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_departman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_departman.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_departman.FormattingEnabled = true;
            this.cmb_departman.Location = new System.Drawing.Point(3, 23);
            this.cmb_departman.Name = "cmb_departman";
            this.cmb_departman.Size = new System.Drawing.Size(326, 22);
            this.cmb_departman.TabIndex = 23;
            this.cmb_departman.SelectionChangeCommitted += new System.EventHandler(this.cmb_departman_SelectionChangeCommitted);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.btn_guncelle, 2);
            this.btn_guncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_guncelle.Location = new System.Drawing.Point(30, 403);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(590, 44);
            this.btn_guncelle.TabIndex = 24;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Visible = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_adminYardimci
            // 
            this.btn_adminYardimci.AutoSize = true;
            this.btn_adminYardimci.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_adminYardimci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_adminYardimci.FlatAppearance.BorderSize = 0;
            this.btn_adminYardimci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminYardimci.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_adminYardimci.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_adminYardimci.Location = new System.Drawing.Point(353, 23);
            this.btn_adminYardimci.Name = "btn_adminYardimci";
            this.btn_adminYardimci.Size = new System.Drawing.Size(294, 24);
            this.btn_adminYardimci.TabIndex = 25;
            this.btn_adminYardimci.Text = "ID\'lerin karşılıklarını öğren!";
            this.btn_adminYardimci.UseVisualStyleBackColor = false;
            this.btn_adminYardimci.Visible = false;
            this.btn_adminYardimci.Click += new System.EventHandler(this.btn_adminYardimci_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_adminYardimci, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmb_departman, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_guncelle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgv_personel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 450);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // Form_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_menuPerList;
            this.ClientSize = new System.Drawing.Size(350, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_menuPerList);
            this.Controls.Add(this.btn_titlePerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_List";
            this.Text = "Form_List";
            this.Load += new System.EventHandler(this.Form_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_titlePerList;
        private System.Windows.Forms.Button btn_menuPerList;
        private System.Windows.Forms.DataGridView dgv_personel;
        //private System.Windows.Forms.BindingSource mHRSDataSet1BindingSource;
        //private System.Windows.Forms.BindingSource mHRSDataSet1BindingSource1;
        //private System.Windows.Forms.BindingSource mHRSDataSet1BindingSource2;
        private System.Windows.Forms.ComboBox cmb_departman;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_adminYardimci;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
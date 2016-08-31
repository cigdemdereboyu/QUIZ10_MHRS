using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz10_20160627_MHRS
{
    public partial class Form_List : Form
    {
        public Form_List()
        {
            InitializeComponent();
        }
        Form form1;

        private void btn_menuPerList_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
            this.Close();
            form1.Location = this.Location;
        }
        #region dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void btn_titlePerList_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_titlePerList_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_titlePerList_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void Form_List_Load(object sender, EventArgs e)
        {
            SqlConnection conPersonelTip = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);
            SqlDataAdapter daPersonelTip = new SqlDataAdapter("SELECT PersonelTipId, Ad FROM PersonelTip WHERE PersonelTipId<>1", conPersonelTip);
            DataTable dtPersonelTip = new DataTable();
            daPersonelTip.Fill(dtPersonelTip);
            cmb_departman.DataSource = dtPersonelTip;
            cmb_departman.ValueMember = "PersonelTipId";
            cmb_departman.DisplayMember = "Ad";

            if (Form_UyeGiris.adminMod)
            {
                btn_guncelle.Visible = true;
                Width = 650;
                dgv_personel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                btn_titlePerList.Text = "Veri Düzenleme";
                btn_adminYardimci.Visible = true;
                tableLayoutPanel1.SetColumnSpan(dgv_personel, 2);
            }
            else
            {
                dgv_personel.ReadOnly = true;
                dgv_personel.AllowUserToDeleteRows = false;
                tableLayoutPanel1.SetColumnSpan(dgv_personel, 1);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            cb = new SqlCommandBuilder(daPersonel);
            daPersonel.Update(dtPersonel);
        }
        SqlConnection con;
        SqlDataAdapter daPersonel;
        SqlCommandBuilder cb;
        DataTable dtPersonel;
        private void cmb_departman_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!Form_UyeGiris.adminMod)
            {
                con = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);
                if ((int)cmb_departman.SelectedValue == 2)
                {
                    daPersonel = new SqlDataAdapter(
                        "SELECT CONCAT(p.Ad, ' ', p.Soyad) AS [Personel], " +
                        "p.DogumTarihi AS [Doğum Tarihi], " +
                        "b.BolumAd AS [Bölüm] " +
                        "FROM Personel p " +
                        "JOIN Bolum b on b.BolumId=p.BolumId " +
                        "JOIN PersonelTip pt on p.PersonelTipId=pt.PersonelTipId " +
                        "WHERE pt.PersonelTipId=@pId AND p.IsDeleted=0", con);
                    daPersonel.SelectCommand.Parameters.AddWithValue("pId", cmb_departman.SelectedValue);
                    dtPersonel = new DataTable();
                    daPersonel.Fill(dtPersonel);
                    dgv_personel.DataSource = dtPersonel;
                }
                else
                {
                    daPersonel = new SqlDataAdapter(
                        "SELECT CONCAT(p.Ad, ' ', p.Soyad) AS [Personel], " +
                        "p.DogumTarihi AS [Doğum Tarihi] " +
                        "FROM Personel p " +
                        "JOIN PersonelTip pt on p.PersonelTipId=pt.PersonelTipId " +
                        "WHERE pt.PersonelTipId=@pId AND p.IsDeleted=0", con);
                    daPersonel.SelectCommand.Parameters.AddWithValue("pId", cmb_departman.SelectedValue);
                    dtPersonel = new DataTable();
                    daPersonel.Fill(dtPersonel);
                    dgv_personel.DataSource = dtPersonel;
                }
            }
            else
            {
                dgv_personel.ReadOnly = false;
                con = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);
                daPersonel = new SqlDataAdapter(
                    "SELECT PersonelId, Tc AS [TC Kimlik No], Ad, Soyad, " +
                    "DogumTarihi AS [Doğum Tarihi], Cinsiyet, " +
                    "PersonelTipId AS [PersonelTip], BolumId, " +
                    "CreateDate AS [OluşturulmaTarihi], IsDeleted AS [Silindi Mi?]" +
                    "FROM Personel WHERE PersonelTipId=@pId", con);
                daPersonel.SelectCommand.Parameters.AddWithValue("pId", cmb_departman.SelectedValue);
                dtPersonel = new DataTable();
                daPersonel.Fill(dtPersonel);
                dgv_personel.DataSource = dtPersonel;
            }
        }

        private void btn_adminYardimci_Click(object sender, EventArgs e)
        {
            SqlConnection conYardimci = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);
            DataTable dtDepartman = new DataTable();
            SqlDataAdapter daDepartman = new SqlDataAdapter("SELECT PersonelTipId, Ad FROM PersonelTip", conYardimci);
            daDepartman.Fill(dtDepartman);
            DataTable dtBolum = new DataTable();
            SqlDataAdapter daBolum = new SqlDataAdapter("SELECT BolumId, BolumAd FROM Bolum", conYardimci);
            daBolum.Fill(dtBolum);
            string yardimciTablo = "\tBÖLÜMLER İÇİN\n\n";
            foreach (DataRow row in dtBolum.Rows)
            {
                yardimciTablo += row[0].ToString() + "\t" + row[1].ToString()+"\n";
            }
            yardimciTablo += "\n\n\n";
            yardimciTablo += "\tDEPARTMANLAR İÇİN\n\n";
            foreach (DataRow row in dtDepartman.Rows)
            {
                yardimciTablo += row[0].ToString() + "\t" + row[1].ToString() + "\n";
            }

            MessageBox.Show(yardimciTablo, "ID'lerin Karşılıkları", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
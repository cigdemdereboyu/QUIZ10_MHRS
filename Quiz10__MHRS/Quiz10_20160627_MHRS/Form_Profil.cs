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
    public partial class Form_Profil : Form
    {
        public Form_Profil()
        {
            InitializeComponent();
        }

        #region dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void btn_titleProfil_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_titleProfil_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_titleProfil_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
        Form f_randevuAl;
        Form f_profilDuzenle;

        private void btn_menuProfil_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Close();
            form1.Location = this.Location;
            try
            {
                f_profilDuzenle.Close();
            }
            catch (Exception)
            {
            }
        }

        SqlConnection con;
        SqlDataAdapter daRandevu;
        DataTable dtRandevu;
        private void Form_Profil_Load(object sender, EventArgs e)
        {
            rtb_bilgilerHasta.Visible = true;
            dgv_randevuHasta.Visible = false;
            dgv_recete.Visible = false;
            tableLayoutPanel2.SetColumnSpan(rtb_bilgilerHasta, 3);
            cmb_receteHasta.Visible = false;

            con = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta WHERE Tc=@pTc", con);
            da.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string cinsiyet = dt.Rows[0][5].ToString() == "False" ? "Kadın" : "Erkek";
            rtb_bilgilerHasta.Text =
                "TC: " + dt.Rows[0][1].ToString() + "\n" +
                "Ad: " + dt.Rows[0][2].ToString() + "\n" +
                "Soyad: " + dt.Rows[0][3].ToString() + "\n" +
                "Doğum Tarihi: " + ((DateTime)dt.Rows[0][4]).ToLongDateString() + "\n" +
                "Cinsiyet: " + cinsiyet + "\n" +
                "Kayıt Tarihi: " + ((DateTime)dt.Rows[0][10]).ToLongDateString();
            btn_titleProfil.Text = "Hoşgeldiniz! " + dt.Rows[0][2].ToString().ToUpper() + " " + dt.Rows[0][3].ToString().ToUpper();

            //Üyenin oturum açık özelliğini açar
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.GetUpdateCommand();
            dt.Rows[0][9] = true;
            da.Update(dt);

            //Üyenin randevularını DataGridView'e getirir
            daRandevu = new SqlDataAdapter(
                "SELECT r.RandevuSaati AS [Randevu Saati], CONCAT(p.Ad, ' ', p.Soyad) AS Doktor, b.BolumAd AS [Bölüm], " +
                "r.CreateDate AS [Alındığı Tarih] "+
                "FROM Randevu r JOIN Personel p on p.PersonelId=r.PersonelId " +
                "JOIN Bolum b on b.BolumId=p.BolumId " +
                "JOIN Hasta h on h.HastaId=r.HastaId " +
                "WHERE h.Tc=@pTc AND r.IsDeleted=0", con);
            daRandevu.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            dtRandevu = new DataTable();
            daRandevu.Fill(dtRandevu);
            dgv_randevuHasta.DataSource = dtRandevu;

            //Üyenin reçetelerini tarihe göre listeletip getirir
            SqlDataAdapter daReceteTarih = new SqlDataAdapter(
                "SELECT r.CreateDate AS asCreateDate, r.ReceteId AS asReceteId FROM recete r join Hasta h on h.HastaId=r.HastaId WHERE Tc=@pTc", con);
            daReceteTarih.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dtReceteTarih = new DataTable();
            daReceteTarih.Fill(dtReceteTarih);
            cmb_receteHasta.DataSource = dtReceteTarih;
            cmb_receteHasta.DisplayMember = "asCreateDate";
            cmb_receteHasta.ValueMember = "asReceteId";
        }
        private void btn_randevuAl_Click(object sender, EventArgs e)
        {
            f_randevuAl = new Form_RandevuAl();
            f_randevuAl.Show();
            f_randevuAl.Location = Location;
            Hide();
        }

        private void btn_uyeOturumuKapat_Click(object sender, EventArgs e)
        {
            //Üyenin oturum açık özelliğini kapatır
            SqlDataAdapter da = new SqlDataAdapter("SELECT HastaId, Tc, IsOturumAcik FROM Hasta WHERE Tc=@pTc", con);
            da.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.GetUpdateCommand();
            dt.Rows[0][2] = false;
            da.Update(dt);

            Form_UyeGiris.TcGiris = null;
            Form form1 = new Form1();
            form1.Show();
            Close();
            form1.Location = this.Location;
        }

        private void btn_sifreDegistir_Click(object sender, EventArgs e)
        {
            f_profilDuzenle = new Form_ProfilDuzenle();
            f_profilDuzenle.Show();
        }

        private void btn_profilSil_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta WHERE Tc=@pTc", con);
            da.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Rows[0][11] = true;
            dt.Rows[0][9] = false;
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.GetUpdateCommand();
            da.Update(dt);
            Form_UyeGiris.TcGiris = null;
            MessageBox.Show("Kaydınız başarıyla silindi");
            Form form1 = new Form1();
            form1.Show();
            this.Close();
            form1.Location = this.Location;
        }

        private void cmb_receteHasta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter daReceteSonuc = new SqlDataAdapter(
                    "SELECT * FROM ReceteIlac WHERE ReceteId=@pId", con);
                daReceteSonuc.SelectCommand.Parameters.AddWithValue("pId", (int)cmb_receteHasta.SelectedValue);
                DataTable dtReceteSonuc = new DataTable();
                daReceteSonuc.Fill(dtReceteSonuc);
                dgv_recete.DataSource = dtReceteSonuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_randevuHasta_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DateTime silinenRowunKayitTarihi = (DateTime)(dgv_randevuHasta.SelectedRows[0].Cells[3].Value);
            SqlCommand comDelete=new SqlCommand("UPDATE Randevu SET IsDeleted=1 WHERE CreateDate=@pCreateDate",con);
            comDelete.Parameters.AddWithValue("pCreateDate", (DateTime)silinenRowunKayitTarihi);
            con.Open();
            comDelete.ExecuteNonQuery();
            con.Close();
            daRandevu.Update(dtRandevu);
        }

        private void btn_bilgiler_Click(object sender, EventArgs e)
        {
            rtb_bilgilerHasta.Visible = true;
            tableLayoutPanel2.Controls.Add(rtb_bilgilerHasta, 0, 1);
            dgv_randevuHasta.Visible = false;
            dgv_recete.Visible = false;
            tableLayoutPanel2.SetColumnSpan(rtb_bilgilerHasta, 3);
            cmb_receteHasta.Visible = false;
        }

        private void btn_randevular_Click(object sender, EventArgs e)
        {
            rtb_bilgilerHasta.Visible = false;
            tableLayoutPanel2.Controls.Add(dgv_randevuHasta, 0, 1);
            dgv_randevuHasta.Visible = true;
            dgv_recete.Visible = false;
            tableLayoutPanel2.SetColumnSpan(dgv_randevuHasta, 3);
            cmb_receteHasta.Visible = false;
        }

        private void btn_receteler_Click(object sender, EventArgs e)
        {
            rtb_bilgilerHasta.Visible = false;
            tableLayoutPanel2.Controls.Add(dgv_recete, 0, 1);
            dgv_randevuHasta.Visible = false;
            dgv_recete.Visible = true;
            tableLayoutPanel2.SetColumnSpan(dgv_recete, 3);
            cmb_receteHasta.Visible = true;
        }
    }
}

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
    public partial class Form_RandevuOzet : Form
    {
        public Form_RandevuOzet()
        {
            InitializeComponent();

        }
        Form form1;
        Form f_profil;
        private void btn_menuRandevuOzet_Click(object sender, EventArgs e)
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
        private void btn_titleRandevuOzet_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_titleRandevuOzet_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_titleRandevuOzet_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void btn_profileGit_Click(object sender, EventArgs e)
        {
            f_profil = new Form_Profil();
            f_profil.Show();
            this.Close();
            f_profil.Location = this.Location;
        }

        private void Form_RandevuOzet_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT CONCAT(h.Ad, ' ', h.Soyad) AS HastaAd, " +
                "CONCAT(p.Ad, ' ', p.Soyad) AS DoktorAd, BolumAd, RandevuSaati, r.CreateDate " +
                "FROM Hasta h " +
                "join Randevu r on r.HastaId = h.HastaId " +
                "join Personel p on p.PersonelId = r.PersonelId " +
                "join Bolum b on b.BolumId = p.BolumId WHERE r.RandevuId=@pRandevuId", con);
            da.SelectCommand.Parameters.AddWithValue("pRandevuId", Form_RandevuAl.sonRandevuId);
            DataTable dt = new DataTable();
            da.Fill(dt);

            rtb_randevuOzet.Text =
                "Sayın " +
                dt.Rows[0][0].ToString() + ",\n" +
                "Dr. " +
                dt.Rows[0][1].ToString() + " için\n" +
                dt.Rows[0][2].ToString() + " bölümüne kaydınız yapılmıştır.\n" +
                "Randevu Tarihi: " +
                ((DateTime)dt.Rows[0][3]).ToLongDateString() + "\nRandevuya Kayıt: " + ((DateTime)dt.Rows[0][4]).ToLongDateString();
        }
    }
}

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
    public partial class Form_ProfilDuzenle : Form
    {
        public Form_ProfilDuzenle()
        {
            InitializeComponent();
        }
        #region dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void btn_titleGuncelle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void btn_titleGuncelle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void btn_titleGuncelle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);

            SqlDataAdapter daHasta = new SqlDataAdapter("SELECT HastaId, Tc, Sifre FROM Hasta WHERE Tc=@pTc", con);
            daHasta.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dtHasta = new DataTable();
            daHasta.Fill(dtHasta);

            SqlDataAdapter daPersonel = new SqlDataAdapter("SELECT PersonelId, Tc, Sifre FROM Personel WHERE Tc = @pTc", con);
            daPersonel.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dtPersonel = new DataTable();
            daPersonel.Fill(dtPersonel);

            if (tbx_yeniSifre.Text.Equals(tbx_yeniSifre2.Text))
            {
                if (tbx_yeniSifre.TextLength == 0)
                {
                    MessageBox.Show("Lütfen bir şifre giriniz");
                    return;
                }
                try
                {
                    dtHasta.Rows[0][2] = tbx_yeniSifre.Text;
                    SqlCommandBuilder cb = new SqlCommandBuilder(daHasta);
                    cb.GetUpdateCommand();
                    daHasta.Update(dtHasta);
                    MessageBox.Show("Şifre başarıyla güncellendi");
                    Hide();
                }
                catch (Exception)
                {
                    dtPersonel.Rows[0][2] = tbx_yeniSifre.Text;
                    SqlCommandBuilder cb = new SqlCommandBuilder(daPersonel);
                    cb.GetUpdateCommand();
                    daPersonel.Update(dtPersonel);
                    MessageBox.Show("Şifre başarıyla güncellendi");
                    Hide();
                }
            }

            else
            {
                MessageBox.Show("Şifre doğrulaması başarısız\nLütfen yeni şifreyi iki kez girin");
                tbx_yeniSifre.Clear();
                tbx_yeniSifre2.Clear();
            }
        }

        private void btn_geriGuncelle_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

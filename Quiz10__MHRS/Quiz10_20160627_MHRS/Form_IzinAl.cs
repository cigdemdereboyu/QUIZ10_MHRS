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
    public partial class Form_IzinAl : Form
    {
        public Form_IzinAl()
        {
            InitializeComponent();
        }
        #region None-styled window sürükleme (dragging)
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void btn_titleIzinAl_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void btn_titleIzinAl_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void btn_titleIzinAl_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        Form form_1;

        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommandBuilder cb;
        private void btn_izinAl_Click(object sender, EventArgs e)
        {            
            da = new SqlDataAdapter("SELECT * FROM PersonelIzin", con);
            dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr[1] = IdBul();
            dr[2] = dtp_baslangic.Value;
            dr[3] = dtp_bitis.Value;
            dr[4] = DateTime.Now;
            dr[5] = false;

            cb = new SqlCommandBuilder(da);
            cb.GetUpdateCommand();
            dt.Rows.Add(dr);
            
            if ((dtp_baslangic.Value <= dtp_bitis.Value) && (dtp_baslangic.Value >= DateTime.Now))
            {
                if (!IzinIzinCakisiyorMu(dtp_baslangic.Value, dtp_bitis.Value))
                {
                    if (TopIzinGunuBul() < 30)
                    {
                        da.Update(dt);
                        MessageBox.Show("İzin alma işlemi başarılı",
                            "İşlem Başarılı",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("İzin alma işlemi gerçekleştirilemedi.\n\nİzin hakkınız dolmuş!",
                            "İşlem Başarısız",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                    }
                }
            }
            else
            {
                MessageBox.Show("İzin alma işlemi gerçekleştirilemedi", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private int IdBul()
        {
            con = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);
            SqlDataAdapter daIdBul = new SqlDataAdapter("SELECT PersonelId, Tc FROM Personel WHERE Tc=@pTc", con);
            DataTable dtIdBul = new DataTable();
            daIdBul.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            daIdBul.Fill(dtIdBul);
            int id = (int)(dtIdBul.Rows[0][0]);
            return id;
        }


        private int TopIzinGunuBul()
        {
            int topIzin = 0;
            SqlDataAdapter daIzinKontrol = new SqlDataAdapter(
                "SELECT SUM((DATEDIFF(DAY, BaslamaTarihi, BitisTarihi)) + 1)" +
                "FROM PersonelIzin WHERE PersonelId =@pId AND BitisTarihi > @pYilinIlkGunu", con);
            daIzinKontrol.SelectCommand.Parameters.AddWithValue("pId", IdBul());
            daIzinKontrol.SelectCommand.Parameters.AddWithValue("@pYilinIlkGunu", new DateTime(DateTime.Now.Year, 1, 1));
            con.Open();
            try
            {
                topIzin = (int)daIzinKontrol.SelectCommand.ExecuteScalar() + ((dtp_bitis.Value.Date - dtp_baslangic.Value.Date).Days + 1);
            }
            catch (Exception)
            {
                topIzin = (dtp_bitis.Value - dtp_baslangic.Value).Days + 1;
            }
            con.Close();
            return topIzin;
        }

        private bool IzinIzinCakisiyorMu(DateTime izinTalepBaslangic, DateTime izinTalepBitis)
        {
            izinTalepBaslangic = izinTalepBaslangic.Date;
            izinTalepBitis = izinTalepBitis.Date;
            bool izinIzinCakisma = false;
            SqlDataAdapter daIzinler = new SqlDataAdapter(
                "SELECT BaslamaTarihi, BitisTarihi " +
                "FROM PersonelIzin pin JOIN Personel p on p.PersonelId = pin.personelId " +
                "WHERE p.Tc = @pTc AND pin.IsDeleted = 0 " +
                "AND BitisTarihi >= @pBugununTarihi", con);
            daIzinler.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            daIzinler.SelectCommand.Parameters.AddWithValue("pBugununTarihi", DateTime.Now.Date);
            DataTable dtIzinler = new DataTable();
            daIzinler.Fill(dtIzinler);

            if (dtIzinler.Rows.Count == 0)
            {
                return false;
            }

            foreach (DataRow row in dtIzinler.Rows)
            {
                if (
                    (
                        (izinTalepBaslangic < ((DateTime)row[0])) &&
                        (izinTalepBitis < ((DateTime)row[0]))
                    )
                    ||
                    (
                        (izinTalepBaslangic > ((DateTime)row[1])) &&
                        (izinTalepBitis > ((DateTime)row[1]))
                    )
                   )
                {
                    izinIzinCakisma = false;
                }
                else
                {
                    izinIzinCakisma = true;
                    MessageBox.Show("Seçtiğiniz tarihte zaten izniniz var" +
                        "\nİzin başlangıç tarihi: " + ((DateTime)row[0]).ToShortDateString() +
                        "\nİzin bitiş tarihi: " + ((DateTime)row[1]).ToShortDateString());
                    break;
                }
            }
            return izinIzinCakisma;
        }

        private void btn_menuIzinAl_Click(object sender, EventArgs e)
        {
            form_1 = new Form1();
            form_1.Show();
            form_1.Location = Location;
            Close();
        }
        SqlDataAdapter daIzinler;
        DataTable dtIzinler;
        private void Form_IzinAl_Load(object sender, EventArgs e)
        {
            IzinBilgileriYazdir();
            dtp_baslangic.MinDate = DateTime.Now;
            dtp_bitis.MinDate = DateTime.Now;
            con = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);
            IzinBilgileriYazdir();
            daIzinler = new SqlDataAdapter("SELECT BaslamaTarihi AS [İzin Başlangıç], " +
                "BitisTarihi AS [İzin Bitiş], " +
                "CreateDate AS [Alındığı Gün] " +
                "FROM PersonelIzin", con);
            dtIzinler = new DataTable();
            daIzinler.Fill(dtIzinler);
            dgv_izin.DataSource = dtIzinler;
        }

        private void dtp_baslangic_ValueChanged(object sender, EventArgs e)
        {
            IzinBilgileriYazdir();
        }
        private void dtp_bitis_ValueChanged(object sender, EventArgs e)
        {
            IzinBilgileriYazdir();
        }
        private void IzinBilgileriYazdir()
        {
            lbl_gecmisIzin.Text = "Bu yıl " + (TopIzinGunuBul() - ((int)((dtp_bitis.Value - dtp_baslangic.Value).TotalDays) + 1)).ToString() + " gün izin kullandınız";
            lbl_simdikiIzin.Text = "Şu anda " + ((int)((dtp_bitis.Value.Date - dtp_baslangic.Value.Date).TotalDays+1)) + " günlük izin talep etmektesiniz";

            int kalanIzin = 30 - TopIzinGunuBul();
            if (kalanIzin >= 0)
            {
                lbl_izinOzet.ForeColor = Color.LimeGreen;
                lbl_izinOzet.Text = "Bu yıl toplam "
                    + kalanIzin + " gün izniniz kalacak";
                btn_izinAl.Enabled = true;
            }
            else
            {
                lbl_izinOzet.ForeColor = Color.Red;
                lbl_izinOzet.Text = "Yıllık izin hakkınızı aşamazsınız";
                btn_izinAl.Enabled = false;
            }
        }

        private void dgv_izin_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DateTime silinenRowunKayitTarihi = (DateTime)(dgv_izin.SelectedRows[0].Cells[0].Value);
            SqlCommand comDelete = new SqlCommand("UPDATE PersonelIzin SET IsDeleted=1 WHERE BaslamaTarihi=@pBasTarih", con);
            comDelete.Parameters.AddWithValue("pBasTarih", (DateTime)silinenRowunKayitTarihi);
            con.Open();
            comDelete.ExecuteNonQuery();
            con.Close();
            daIzinler.Update(dtIzinler);
        }
    }
}

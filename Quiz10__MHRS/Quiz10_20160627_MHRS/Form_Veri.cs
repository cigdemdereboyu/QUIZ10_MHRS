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
    public partial class Form_Veri : Form
    {
        public Form_Veri()
        {
            InitializeComponent();
        }
        Form form1;

        #region dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void btn_titleVeriGiris_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_titleVeriGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_titleVeriGiris_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void btn_menuVeri_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
            this.Close();
            form1.Location = this.Location;
        }
        static DataTable dt = new DataTable();

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personel", con);
            da.Fill(dt);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.GetInsertCommand();
            DataRow dr = dt.NewRow();
            dr[1] = tbx_tcPersonel.Text;
            dr[2] = tbx_personelAd.Text;
            dr[3] = tbx_personelSoyad.Text;
            dr[4] = dtp_dogumTarihiPersonel.Value;
            dr[5] = cmb_cinsiyetPersonel.Text == "Kadın" ? false : true;
            dr[6] = tbx_personelAd.Text + "123";
            dr[7] = cmb_departmanVeri.SelectedValue;
            dr[8] = cmb_bolumYaDaDoktor.SelectedValue;
            dr[9] = new byte[5] { 1, 0, 1, 0, 1 };
            dr[10] = "FotoYolu";
            dr[11] = false;
            dr[12] = DateTime.Now;
            dt.Rows.Add(dr);
            if (KayitGecerliMi(dr))
            {
                da.Update(dt);
                MessageBox.Show("Kayıt başarılı");
            }            
        }

        private void Form_Veri_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);

            SqlDataAdapter da = new SqlDataAdapter("SELECT PersonelTipId, Ad FROM PersonelTip WHERE Ad<>'Admin'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_departmanVeri.DataSource = dt;
            cmb_departmanVeri.DisplayMember = "Ad";
            cmb_departmanVeri.ValueMember = "PersonelTipId";

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Bolum", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmb_bolumYaDaDoktor.DataSource = dt2;
            cmb_bolumYaDaDoktor.DisplayMember = "BolumAd";
            cmb_bolumYaDaDoktor.ValueMember = "BolumId";

            SqlDataAdapter da3 = new SqlDataAdapter("SELECT * FROM Personel WHERE Tc=@pTc", con);
            da3.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            SqlCommandBuilder cb = new SqlCommandBuilder(da3);
            cb.GetUpdateCommand();
            dt3.Rows[0][11] = true;
            da3.Update(dt3);
        }

        private void btn_adminOturumuKapat_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personel WHERE Tc=@pTc", con);
            da.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dt3 = new DataTable();
            da.Fill(dt3);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.GetUpdateCommand();
            dt3.Rows[0][11] = false;
            da.Update(dt3);

            Form_UyeGiris.TcGiris = null;
            Form_UyeGiris.adminMod = false;
            form1 = new Form1();
            form1.Show();
            Hide();
            form1.Location = Location;
        }

        private void cmb_departmanVeri_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((int)cmb_departmanVeri.SelectedValue == 2)
            {
                cmb_bolumYaDaDoktor.Visible = true;
                lbl_personelBilgi.Visible = true;
            }
            else
            {
                cmb_bolumYaDaDoktor.Visible = false;
                lbl_personelBilgi.Visible = false;
            }
        }

        private bool KayitGecerliMi(DataRow yeniRow)
        {
            bool kayitDevam = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);
            SqlDataAdapter daTumKayitlar = new SqlDataAdapter(
                "SELECT Tc FROM Hasta UNION SELECT Tc FROM Personel ORDER BY Tc ASC", con);
            DataTable dtTumKayitlar = new DataTable();
            daTumKayitlar.Fill(dtTumKayitlar);

            foreach (DataRow row in dtTumKayitlar.Rows)
            {
                if (row[0].ToString().TrimEnd() == yeniRow[1].ToString())
                {
                    MessageBox.Show("Bu TC Kimlik No zaten kayıtlı");
                    kayitDevam = false;
                    break;
                }
                else
                {
                    kayitDevam = true;
                }
            }
            return kayitDevam;
        }
    }
}

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
    public partial class Form_ReceteYaz : Form
    {
        public Form_ReceteYaz()
        {
            InitializeComponent();
        }
        #region None-styled window sürükleme (dragging)
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void btn_titleReceteYaz_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_titleReceteYaz_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_titleReceteYaz_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
        Form f_ProfilDoktor;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConnectionString);
        int olusturulanReceteId;
        List<int> eklenecekIlaclar = new List<int>();

        private void btn_profileGit_Click(object sender, EventArgs e)
        {
            f_ProfilDoktor = new Form_ProfilDoktor();
            f_ProfilDoktor.Show();
            f_ProfilDoktor.Location = Location;
            Hide();
        }

        private void Form_ReceteYaz_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ilac", con);
            da.Fill(dt);
            cmb_ilac.DataSource = dt;
            cmb_ilac.ValueMember = "IlacId";
            cmb_ilac.DisplayMember = "Ad";
        }


        private void btn_receteOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                //Reçetenin muhatapı olan doktor ve hasta için veritabanına reçete kaydı yapar
                SqlCommand com = new SqlCommand("sp_InsertRecete", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("hastaId", HastaIdBul());
                com.Parameters.AddWithValue("personelId", DoktorIdBul());
                com.Parameters.AddWithValue("createDate", DateTime.Now);
                com.Parameters.AddWithValue("isDeleted", 0);
                SqlParameter pReceteId = new SqlParameter();
                pReceteId.ParameterName = "@receteId";
                pReceteId.DbType = DbType.Int32;
                pReceteId.Direction = ParameterDirection.Output;
                com.Parameters.Add(pReceteId);

                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                olusturulanReceteId = Convert.ToInt32(com.Parameters["@receteId"].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir TC Kimlik No girin!");
            }
        }

        private void btn_ilacEkle_Click(object sender, EventArgs e)
        {
            try
            {
                rtb_ilaclar.AppendText(cmb_ilac.GetItemText(cmb_ilac.SelectedItem) + "\n");
                eklenecekIlaclar.Add((int)cmb_ilac.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_receteKaydet_Click(object sender, EventArgs e)
        {
            if (eklenecekIlaclar.Count == 0)
            {
                MessageBox.Show("Lütfen öncelikle bir reçete oluşturun");
                return;
            }
            SqlDataAdapter daReceteKaydet = new SqlDataAdapter("SELECT * FROM ReceteIlac", con);
            DataTable dtReceteKaydet = new DataTable();
            daReceteKaydet.Fill(dtReceteKaydet);
            foreach (int item in eklenecekIlaclar)
            {
                DataRow dr = dtReceteKaydet.NewRow();
                dr[1] = olusturulanReceteId;
                dr[2] = item;
                dr[3] = false;
                dtReceteKaydet.Rows.Add(dr);
            }
            SqlCommandBuilder cbReceteKaydet = new SqlCommandBuilder(daReceteKaydet);
            cbReceteKaydet.GetInsertCommand();
            try
            {
                daReceteKaydet.Update(dtReceteKaydet);
                f_ProfilDoktor = new Form_ProfilDoktor();
                f_ProfilDoktor.Show();
                f_ProfilDoktor.Location = Location;
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen öncelikle bir reçete oluşturun");
            }
            finally
            {
                eklenecekIlaclar.Clear();
                rtb_ilaclar.Clear();
            }
        }
        private int HastaIdBul()
        {
            //Reçetenin yazılacağı hastanın id'sini bulur
            int hastaId;
            SqlDataAdapter daHastaBul = new SqlDataAdapter("SELECT * FROM Hasta WHERE Tc=@pTcHasta", con);
            daHastaBul.SelectCommand.Parameters.AddWithValue("pTcHasta", tbx_hastaTc.Text);
            DataTable dtHastaBul = new DataTable();
            daHastaBul.Fill(dtHastaBul);
            hastaId = (int)dtHastaBul.Rows[0][0];
            return hastaId;
        }
        private int DoktorIdBul()
        {
            //Reçeteyi yazacak doktorun id'sini bulur
            int doktorId;
            SqlDataAdapter daDoktorBul = new SqlDataAdapter("SELECT * FROM Personel WHERE Tc=@pTcDoktor", con);
            daDoktorBul.SelectCommand.Parameters.AddWithValue("pTcDoktor", Form_UyeGiris.TcGiris);
            DataTable dtDoktorBul = new DataTable();
            daDoktorBul.Fill(dtDoktorBul);
            doktorId = (int)dtDoktorBul.Rows[0][0];
            return doktorId;
        }
    }
}

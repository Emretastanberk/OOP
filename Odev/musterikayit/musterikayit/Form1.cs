using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace musterikayit
{
    public partial class Form1 : Form
    {

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmreDB;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);






            baglanti.Open();

            baglanti.Close();



            SqlCommand komut = new SqlCommand("INSERT INTO Kisiler (Ad, Soyad) VALUES (@ad, @soyad)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            lblDurum.Text = "Ekleme işi başarılı bir şekilde tamamlandı!";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Kisiler";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvListele.DataSource = table;
            }
        }
    }
}

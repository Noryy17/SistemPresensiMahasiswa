using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemPresensiMahasiswa
{
    public partial class GenerateLaporan : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
        "Data Source=.\\RIZQIHUDAYA;Initial Catalog=SistemPresensiDB;Integrated Security=True";

        public GenerateLaporan()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            btnGenerate.Click += btnGenerate_Click;
            this.Load += GenerateLaporan_Load;
        }

        private void GenerateLaporan_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter daMk = new SqlDataAdapter(
                    "SELECT id_matakuliah, nama_mk FROM Matakuliah ORDER BY nama_mk", conn);
                DataTable dtMk = new DataTable();
                daMk.Fill(dtMk);
                comboBox1.DataSource = dtMk;
                comboBox1.DisplayMember = "nama_mk";
                comboBox1.ValueMember = "id_matakuliah";

                SqlDataAdapter daDs = new SqlDataAdapter(
                    "SELECT id_dosen, nama FROM Dosen ORDER BY nama", conn);
                DataTable dtDs = new DataTable();
                daDs.Fill(dtDs);
                comboBox2.DataSource = dtDs;
                comboBox2.DisplayMember = "nama";
                comboBox2.ValueMember = "id_dosen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal muat filter: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Pilih mata kuliah dan dosen.");
                return;
            }

            DateTime t1 = dateTimePicker1.Value.Date;
            DateTime t2 = dateTimePicker3.Value.Date;
            if (t1 > t2)
            {
                MessageBox.Show("Tanggal awal tidak boleh lebih besar dari tanggal akhir.");
                return;
            }

            try
            {
                conn.Open();
                string sql = @"SELECT p.tanggal, m.nim, m.nama, p.status
FROM Presensi p
INNER JOIN Mahasiswa m ON m.id_mahasiswa = p.id_mahasiswa
WHERE p.id_matakuliah = @idMk AND p.id_dosen = @idDs
  AND p.tanggal >= @t1 AND p.tanggal <= @t2
ORDER BY p.tanggal, m.nim";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idMk", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@idDs", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@t1", t1);
                cmd.Parameters.AddWithValue("@t2", t2);

                dataGridView1.Rows.Clear();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        dataGridView1.Rows.Add(
                            Convert.ToDateTime(r["tanggal"]).ToString("yyyy-MM-dd"),
                            r["nim"].ToString(),
                            r["nama"].ToString(),
                            r["status"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal generate: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardAdmin dashboardAdminForm = new DashboardAdmin();
            dashboardAdminForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

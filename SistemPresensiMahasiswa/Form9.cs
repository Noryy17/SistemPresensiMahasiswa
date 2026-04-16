using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemPresensiMahasiswa
{
    public partial class RekapPresensi : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=.\\RIZQIHUDAYA;Initial Catalog=SistemPresensiDB;Integrated Security=True";

        public RekapPresensi()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            this.Load += RekapPresensi_Load;
        }

        private void RekapPresensi_Load(object sender, EventArgs e)
        {
            if (Sesi.IdDosen <= 0)
            {
                MessageBox.Show("Sesi dosen tidak valid. Login ulang.");
                return;
            }
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_matakuliah, nama_mk FROM Matakuliah ORDER BY nama_mk", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "nama_mk";
                comboBox1.ValueMember = "id_matakuliah";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal muat mata kuliah: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Sesi.IdDosen <= 0)
            {
                MessageBox.Show("Sesi dosen tidak valid.");
                return;
            }
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Pilih mata kuliah.");
                return;
            }

            DateTime t1 = dateTimePicker1.Value.Date;
            DateTime t2 = dateTimePicker2.Value.Date;
            if (t1 > t2)
            {
                MessageBox.Show("Tanggal awal tidak boleh lebih besar dari tanggal akhir.");
                return;
            }

            int idMk = Convert.ToInt32(comboBox1.SelectedValue);

            try
            {
                conn.Open();
                string sql = @"SELECT m.nim, m.nama,
    ISNULL(SUM(CASE WHEN p.status = 'Hadir' THEN 1 END), 0) AS j_hadir,
    ISNULL(SUM(CASE WHEN p.status = 'Izin' THEN 1 END), 0) AS j_izin,
    ISNULL(SUM(CASE WHEN p.status = 'Sakit' THEN 1 END), 0) AS j_sakit,
    ISNULL(SUM(CASE WHEN p.status = 'Alpa' THEN 1 END), 0) AS j_alpa
FROM Mahasiswa m
INNER JOIN KRS k ON k.id_mahasiswa = m.id_mahasiswa AND k.id_matakuliah = @idMk
LEFT JOIN Presensi p ON p.id_mahasiswa = m.id_mahasiswa
    AND p.id_matakuliah = @idMk
    AND p.id_dosen = @idDos
    AND p.tanggal >= @t1 AND p.tanggal <= @t2
GROUP BY m.id_mahasiswa, m.nim, m.nama
ORDER BY m.nim";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idMk", idMk);
                cmd.Parameters.AddWithValue("@idDos", Sesi.IdDosen);
                cmd.Parameters.AddWithValue("@t1", t1);
                cmd.Parameters.AddWithValue("@t2", t2);

                dataGridView1.Rows.Clear();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        dataGridView1.Rows.Add(
                            r["nim"].ToString(),
                            r["nama"].ToString(),
                            r["j_hadir"].ToString(),
                            r["j_izin"].ToString(),
                            r["j_sakit"].ToString(),
                            r["j_alpa"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal muat rekap: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardDosen dashboardDosen = new DashboardDosen();
            dashboardDosen.Show();
        }
    }
}

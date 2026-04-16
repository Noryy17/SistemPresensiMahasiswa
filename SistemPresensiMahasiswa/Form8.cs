using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemPresensiMahasiswa
{
    public partial class InputPresensi : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=.\\RIZQIHUDAYA;Initial Catalog=SistemPresensiDB;Integrated Security=True";

        public InputPresensi()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            ColStatusPresensi.Items.AddRange("Hadir", "Izin", "Sakit", "Alpa");
            this.Load += InputPresensi_Load;
        }

        private void InputPresensi_Load(object sender, EventArgs e)
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
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Pilih mata kuliah.");
                return;
            }
            int idMk = Convert.ToInt32(comboBox1.SelectedValue);

            try
            {
                conn.Open();
                string sql = @"SELECT m.id_mahasiswa, m.nim, m.nama
FROM Mahasiswa m
INNER JOIN KRS k ON k.id_mahasiswa = m.id_mahasiswa
WHERE k.id_matakuliah = @idMk
ORDER BY m.nim";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idMk", idMk);

                dataGridView1.Rows.Clear();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        int idx = dataGridView1.Rows.Add();
                        dataGridView1.Rows[idx].Cells["ColIdMahasiswa"].Value = r["id_mahasiswa"].ToString();
                        dataGridView1.Rows[idx].Cells["ColNim"].Value = r["nim"].ToString();
                        dataGridView1.Rows[idx].Cells["ColNama"].Value = r["nama"].ToString();
                        dataGridView1.Rows[idx].Cells["ColStatusPresensi"].Value = "Hadir";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal muat mahasiswa: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
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
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Muat mahasiswa dulu.");
                return;
            }

            int idMk = Convert.ToInt32(comboBox1.SelectedValue);
            DateTime tgl = dateTimePicker1.Value.Date;

            try
            {
                conn.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    int idMhs = Convert.ToInt32(row.Cells["ColIdMahasiswa"].Value);
                    object stObj = row.Cells["ColStatusPresensi"].Value;
                    if (stObj == null) continue;
                    string status = stObj.ToString();

                    SqlCommand cek = new SqlCommand(
                        "SELECT COUNT(*) FROM Presensi WHERE tanggal=@tgl AND id_mahasiswa=@mhs AND id_matakuliah=@mk",
                        conn);
                    cek.Parameters.AddWithValue("@tgl", tgl);
                    cek.Parameters.AddWithValue("@mhs", idMhs);
                    cek.Parameters.AddWithValue("@mk", idMk);
                    int ada = Convert.ToInt32(cek.ExecuteScalar());

                    if (ada > 0)
                    {
                        SqlCommand upd = new SqlCommand(
                            @"UPDATE Presensi SET status=@st, id_dosen=@dos
WHERE tanggal=@tgl AND id_mahasiswa=@mhs AND id_matakuliah=@mk", conn);
                        upd.Parameters.AddWithValue("@st", status);
                        upd.Parameters.AddWithValue("@dos", Sesi.IdDosen);
                        upd.Parameters.AddWithValue("@tgl", tgl);
                        upd.Parameters.AddWithValue("@mhs", idMhs);
                        upd.Parameters.AddWithValue("@mk", idMk);
                        upd.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand ins = new SqlCommand(
                            @"INSERT INTO Presensi (tanggal, status, id_mahasiswa, id_matakuliah, id_dosen)
VALUES (@tgl, @st, @mhs, @mk, @dos)", conn);
                        ins.Parameters.AddWithValue("@tgl", tgl);
                        ins.Parameters.AddWithValue("@st", status);
                        ins.Parameters.AddWithValue("@mhs", idMhs);
                        ins.Parameters.AddWithValue("@mk", idMk);
                        ins.Parameters.AddWithValue("@dos", Sesi.IdDosen);
                        ins.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Presensi tersimpan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal simpan: " + ex.Message);
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
            DashboardDosen dashboardDosen = new DashboardDosen();
            dashboardDosen.Show();
        }
    }
}

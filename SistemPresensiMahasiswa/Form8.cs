using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemPresensiMahasiswa
{
    public partial class InputPresensi : Form
    {
        public InputPresensi()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardDosen dashboardDosen = new DashboardDosen();
            dashboardDosen.Show();
        }
    }
}

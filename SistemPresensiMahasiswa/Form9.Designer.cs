namespace SistemPresensiMahasiswa
{
    partial class RekapPresensi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColNim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHadir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSakit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNim,
            this.ColNama,
            this.ColHadir,
            this.ColIzin,
            this.ColSakit});
            this.dataGridView1.Location = new System.Drawing.Point(482, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 440);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColNim
            // 
            this.ColNim.HeaderText = "Nim";
            this.ColNim.MinimumWidth = 6;
            this.ColNim.Name = "ColNim";
            this.ColNim.Width = 125;
            // 
            // ColNama
            // 
            this.ColNama.HeaderText = "Nama";
            this.ColNama.MinimumWidth = 6;
            this.ColNama.Name = "ColNama";
            this.ColNama.Width = 125;
            // 
            // ColHadir
            // 
            this.ColHadir.HeaderText = "Hadir";
            this.ColHadir.MinimumWidth = 6;
            this.ColHadir.Name = "ColHadir";
            this.ColHadir.Width = 125;
            // 
            // ColIzin
            // 
            this.ColIzin.HeaderText = "Izin";
            this.ColIzin.MinimumWidth = 6;
            this.ColIzin.Name = "ColIzin";
            this.ColIzin.Width = 125;
            // 
            // ColSakit
            // 
            this.ColSakit.HeaderText = "Sakit";
            this.ColSakit.MinimumWidth = 6;
            this.ColSakit.Name = "ColSakit";
            this.ColSakit.Width = 125;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(111, 210);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Template Rekap";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.Red;
            this.btnKembali.Location = new System.Drawing.Point(111, 357);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(101, 27);
            this.btnKembali.TabIndex = 5;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // RekapPresensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 500);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "RekapPresensi";
            this.Text = "FormRekapPresensi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIzin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSakit;
        private System.Windows.Forms.Button btnKembali;
    }
}
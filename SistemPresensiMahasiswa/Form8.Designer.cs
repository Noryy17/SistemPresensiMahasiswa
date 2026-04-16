namespace SistemPresensiMahasiswa
{
    partial class InputPresensi
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColIdMahasiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatusPresensi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lblMk = new System.Windows.Forms.Label();
            this.lblTgl = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(590, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Muat Mahasiswa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(590, 277);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(166, 43);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan Presensi";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdMahasiswa,
            this.ColNim,
            this.ColNama,
            this.ColStatusPresensi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 471);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColIdMahasiswa
            // 
            this.ColIdMahasiswa.HeaderText = "id";
            this.ColIdMahasiswa.MinimumWidth = 6;
            this.ColIdMahasiswa.Name = "ColIdMahasiswa";
            this.ColIdMahasiswa.Visible = false;
            this.ColIdMahasiswa.Width = 50;
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
            // ColStatusPresensi
            // 
            this.ColStatusPresensi.HeaderText = "StatusPresensi";
            this.ColStatusPresensi.MinimumWidth = 6;
            this.ColStatusPresensi.Name = "ColStatusPresensi";
            this.ColStatusPresensi.Width = 125;
            // 
            // lblMk
            // 
            this.lblMk.AutoSize = true;
            this.lblMk.Location = new System.Drawing.Point(621, 106);
            this.lblMk.Name = "lblMk";
            this.lblMk.Size = new System.Drawing.Size(75, 16);
            this.lblMk.TabIndex = 6;
            this.lblMk.Text = "Mata kuliah";
            // 
            // lblTgl
            // 
            this.lblTgl.AutoSize = true;
            this.lblTgl.Location = new System.Drawing.Point(257, 5);
            this.lblTgl.Name = "lblTgl";
            this.lblTgl.Size = new System.Drawing.Size(58, 16);
            this.lblTgl.TabIndex = 7;
            this.lblTgl.Text = "Tanggal";
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.Red;
            this.btnKembali.Location = new System.Drawing.Point(613, 374);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(121, 34);
            this.btnKembali.TabIndex = 4;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // InputPresensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 533);
            this.Controls.Add(this.lblTgl);
            this.Controls.Add(this.lblMk);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Name = "InputPresensi";
            this.Text = "FormInputPresensi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdMahasiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNama;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColStatusPresensi;
        private System.Windows.Forms.Label lblMk;
        private System.Windows.Forms.Label lblTgl;
        private System.Windows.Forms.Button btnKembali;
    }
}
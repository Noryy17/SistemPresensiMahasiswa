namespace SistemPresensiMahasiswa
{
    partial class FormLogin
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
            this.PanelCard = new System.Windows.Forms.Panel();
            this.txtUsernameDosen = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCard
            // 
            this.PanelCard.Controls.Add(this.label2);
            this.PanelCard.Controls.Add(this.label1);
            this.PanelCard.Controls.Add(this.btnLogin);
            this.PanelCard.Controls.Add(this.txtPassword);
            this.PanelCard.Controls.Add(this.txtUsernameDosen);
            this.PanelCard.Location = new System.Drawing.Point(200, 130);
            this.PanelCard.Name = "PanelCard";
            this.PanelCard.Size = new System.Drawing.Size(400, 300);
            this.PanelCard.TabIndex = 0;
            // 
            // txtUsernameDosen
            // 
            this.txtUsernameDosen.Location = new System.Drawing.Point(50, 80);
            this.txtUsernameDosen.Name = "txtUsernameDosen";
            this.txtUsernameDosen.Size = new System.Drawing.Size(300, 22);
            this.txtUsernameDosen.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(50, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.PanelCard);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelCard.ResumeLayout(false);
            this.PanelCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCard;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsernameDosen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


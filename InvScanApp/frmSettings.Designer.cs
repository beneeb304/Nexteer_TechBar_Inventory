
namespace InvScanApp
{
    partial class frmSettings
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtEmailUsername = new System.Windows.Forms.TextBox();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbEmail = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSMTPPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSMTPClient = new System.Windows.Forms.TextBox();
            this.btnSaveEmail = new System.Windows.Forms.Button();
            this.btnCancelEmail = new System.Windows.Forms.Button();
            this.gpbSQL = new System.Windows.Forms.GroupBox();
            this.cmbString = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtSQLString = new System.Windows.Forms.TextBox();
            this.gpbEmail.SuspendLayout();
            this.gpbSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(668, 338);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 100);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtEmailUsername
            // 
            this.txtEmailUsername.Location = new System.Drawing.Point(107, 24);
            this.txtEmailUsername.Name = "txtEmailUsername";
            this.txtEmailUsername.Size = new System.Drawing.Size(127, 20);
            this.txtEmailUsername.TabIndex = 9;
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.Location = new System.Drawing.Point(107, 50);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.PasswordChar = '*';
            this.txtEmailPassword.Size = new System.Drawing.Size(127, 20);
            this.txtEmailPassword.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "From Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "From Password:";
            // 
            // gpbEmail
            // 
            this.gpbEmail.Controls.Add(this.label5);
            this.gpbEmail.Controls.Add(this.txtSMTPPort);
            this.gpbEmail.Controls.Add(this.label4);
            this.gpbEmail.Controls.Add(this.txtToEmail);
            this.gpbEmail.Controls.Add(this.label3);
            this.gpbEmail.Controls.Add(this.txtSMTPClient);
            this.gpbEmail.Controls.Add(this.btnSaveEmail);
            this.gpbEmail.Controls.Add(this.btnCancelEmail);
            this.gpbEmail.Controls.Add(this.label1);
            this.gpbEmail.Controls.Add(this.label2);
            this.gpbEmail.Controls.Add(this.txtEmailUsername);
            this.gpbEmail.Controls.Add(this.txtEmailPassword);
            this.gpbEmail.Location = new System.Drawing.Point(12, 97);
            this.gpbEmail.Name = "gpbEmail";
            this.gpbEmail.Size = new System.Drawing.Size(453, 110);
            this.gpbEmail.TabIndex = 13;
            this.gpbEmail.TabStop = false;
            this.gpbEmail.Text = "Email Credentials";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "SMTP Port:";
            // 
            // txtSMTPPort
            // 
            this.txtSMTPPort.Location = new System.Drawing.Point(315, 50);
            this.txtSMTPPort.Name = "txtSMTPPort";
            this.txtSMTPPort.Size = new System.Drawing.Size(127, 20);
            this.txtSMTPPort.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "To Email:";
            // 
            // txtToEmail
            // 
            this.txtToEmail.Location = new System.Drawing.Point(315, 24);
            this.txtToEmail.Name = "txtToEmail";
            this.txtToEmail.Size = new System.Drawing.Size(127, 20);
            this.txtToEmail.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "From SMTP Client:";
            // 
            // txtSMTPClient
            // 
            this.txtSMTPClient.Location = new System.Drawing.Point(107, 76);
            this.txtSMTPClient.Name = "txtSMTPClient";
            this.txtSMTPClient.Size = new System.Drawing.Size(127, 20);
            this.txtSMTPClient.TabIndex = 15;
            // 
            // btnSaveEmail
            // 
            this.btnSaveEmail.Location = new System.Drawing.Point(344, 76);
            this.btnSaveEmail.Name = "btnSaveEmail";
            this.btnSaveEmail.Size = new System.Drawing.Size(98, 28);
            this.btnSaveEmail.TabIndex = 14;
            this.btnSaveEmail.Text = "Save";
            this.btnSaveEmail.UseVisualStyleBackColor = true;
            this.btnSaveEmail.Click += new System.EventHandler(this.btnSaveEmail_Click);
            // 
            // btnCancelEmail
            // 
            this.btnCancelEmail.Location = new System.Drawing.Point(240, 76);
            this.btnCancelEmail.Name = "btnCancelEmail";
            this.btnCancelEmail.Size = new System.Drawing.Size(98, 28);
            this.btnCancelEmail.TabIndex = 13;
            this.btnCancelEmail.Text = "Cancel";
            this.btnCancelEmail.UseVisualStyleBackColor = true;
            this.btnCancelEmail.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gpbSQL
            // 
            this.gpbSQL.Controls.Add(this.cmbString);
            this.gpbSQL.Controls.Add(this.btnEnter);
            this.gpbSQL.Controls.Add(this.txtSQLString);
            this.gpbSQL.Location = new System.Drawing.Point(12, 12);
            this.gpbSQL.Name = "gpbSQL";
            this.gpbSQL.Size = new System.Drawing.Size(372, 79);
            this.gpbSQL.TabIndex = 14;
            this.gpbSQL.TabStop = false;
            this.gpbSQL.Text = "SQL Server Connection";
            // 
            // cmbString
            // 
            this.cmbString.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbString.FormattingEnabled = true;
            this.cmbString.Items.AddRange(new object[] {
            "Data Base Name",
            "Data Base Path",
            "Server Name",
            "User Name",
            "User Password"});
            this.cmbString.Location = new System.Drawing.Point(6, 45);
            this.cmbString.Name = "cmbString";
            this.cmbString.Size = new System.Drawing.Size(188, 21);
            this.cmbString.TabIndex = 11;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(200, 43);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(157, 23);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Save SQL String";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // txtSQLString
            // 
            this.txtSQLString.Location = new System.Drawing.Point(6, 19);
            this.txtSQLString.Name = "txtSQLString";
            this.txtSQLString.Size = new System.Drawing.Size(351, 20);
            this.txtSQLString.TabIndex = 9;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbSQL);
            this.Controls.Add(this.gpbEmail);
            this.Controls.Add(this.btnBack);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.gpbEmail.ResumeLayout(false);
            this.gpbEmail.PerformLayout();
            this.gpbSQL.ResumeLayout(false);
            this.gpbSQL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtEmailUsername;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbEmail;
        private System.Windows.Forms.Button btnSaveEmail;
        private System.Windows.Forms.Button btnCancelEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSMTPClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSMTPPort;
        private System.Windows.Forms.GroupBox gpbSQL;
        private System.Windows.Forms.ComboBox cmbString;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtSQLString;
    }
}
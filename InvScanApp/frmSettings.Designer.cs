
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
            this.txtSQLString = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnSQLConnect = new System.Windows.Forms.Button();
            this.cmbString = new System.Windows.Forms.ComboBox();
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
            // txtSQLString
            // 
            this.txtSQLString.Location = new System.Drawing.Point(12, 101);
            this.txtSQLString.Name = "txtSQLString";
            this.txtSQLString.Size = new System.Drawing.Size(351, 20);
            this.txtSQLString.TabIndex = 5;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(206, 125);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(157, 23);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "Save SQL String";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnSQLConnect
            // 
            this.btnSQLConnect.Location = new System.Drawing.Point(192, 237);
            this.btnSQLConnect.Name = "btnSQLConnect";
            this.btnSQLConnect.Size = new System.Drawing.Size(138, 61);
            this.btnSQLConnect.TabIndex = 7;
            this.btnSQLConnect.Text = "Connect to SQL Server";
            this.btnSQLConnect.UseVisualStyleBackColor = true;
            this.btnSQLConnect.Click += new System.EventHandler(this.btnSQLConnect_Click);
            // 
            // cmbString
            // 
            this.cmbString.FormattingEnabled = true;
            this.cmbString.Items.AddRange(new object[] {
            "Data Base Name",
            "Data Base Path",
            "Server Name",
            "User Name",
            "User Password"});
            this.cmbString.Location = new System.Drawing.Point(12, 127);
            this.cmbString.Name = "cmbString";
            this.cmbString.Size = new System.Drawing.Size(188, 21);
            this.cmbString.TabIndex = 8;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbString);
            this.Controls.Add(this.btnSQLConnect);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtSQLString);
            this.Controls.Add(this.btnBack);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSQLString;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnSQLConnect;
        private System.Windows.Forms.ComboBox cmbString;
    }
}
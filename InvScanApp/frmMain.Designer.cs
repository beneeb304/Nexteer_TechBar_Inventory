
namespace InvScanApp
{
    partial class frmMain
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnHandOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(668, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 100);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add/Edit Inventory";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(668, 232);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(120, 100);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Administration";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(668, 338);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(120, 100);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMain.Location = new System.Drawing.Point(12, 20);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(650, 418);
            this.dgvMain.TabIndex = 4;
            // 
            // btnHandOut
            // 
            this.btnHandOut.Location = new System.Drawing.Point(668, 126);
            this.btnHandOut.Name = "btnHandOut";
            this.btnHandOut.Size = new System.Drawing.Size(120, 100);
            this.btnHandOut.TabIndex = 6;
            this.btnHandOut.Text = "Hand Out Item(s)";
            this.btnHandOut.UseVisualStyleBackColor = true;
            this.btnHandOut.Click += new System.EventHandler(this.btnHandOut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHandOut);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmMain";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnHandOut;
    }
}


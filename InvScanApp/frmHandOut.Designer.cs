
namespace InvScanApp
{
    partial class frmHandOut
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gpbStaff = new System.Windows.Forms.GroupBox();
            this.cmbStaffName = new System.Windows.Forms.ComboBox();
            this.gpbRecipient = new System.Windows.Forms.GroupBox();
            this.txtRecipientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecipientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbItemCategory = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gpbStaff.SuspendLayout();
            this.gpbRecipient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "or";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(182, 83);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(443, 31);
            this.txtStaffID.TabIndex = 25;
            this.txtStaffID.TextChanged += new System.EventHandler(this.txtStaffID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Staff ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Staff Name:";
            // 
            // gpbStaff
            // 
            this.gpbStaff.Controls.Add(this.cmbStaffName);
            this.gpbStaff.Controls.Add(this.txtStaffID);
            this.gpbStaff.Controls.Add(this.label2);
            this.gpbStaff.Controls.Add(this.label8);
            this.gpbStaff.Controls.Add(this.label7);
            this.gpbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStaff.Location = new System.Drawing.Point(17, 193);
            this.gpbStaff.Name = "gpbStaff";
            this.gpbStaff.Size = new System.Drawing.Size(634, 120);
            this.gpbStaff.TabIndex = 27;
            this.gpbStaff.TabStop = false;
            this.gpbStaff.Text = "Staff Info";
            // 
            // cmbStaffName
            // 
            this.cmbStaffName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStaffName.FormattingEnabled = true;
            this.cmbStaffName.Location = new System.Drawing.Point(182, 21);
            this.cmbStaffName.Name = "cmbStaffName";
            this.cmbStaffName.Size = new System.Drawing.Size(443, 33);
            this.cmbStaffName.TabIndex = 29;
            this.cmbStaffName.SelectedIndexChanged += new System.EventHandler(this.cmbStaffName_SelectedIndexChanged);
            // 
            // gpbRecipient
            // 
            this.gpbRecipient.Controls.Add(this.txtRecipientID);
            this.gpbRecipient.Controls.Add(this.label3);
            this.gpbRecipient.Controls.Add(this.label4);
            this.gpbRecipient.Controls.Add(this.txtRecipientName);
            this.gpbRecipient.Controls.Add(this.label5);
            this.gpbRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRecipient.Location = new System.Drawing.Point(17, 319);
            this.gpbRecipient.Name = "gpbRecipient";
            this.gpbRecipient.Size = new System.Drawing.Size(634, 120);
            this.gpbRecipient.TabIndex = 28;
            this.gpbRecipient.TabStop = false;
            this.gpbRecipient.Text = "Recipient Info";
            // 
            // txtRecipientID
            // 
            this.txtRecipientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipientID.Location = new System.Drawing.Point(182, 83);
            this.txtRecipientID.Name = "txtRecipientID";
            this.txtRecipientID.ReadOnly = true;
            this.txtRecipientID.Size = new System.Drawing.Size(443, 31);
            this.txtRecipientID.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "or";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Recipient Name:";
            // 
            // txtRecipientName
            // 
            this.txtRecipientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipientName.Location = new System.Drawing.Point(182, 21);
            this.txtRecipientName.Name = "txtRecipientName";
            this.txtRecipientName.Size = new System.Drawing.Size(443, 31);
            this.txtRecipientName.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Recipient ID:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(668, 338);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 100);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(668, 232);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 100);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbItemCategory);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbItemName);
            this.groupBox1.Controls.Add(this.txtItemID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 160);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Info";
            // 
            // cmbItemCategory
            // 
            this.cmbItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemCategory.FormattingEnabled = true;
            this.cmbItemCategory.Location = new System.Drawing.Point(182, 21);
            this.cmbItemCategory.Name = "cmbItemCategory";
            this.cmbItemCategory.Size = new System.Drawing.Size(443, 33);
            this.cmbItemCategory.TabIndex = 36;
            this.cmbItemCategory.SelectedIndexChanged += new System.EventHandler(this.cmbItemCategory_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "Item Category:";
            // 
            // cmbItemName
            // 
            this.cmbItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(182, 60);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(443, 33);
            this.cmbItemName.TabIndex = 34;
            this.cmbItemName.SelectedIndexChanged += new System.EventHandler(this.cmbItemName_SelectedIndexChanged);
            // 
            // txtItemID
            // 
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(182, 122);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(443, 31);
            this.txtItemID.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "or";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Item Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Item ID:";
            // 
            // frmHandOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gpbRecipient);
            this.Controls.Add(this.gpbStaff);
            this.Name = "frmHandOut";
            this.Text = "Hand Out Item(s)";
            this.Load += new System.EventHandler(this.frmHandOut_Load);
            this.gpbStaff.ResumeLayout(false);
            this.gpbStaff.PerformLayout();
            this.gpbRecipient.ResumeLayout(false);
            this.gpbRecipient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gpbStaff;
        private System.Windows.Forms.GroupBox gpbRecipient;
        private System.Windows.Forms.TextBox txtRecipientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecipientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStaffName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbItemCategory;
        private System.Windows.Forms.Label label10;
    }
}
﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandOut));
            this.label8 = new System.Windows.Forms.Label();
            this.gpbStaff = new System.Windows.Forms.GroupBox();
            this.cmbStaffName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCommodityCategory = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCommodityName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHandOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRecipientName = new System.Windows.Forms.ComboBox();
            this.txtRecipientName = new System.Windows.Forms.TextBox();
            this.gpbStaff.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "Staff Name:";
            // 
            // gpbStaff
            // 
            this.gpbStaff.BackColor = System.Drawing.Color.Transparent;
            this.gpbStaff.Controls.Add(this.cmbStaffName);
            this.gpbStaff.Controls.Add(this.label8);
            this.gpbStaff.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStaff.Location = new System.Drawing.Point(12, 208);
            this.gpbStaff.Name = "gpbStaff";
            this.gpbStaff.Size = new System.Drawing.Size(645, 76);
            this.gpbStaff.TabIndex = 2;
            this.gpbStaff.TabStop = false;
            this.gpbStaff.Text = "Staff Info";
            // 
            // cmbStaffName
            // 
            this.cmbStaffName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStaffName.FormattingEnabled = true;
            this.cmbStaffName.Location = new System.Drawing.Point(182, 21);
            this.cmbStaffName.Name = "cmbStaffName";
            this.cmbStaffName.Size = new System.Drawing.Size(457, 34);
            this.cmbStaffName.TabIndex = 5;
            this.cmbStaffName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeKeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nudQty);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbCommodityCategory);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbCommodityName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Info";
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(221, 100);
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(114, 33);
            this.nudQty.TabIndex = 4;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeKeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 26);
            this.label11.TabIndex = 32;
            this.label11.Text = "Quantity to Hand- Out:";
            // 
            // cmbCommodityCategory
            // 
            this.cmbCommodityCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommodityCategory.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCommodityCategory.FormattingEnabled = true;
            this.cmbCommodityCategory.Location = new System.Drawing.Point(182, 21);
            this.cmbCommodityCategory.Name = "cmbCommodityCategory";
            this.cmbCommodityCategory.Size = new System.Drawing.Size(457, 34);
            this.cmbCommodityCategory.TabIndex = 2;
            this.cmbCommodityCategory.SelectedIndexChanged += new System.EventHandler(this.cmbItemCategory_SelectedIndexChanged);
            this.cmbCommodityCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeKeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 26);
            this.label10.TabIndex = 35;
            this.label10.Text = "Item Category:";
            // 
            // cmbCommodityName
            // 
            this.cmbCommodityName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommodityName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCommodityName.FormattingEnabled = true;
            this.cmbCommodityName.Location = new System.Drawing.Point(182, 60);
            this.cmbCommodityName.Name = "cmbCommodityName";
            this.cmbCommodityName.Size = new System.Drawing.Size(457, 34);
            this.cmbCommodityName.TabIndex = 3;
            this.cmbCommodityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeKeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 30;
            this.label6.Text = "Item Name:";
            // 
            // btnHandOut
            // 
            this.btnHandOut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHandOut.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandOut.Location = new System.Drawing.Point(668, 268);
            this.btnHandOut.Name = "btnHandOut";
            this.btnHandOut.Size = new System.Drawing.Size(120, 82);
            this.btnHandOut.TabIndex = 6;
            this.btnHandOut.Text = "Hand Out Item";
            this.btnHandOut.UseVisualStyleBackColor = false;
            this.btnHandOut.Click += new System.EventHandler(this.btnHandOut_Click);
            this.btnHandOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeKeyPress);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(668, 356);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 82);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeKeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(668, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 190);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Recipient Name:";
            // 
            // cmbRecipientName
            // 
            this.cmbRecipientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecipientName.Enabled = false;
            this.cmbRecipientName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecipientName.FormattingEnabled = true;
            this.cmbRecipientName.Location = new System.Drawing.Point(374, 12);
            this.cmbRecipientName.Name = "cmbRecipientName";
            this.cmbRecipientName.Size = new System.Drawing.Size(277, 34);
            this.cmbRecipientName.TabIndex = 36;
            this.cmbRecipientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeKeyPress);
            // 
            // txtRecipientName
            // 
            this.txtRecipientName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipientName.Location = new System.Drawing.Point(194, 12);
            this.txtRecipientName.Name = "txtRecipientName";
            this.txtRecipientName.Size = new System.Drawing.Size(174, 33);
            this.txtRecipientName.TabIndex = 1;
            this.txtRecipientName.TextChanged += new System.EventHandler(this.txtRecipientName_TextChanged);
            this.txtRecipientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeKeyPress);
            // 
            // frmHandOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cmbRecipientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRecipientName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHandOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbStaff);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHandOut";
            this.Text = "Tech Bar Inventory | Hand Out Item";
            this.Load += new System.EventHandler(this.frmHandOut_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeKeyPress);
            this.gpbStaff.ResumeLayout(false);
            this.gpbStaff.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gpbStaff;
        private System.Windows.Forms.ComboBox cmbStaffName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCommodityName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCommodityCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHandOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRecipientName;
        private System.Windows.Forms.TextBox txtRecipientName;
    }
}
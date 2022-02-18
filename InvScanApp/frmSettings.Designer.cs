
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tbpCategory = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.tbpVendor = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.tbpStaff = new System.Windows.Forms.TabPage();
            this.rdoType = new System.Windows.Forms.RadioButton();
            this.rdoScan = new System.Windows.Forms.RadioButton();
            this.label30 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.tbpRemove = new System.Windows.Forms.TabPage();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.gpbTables = new System.Windows.Forms.GroupBox();
            this.rdoStaff = new System.Windows.Forms.RadioButton();
            this.rdoVendor = new System.Windows.Forms.RadioButton();
            this.rdoCommodity = new System.Windows.Forms.RadioButton();
            this.rdoCategory = new System.Windows.Forms.RadioButton();
            this.tbpEmail = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSMTPPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSMTPClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailUsername = new System.Windows.Forms.TextBox();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.tbpSQL = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSQLServerName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbcSettings.SuspendLayout();
            this.tbpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.tbpVendor.SuspendLayout();
            this.tbpStaff.SuspendLayout();
            this.tbpRemove.SuspendLayout();
            this.gpbTables.SuspendLayout();
            this.tbpEmail.SuspendLayout();
            this.tbpSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tbpCategory);
            this.tbcSettings.Controls.Add(this.tbpVendor);
            this.tbcSettings.Controls.Add(this.tbpStaff);
            this.tbcSettings.Controls.Add(this.tbpRemove);
            this.tbcSettings.Controls.Add(this.tbpEmail);
            this.tbcSettings.Controls.Add(this.tbpSQL);
            this.tbcSettings.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcSettings.Location = new System.Drawing.Point(12, 12);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(650, 426);
            this.tbcSettings.TabIndex = 19;
            this.tbcSettings.SelectedIndexChanged += new System.EventHandler(this.tbcSettings_SelectedIndexChanged);
            // 
            // tbpCategory
            // 
            this.tbpCategory.Controls.Add(this.label26);
            this.tbpCategory.Controls.Add(this.label27);
            this.tbpCategory.Controls.Add(this.nudQty);
            this.tbpCategory.Controls.Add(this.label28);
            this.tbpCategory.Controls.Add(this.txtCategory);
            this.tbpCategory.Location = new System.Drawing.Point(4, 32);
            this.tbpCategory.Name = "tbpCategory";
            this.tbpCategory.Size = new System.Drawing.Size(642, 390);
            this.tbpCategory.TabIndex = 3;
            this.tbpCategory.Text = "Create Category";
            this.tbpCategory.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(318, 51);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(315, 132);
            this.label26.TabIndex = 27;
            this.label26.Text = "Note: The program will alert the designated email any time a commodity of this ca" +
    "tegory hits the low quantity threshold.";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 51);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(182, 26);
            this.label27.TabIndex = 26;
            this.label27.Text = "Low Alert Quantity:";
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(224, 49);
            this.nudQty.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(88, 33);
            this.nudQty.TabIndex = 2;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(3, 15);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(198, 26);
            this.label28.TabIndex = 11;
            this.label28.Text = "New Category Name:";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(224, 12);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(409, 33);
            this.txtCategory.TabIndex = 1;
            // 
            // tbpVendor
            // 
            this.tbpVendor.Controls.Add(this.label29);
            this.tbpVendor.Controls.Add(this.txtVendor);
            this.tbpVendor.Location = new System.Drawing.Point(4, 32);
            this.tbpVendor.Name = "tbpVendor";
            this.tbpVendor.Size = new System.Drawing.Size(642, 390);
            this.tbpVendor.TabIndex = 4;
            this.tbpVendor.Text = "Create Vendor";
            this.tbpVendor.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(9, 15);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(183, 26);
            this.label29.TabIndex = 13;
            this.label29.Text = "New Vendor Name:";
            // 
            // txtVendor
            // 
            this.txtVendor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendor.Location = new System.Drawing.Point(212, 12);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(427, 33);
            this.txtVendor.TabIndex = 1;
            // 
            // tbpStaff
            // 
            this.tbpStaff.Controls.Add(this.rdoType);
            this.tbpStaff.Controls.Add(this.rdoScan);
            this.tbpStaff.Controls.Add(this.label30);
            this.tbpStaff.Controls.Add(this.txtStaffID);
            this.tbpStaff.Controls.Add(this.label31);
            this.tbpStaff.Controls.Add(this.txtStaff);
            this.tbpStaff.Location = new System.Drawing.Point(4, 32);
            this.tbpStaff.Name = "tbpStaff";
            this.tbpStaff.Size = new System.Drawing.Size(642, 390);
            this.tbpStaff.TabIndex = 5;
            this.tbpStaff.Text = "Create Staff";
            this.tbpStaff.UseVisualStyleBackColor = true;
            // 
            // rdoType
            // 
            this.rdoType.AutoSize = true;
            this.rdoType.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoType.Location = new System.Drawing.Point(535, 88);
            this.rdoType.Name = "rdoType";
            this.rdoType.Size = new System.Drawing.Size(95, 30);
            this.rdoType.TabIndex = 4;
            this.rdoType.TabStop = true;
            this.rdoType.Text = "Type ID";
            this.rdoType.UseVisualStyleBackColor = true;
            // 
            // rdoScan
            // 
            this.rdoScan.AutoSize = true;
            this.rdoScan.Checked = true;
            this.rdoScan.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoScan.Location = new System.Drawing.Point(424, 88);
            this.rdoScan.Name = "rdoScan";
            this.rdoScan.Size = new System.Drawing.Size(94, 30);
            this.rdoScan.TabIndex = 3;
            this.rdoScan.TabStop = true;
            this.rdoScan.Text = "Scan ID";
            this.rdoScan.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(9, 54);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(128, 26);
            this.label30.TabIndex = 17;
            this.label30.Text = "New Staff ID:";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(187, 51);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(452, 33);
            this.txtStaffID.TabIndex = 2;
            this.txtStaffID.TabStop = false;
            this.txtStaffID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStaffID_KeyUp);
            this.txtStaffID.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtStaffID_PreviewKeyDown);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(9, 17);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(161, 26);
            this.label31.TabIndex = 15;
            this.label31.Text = "New Staff Name:";
            // 
            // txtStaff
            // 
            this.txtStaff.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff.Location = new System.Drawing.Point(187, 14);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(452, 33);
            this.txtStaff.TabIndex = 1;
            // 
            // tbpRemove
            // 
            this.tbpRemove.Controls.Add(this.txtDetails);
            this.tbpRemove.Controls.Add(this.label7);
            this.tbpRemove.Controls.Add(this.label8);
            this.tbpRemove.Controls.Add(this.cmbField);
            this.tbpRemove.Controls.Add(this.gpbTables);
            this.tbpRemove.Location = new System.Drawing.Point(4, 32);
            this.tbpRemove.Name = "tbpRemove";
            this.tbpRemove.Size = new System.Drawing.Size(642, 390);
            this.tbpRemove.TabIndex = 8;
            this.tbpRemove.Text = "Remove Field";
            this.tbpRemove.UseVisualStyleBackColor = true;
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(9, 178);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(409, 111);
            this.txtDetails.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(368, 50);
            this.label7.TabIndex = 19;
            this.label7.Text = "To delete the Category/Vendor, first remove or modify the affected Commodities!";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(271, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(368, 75);
            this.label8.TabIndex = 18;
            this.label8.Text = "Note: You cannot delete a Category/Vendor if there are Commodities with this Cate" +
    "gory/Vendor assigned!";
            // 
            // cmbField
            // 
            this.cmbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbField.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(9, 139);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(409, 34);
            this.cmbField.TabIndex = 6;
            this.cmbField.SelectedIndexChanged += new System.EventHandler(this.cmbField_SelectedIndexChanged);
            // 
            // gpbTables
            // 
            this.gpbTables.Controls.Add(this.rdoStaff);
            this.gpbTables.Controls.Add(this.rdoVendor);
            this.gpbTables.Controls.Add(this.rdoCommodity);
            this.gpbTables.Controls.Add(this.rdoCategory);
            this.gpbTables.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTables.Location = new System.Drawing.Point(3, 3);
            this.gpbTables.Name = "gpbTables";
            this.gpbTables.Size = new System.Drawing.Size(262, 103);
            this.gpbTables.TabIndex = 1;
            this.gpbTables.TabStop = false;
            this.gpbTables.Text = "Tables";
            // 
            // rdoStaff
            // 
            this.rdoStaff.AutoSize = true;
            this.rdoStaff.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStaff.Location = new System.Drawing.Point(149, 28);
            this.rdoStaff.Name = "rdoStaff";
            this.rdoStaff.Size = new System.Drawing.Size(70, 30);
            this.rdoStaff.TabIndex = 4;
            this.rdoStaff.TabStop = true;
            this.rdoStaff.Text = "Staff";
            this.rdoStaff.UseVisualStyleBackColor = true;
            this.rdoStaff.Click += new System.EventHandler(this.SetControls);
            // 
            // rdoVendor
            // 
            this.rdoVendor.AutoSize = true;
            this.rdoVendor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVendor.Location = new System.Drawing.Point(149, 63);
            this.rdoVendor.Name = "rdoVendor";
            this.rdoVendor.Size = new System.Drawing.Size(92, 30);
            this.rdoVendor.TabIndex = 5;
            this.rdoVendor.TabStop = true;
            this.rdoVendor.Text = "Vendor";
            this.rdoVendor.UseVisualStyleBackColor = true;
            this.rdoVendor.Click += new System.EventHandler(this.SetControls);
            // 
            // rdoCommodity
            // 
            this.rdoCommodity.AutoSize = true;
            this.rdoCommodity.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCommodity.Location = new System.Drawing.Point(6, 63);
            this.rdoCommodity.Name = "rdoCommodity";
            this.rdoCommodity.Size = new System.Drawing.Size(130, 30);
            this.rdoCommodity.TabIndex = 3;
            this.rdoCommodity.TabStop = true;
            this.rdoCommodity.Text = "Commodity";
            this.rdoCommodity.UseVisualStyleBackColor = true;
            this.rdoCommodity.Click += new System.EventHandler(this.SetControls);
            // 
            // rdoCategory
            // 
            this.rdoCategory.AutoSize = true;
            this.rdoCategory.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCategory.Location = new System.Drawing.Point(6, 28);
            this.rdoCategory.Name = "rdoCategory";
            this.rdoCategory.Size = new System.Drawing.Size(107, 30);
            this.rdoCategory.TabIndex = 2;
            this.rdoCategory.TabStop = true;
            this.rdoCategory.Text = "Category";
            this.rdoCategory.UseVisualStyleBackColor = true;
            this.rdoCategory.Click += new System.EventHandler(this.SetControls);
            // 
            // tbpEmail
            // 
            this.tbpEmail.Controls.Add(this.label5);
            this.tbpEmail.Controls.Add(this.txtSMTPPort);
            this.tbpEmail.Controls.Add(this.label4);
            this.tbpEmail.Controls.Add(this.txtToEmail);
            this.tbpEmail.Controls.Add(this.label3);
            this.tbpEmail.Controls.Add(this.txtSMTPClient);
            this.tbpEmail.Controls.Add(this.label1);
            this.tbpEmail.Controls.Add(this.label2);
            this.tbpEmail.Controls.Add(this.txtEmailUsername);
            this.tbpEmail.Controls.Add(this.txtEmailPassword);
            this.tbpEmail.Location = new System.Drawing.Point(4, 32);
            this.tbpEmail.Name = "tbpEmail";
            this.tbpEmail.Size = new System.Drawing.Size(642, 390);
            this.tbpEmail.TabIndex = 7;
            this.tbpEmail.Text = "Email";
            this.tbpEmail.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "SMTP Port:";
            // 
            // txtSMTPPort
            // 
            this.txtSMTPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMTPPort.Location = new System.Drawing.Point(202, 138);
            this.txtSMTPPort.Name = "txtSMTPPort";
            this.txtSMTPPort.Size = new System.Drawing.Size(75, 31);
            this.txtSMTPPort.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "To Email:";
            // 
            // txtToEmail
            // 
            this.txtToEmail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToEmail.Location = new System.Drawing.Point(202, 175);
            this.txtToEmail.Name = "txtToEmail";
            this.txtToEmail.Size = new System.Drawing.Size(382, 33);
            this.txtToEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "From SMTP Client:";
            // 
            // txtSMTPClient
            // 
            this.txtSMTPClient.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMTPClient.Location = new System.Drawing.Point(202, 101);
            this.txtSMTPClient.Name = "txtSMTPClient";
            this.txtSMTPClient.Size = new System.Drawing.Size(382, 33);
            this.txtSMTPClient.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "From Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "From Password:";
            // 
            // txtEmailUsername
            // 
            this.txtEmailUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUsername.Location = new System.Drawing.Point(202, 27);
            this.txtEmailUsername.Name = "txtEmailUsername";
            this.txtEmailUsername.Size = new System.Drawing.Size(382, 33);
            this.txtEmailUsername.TabIndex = 1;
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPassword.Location = new System.Drawing.Point(202, 64);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.PasswordChar = '*';
            this.txtEmailPassword.Size = new System.Drawing.Size(382, 33);
            this.txtEmailPassword.TabIndex = 2;
            // 
            // tbpSQL
            // 
            this.tbpSQL.Controls.Add(this.label6);
            this.tbpSQL.Controls.Add(this.txtSQLServerName);
            this.tbpSQL.Location = new System.Drawing.Point(4, 32);
            this.tbpSQL.Name = "tbpSQL";
            this.tbpSQL.Size = new System.Drawing.Size(642, 390);
            this.tbpSQL.TabIndex = 6;
            this.tbpSQL.Text = "SQL";
            this.tbpSQL.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "Server Name";
            // 
            // txtSQLServerName
            // 
            this.txtSQLServerName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLServerName.Location = new System.Drawing.Point(146, 25);
            this.txtSQLServerName.Name = "txtSQLServerName";
            this.txtSQLServerName.Size = new System.Drawing.Size(294, 33);
            this.txtSQLServerName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(668, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 190);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(668, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 82);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(668, 356);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 82);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbcSettings);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Tech Bar Inventory | Settings";
            this.tbcSettings.ResumeLayout(false);
            this.tbpCategory.ResumeLayout(false);
            this.tbpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.tbpVendor.ResumeLayout(false);
            this.tbpVendor.PerformLayout();
            this.tbpStaff.ResumeLayout(false);
            this.tbpStaff.PerformLayout();
            this.tbpRemove.ResumeLayout(false);
            this.tbpRemove.PerformLayout();
            this.gpbTables.ResumeLayout(false);
            this.gpbTables.PerformLayout();
            this.tbpEmail.ResumeLayout(false);
            this.tbpEmail.PerformLayout();
            this.tbpSQL.ResumeLayout(false);
            this.tbpSQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcSettings;
        private System.Windows.Forms.TabPage tbpCategory;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TabPage tbpVendor;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.TabPage tbpStaff;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.TabPage tbpSQL;
        private System.Windows.Forms.TabPage tbpEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSMTPPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSMTPClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailUsername;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSQLServerName;
        private System.Windows.Forms.RadioButton rdoType;
        private System.Windows.Forms.RadioButton rdoScan;
        private System.Windows.Forms.TabPage tbpRemove;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.GroupBox gpbTables;
        private System.Windows.Forms.RadioButton rdoStaff;
        private System.Windows.Forms.RadioButton rdoVendor;
        private System.Windows.Forms.RadioButton rdoCommodity;
        private System.Windows.Forms.RadioButton rdoCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}
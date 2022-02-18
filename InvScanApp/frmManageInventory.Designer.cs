
namespace InvScanApp
{
    partial class frmManageInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInventory));
            this.tbcManage = new System.Windows.Forms.TabControl();
            this.tbpAddCommodity = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAddBarcode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbAddCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAddQty = new System.Windows.Forms.NumericUpDown();
            this.cmbAddCommodities = new System.Windows.Forms.ComboBox();
            this.tbpCreateCommodity = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCreateVendorURL = new System.Windows.Forms.TextBox();
            this.cmbCreateCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCreateVendor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCreateBarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCreateQty = new System.Windows.Forms.NumericUpDown();
            this.txtCreateCommodity = new System.Windows.Forms.TextBox();
            this.tbpEditCommodity = new System.Windows.Forms.TabPage();
            this.btnEditLookup = new System.Windows.Forms.Button();
            this.cmbEditNewCategory = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEditNewCommodity = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblNewQty = new System.Windows.Forms.Label();
            this.nudEditQty = new System.Windows.Forms.NumericUpDown();
            this.chkEditQty = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEditVendorURL = new System.Windows.Forms.TextBox();
            this.cmbEditNewVendor = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEditBarcode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEditCommodities = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEditCategory = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.txtQtyAlert = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudQtyAlert = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbQtyCategory = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbcManage.SuspendLayout();
            this.tbpAddCommodity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQty)).BeginInit();
            this.tbpCreateCommodity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreateQty)).BeginInit();
            this.tbpEditCommodity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditQty)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcManage
            // 
            this.tbcManage.Controls.Add(this.tbpAddCommodity);
            this.tbcManage.Controls.Add(this.tbpCreateCommodity);
            this.tbcManage.Controls.Add(this.tbpEditCommodity);
            this.tbcManage.Controls.Add(this.tabPage1);
            this.tbcManage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcManage.Location = new System.Drawing.Point(12, 12);
            this.tbcManage.Name = "tbcManage";
            this.tbcManage.SelectedIndex = 0;
            this.tbcManage.Size = new System.Drawing.Size(650, 426);
            this.tbcManage.TabIndex = 0;
            this.tbcManage.SelectedIndexChanged += new System.EventHandler(this.tbcAdd_SelectedIndexChanged);
            // 
            // tbpAddCommodity
            // 
            this.tbpAddCommodity.Controls.Add(this.label25);
            this.tbpAddCommodity.Controls.Add(this.label24);
            this.tbpAddCommodity.Controls.Add(this.txtAddBarcode);
            this.tbpAddCommodity.Controls.Add(this.label12);
            this.tbpAddCommodity.Controls.Add(this.cmbAddCategory);
            this.tbpAddCommodity.Controls.Add(this.label6);
            this.tbpAddCommodity.Controls.Add(this.label1);
            this.tbpAddCommodity.Controls.Add(this.nudAddQty);
            this.tbpAddCommodity.Controls.Add(this.cmbAddCommodities);
            this.tbpAddCommodity.Location = new System.Drawing.Point(4, 32);
            this.tbpAddCommodity.Name = "tbpAddCommodity";
            this.tbpAddCommodity.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddCommodity.Size = new System.Drawing.Size(642, 390);
            this.tbpAddCommodity.TabIndex = 0;
            this.tbpAddCommodity.Text = "Add Commodities";
            this.tbpAddCommodity.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(225, 90);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 26);
            this.label25.TabIndex = 34;
            this.label25.Text = "or";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 133);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(194, 26);
            this.label24.TabIndex = 17;
            this.label24.Text = "Commodity Barcode:";
            // 
            // txtAddBarcode
            // 
            this.txtAddBarcode.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddBarcode.Location = new System.Drawing.Point(230, 127);
            this.txtAddBarcode.Name = "txtAddBarcode";
            this.txtAddBarcode.Size = new System.Drawing.Size(406, 33);
            this.txtAddBarcode.TabIndex = 16;
            this.txtAddBarcode.TabStop = false;
            this.txtAddBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt0Barcode_KeyUp);
            this.txtAddBarcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt0Barcode_PreviewKeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 26);
            this.label12.TabIndex = 12;
            this.label12.Text = "Commodity Category:";
            // 
            // cmbAddCategory
            // 
            this.cmbAddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddCategory.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCategory.FormattingEnabled = true;
            this.cmbAddCategory.Location = new System.Drawing.Point(230, 6);
            this.cmbAddCategory.Name = "cmbAddCategory";
            this.cmbAddCategory.Size = new System.Drawing.Size(409, 34);
            this.cmbAddCategory.TabIndex = 1;
            this.cmbAddCategory.SelectedIndexChanged += new System.EventHandler(this.cmb0Category_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Commodity Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantity to Add to Inventory:";
            // 
            // nudAddQty
            // 
            this.nudAddQty.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAddQty.Location = new System.Drawing.Point(548, 186);
            this.nudAddQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAddQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAddQty.Name = "nudAddQty";
            this.nudAddQty.Size = new System.Drawing.Size(88, 33);
            this.nudAddQty.TabIndex = 3;
            this.nudAddQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbAddCommodities
            // 
            this.cmbAddCommodities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddCommodities.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCommodities.FormattingEnabled = true;
            this.cmbAddCommodities.Location = new System.Drawing.Point(230, 45);
            this.cmbAddCommodities.Name = "cmbAddCommodities";
            this.cmbAddCommodities.Size = new System.Drawing.Size(409, 34);
            this.cmbAddCommodities.TabIndex = 2;
            // 
            // tbpCreateCommodity
            // 
            this.tbpCreateCommodity.Controls.Add(this.label2);
            this.tbpCreateCommodity.Controls.Add(this.label9);
            this.tbpCreateCommodity.Controls.Add(this.txtCreateVendorURL);
            this.tbpCreateCommodity.Controls.Add(this.cmbCreateCategory);
            this.tbpCreateCommodity.Controls.Add(this.label5);
            this.tbpCreateCommodity.Controls.Add(this.cmbCreateVendor);
            this.tbpCreateCommodity.Controls.Add(this.label8);
            this.tbpCreateCommodity.Controls.Add(this.txtCreateBarcode);
            this.tbpCreateCommodity.Controls.Add(this.label4);
            this.tbpCreateCommodity.Controls.Add(this.label3);
            this.tbpCreateCommodity.Controls.Add(this.nudCreateQty);
            this.tbpCreateCommodity.Controls.Add(this.txtCreateCommodity);
            this.tbpCreateCommodity.Location = new System.Drawing.Point(4, 32);
            this.tbpCreateCommodity.Name = "tbpCreateCommodity";
            this.tbpCreateCommodity.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCreateCommodity.Size = new System.Drawing.Size(642, 390);
            this.tbpCreateCommodity.TabIndex = 1;
            this.tbpCreateCommodity.Text = "Create Commodity";
            this.tbpCreateCommodity.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quantity to Add to Inventory:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "Vendor URL:";
            // 
            // txtCreateVendorURL
            // 
            this.txtCreateVendorURL.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateVendorURL.Location = new System.Drawing.Point(230, 127);
            this.txtCreateVendorURL.Name = "txtCreateVendorURL";
            this.txtCreateVendorURL.Size = new System.Drawing.Size(406, 33);
            this.txtCreateVendorURL.TabIndex = 4;
            // 
            // cmbCreateCategory
            // 
            this.cmbCreateCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreateCategory.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateCategory.FormattingEnabled = true;
            this.cmbCreateCategory.Location = new System.Drawing.Point(230, 49);
            this.cmbCreateCategory.Name = "cmbCreateCategory";
            this.cmbCreateCategory.Size = new System.Drawing.Size(406, 34);
            this.cmbCreateCategory.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Commodity Category:";
            // 
            // cmbCreateVendor
            // 
            this.cmbCreateVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreateVendor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreateVendor.FormattingEnabled = true;
            this.cmbCreateVendor.Location = new System.Drawing.Point(230, 88);
            this.cmbCreateVendor.Name = "cmbCreateVendor";
            this.cmbCreateVendor.Size = new System.Drawing.Size(406, 34);
            this.cmbCreateVendor.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Commodity Barcode:";
            // 
            // txtCreateBarcode
            // 
            this.txtCreateBarcode.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateBarcode.Location = new System.Drawing.Point(230, 164);
            this.txtCreateBarcode.Name = "txtCreateBarcode";
            this.txtCreateBarcode.Size = new System.Drawing.Size(406, 33);
            this.txtCreateBarcode.TabIndex = 14;
            this.txtCreateBarcode.TabStop = false;
            this.txtCreateBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt1Barcode_KeyUp);
            this.txtCreateBarcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt1Barcode_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vendor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Commodity Name:";
            // 
            // nudCreateQty
            // 
            this.nudCreateQty.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCreateQty.Location = new System.Drawing.Point(548, 201);
            this.nudCreateQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCreateQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCreateQty.Name = "nudCreateQty";
            this.nudCreateQty.Size = new System.Drawing.Size(88, 33);
            this.nudCreateQty.TabIndex = 5;
            this.nudCreateQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCreateCommodity
            // 
            this.txtCreateCommodity.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateCommodity.Location = new System.Drawing.Point(230, 12);
            this.txtCreateCommodity.Name = "txtCreateCommodity";
            this.txtCreateCommodity.Size = new System.Drawing.Size(406, 33);
            this.txtCreateCommodity.TabIndex = 1;
            // 
            // tbpEditCommodity
            // 
            this.tbpEditCommodity.Controls.Add(this.btnEditLookup);
            this.tbpEditCommodity.Controls.Add(this.cmbEditNewCategory);
            this.tbpEditCommodity.Controls.Add(this.label20);
            this.tbpEditCommodity.Controls.Add(this.label19);
            this.tbpEditCommodity.Controls.Add(this.txtEditNewCommodity);
            this.tbpEditCommodity.Controls.Add(this.label18);
            this.tbpEditCommodity.Controls.Add(this.lblNewQty);
            this.tbpEditCommodity.Controls.Add(this.nudEditQty);
            this.tbpEditCommodity.Controls.Add(this.chkEditQty);
            this.tbpEditCommodity.Controls.Add(this.label16);
            this.tbpEditCommodity.Controls.Add(this.txtEditVendorURL);
            this.tbpEditCommodity.Controls.Add(this.cmbEditNewVendor);
            this.tbpEditCommodity.Controls.Add(this.label15);
            this.tbpEditCommodity.Controls.Add(this.label14);
            this.tbpEditCommodity.Controls.Add(this.txtEditBarcode);
            this.tbpEditCommodity.Controls.Add(this.label13);
            this.tbpEditCommodity.Controls.Add(this.cmbEditCommodities);
            this.tbpEditCommodity.Controls.Add(this.label7);
            this.tbpEditCommodity.Controls.Add(this.cmbEditCategory);
            this.tbpEditCommodity.Location = new System.Drawing.Point(4, 32);
            this.tbpEditCommodity.Name = "tbpEditCommodity";
            this.tbpEditCommodity.Size = new System.Drawing.Size(642, 390);
            this.tbpEditCommodity.TabIndex = 2;
            this.tbpEditCommodity.Text = "Edit Commodity";
            this.tbpEditCommodity.UseVisualStyleBackColor = true;
            // 
            // btnEditLookup
            // 
            this.btnEditLookup.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLookup.Location = new System.Drawing.Point(412, 92);
            this.btnEditLookup.Name = "btnEditLookup";
            this.btnEditLookup.Size = new System.Drawing.Size(190, 53);
            this.btnEditLookup.TabIndex = 3;
            this.btnEditLookup.Text = "Lookup Item";
            this.btnEditLookup.UseVisualStyleBackColor = true;
            this.btnEditLookup.Click += new System.EventHandler(this.btn2Lookup_Click);
            // 
            // cmbEditNewCategory
            // 
            this.cmbEditNewCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditNewCategory.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditNewCategory.FormattingEnabled = true;
            this.cmbEditNewCategory.Location = new System.Drawing.Point(227, 165);
            this.cmbEditNewCategory.Name = "cmbEditNewCategory";
            this.cmbEditNewCategory.Size = new System.Drawing.Size(412, 34);
            this.cmbEditNewCategory.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(337, 26);
            this.label20.TabIndex = 7;
            this.label20.Text = "Change the commodity (listed above)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 207);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(175, 26);
            this.label19.TabIndex = 28;
            this.label19.Text = "Commodity Name:";
            // 
            // txtEditNewCommodity
            // 
            this.txtEditNewCommodity.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditNewCommodity.Location = new System.Drawing.Point(227, 204);
            this.txtEditNewCommodity.Name = "txtEditNewCommodity";
            this.txtEditNewCommodity.Size = new System.Drawing.Size(412, 33);
            this.txtEditNewCommodity.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(200, 26);
            this.label18.TabIndex = 26;
            this.label18.Text = "Commodity Category:";
            // 
            // lblNewQty
            // 
            this.lblNewQty.AutoSize = true;
            this.lblNewQty.Enabled = false;
            this.lblNewQty.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewQty.Location = new System.Drawing.Point(279, 356);
            this.lblNewQty.Name = "lblNewQty";
            this.lblNewQty.Size = new System.Drawing.Size(249, 26);
            this.lblNewQty.TabIndex = 24;
            this.lblNewQty.Text = "New Quantity in Inventory:";
            // 
            // nudEditQty
            // 
            this.nudEditQty.Enabled = false;
            this.nudEditQty.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEditQty.Location = new System.Drawing.Point(551, 354);
            this.nudEditQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEditQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEditQty.Name = "nudEditQty";
            this.nudEditQty.Size = new System.Drawing.Size(88, 33);
            this.nudEditQty.TabIndex = 8;
            this.nudEditQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkEditQty
            // 
            this.chkEditQty.AutoSize = true;
            this.chkEditQty.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditQty.Location = new System.Drawing.Point(69, 354);
            this.chkEditQty.Name = "chkEditQty";
            this.chkEditQty.Size = new System.Drawing.Size(185, 30);
            this.chkEditQty.TabIndex = 7;
            this.chkEditQty.Text = "Change Quantity?";
            this.chkEditQty.UseVisualStyleBackColor = true;
            this.chkEditQty.CheckedChanged += new System.EventHandler(this.chk2Qty_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 320);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 26);
            this.label16.TabIndex = 21;
            this.label16.Text = "Vendor URL:";
            // 
            // txtEditVendorURL
            // 
            this.txtEditVendorURL.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditVendorURL.Location = new System.Drawing.Point(227, 317);
            this.txtEditVendorURL.Name = "txtEditVendorURL";
            this.txtEditVendorURL.Size = new System.Drawing.Size(412, 33);
            this.txtEditVendorURL.TabIndex = 207;
            this.txtEditVendorURL.TabStop = false;
            // 
            // cmbEditNewVendor
            // 
            this.cmbEditNewVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditNewVendor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditNewVendor.FormattingEnabled = true;
            this.cmbEditNewVendor.Location = new System.Drawing.Point(227, 278);
            this.cmbEditNewVendor.Name = "cmbEditNewVendor";
            this.cmbEditNewVendor.Size = new System.Drawing.Size(412, 34);
            this.cmbEditNewVendor.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 26);
            this.label15.TabIndex = 18;
            this.label15.Text = "Vendor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 26);
            this.label14.TabIndex = 17;
            this.label14.Text = "Commodity Barcode:";
            // 
            // txtEditBarcode
            // 
            this.txtEditBarcode.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditBarcode.Location = new System.Drawing.Point(227, 241);
            this.txtEditBarcode.Name = "txtEditBarcode";
            this.txtEditBarcode.Size = new System.Drawing.Size(412, 33);
            this.txtEditBarcode.TabIndex = 6;
            this.txtEditBarcode.TabStop = false;
            this.txtEditBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt2Barcode_KeyUp);
            this.txtEditBarcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt2Barcode_PreviewKeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 26);
            this.label13.TabIndex = 14;
            this.label13.Text = "Commodity Name:";
            // 
            // cmbEditCommodities
            // 
            this.cmbEditCommodities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditCommodities.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditCommodities.FormattingEnabled = true;
            this.cmbEditCommodities.Location = new System.Drawing.Point(227, 44);
            this.cmbEditCommodities.Name = "cmbEditCommodities";
            this.cmbEditCommodities.Size = new System.Drawing.Size(412, 34);
            this.cmbEditCommodities.TabIndex = 2;
            this.cmbEditCommodities.SelectedIndexChanged += new System.EventHandler(this.cmb2Commodities_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Commodity Category:";
            // 
            // cmbEditCategory
            // 
            this.cmbEditCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditCategory.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditCategory.FormattingEnabled = true;
            this.cmbEditCategory.Location = new System.Drawing.Point(227, 5);
            this.cmbEditCategory.Name = "cmbEditCategory";
            this.cmbEditCategory.Size = new System.Drawing.Size(412, 34);
            this.cmbEditCategory.TabIndex = 1;
            this.cmbEditCategory.SelectedIndexChanged += new System.EventHandler(this.cmb2Category_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.txtQtyAlert);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.nudQtyAlert);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cmbQtyCategory);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(642, 390);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Edit Quantity Alert";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(322, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(208, 26);
            this.label17.TabIndex = 18;
            this.label17.Text = "Current Low Alert Qty:";
            // 
            // txtQtyAlert
            // 
            this.txtQtyAlert.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyAlert.Location = new System.Drawing.Point(551, 56);
            this.txtQtyAlert.Name = "txtQtyAlert";
            this.txtQtyAlert.ReadOnly = true;
            this.txtQtyAlert.Size = new System.Drawing.Size(88, 33);
            this.txtQtyAlert.TabIndex = 17;
            this.txtQtyAlert.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(351, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 26);
            this.label11.TabIndex = 16;
            this.label11.Text = "New Low Alert Qty:";
            // 
            // nudQtyAlert
            // 
            this.nudQtyAlert.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtyAlert.Location = new System.Drawing.Point(551, 91);
            this.nudQtyAlert.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQtyAlert.Name = "nudQtyAlert";
            this.nudQtyAlert.Size = new System.Drawing.Size(88, 33);
            this.nudQtyAlert.TabIndex = 2;
            this.nudQtyAlert.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Commodity Category:";
            // 
            // cmbQtyCategory
            // 
            this.cmbQtyCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQtyCategory.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQtyCategory.FormattingEnabled = true;
            this.cmbQtyCategory.Location = new System.Drawing.Point(227, 17);
            this.cmbQtyCategory.Name = "cmbQtyCategory";
            this.cmbQtyCategory.Size = new System.Drawing.Size(412, 34);
            this.cmbQtyCategory.TabIndex = 1;
            this.cmbQtyCategory.SelectedIndexChanged += new System.EventHandler(this.cmbQtyCategory_SelectedIndexChanged);
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
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(668, 268);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 82);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbcManage);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageInventory";
            this.Text = "Tech Bar Inventory | Manage Inventory";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.tbcManage.ResumeLayout(false);
            this.tbpAddCommodity.ResumeLayout(false);
            this.tbpAddCommodity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQty)).EndInit();
            this.tbpCreateCommodity.ResumeLayout(false);
            this.tbpCreateCommodity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreateQty)).EndInit();
            this.tbpEditCommodity.ResumeLayout(false);
            this.tbpEditCommodity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditQty)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcManage;
        private System.Windows.Forms.TabPage tbpAddCommodity;
        private System.Windows.Forms.TabPage tbpCreateCommodity;
        private System.Windows.Forms.ComboBox cmbAddCommodities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAddQty;
        private System.Windows.Forms.TextBox txtCreateCommodity;
        private System.Windows.Forms.TabPage tbpEditCommodity;
        private System.Windows.Forms.NumericUpDown nudCreateQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEditCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCreateBarcode;
        private System.Windows.Forms.ComboBox cmbCreateVendor;
        private System.Windows.Forms.ComboBox cmbCreateCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCreateVendorURL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbAddCategory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbEditCommodities;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEditBarcode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEditVendorURL;
        private System.Windows.Forms.Label lblNewQty;
        private System.Windows.Forms.NumericUpDown nudEditQty;
        private System.Windows.Forms.CheckBox chkEditQty;
        private System.Windows.Forms.ComboBox cmbEditNewVendor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEditNewCommodity;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbEditNewCategory;
        private System.Windows.Forms.Button btnEditLookup;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtAddBarcode;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbQtyCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudQtyAlert;
        private System.Windows.Forms.TextBox txtQtyAlert;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
    }
}
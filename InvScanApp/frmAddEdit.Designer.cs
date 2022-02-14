
namespace InvScanApp
{
    partial class frmAddEdit
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
            this.tbcAdd = new System.Windows.Forms.TabControl();
            this.tbpAddCommodity = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txt0Barcode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb0Category = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud0Qty = new System.Windows.Forms.NumericUpDown();
            this.cmb0Commodities = new System.Windows.Forms.ComboBox();
            this.tbpCreateCommodity = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt1VendorURL = new System.Windows.Forms.TextBox();
            this.cmb1Category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb1Vendor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt1Barcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud1Qty = new System.Windows.Forms.NumericUpDown();
            this.txt1Commodity = new System.Windows.Forms.TextBox();
            this.tbpEditCommodity = new System.Windows.Forms.TabPage();
            this.btn2Lookup = new System.Windows.Forms.Button();
            this.cmb2NewCategory = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt2NewCommodity = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblNewQty = new System.Windows.Forms.Label();
            this.nud2Qty = new System.Windows.Forms.NumericUpDown();
            this.chk2Qty = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt2VendorURL = new System.Windows.Forms.TextBox();
            this.cmb2NewVendor = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt2Barcode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb2Commodities = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb2Category = new System.Windows.Forms.ComboBox();
            this.tbpCreateCategory = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nud3Qty = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txt3Category = new System.Windows.Forms.TextBox();
            this.tbpCreateVendor = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txt4Vendor = new System.Windows.Forms.TextBox();
            this.tbpCreateStaff = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.txt5StaffID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt5Staff = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbcAdd.SuspendLayout();
            this.tbpAddCommodity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud0Qty)).BeginInit();
            this.tbpCreateCommodity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1Qty)).BeginInit();
            this.tbpEditCommodity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2Qty)).BeginInit();
            this.tbpCreateCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud3Qty)).BeginInit();
            this.tbpCreateVendor.SuspendLayout();
            this.tbpCreateStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcAdd
            // 
            this.tbcAdd.Controls.Add(this.tbpAddCommodity);
            this.tbcAdd.Controls.Add(this.tbpCreateCommodity);
            this.tbcAdd.Controls.Add(this.tbpEditCommodity);
            this.tbcAdd.Controls.Add(this.tbpCreateCategory);
            this.tbcAdd.Controls.Add(this.tbpCreateVendor);
            this.tbcAdd.Controls.Add(this.tbpCreateStaff);
            this.tbcAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcAdd.Location = new System.Drawing.Point(12, 12);
            this.tbcAdd.Name = "tbcAdd";
            this.tbcAdd.SelectedIndex = 0;
            this.tbcAdd.Size = new System.Drawing.Size(650, 426);
            this.tbcAdd.TabIndex = 0;
            this.tbcAdd.SelectedIndexChanged += new System.EventHandler(this.tbcAdd_SelectedIndexChanged);
            // 
            // tbpAddCommodity
            // 
            this.tbpAddCommodity.Controls.Add(this.label25);
            this.tbpAddCommodity.Controls.Add(this.label24);
            this.tbpAddCommodity.Controls.Add(this.txt0Barcode);
            this.tbpAddCommodity.Controls.Add(this.label12);
            this.tbpAddCommodity.Controls.Add(this.cmb0Category);
            this.tbpAddCommodity.Controls.Add(this.label6);
            this.tbpAddCommodity.Controls.Add(this.label1);
            this.tbpAddCommodity.Controls.Add(this.nud0Qty);
            this.tbpAddCommodity.Controls.Add(this.cmb0Commodities);
            this.tbpAddCommodity.Location = new System.Drawing.Point(4, 34);
            this.tbpAddCommodity.Name = "tbpAddCommodity";
            this.tbpAddCommodity.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddCommodity.Size = new System.Drawing.Size(642, 388);
            this.tbpAddCommodity.TabIndex = 0;
            this.tbpAddCommodity.Text = "Add Commodities";
            this.tbpAddCommodity.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(225, 90);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(33, 25);
            this.label25.TabIndex = 34;
            this.label25.Text = "or";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 133);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(211, 25);
            this.label24.TabIndex = 17;
            this.label24.Text = "Commodity Barcode:";
            // 
            // txt0Barcode
            // 
            this.txt0Barcode.Location = new System.Drawing.Point(230, 127);
            this.txt0Barcode.Name = "txt0Barcode";
            this.txt0Barcode.Size = new System.Drawing.Size(406, 31);
            this.txt0Barcode.TabIndex = 16;
            this.txt0Barcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt0Barcode_KeyUp);
            this.txt0Barcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt0Barcode_PreviewKeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(218, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "Commodity Category:";
            // 
            // cmb0Category
            // 
            this.cmb0Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb0Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb0Category.FormattingEnabled = true;
            this.cmb0Category.Location = new System.Drawing.Point(230, 6);
            this.cmb0Category.Name = "cmb0Category";
            this.cmb0Category.Size = new System.Drawing.Size(409, 33);
            this.cmb0Category.TabIndex = 11;
            this.cmb0Category.SelectedIndexChanged += new System.EventHandler(this.cmb0Category_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Commodity Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantity to Add to Inventory:";
            // 
            // nud0Qty
            // 
            this.nud0Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud0Qty.Location = new System.Drawing.Point(548, 186);
            this.nud0Qty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud0Qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud0Qty.Name = "nud0Qty";
            this.nud0Qty.Size = new System.Drawing.Size(88, 31);
            this.nud0Qty.TabIndex = 1;
            this.nud0Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmb0Commodities
            // 
            this.cmb0Commodities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb0Commodities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb0Commodities.FormattingEnabled = true;
            this.cmb0Commodities.Location = new System.Drawing.Point(230, 45);
            this.cmb0Commodities.Name = "cmb0Commodities";
            this.cmb0Commodities.Size = new System.Drawing.Size(409, 33);
            this.cmb0Commodities.TabIndex = 0;
            // 
            // tbpCreateCommodity
            // 
            this.tbpCreateCommodity.Controls.Add(this.label2);
            this.tbpCreateCommodity.Controls.Add(this.label9);
            this.tbpCreateCommodity.Controls.Add(this.txt1VendorURL);
            this.tbpCreateCommodity.Controls.Add(this.cmb1Category);
            this.tbpCreateCommodity.Controls.Add(this.label5);
            this.tbpCreateCommodity.Controls.Add(this.cmb1Vendor);
            this.tbpCreateCommodity.Controls.Add(this.label8);
            this.tbpCreateCommodity.Controls.Add(this.txt1Barcode);
            this.tbpCreateCommodity.Controls.Add(this.label4);
            this.tbpCreateCommodity.Controls.Add(this.label3);
            this.tbpCreateCommodity.Controls.Add(this.nud1Qty);
            this.tbpCreateCommodity.Controls.Add(this.txt1Commodity);
            this.tbpCreateCommodity.Location = new System.Drawing.Point(4, 34);
            this.tbpCreateCommodity.Name = "tbpCreateCommodity";
            this.tbpCreateCommodity.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCreateCommodity.Size = new System.Drawing.Size(642, 388);
            this.tbpCreateCommodity.TabIndex = 1;
            this.tbpCreateCommodity.Text = "Create Commodity";
            this.tbpCreateCommodity.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quantity to Add to Inventory:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Vendor URL:";
            // 
            // txt1VendorURL
            // 
            this.txt1VendorURL.Location = new System.Drawing.Point(230, 127);
            this.txt1VendorURL.Name = "txt1VendorURL";
            this.txt1VendorURL.Size = new System.Drawing.Size(406, 31);
            this.txt1VendorURL.TabIndex = 20;
            // 
            // cmb1Category
            // 
            this.cmb1Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb1Category.FormattingEnabled = true;
            this.cmb1Category.Location = new System.Drawing.Point(230, 49);
            this.cmb1Category.Name = "cmb1Category";
            this.cmb1Category.Size = new System.Drawing.Size(406, 33);
            this.cmb1Category.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Commodity Category:";
            // 
            // cmb1Vendor
            // 
            this.cmb1Vendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb1Vendor.FormattingEnabled = true;
            this.cmb1Vendor.Location = new System.Drawing.Point(230, 88);
            this.cmb1Vendor.Name = "cmb1Vendor";
            this.cmb1Vendor.Size = new System.Drawing.Size(406, 33);
            this.cmb1Vendor.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Commodity Barcode:";
            // 
            // txt1Barcode
            // 
            this.txt1Barcode.Location = new System.Drawing.Point(230, 164);
            this.txt1Barcode.Name = "txt1Barcode";
            this.txt1Barcode.Size = new System.Drawing.Size(406, 31);
            this.txt1Barcode.TabIndex = 14;
            this.txt1Barcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt1Barcode_KeyUp);
            this.txt1Barcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt1Barcode_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vendor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Commodity Name:";
            // 
            // nud1Qty
            // 
            this.nud1Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud1Qty.Location = new System.Drawing.Point(548, 201);
            this.nud1Qty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud1Qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud1Qty.Name = "nud1Qty";
            this.nud1Qty.Size = new System.Drawing.Size(88, 31);
            this.nud1Qty.TabIndex = 7;
            this.nud1Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt1Commodity
            // 
            this.txt1Commodity.Location = new System.Drawing.Point(230, 12);
            this.txt1Commodity.Name = "txt1Commodity";
            this.txt1Commodity.Size = new System.Drawing.Size(406, 31);
            this.txt1Commodity.TabIndex = 6;
            // 
            // tbpEditCommodity
            // 
            this.tbpEditCommodity.Controls.Add(this.btn2Lookup);
            this.tbpEditCommodity.Controls.Add(this.cmb2NewCategory);
            this.tbpEditCommodity.Controls.Add(this.label20);
            this.tbpEditCommodity.Controls.Add(this.label19);
            this.tbpEditCommodity.Controls.Add(this.txt2NewCommodity);
            this.tbpEditCommodity.Controls.Add(this.label18);
            this.tbpEditCommodity.Controls.Add(this.lblNewQty);
            this.tbpEditCommodity.Controls.Add(this.nud2Qty);
            this.tbpEditCommodity.Controls.Add(this.chk2Qty);
            this.tbpEditCommodity.Controls.Add(this.label16);
            this.tbpEditCommodity.Controls.Add(this.txt2VendorURL);
            this.tbpEditCommodity.Controls.Add(this.cmb2NewVendor);
            this.tbpEditCommodity.Controls.Add(this.label15);
            this.tbpEditCommodity.Controls.Add(this.label14);
            this.tbpEditCommodity.Controls.Add(this.txt2Barcode);
            this.tbpEditCommodity.Controls.Add(this.label13);
            this.tbpEditCommodity.Controls.Add(this.cmb2Commodities);
            this.tbpEditCommodity.Controls.Add(this.label7);
            this.tbpEditCommodity.Controls.Add(this.cmb2Category);
            this.tbpEditCommodity.Location = new System.Drawing.Point(4, 34);
            this.tbpEditCommodity.Name = "tbpEditCommodity";
            this.tbpEditCommodity.Size = new System.Drawing.Size(642, 388);
            this.tbpEditCommodity.TabIndex = 2;
            this.tbpEditCommodity.Text = "Edit Commodity";
            this.tbpEditCommodity.UseVisualStyleBackColor = true;
            // 
            // btn2Lookup
            // 
            this.btn2Lookup.Location = new System.Drawing.Point(412, 92);
            this.btn2Lookup.Name = "btn2Lookup";
            this.btn2Lookup.Size = new System.Drawing.Size(190, 53);
            this.btn2Lookup.TabIndex = 30;
            this.btn2Lookup.Text = "Lookup Item";
            this.btn2Lookup.UseVisualStyleBackColor = true;
            this.btn2Lookup.Click += new System.EventHandler(this.btn2Lookup_Click);
            // 
            // cmb2NewCategory
            // 
            this.cmb2NewCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2NewCategory.FormattingEnabled = true;
            this.cmb2NewCategory.Location = new System.Drawing.Point(227, 165);
            this.cmb2NewCategory.Name = "cmb2NewCategory";
            this.cmb2NewCategory.Size = new System.Drawing.Size(412, 33);
            this.cmb2NewCategory.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(403, 25);
            this.label20.TabIndex = 7;
            this.label20.Text = "Change the commodity (listed above)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 207);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(187, 25);
            this.label19.TabIndex = 28;
            this.label19.Text = "Commodity Name:";
            // 
            // txt2NewCommodity
            // 
            this.txt2NewCommodity.Location = new System.Drawing.Point(227, 204);
            this.txt2NewCommodity.Name = "txt2NewCommodity";
            this.txt2NewCommodity.Size = new System.Drawing.Size(412, 31);
            this.txt2NewCommodity.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(218, 25);
            this.label18.TabIndex = 26;
            this.label18.Text = "Commodity Category:";
            // 
            // lblNewQty
            // 
            this.lblNewQty.AutoSize = true;
            this.lblNewQty.Enabled = false;
            this.lblNewQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewQty.Location = new System.Drawing.Point(279, 356);
            this.lblNewQty.Name = "lblNewQty";
            this.lblNewQty.Size = new System.Drawing.Size(263, 25);
            this.lblNewQty.TabIndex = 24;
            this.lblNewQty.Text = "New Quantity in Inventory:";
            // 
            // nud2Qty
            // 
            this.nud2Qty.Enabled = false;
            this.nud2Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud2Qty.Location = new System.Drawing.Point(551, 354);
            this.nud2Qty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud2Qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud2Qty.Name = "nud2Qty";
            this.nud2Qty.Size = new System.Drawing.Size(88, 31);
            this.nud2Qty.TabIndex = 23;
            this.nud2Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chk2Qty
            // 
            this.chk2Qty.AutoSize = true;
            this.chk2Qty.Location = new System.Drawing.Point(69, 354);
            this.chk2Qty.Name = "chk2Qty";
            this.chk2Qty.Size = new System.Drawing.Size(204, 29);
            this.chk2Qty.TabIndex = 22;
            this.chk2Qty.Text = "Change Quantity?";
            this.chk2Qty.UseVisualStyleBackColor = true;
            this.chk2Qty.CheckedChanged += new System.EventHandler(this.chk2Qty_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 320);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 25);
            this.label16.TabIndex = 21;
            this.label16.Text = "Vendor URL:";
            // 
            // txt2VendorURL
            // 
            this.txt2VendorURL.Location = new System.Drawing.Point(227, 317);
            this.txt2VendorURL.Name = "txt2VendorURL";
            this.txt2VendorURL.Size = new System.Drawing.Size(412, 31);
            this.txt2VendorURL.TabIndex = 20;
            // 
            // cmb2NewVendor
            // 
            this.cmb2NewVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2NewVendor.FormattingEnabled = true;
            this.cmb2NewVendor.Location = new System.Drawing.Point(227, 278);
            this.cmb2NewVendor.Name = "cmb2NewVendor";
            this.cmb2NewVendor.Size = new System.Drawing.Size(412, 33);
            this.cmb2NewVendor.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 25);
            this.label15.TabIndex = 18;
            this.label15.Text = "Vendor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "Commodity Barcode:";
            // 
            // txt2Barcode
            // 
            this.txt2Barcode.Location = new System.Drawing.Point(227, 241);
            this.txt2Barcode.Name = "txt2Barcode";
            this.txt2Barcode.Size = new System.Drawing.Size(412, 31);
            this.txt2Barcode.TabIndex = 16;
            this.txt2Barcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt2Barcode_KeyUp);
            this.txt2Barcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt2Barcode_PreviewKeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "Commodity Name:";
            // 
            // cmb2Commodities
            // 
            this.cmb2Commodities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2Commodities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb2Commodities.FormattingEnabled = true;
            this.cmb2Commodities.Location = new System.Drawing.Point(227, 44);
            this.cmb2Commodities.Name = "cmb2Commodities";
            this.cmb2Commodities.Size = new System.Drawing.Size(412, 33);
            this.cmb2Commodities.TabIndex = 13;
            this.cmb2Commodities.SelectedIndexChanged += new System.EventHandler(this.cmb2Commodities_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Commodity Category:";
            // 
            // cmb2Category
            // 
            this.cmb2Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb2Category.FormattingEnabled = true;
            this.cmb2Category.Location = new System.Drawing.Point(227, 5);
            this.cmb2Category.Name = "cmb2Category";
            this.cmb2Category.Size = new System.Drawing.Size(412, 33);
            this.cmb2Category.TabIndex = 11;
            this.cmb2Category.SelectedIndexChanged += new System.EventHandler(this.cmb2Category_SelectedIndexChanged);
            // 
            // tbpCreateCategory
            // 
            this.tbpCreateCategory.Controls.Add(this.label23);
            this.tbpCreateCategory.Controls.Add(this.label22);
            this.tbpCreateCategory.Controls.Add(this.nud3Qty);
            this.tbpCreateCategory.Controls.Add(this.label10);
            this.tbpCreateCategory.Controls.Add(this.txt3Category);
            this.tbpCreateCategory.Location = new System.Drawing.Point(4, 34);
            this.tbpCreateCategory.Name = "tbpCreateCategory";
            this.tbpCreateCategory.Size = new System.Drawing.Size(642, 388);
            this.tbpCreateCategory.TabIndex = 3;
            this.tbpCreateCategory.Text = "Create Category";
            this.tbpCreateCategory.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(318, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(315, 132);
            this.label23.TabIndex = 27;
            this.label23.Text = "Note: The program will alert the designated email any time a commodity of this ca" +
    "tegory hits the low quantity threshold.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(193, 25);
            this.label22.TabIndex = 26;
            this.label22.Text = "Low Alert Quantity:";
            // 
            // nud3Qty
            // 
            this.nud3Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud3Qty.Location = new System.Drawing.Point(224, 49);
            this.nud3Qty.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud3Qty.Name = "nud3Qty";
            this.nud3Qty.Size = new System.Drawing.Size(88, 31);
            this.nud3Qty.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "New Category Name:";
            // 
            // txt3Category
            // 
            this.txt3Category.Location = new System.Drawing.Point(224, 12);
            this.txt3Category.Name = "txt3Category";
            this.txt3Category.Size = new System.Drawing.Size(409, 31);
            this.txt3Category.TabIndex = 10;
            // 
            // tbpCreateVendor
            // 
            this.tbpCreateVendor.Controls.Add(this.label11);
            this.tbpCreateVendor.Controls.Add(this.txt4Vendor);
            this.tbpCreateVendor.Location = new System.Drawing.Point(4, 34);
            this.tbpCreateVendor.Name = "tbpCreateVendor";
            this.tbpCreateVendor.Size = new System.Drawing.Size(642, 388);
            this.tbpCreateVendor.TabIndex = 4;
            this.tbpCreateVendor.Text = "Create Vendor";
            this.tbpCreateVendor.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "New Vendor Name:";
            // 
            // txt4Vendor
            // 
            this.txt4Vendor.Location = new System.Drawing.Point(212, 12);
            this.txt4Vendor.Name = "txt4Vendor";
            this.txt4Vendor.Size = new System.Drawing.Size(427, 31);
            this.txt4Vendor.TabIndex = 12;
            // 
            // tbpCreateStaff
            // 
            this.tbpCreateStaff.Controls.Add(this.label21);
            this.tbpCreateStaff.Controls.Add(this.txt5StaffID);
            this.tbpCreateStaff.Controls.Add(this.label17);
            this.tbpCreateStaff.Controls.Add(this.txt5Staff);
            this.tbpCreateStaff.Location = new System.Drawing.Point(4, 34);
            this.tbpCreateStaff.Name = "tbpCreateStaff";
            this.tbpCreateStaff.Size = new System.Drawing.Size(642, 388);
            this.tbpCreateStaff.TabIndex = 5;
            this.tbpCreateStaff.Text = "Create Staff";
            this.tbpCreateStaff.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 25);
            this.label21.TabIndex = 17;
            this.label21.Text = "New Staff ID:";
            // 
            // txt5StaffID
            // 
            this.txt5StaffID.Location = new System.Drawing.Point(187, 51);
            this.txt5StaffID.Name = "txt5StaffID";
            this.txt5StaffID.Size = new System.Drawing.Size(452, 31);
            this.txt5StaffID.TabIndex = 16;
            this.txt5StaffID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt5StaffID_KeyUp);
            this.txt5StaffID.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt5StaffID_PreviewKeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 25);
            this.label17.TabIndex = 15;
            this.label17.Text = "New Staff Name:";
            // 
            // txt5Staff
            // 
            this.txt5Staff.Location = new System.Drawing.Point(187, 14);
            this.txt5Staff.Name = "txt5Staff";
            this.txt5Staff.Size = new System.Drawing.Size(452, 31);
            this.txt5Staff.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(668, 338);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 100);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(668, 232);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 100);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbcAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEdit";
            this.Text = "Add/Edit";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.tbcAdd.ResumeLayout(false);
            this.tbpAddCommodity.ResumeLayout(false);
            this.tbpAddCommodity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud0Qty)).EndInit();
            this.tbpCreateCommodity.ResumeLayout(false);
            this.tbpCreateCommodity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1Qty)).EndInit();
            this.tbpEditCommodity.ResumeLayout(false);
            this.tbpEditCommodity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2Qty)).EndInit();
            this.tbpCreateCategory.ResumeLayout(false);
            this.tbpCreateCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud3Qty)).EndInit();
            this.tbpCreateVendor.ResumeLayout(false);
            this.tbpCreateVendor.PerformLayout();
            this.tbpCreateStaff.ResumeLayout(false);
            this.tbpCreateStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcAdd;
        private System.Windows.Forms.TabPage tbpAddCommodity;
        private System.Windows.Forms.TabPage tbpCreateCommodity;
        private System.Windows.Forms.ComboBox cmb0Commodities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud0Qty;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txt1Commodity;
        private System.Windows.Forms.TabPage tbpEditCommodity;
        private System.Windows.Forms.NumericUpDown nud1Qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb2Category;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt1Barcode;
        private System.Windows.Forms.ComboBox cmb1Vendor;
        private System.Windows.Forms.ComboBox cmb1Category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt1VendorURL;
        private System.Windows.Forms.TabPage tbpCreateCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt3Category;
        private System.Windows.Forms.TabPage tbpCreateVendor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt4Vendor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb0Category;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb2Commodities;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt2Barcode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt2VendorURL;
        private System.Windows.Forms.Label lblNewQty;
        private System.Windows.Forms.NumericUpDown nud2Qty;
        private System.Windows.Forms.CheckBox chk2Qty;
        private System.Windows.Forms.ComboBox cmb2NewVendor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt2NewCommodity;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmb2NewCategory;
        private System.Windows.Forms.Button btn2Lookup;
        private System.Windows.Forms.TabPage tbpCreateStaff;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt5Staff;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt5StaffID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown nud3Qty;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt0Barcode;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label2;
    }
}
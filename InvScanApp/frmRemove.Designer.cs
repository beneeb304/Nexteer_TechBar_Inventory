
namespace InvScanApp
{
    partial class frmRemove
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rdoCategory = new System.Windows.Forms.RadioButton();
            this.gpbTables = new System.Windows.Forms.GroupBox();
            this.rdoStaff = new System.Windows.Forms.RadioButton();
            this.rdoVendor = new System.Windows.Forms.RadioButton();
            this.rdoCommodity = new System.Windows.Forms.RadioButton();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.gpbTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(668, 338);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 100);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(668, 232);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 100);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Remove";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdoCategory
            // 
            this.rdoCategory.AutoSize = true;
            this.rdoCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCategory.Location = new System.Drawing.Point(6, 19);
            this.rdoCategory.Name = "rdoCategory";
            this.rdoCategory.Size = new System.Drawing.Size(117, 29);
            this.rdoCategory.TabIndex = 8;
            this.rdoCategory.TabStop = true;
            this.rdoCategory.Text = "Category";
            this.rdoCategory.UseVisualStyleBackColor = true;
            this.rdoCategory.Click += new System.EventHandler(this.SetControls);
            // 
            // gpbTables
            // 
            this.gpbTables.Controls.Add(this.rdoStaff);
            this.gpbTables.Controls.Add(this.rdoVendor);
            this.gpbTables.Controls.Add(this.rdoCommodity);
            this.gpbTables.Controls.Add(this.rdoCategory);
            this.gpbTables.Location = new System.Drawing.Point(11, 12);
            this.gpbTables.Name = "gpbTables";
            this.gpbTables.Size = new System.Drawing.Size(262, 98);
            this.gpbTables.TabIndex = 9;
            this.gpbTables.TabStop = false;
            this.gpbTables.Text = "Tables";
            // 
            // rdoStaff
            // 
            this.rdoStaff.AutoSize = true;
            this.rdoStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStaff.Location = new System.Drawing.Point(149, 19);
            this.rdoStaff.Name = "rdoStaff";
            this.rdoStaff.Size = new System.Drawing.Size(74, 29);
            this.rdoStaff.TabIndex = 10;
            this.rdoStaff.TabStop = true;
            this.rdoStaff.Text = "Staff";
            this.rdoStaff.UseVisualStyleBackColor = true;
            this.rdoStaff.Click += new System.EventHandler(this.SetControls);
            // 
            // rdoVendor
            // 
            this.rdoVendor.AutoSize = true;
            this.rdoVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVendor.Location = new System.Drawing.Point(149, 54);
            this.rdoVendor.Name = "rdoVendor";
            this.rdoVendor.Size = new System.Drawing.Size(99, 29);
            this.rdoVendor.TabIndex = 10;
            this.rdoVendor.TabStop = true;
            this.rdoVendor.Text = "Vendor";
            this.rdoVendor.UseVisualStyleBackColor = true;
            this.rdoVendor.Click += new System.EventHandler(this.SetControls);
            // 
            // rdoCommodity
            // 
            this.rdoCommodity.AutoSize = true;
            this.rdoCommodity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCommodity.Location = new System.Drawing.Point(6, 54);
            this.rdoCommodity.Name = "rdoCommodity";
            this.rdoCommodity.Size = new System.Drawing.Size(137, 29);
            this.rdoCommodity.TabIndex = 9;
            this.rdoCommodity.TabStop = true;
            this.rdoCommodity.Text = "Commodity";
            this.rdoCommodity.UseVisualStyleBackColor = true;
            this.rdoCommodity.Click += new System.EventHandler(this.SetControls);
            // 
            // cmbField
            // 
            this.cmbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(17, 193);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(409, 33);
            this.cmbField.TabIndex = 12;
            this.cmbField.SelectedIndexChanged += new System.EventHandler(this.cmbField_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 75);
            this.label1.TabIndex = 13;
            this.label1.Text = "Note: You cannot delete a Category/Vendor if there are Commodities with this Cate" +
    "gory/Vendor assigned!";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 75);
            this.label2.TabIndex = 14;
            this.label2.Text = "To delete the Category/Vendor, first remove or modify the affected Commodities!";
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(17, 232);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(409, 111);
            this.txtDetails.TabIndex = 15;
            // 
            // frmRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbField);
            this.Controls.Add(this.gpbTables);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRemove";
            this.Text = "Remove";
            this.gpbTables.ResumeLayout(false);
            this.gpbTables.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdoCategory;
        private System.Windows.Forms.GroupBox gpbTables;
        private System.Windows.Forms.RadioButton rdoStaff;
        private System.Windows.Forms.RadioButton rdoVendor;
        private System.Windows.Forms.RadioButton rdoCommodity;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetails;
    }
}
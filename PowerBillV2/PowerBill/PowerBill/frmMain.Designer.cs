namespace PowerBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picPowerCompany = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.lblkWh1Prompt = new System.Windows.Forms.Label();
            this.lblkWh2Prompt = new System.Windows.Forms.Label();
            this.txtkWh1 = new System.Windows.Forms.TextBox();
            this.txtkWh2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.grbSummary = new System.Windows.Forms.GroupBox();
            this.lblTotCharge = new System.Windows.Forms.Label();
            this.lblIndCharge = new System.Windows.Forms.Label();
            this.lblComCharge = new System.Windows.Forms.Label();
            this.lblResCharge = new System.Windows.Forms.Label();
            this.lblTotCus = new System.Windows.Forms.Label();
            this.lblTotalCharg = new System.Windows.Forms.Label();
            this.lblIndCharg = new System.Windows.Forms.Label();
            this.lblComCharg = new System.Windows.Forms.Label();
            this.lblResCharg = new System.Windows.Forms.Label();
            this.lblTotalCust = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPowerCompany)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPowerCompany
            // 
            this.picPowerCompany.Image = ((System.Drawing.Image)(resources.GetObject("picPowerCompany.Image")));
            this.picPowerCompany.Location = new System.Drawing.Point(45, 48);
            this.picPowerCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPowerCompany.Name = "picPowerCompany";
            this.picPowerCompany.Size = new System.Drawing.Size(410, 232);
            this.picPowerCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPowerCompany.TabIndex = 0;
            this.picPowerCompany.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radIndustrial);
            this.groupBox1.Controls.Add(this.radCommercial);
            this.groupBox1.Controls.Add(this.radResidential);
            this.groupBox1.Location = new System.Drawing.Point(496, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select customer type";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(386, 42);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(86, 21);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Location = new System.Drawing.Point(196, 42);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(102, 21);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Location = new System.Drawing.Point(33, 42);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(99, 21);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // lblkWh1Prompt
            // 
            this.lblkWh1Prompt.AutoSize = true;
            this.lblkWh1Prompt.Location = new System.Drawing.Point(502, 239);
            this.lblkWh1Prompt.Name = "lblkWh1Prompt";
            this.lblkWh1Prompt.Size = new System.Drawing.Size(77, 17);
            this.lblkWh1Prompt.TabIndex = 2;
            this.lblkWh1Prompt.Text = "Used khW:";
            // 
            // lblkWh2Prompt
            // 
            this.lblkWh2Prompt.AutoSize = true;
            this.lblkWh2Prompt.Location = new System.Drawing.Point(502, 289);
            this.lblkWh2Prompt.Name = "lblkWh2Prompt";
            this.lblkWh2Prompt.Size = new System.Drawing.Size(99, 17);
            this.lblkWh2Prompt.TabIndex = 3;
            this.lblkWh2Prompt.Text = "Off-peak khW:";
            // 
            // txtkWh1
            // 
            this.txtkWh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkWh1.Location = new System.Drawing.Point(666, 226);
            this.txtkWh1.Name = "txtkWh1";
            this.txtkWh1.Size = new System.Drawing.Size(128, 34);
            this.txtkWh1.TabIndex = 4;
            // 
            // txtkWh2
            // 
            this.txtkWh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkWh2.Location = new System.Drawing.Point(666, 276);
            this.txtkWh2.Name = "txtkWh2";
            this.txtkWh2.Size = new System.Drawing.Size(128, 34);
            this.txtkWh2.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(737, 331);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 44);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(737, 427);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 42);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(737, 508);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(502, 149);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(109, 17);
            this.lblCustName.TabIndex = 11;
            this.lblCustName.Text = "Customer Name";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(502, 198);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(113, 17);
            this.lblAccountNumber.TabIndex = 12;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(668, 149);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(307, 23);
            this.txtCustName.TabIndex = 13;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(668, 192);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(307, 23);
            this.txtAccountNumber.TabIndex = 14;
            // 
            // grbSummary
            // 
            this.grbSummary.Controls.Add(this.lblTotCharge);
            this.grbSummary.Controls.Add(this.lblIndCharge);
            this.grbSummary.Controls.Add(this.lblComCharge);
            this.grbSummary.Controls.Add(this.lblResCharge);
            this.grbSummary.Controls.Add(this.lblTotCus);
            this.grbSummary.Controls.Add(this.lblTotalCharg);
            this.grbSummary.Controls.Add(this.lblIndCharg);
            this.grbSummary.Controls.Add(this.lblComCharg);
            this.grbSummary.Controls.Add(this.lblResCharg);
            this.grbSummary.Controls.Add(this.lblTotalCust);
            this.grbSummary.Location = new System.Drawing.Point(33, 315);
            this.grbSummary.Name = "grbSummary";
            this.grbSummary.Size = new System.Drawing.Size(268, 259);
            this.grbSummary.TabIndex = 15;
            this.grbSummary.TabStop = false;
            this.grbSummary.Text = "Summary:";
            // 
            // lblTotCharge
            // 
            this.lblTotCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotCharge.Location = new System.Drawing.Point(177, 213);
            this.lblTotCharge.Name = "lblTotCharge";
            this.lblTotCharge.Size = new System.Drawing.Size(85, 31);
            this.lblTotCharge.TabIndex = 9;
            this.lblTotCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndCharge
            // 
            this.lblIndCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndCharge.Location = new System.Drawing.Point(177, 169);
            this.lblIndCharge.Name = "lblIndCharge";
            this.lblIndCharge.Size = new System.Drawing.Size(85, 31);
            this.lblIndCharge.TabIndex = 8;
            this.lblIndCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComCharge
            // 
            this.lblComCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComCharge.Location = new System.Drawing.Point(177, 125);
            this.lblComCharge.Name = "lblComCharge";
            this.lblComCharge.Size = new System.Drawing.Size(85, 31);
            this.lblComCharge.TabIndex = 7;
            this.lblComCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResCharge
            // 
            this.lblResCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResCharge.Location = new System.Drawing.Point(177, 81);
            this.lblResCharge.Name = "lblResCharge";
            this.lblResCharge.Size = new System.Drawing.Size(85, 31);
            this.lblResCharge.TabIndex = 6;
            this.lblResCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotCus
            // 
            this.lblTotCus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotCus.Location = new System.Drawing.Point(177, 29);
            this.lblTotCus.Name = "lblTotCus";
            this.lblTotCus.Size = new System.Drawing.Size(85, 31);
            this.lblTotCus.TabIndex = 5;
            this.lblTotCus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCharg
            // 
            this.lblTotalCharg.AutoSize = true;
            this.lblTotalCharg.Location = new System.Drawing.Point(29, 213);
            this.lblTotalCharg.Name = "lblTotalCharg";
            this.lblTotalCharg.Size = new System.Drawing.Size(90, 17);
            this.lblTotalCharg.TabIndex = 4;
            this.lblTotalCharg.Text = "Total Charge";
            // 
            // lblIndCharg
            // 
            this.lblIndCharg.AutoSize = true;
            this.lblIndCharg.Location = new System.Drawing.Point(29, 169);
            this.lblIndCharg.Name = "lblIndCharg";
            this.lblIndCharg.Size = new System.Drawing.Size(81, 17);
            this.lblIndCharg.TabIndex = 3;
            this.lblIndCharg.Text = "Ind. Charge";
            // 
            // lblComCharg
            // 
            this.lblComCharg.AutoSize = true;
            this.lblComCharg.Location = new System.Drawing.Point(29, 125);
            this.lblComCharg.Name = "lblComCharg";
            this.lblComCharg.Size = new System.Drawing.Size(90, 17);
            this.lblComCharg.TabIndex = 2;
            this.lblComCharg.Text = "Com. Charge";
            // 
            // lblResCharg
            // 
            this.lblResCharg.AutoSize = true;
            this.lblResCharg.Location = new System.Drawing.Point(29, 81);
            this.lblResCharg.Name = "lblResCharg";
            this.lblResCharg.Size = new System.Drawing.Size(87, 17);
            this.lblResCharg.TabIndex = 1;
            this.lblResCharg.Text = "Res. Charge";
            // 
            // lblTotalCust
            // 
            this.lblTotalCust.AutoSize = true;
            this.lblTotalCust.Location = new System.Drawing.Point(29, 37);
            this.lblTotalCust.Name = "lblTotalCust";
            this.lblTotalCust.Size = new System.Drawing.Size(115, 17);
            this.lblTotalCust.TabIndex = 0;
            this.lblTotalCust.Text = "Total Customers:";
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 16;
            this.lstCustomers.Location = new System.Drawing.Point(365, 331);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(263, 244);
            this.lstCustomers.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 581);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.grbSummary);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtkWh2);
            this.Controls.Add(this.txtkWh1);
            this.Controls.Add(this.lblkWh2Prompt);
            this.Controls.Add(this.lblkWh1Prompt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picPowerCompany);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Company Charges";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picPowerCompany)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbSummary.ResumeLayout(false);
            this.grbSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPowerCompany;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.Label lblkWh1Prompt;
        private System.Windows.Forms.Label lblkWh2Prompt;
        private System.Windows.Forms.TextBox txtkWh1;
        private System.Windows.Forms.TextBox txtkWh2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.GroupBox grbSummary;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblTotalCharg;
        private System.Windows.Forms.Label lblIndCharg;
        private System.Windows.Forms.Label lblComCharg;
        private System.Windows.Forms.Label lblResCharg;
        private System.Windows.Forms.Label lblTotalCust;
        private System.Windows.Forms.Label lblTotCus;
        private System.Windows.Forms.Label lblResCharge;
        private System.Windows.Forms.Label lblTotCharge;
        private System.Windows.Forms.Label lblIndCharge;
        private System.Windows.Forms.Label lblComCharge;
    }
}


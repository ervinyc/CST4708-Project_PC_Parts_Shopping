namespace CST4708_Project
{
    partial class Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FullNameTB = new System.Windows.Forms.TextBox();
            this.CardNumTB = new System.Windows.Forms.TextBox();
            this.CSVTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.CityTB = new System.Windows.Forms.TextBox();
            this.StateTB = new System.Windows.Forms.TextBox();
            this.ZipCodeTB = new System.Windows.Forms.TextBox();
            this.YearCB = new System.Windows.Forms.ComboBox();
            this.MonthCB = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FullNameErrorLbl = new System.Windows.Forms.Label();
            this.CardNumErrorLbl = new System.Windows.Forms.Label();
            this.ExpDateErrorLbl = new System.Windows.Forms.Label();
            this.CSVErrorLbl = new System.Windows.Forms.Label();
            this.AddressErrorLbl = new System.Windows.Forms.Label();
            this.CityErrorLbl = new System.Windows.Forms.Label();
            this.StateErrorLbl = new System.Windows.Forms.Label();
            this.ZipCodeErrorLbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(288, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Payment Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name on Card:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exp Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CSV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address Line:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "City/Town:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Zip Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Card Number:";
            // 
            // FullNameTB
            // 
            this.FullNameTB.Location = new System.Drawing.Point(394, 107);
            this.FullNameTB.Name = "FullNameTB";
            this.FullNameTB.Size = new System.Drawing.Size(170, 23);
            this.FullNameTB.TabIndex = 0;
            // 
            // CardNumTB
            // 
            this.CardNumTB.Location = new System.Drawing.Point(394, 141);
            this.CardNumTB.Name = "CardNumTB";
            this.CardNumTB.Size = new System.Drawing.Size(170, 23);
            this.CardNumTB.TabIndex = 1;
            // 
            // CSVTB
            // 
            this.CSVTB.Location = new System.Drawing.Point(394, 220);
            this.CSVTB.Name = "CSVTB";
            this.CSVTB.Size = new System.Drawing.Size(53, 23);
            this.CSVTB.TabIndex = 4;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(394, 256);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(170, 23);
            this.AddressTB.TabIndex = 5;
            // 
            // CityTB
            // 
            this.CityTB.Location = new System.Drawing.Point(394, 295);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(170, 23);
            this.CityTB.TabIndex = 6;
            // 
            // StateTB
            // 
            this.StateTB.Location = new System.Drawing.Point(394, 332);
            this.StateTB.Name = "StateTB";
            this.StateTB.Size = new System.Drawing.Size(53, 23);
            this.StateTB.TabIndex = 7;
            // 
            // ZipCodeTB
            // 
            this.ZipCodeTB.Location = new System.Drawing.Point(394, 365);
            this.ZipCodeTB.Name = "ZipCodeTB";
            this.ZipCodeTB.Size = new System.Drawing.Size(100, 23);
            this.ZipCodeTB.TabIndex = 8;
            // 
            // YearCB
            // 
            this.YearCB.FormattingEnabled = true;
            this.YearCB.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.YearCB.Location = new System.Drawing.Point(453, 184);
            this.YearCB.Name = "YearCB";
            this.YearCB.Size = new System.Drawing.Size(60, 23);
            this.YearCB.TabIndex = 3;
            this.YearCB.Text = "YYYY";
            // 
            // MonthCB
            // 
            this.MonthCB.FormattingEnabled = true;
            this.MonthCB.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.MonthCB.Location = new System.Drawing.Point(394, 184);
            this.MonthCB.Name = "MonthCB";
            this.MonthCB.Size = new System.Drawing.Size(53, 23);
            this.MonthCB.TabIndex = 2;
            this.MonthCB.Text = "MM";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(394, 409);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FullNameErrorLbl
            // 
            this.FullNameErrorLbl.AutoSize = true;
            this.FullNameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.FullNameErrorLbl.Location = new System.Drawing.Point(591, 107);
            this.FullNameErrorLbl.Name = "FullNameErrorLbl";
            this.FullNameErrorLbl.Size = new System.Drawing.Size(91, 15);
            this.FullNameErrorLbl.TabIndex = 35;
            this.FullNameErrorLbl.Text = "Enter Full Name";
            this.FullNameErrorLbl.Visible = false;
            // 
            // CardNumErrorLbl
            // 
            this.CardNumErrorLbl.AutoSize = true;
            this.CardNumErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.CardNumErrorLbl.Location = new System.Drawing.Point(591, 141);
            this.CardNumErrorLbl.Name = "CardNumErrorLbl";
            this.CardNumErrorLbl.Size = new System.Drawing.Size(109, 15);
            this.CardNumErrorLbl.TabIndex = 36;
            this.CardNumErrorLbl.Text = "Enter Card Number";
            this.CardNumErrorLbl.Visible = false;
            // 
            // ExpDateErrorLbl
            // 
            this.ExpDateErrorLbl.AutoSize = true;
            this.ExpDateErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.ExpDateErrorLbl.Location = new System.Drawing.Point(591, 184);
            this.ExpDateErrorLbl.Name = "ExpDateErrorLbl";
            this.ExpDateErrorLbl.Size = new System.Drawing.Size(117, 15);
            this.ExpDateErrorLbl.TabIndex = 37;
            this.ExpDateErrorLbl.Text = "Enter Expiration Date";
            this.ExpDateErrorLbl.Visible = false;
            // 
            // CSVErrorLbl
            // 
            this.CSVErrorLbl.AutoSize = true;
            this.CSVErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.CSVErrorLbl.Location = new System.Drawing.Point(591, 220);
            this.CSVErrorLbl.Name = "CSVErrorLbl";
            this.CSVErrorLbl.Size = new System.Drawing.Size(58, 15);
            this.CSVErrorLbl.TabIndex = 38;
            this.CSVErrorLbl.Text = "Enter CSV";
            this.CSVErrorLbl.Visible = false;
            // 
            // AddressErrorLbl
            // 
            this.AddressErrorLbl.AutoSize = true;
            this.AddressErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.AddressErrorLbl.Location = new System.Drawing.Point(591, 256);
            this.AddressErrorLbl.Name = "AddressErrorLbl";
            this.AddressErrorLbl.Size = new System.Drawing.Size(79, 15);
            this.AddressErrorLbl.TabIndex = 39;
            this.AddressErrorLbl.Text = "Enter Address";
            this.AddressErrorLbl.Visible = false;
            // 
            // CityErrorLbl
            // 
            this.CityErrorLbl.AutoSize = true;
            this.CityErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.CityErrorLbl.Location = new System.Drawing.Point(591, 295);
            this.CityErrorLbl.Name = "CityErrorLbl";
            this.CityErrorLbl.Size = new System.Drawing.Size(58, 15);
            this.CityErrorLbl.TabIndex = 40;
            this.CityErrorLbl.Text = "Enter City";
            this.CityErrorLbl.Visible = false;
            // 
            // StateErrorLbl
            // 
            this.StateErrorLbl.AutoSize = true;
            this.StateErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.StateErrorLbl.Location = new System.Drawing.Point(591, 332);
            this.StateErrorLbl.Name = "StateErrorLbl";
            this.StateErrorLbl.Size = new System.Drawing.Size(63, 15);
            this.StateErrorLbl.TabIndex = 41;
            this.StateErrorLbl.Text = "Enter State";
            this.StateErrorLbl.Visible = false;
            // 
            // ZipCodeErrorLbl
            // 
            this.ZipCodeErrorLbl.AutoSize = true;
            this.ZipCodeErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.ZipCodeErrorLbl.Location = new System.Drawing.Point(591, 365);
            this.ZipCodeErrorLbl.Name = "ZipCodeErrorLbl";
            this.ZipCodeErrorLbl.Size = new System.Drawing.Size(85, 15);
            this.ZipCodeErrorLbl.TabIndex = 42;
            this.ZipCodeErrorLbl.Text = "Enter Zip Code";
            this.ZipCodeErrorLbl.Visible = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 558);
            this.Controls.Add(this.ZipCodeErrorLbl);
            this.Controls.Add(this.StateErrorLbl);
            this.Controls.Add(this.CityErrorLbl);
            this.Controls.Add(this.AddressErrorLbl);
            this.Controls.Add(this.CSVErrorLbl);
            this.Controls.Add(this.ExpDateErrorLbl);
            this.Controls.Add(this.CardNumErrorLbl);
            this.Controls.Add(this.FullNameErrorLbl);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.MonthCB);
            this.Controls.Add(this.YearCB);
            this.Controls.Add(this.ZipCodeTB);
            this.Controls.Add(this.StateTB);
            this.Controls.Add(this.CityTB);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.CSVTB);
            this.Controls.Add(this.CardNumTB);
            this.Controls.Add(this.FullNameTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox FullNameTB;
        private TextBox CardNumTB;
        private TextBox CSVTB;
        private TextBox AddressTB;
        private TextBox CityTB;
        private TextBox StateTB;
        private TextBox ZipCodeTB;
        private ComboBox YearCB;
        private ComboBox MonthCB;
        private Button SubmitButton;
        private Label FullNameErrorLbl;
        private Label CardNumErrorLbl;
        private Label ExpDateErrorLbl;
        private Label CSVErrorLbl;
        private Label AddressErrorLbl;
        private Label CityErrorLbl;
        private Label StateErrorLbl;
        private Label ZipCodeErrorLbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
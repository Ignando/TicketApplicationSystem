namespace WinFormsApp1
{
    partial class frmTicketManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlPassenger = new Panel();
            pnlGender = new Panel();
            radioMale = new RadioButton();
            lblGender = new Label();
            radioFemale = new RadioButton();
            txtAge = new TextBox();
            txtName = new TextBox();
            lblAge = new Label();
            lblName = new Label();
            lblPassengerDetails = new Label();
            pnlTravel = new Panel();
            comboCategory = new ComboBox();
            txtDistance = new TextBox();
            lblDistance = new Label();
            pnlTravelTitle = new Panel();
            lblTravelDetails = new Label();
            lblCategory = new Label();
            pnlButtons = new Panel();
            btnCalculate = new Button();
            btnExit = new Button();
            btnClear = new Button();
            label7 = new Label();
            pnlPassengerTitle = new Panel();
            pnlTicketTitle = new Panel();
            lblPrice = new Label();
            lblTicketSummary = new Label();
            lblResult = new Label();
            pnlTicket = new Panel();
            lblDiscountResult = new Label();
            lblDistanceResult = new Label();
            lblCategoryResult = new Label();
            lblNameResult = new Label();
            lblDiscountTicket = new Label();
            lblDistanceTicket = new Label();
            lblCategoryTicket = new Label();
            lblNameTicket = new Label();
            pnlPassenger.SuspendLayout();
            pnlGender.SuspendLayout();
            pnlTravel.SuspendLayout();
            pnlTravelTitle.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlPassengerTitle.SuspendLayout();
            pnlTicketTitle.SuspendLayout();
            pnlTicket.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPassenger
            // 
            pnlPassenger.BackColor = Color.White;
            pnlPassenger.Controls.Add(pnlGender);
            pnlPassenger.Controls.Add(txtAge);
            pnlPassenger.Controls.Add(txtName);
            pnlPassenger.Controls.Add(lblAge);
            pnlPassenger.Controls.Add(lblName);
            pnlPassenger.Font = new Font("Times New Roman", 10F);
            pnlPassenger.Location = new Point(28, 29);
            pnlPassenger.Margin = new Padding(2, 3, 2, 3);
            pnlPassenger.Name = "pnlPassenger";
            pnlPassenger.Padding = new Padding(15);
            pnlPassenger.Size = new Size(310, 197);
            pnlPassenger.TabIndex = 1;
            // 
            // pnlGender
            // 
            pnlGender.BackColor = SystemColors.MenuBar;
            pnlGender.Controls.Add(radioMale);
            pnlGender.Controls.Add(lblGender);
            pnlGender.Controls.Add(radioFemale);
            pnlGender.Location = new Point(23, 123);
            pnlGender.Margin = new Padding(2, 3, 2, 3);
            pnlGender.Name = "pnlGender";
            pnlGender.Padding = new Padding(8);
            pnlGender.Size = new Size(135, 56);
            pnlGender.TabIndex = 11;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(10, 27);
            radioMale.Margin = new Padding(2, 3, 2, 3);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(52, 20);
            radioMale.TabIndex = 8;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Times New Roman", 10F);
            lblGender.Location = new Point(10, 8);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(48, 16);
            lblGender.TabIndex = 10;
            lblGender.Text = "Gender";
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(66, 27);
            radioFemale.Margin = new Padding(2, 3, 2, 3);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(65, 20);
            radioFemale.TabIndex = 9;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(188, 150);
            txtAge.Margin = new Padding(2, 3, 2, 3);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(105, 23);
            txtAge.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(22, 88);
            txtName.Margin = new Padding(2, 3, 2, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 23);
            txtName.TabIndex = 4;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Times New Roman", 10F);
            lblAge.ForeColor = Color.DimGray;
            lblAge.Location = new Point(188, 124);
            lblAge.Margin = new Padding(2, 0, 2, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(29, 16);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.DimGray;
            lblName.Location = new Point(23, 69);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 16);
            lblName.TabIndex = 2;
            lblName.Text = "Full Name";
            lblName.Click += rrn;
            // 
            // lblPassengerDetails
            // 
            lblPassengerDetails.AutoSize = true;
            lblPassengerDetails.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPassengerDetails.Location = new Point(83, 14);
            lblPassengerDetails.Margin = new Padding(2, 0, 2, 0);
            lblPassengerDetails.Name = "lblPassengerDetails";
            lblPassengerDetails.Size = new Size(166, 25);
            lblPassengerDetails.TabIndex = 2;
            lblPassengerDetails.Text = "Passenger Details";
            // 
            // pnlTravel
            // 
            pnlTravel.BackColor = Color.White;
            pnlTravel.Controls.Add(comboCategory);
            pnlTravel.Controls.Add(txtDistance);
            pnlTravel.Controls.Add(lblDistance);
            pnlTravel.Controls.Add(pnlTravelTitle);
            pnlTravel.Controls.Add(lblCategory);
            pnlTravel.Font = new Font("Times New Roman", 10F);
            pnlTravel.Location = new Point(30, 247);
            pnlTravel.Margin = new Padding(2, 3, 2, 3);
            pnlTravel.Name = "pnlTravel";
            pnlTravel.Padding = new Padding(15);
            pnlTravel.Size = new Size(310, 140);
            pnlTravel.TabIndex = 6;
            // 
            // comboCategory
            // 
            comboCategory.BackColor = Color.White;
            comboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategory.FormattingEnabled = true;
            comboCategory.Items.AddRange(new object[] { "One", "Two", "Three" });
            comboCategory.Location = new Point(20, 98);
            comboCategory.Margin = new Padding(2, 3, 2, 3);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(126, 23);
            comboCategory.TabIndex = 7;
            // 
            // txtDistance
            // 
            txtDistance.BackColor = Color.White;
            txtDistance.BorderStyle = BorderStyle.FixedSingle;
            txtDistance.Location = new Point(186, 99);
            txtDistance.Margin = new Padding(2, 3, 2, 3);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(107, 23);
            txtDistance.TabIndex = 6;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.ForeColor = Color.DimGray;
            lblDistance.Location = new Point(186, 72);
            lblDistance.Margin = new Padding(2, 0, 2, 0);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(56, 16);
            lblDistance.TabIndex = 3;
            lblDistance.Text = "Distance";
            // 
            // pnlTravelTitle
            // 
            pnlTravelTitle.BackColor = SystemColors.GradientActiveCaption;
            pnlTravelTitle.Controls.Add(lblTravelDetails);
            pnlTravelTitle.Font = new Font("Times New Roman", 10F);
            pnlTravelTitle.Location = new Point(0, 0);
            pnlTravelTitle.Margin = new Padding(2, 3, 2, 3);
            pnlTravelTitle.Name = "pnlTravelTitle";
            pnlTravelTitle.Size = new Size(310, 53);
            pnlTravelTitle.TabIndex = 8;
            // 
            // lblTravelDetails
            // 
            lblTravelDetails.AutoSize = true;
            lblTravelDetails.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTravelDetails.Location = new Point(94, 16);
            lblTravelDetails.Margin = new Padding(2, 0, 2, 0);
            lblTravelDetails.Name = "lblTravelDetails";
            lblTravelDetails.Size = new Size(129, 25);
            lblTravelDetails.TabIndex = 2;
            lblTravelDetails.Text = "Travel Details";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.ForeColor = Color.DimGray;
            lblCategory.Location = new Point(20, 72);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 16);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.White;
            pnlButtons.Controls.Add(btnCalculate);
            pnlButtons.Controls.Add(btnExit);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(label7);
            pnlButtons.Font = new Font("Times New Roman", 10F);
            pnlButtons.Location = new Point(30, 406);
            pnlButtons.Margin = new Padding(2, 3, 2, 3);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(15);
            pnlButtons.Size = new Size(310, 55);
            pnlButtons.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.DodgerBlue;
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(205, 12);
            btnCalculate.Margin = new Padding(2, 3, 2, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(86, 32);
            btnCalculate.TabIndex = 12;
            btnCalculate.Text = "Calculate Ticket";
            btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Location = new Point(112, 12);
            btnExit.Margin = new Padding(2, 3, 2, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(54, 32);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gainsboro;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(9, 12);
            btnClear.Margin = new Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(54, 32);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 127);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 16);
            label7.TabIndex = 3;
            label7.Text = "Full Name";
            // 
            // pnlPassengerTitle
            // 
            pnlPassengerTitle.BackColor = SystemColors.GradientActiveCaption;
            pnlPassengerTitle.Controls.Add(lblPassengerDetails);
            pnlPassengerTitle.Font = new Font("Times New Roman", 10F);
            pnlPassengerTitle.Location = new Point(28, 29);
            pnlPassengerTitle.Margin = new Padding(2, 3, 2, 3);
            pnlPassengerTitle.Name = "pnlPassengerTitle";
            pnlPassengerTitle.Size = new Size(310, 54);
            pnlPassengerTitle.TabIndex = 9;
            // 
            // pnlTicketTitle
            // 
            pnlTicketTitle.BackColor = Color.DodgerBlue;
            pnlTicketTitle.Controls.Add(lblPrice);
            pnlTicketTitle.Controls.Add(lblTicketSummary);
            pnlTicketTitle.Controls.Add(lblResult);
            pnlTicketTitle.Font = new Font("Times New Roman", 10F);
            pnlTicketTitle.Location = new Point(369, 105);
            pnlTicketTitle.Margin = new Padding(2, 3, 2, 3);
            pnlTicketTitle.Name = "pnlTicketTitle";
            pnlTicketTitle.Padding = new Padding(15);
            pnlTicketTitle.Size = new Size(206, 121);
            pnlTicketTitle.TabIndex = 10;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.ForeColor = SystemColors.ControlLightLight;
            lblPrice.Location = new Point(17, 72);
            lblPrice.Margin = new Padding(2, 0, 2, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 16);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblTicketSummary
            // 
            lblTicketSummary.AutoSize = true;
            lblTicketSummary.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTicketSummary.ForeColor = SystemColors.ControlLightLight;
            lblTicketSummary.Location = new Point(30, 15);
            lblTicketSummary.Margin = new Padding(2, 0, 2, 0);
            lblTicketSummary.Name = "lblTicketSummary";
            lblTicketSummary.Size = new Size(156, 25);
            lblTicketSummary.TabIndex = 8;
            lblTicketSummary.Text = "Ticket Summary";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.DodgerBlue;
            lblResult.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblResult.ForeColor = SystemColors.ButtonHighlight;
            lblResult.Location = new Point(57, 66);
            lblResult.Margin = new Padding(2, 0, 2, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(97, 37);
            lblResult.TabIndex = 2;
            lblResult.Text = "R 0.00";
            // 
            // pnlTicket
            // 
            pnlTicket.BackColor = Color.White;
            pnlTicket.Controls.Add(lblDiscountResult);
            pnlTicket.Controls.Add(lblDistanceResult);
            pnlTicket.Controls.Add(lblCategoryResult);
            pnlTicket.Controls.Add(lblNameResult);
            pnlTicket.Controls.Add(lblDiscountTicket);
            pnlTicket.Controls.Add(lblDistanceTicket);
            pnlTicket.Controls.Add(lblCategoryTicket);
            pnlTicket.Controls.Add(lblNameTicket);
            pnlTicket.Font = new Font("Times New Roman", 10F);
            pnlTicket.Location = new Point(369, 105);
            pnlTicket.Margin = new Padding(2, 3, 2, 3);
            pnlTicket.Name = "pnlTicket";
            pnlTicket.Padding = new Padding(15);
            pnlTicket.Size = new Size(206, 272);
            pnlTicket.TabIndex = 9;
            // 
            // lblDiscountResult
            // 
            lblDiscountResult.AutoSize = true;
            lblDiscountResult.Location = new Point(164, 229);
            lblDiscountResult.Margin = new Padding(2, 0, 2, 0);
            lblDiscountResult.Name = "lblDiscountResult";
            lblDiscountResult.Size = new Size(22, 16);
            lblDiscountResult.TabIndex = 10;
            lblDiscountResult.Text = "---";
            // 
            // lblDistanceResult
            // 
            lblDistanceResult.AutoSize = true;
            lblDistanceResult.Location = new Point(164, 201);
            lblDistanceResult.Margin = new Padding(2, 0, 2, 0);
            lblDistanceResult.Name = "lblDistanceResult";
            lblDistanceResult.Size = new Size(22, 16);
            lblDistanceResult.TabIndex = 9;
            lblDistanceResult.Text = "---";
            // 
            // lblCategoryResult
            // 
            lblCategoryResult.AutoSize = true;
            lblCategoryResult.Location = new Point(164, 172);
            lblCategoryResult.Margin = new Padding(2, 0, 2, 0);
            lblCategoryResult.Name = "lblCategoryResult";
            lblCategoryResult.Size = new Size(22, 16);
            lblCategoryResult.TabIndex = 8;
            lblCategoryResult.Text = "---";
            // 
            // lblNameResult
            // 
            lblNameResult.AutoSize = true;
            lblNameResult.Location = new Point(164, 147);
            lblNameResult.Margin = new Padding(2, 0, 2, 0);
            lblNameResult.Name = "lblNameResult";
            lblNameResult.Size = new Size(22, 16);
            lblNameResult.TabIndex = 7;
            lblNameResult.Text = "---";
            // 
            // lblDiscountTicket
            // 
            lblDiscountTicket.AutoSize = true;
            lblDiscountTicket.Location = new Point(17, 229);
            lblDiscountTicket.Margin = new Padding(2, 0, 2, 0);
            lblDiscountTicket.Name = "lblDiscountTicket";
            lblDiscountTicket.Size = new Size(58, 16);
            lblDiscountTicket.TabIndex = 6;
            lblDiscountTicket.Text = "Discount";
            // 
            // lblDistanceTicket
            // 
            lblDistanceTicket.AutoSize = true;
            lblDistanceTicket.Location = new Point(17, 201);
            lblDistanceTicket.Margin = new Padding(2, 0, 2, 0);
            lblDistanceTicket.Name = "lblDistanceTicket";
            lblDistanceTicket.Size = new Size(56, 16);
            lblDistanceTicket.TabIndex = 5;
            lblDistanceTicket.Text = "Distance";
            // 
            // lblCategoryTicket
            // 
            lblCategoryTicket.AutoSize = true;
            lblCategoryTicket.Location = new Point(17, 172);
            lblCategoryTicket.Margin = new Padding(2, 0, 2, 0);
            lblCategoryTicket.Name = "lblCategoryTicket";
            lblCategoryTicket.Size = new Size(58, 16);
            lblCategoryTicket.TabIndex = 4;
            lblCategoryTicket.Text = "Category";
            // 
            // lblNameTicket
            // 
            lblNameTicket.AutoSize = true;
            lblNameTicket.Location = new Point(17, 147);
            lblNameTicket.Margin = new Padding(2, 0, 2, 0);
            lblNameTicket.Name = "lblNameTicket";
            lblNameTicket.Size = new Size(40, 16);
            lblNameTicket.TabIndex = 2;
            lblNameTicket.Text = "Name";
            // 
            // frmTicketManagement
            // 
            AutoScaleDimensions = new SizeF(5F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(605, 487);
            Controls.Add(pnlTicketTitle);
            Controls.Add(pnlTicket);
            Controls.Add(pnlPassengerTitle);
            Controls.Add(pnlButtons);
            Controls.Add(pnlTravel);
            Controls.Add(pnlPassenger);
            Font = new Font("Rockwell Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "frmTicketManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket Manager";
            pnlPassenger.ResumeLayout(false);
            pnlPassenger.PerformLayout();
            pnlGender.ResumeLayout(false);
            pnlGender.PerformLayout();
            pnlTravel.ResumeLayout(false);
            pnlTravel.PerformLayout();
            pnlTravelTitle.ResumeLayout(false);
            pnlTravelTitle.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlButtons.PerformLayout();
            pnlPassengerTitle.ResumeLayout(false);
            pnlPassengerTitle.PerformLayout();
            pnlTicketTitle.ResumeLayout(false);
            pnlTicketTitle.PerformLayout();
            pnlTicket.ResumeLayout(false);
            pnlTicket.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlPassenger;
        private Label lblPassengerDetails;
        private Label lblName;
        private Label lblAge;
        private Panel pnlTravel;
        private Label lblDistance;
        private Label lblCategory;
        private Label lblTravelDetails;
        private TextBox txtAge;
        private TextBox txtName;
        private Panel pnlButtons;
        private Label label7;
        private Panel pnlGender;
        private RadioButton radioMale;
        private Label lblGender;
        private RadioButton radioFemale;
        private ComboBox comboCategory;
        private TextBox txtDistance;
        private Panel pnlPassengerTitle;
        private Panel pnlTravelTitle;
        private Button btnCalculate;
        private Button btnExit;
        private Button btnClear;
        private Panel pnlTicketTitle;
        private Label lblTicketSummary;
        private Label lblResult;
        private Panel pnlTicket;
        private Label label9;
        private Label lblNameTicket;
        private Label lblPrice;
        private Label lblDiscountTicket;
        private Label lblDistanceTicket;
        private Label lblCategoryTicket;
        private Label lblDiscountResult;
        private Label lblDistanceResult;
        private Label lblCategoryResult;
        private Label lblNameResult;
    }
}

﻿namespace BankSystemGUI
{
    partial class ShowLoansEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowLoansEmployee));
            showLoansLabel = new Label();
            backToEmployeeLabel = new Label();
            employeeLoansFlowControl = new FlowLayoutPanel();
            employeeLoansPictureBox = new PictureBox();
            numberLoanLabel = new Label();
            employeeNumberLoanPanel = new Panel();
            emplyeeNumberLoanTextBox = new TextBox();
            employeeStateLoanComboBox = new ComboBox();
            employeeStateLoanPanel = new Panel();
            employeeStateLoanLabel = new Label();
            confirmStateLoanButton = new Button();
            reloadLabel = new Label();
            personSSNTextBox = new TextBox();
            personSSNPanel = new Panel();
            personSsnLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)employeeLoansPictureBox).BeginInit();
            SuspendLayout();
            // 
            // showLoansLabel
            // 
            showLoansLabel.AutoSize = true;
            showLoansLabel.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            showLoansLabel.ForeColor = SystemColors.Highlight;
            showLoansLabel.Location = new Point(30, 64);
            showLoansLabel.Name = "showLoansLabel";
            showLoansLabel.Size = new Size(282, 57);
            showLoansLabel.TabIndex = 0;
            showLoansLabel.Text = "Show Loans";
            // 
            // backToEmployeeLabel
            // 
            backToEmployeeLabel.AutoSize = true;
            backToEmployeeLabel.Cursor = Cursors.Hand;
            backToEmployeeLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backToEmployeeLabel.Location = new Point(12, 27);
            backToEmployeeLabel.Name = "backToEmployeeLabel";
            backToEmployeeLabel.Size = new Size(171, 24);
            backToEmployeeLabel.TabIndex = 1;
            backToEmployeeLabel.Text = "Back to Employee Panel";
            backToEmployeeLabel.Click += backToEmployeeLabel_Click;
            // 
            // employeeLoansFlowControl
            // 
            employeeLoansFlowControl.AutoScroll = true;
            employeeLoansFlowControl.BackColor = SystemColors.Control;
            employeeLoansFlowControl.Dock = DockStyle.Right;
            employeeLoansFlowControl.Location = new Point(341, 0);
            employeeLoansFlowControl.Name = "employeeLoansFlowControl";
            employeeLoansFlowControl.Size = new Size(592, 450);
            employeeLoansFlowControl.TabIndex = 2;
            employeeLoansFlowControl.Paint += employeeLoansFlowControl_Paint;
            // 
            // employeeLoansPictureBox
            // 
            employeeLoansPictureBox.Image = (Image)resources.GetObject("employeeLoansPictureBox.Image");
            employeeLoansPictureBox.Location = new Point(109, 124);
            employeeLoansPictureBox.Name = "employeeLoansPictureBox";
            employeeLoansPictureBox.Size = new Size(125, 62);
            employeeLoansPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            employeeLoansPictureBox.TabIndex = 3;
            employeeLoansPictureBox.TabStop = false;
            // 
            // numberLoanLabel
            // 
            numberLoanLabel.AutoSize = true;
            numberLoanLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numberLoanLabel.ForeColor = Color.Peru;
            numberLoanLabel.Location = new Point(30, 204);
            numberLoanLabel.Name = "numberLoanLabel";
            numberLoanLabel.Size = new Size(87, 24);
            numberLoanLabel.TabIndex = 4;
            numberLoanLabel.Text = "Number:";
            // 
            // employeeNumberLoanPanel
            // 
            employeeNumberLoanPanel.BackColor = Color.Black;
            employeeNumberLoanPanel.Location = new Point(32, 231);
            employeeNumberLoanPanel.Name = "employeeNumberLoanPanel";
            employeeNumberLoanPanel.Size = new Size(280, 1);
            employeeNumberLoanPanel.TabIndex = 5;
            // 
            // emplyeeNumberLoanTextBox
            // 
            emplyeeNumberLoanTextBox.BorderStyle = BorderStyle.None;
            emplyeeNumberLoanTextBox.Cursor = Cursors.IBeam;
            emplyeeNumberLoanTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emplyeeNumberLoanTextBox.Location = new Point(123, 204);
            emplyeeNumberLoanTextBox.Name = "emplyeeNumberLoanTextBox";
            emplyeeNumberLoanTextBox.Size = new Size(189, 25);
            emplyeeNumberLoanTextBox.TabIndex = 6;
            // 
            // employeeStateLoanComboBox
            // 
            employeeStateLoanComboBox.BackColor = SystemColors.Control;
            employeeStateLoanComboBox.Cursor = Cursors.Hand;
            employeeStateLoanComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeStateLoanComboBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            employeeStateLoanComboBox.FormattingEnabled = true;
            employeeStateLoanComboBox.Items.AddRange(new object[] { "Accept", "Reject" });
            employeeStateLoanComboBox.Location = new Point(109, 296);
            employeeStateLoanComboBox.Name = "employeeStateLoanComboBox";
            employeeStateLoanComboBox.Size = new Size(203, 32);
            employeeStateLoanComboBox.TabIndex = 7;
            // 
            // employeeStateLoanPanel
            // 
            employeeStateLoanPanel.BackColor = Color.Black;
            employeeStateLoanPanel.Location = new Point(32, 327);
            employeeStateLoanPanel.Name = "employeeStateLoanPanel";
            employeeStateLoanPanel.Size = new Size(280, 1);
            employeeStateLoanPanel.TabIndex = 9;
            // 
            // employeeStateLoanLabel
            // 
            employeeStateLoanLabel.AutoSize = true;
            employeeStateLoanLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            employeeStateLoanLabel.ForeColor = Color.Peru;
            employeeStateLoanLabel.Location = new Point(30, 300);
            employeeStateLoanLabel.Name = "employeeStateLoanLabel";
            employeeStateLoanLabel.Size = new Size(73, 24);
            employeeStateLoanLabel.TabIndex = 8;
            employeeStateLoanLabel.Text = "Status:";
            // 
            // confirmStateLoanButton
            // 
            confirmStateLoanButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirmStateLoanButton.Location = new Point(70, 372);
            confirmStateLoanButton.Name = "confirmStateLoanButton";
            confirmStateLoanButton.Size = new Size(193, 43);
            confirmStateLoanButton.TabIndex = 10;
            confirmStateLoanButton.Text = "Confirm Operation";
            confirmStateLoanButton.UseVisualStyleBackColor = true;
            confirmStateLoanButton.Click += confirmStateLoanButton_Click;
            // 
            // reloadLabel
            // 
            reloadLabel.AutoSize = true;
            reloadLabel.Cursor = Cursors.Hand;
            reloadLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reloadLabel.Location = new Point(214, 27);
            reloadLabel.Name = "reloadLabel";
            reloadLabel.Size = new Size(98, 24);
            reloadLabel.TabIndex = 0;
            reloadLabel.Text = "Reload Loans";
            reloadLabel.Click += reloadLabel_Click;
            // 
            // personSSNTextBox
            // 
            personSSNTextBox.BorderStyle = BorderStyle.None;
            personSSNTextBox.Cursor = Cursors.IBeam;
            personSSNTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            personSSNTextBox.Location = new Point(123, 254);
            personSSNTextBox.Name = "personSSNTextBox";
            personSSNTextBox.Size = new Size(189, 25);
            personSSNTextBox.TabIndex = 13;
            // 
            // personSSNPanel
            // 
            personSSNPanel.BackColor = Color.Black;
            personSSNPanel.Location = new Point(32, 281);
            personSSNPanel.Name = "personSSNPanel";
            personSSNPanel.Size = new Size(280, 1);
            personSSNPanel.TabIndex = 12;
            // 
            // personSsnLabel
            // 
            personSsnLabel.AutoSize = true;
            personSsnLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            personSsnLabel.ForeColor = Color.Peru;
            personSsnLabel.Location = new Point(30, 254);
            personSsnLabel.Name = "personSsnLabel";
            personSsnLabel.Size = new Size(53, 24);
            personSsnLabel.TabIndex = 11;
            personSsnLabel.Text = "SSN:";
            // 
            // ShowLoansEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(933, 450);
            Controls.Add(personSSNTextBox);
            Controls.Add(personSSNPanel);
            Controls.Add(personSsnLabel);
            Controls.Add(reloadLabel);
            Controls.Add(confirmStateLoanButton);
            Controls.Add(employeeStateLoanPanel);
            Controls.Add(employeeStateLoanLabel);
            Controls.Add(employeeStateLoanComboBox);
            Controls.Add(emplyeeNumberLoanTextBox);
            Controls.Add(employeeNumberLoanPanel);
            Controls.Add(numberLoanLabel);
            Controls.Add(employeeLoansPictureBox);
            Controls.Add(employeeLoansFlowControl);
            Controls.Add(backToEmployeeLabel);
            Controls.Add(showLoansLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowLoansEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Loans Employee";
            Load += ShowLoansEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)employeeLoansPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label showLoansLabel;
        private Label backToEmployeeLabel;
        private FlowLayoutPanel employeeLoansFlowControl;
        private PictureBox employeeLoansPictureBox;
        private Label numberLoanLabel;
        private Panel employeeNumberLoanPanel;
        private TextBox emplyeeNumberLoanTextBox;
        private ComboBox employeeStateLoanComboBox;
        private Panel employeeStateLoanPanel;
        private Label employeeStateLoanLabel;
        private Button confirmStateLoanButton;
        private Label reloadLabel;
        private TextBox personSSNTextBox;
        private Panel personSSNPanel;
        private Label personSsnLabel;
    }
}
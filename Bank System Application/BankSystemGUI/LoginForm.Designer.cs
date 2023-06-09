﻿namespace BankSystemGUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginLabel = new Label();
            loginPictureBox = new PictureBox();
            avatarPictureBox = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            loginConfirmButton = new Button();
            clearFieldsLabel = new Label();
            goBackToMainLabel = new Label();
            ssnLoginTextBox = new TextBox();
            passwordLoginTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.ForeColor = SystemColors.Highlight;
            loginLabel.Location = new Point(290, 26);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(108, 42);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Login";
            loginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginPictureBox
            // 
            loginPictureBox.Image = (Image)resources.GetObject("loginPictureBox.Image");
            loginPictureBox.Location = new Point(427, 69);
            loginPictureBox.Name = "loginPictureBox";
            loginPictureBox.Size = new Size(271, 355);
            loginPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            loginPictureBox.TabIndex = 1;
            loginPictureBox.TabStop = false;
            // 
            // avatarPictureBox
            // 
            avatarPictureBox.Image = (Image)resources.GetObject("avatarPictureBox.Image");
            avatarPictureBox.Location = new Point(39, 149);
            avatarPictureBox.Name = "avatarPictureBox";
            avatarPictureBox.Size = new Size(48, 31);
            avatarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            avatarPictureBox.TabIndex = 2;
            avatarPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(39, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 1);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 224);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(39, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 1);
            panel2.TabIndex = 4;
            // 
            // loginConfirmButton
            // 
            loginConfirmButton.Cursor = Cursors.Hand;
            loginConfirmButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginConfirmButton.Location = new Point(103, 333);
            loginConfirmButton.Name = "loginConfirmButton";
            loginConfirmButton.Size = new Size(193, 43);
            loginConfirmButton.TabIndex = 5;
            loginConfirmButton.Text = "Log In";
            loginConfirmButton.UseVisualStyleBackColor = true;
            loginConfirmButton.Click += loginConfirmButton_Click;
            // 
            // clearFieldsLabel
            // 
            clearFieldsLabel.AutoSize = true;
            clearFieldsLabel.Cursor = Cursors.Hand;
            clearFieldsLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearFieldsLabel.Location = new Point(310, 278);
            clearFieldsLabel.Name = "clearFieldsLabel";
            clearFieldsLabel.Size = new Size(88, 24);
            clearFieldsLabel.TabIndex = 6;
            clearFieldsLabel.Text = "Clear Fields";
            clearFieldsLabel.Click += clearFieldsLabel_Click;
            // 
            // goBackToMainLabel
            // 
            goBackToMainLabel.AutoSize = true;
            goBackToMainLabel.Cursor = Cursors.Hand;
            goBackToMainLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goBackToMainLabel.Location = new Point(156, 400);
            goBackToMainLabel.Name = "goBackToMainLabel";
            goBackToMainLabel.Size = new Size(94, 24);
            goBackToMainLabel.TabIndex = 7;
            goBackToMainLabel.Text = "Back to Main";
            goBackToMainLabel.Click += goBackToMainLabel_Click;
            // 
            // ssnLoginTextBox
            // 
            ssnLoginTextBox.BorderStyle = BorderStyle.None;
            ssnLoginTextBox.Cursor = Cursors.IBeam;
            ssnLoginTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ssnLoginTextBox.Location = new Point(93, 149);
            ssnLoginTextBox.Name = "ssnLoginTextBox";
            ssnLoginTextBox.Size = new Size(305, 27);
            ssnLoginTextBox.TabIndex = 8;
            ssnLoginTextBox.TextChanged += ssnLoginTextBox_TextChanged;
            // 
            // passwordLoginTextBox
            // 
            passwordLoginTextBox.BorderStyle = BorderStyle.None;
            passwordLoginTextBox.Cursor = Cursors.IBeam;
            passwordLoginTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLoginTextBox.Location = new Point(93, 224);
            passwordLoginTextBox.Name = "passwordLoginTextBox";
            passwordLoginTextBox.Size = new Size(305, 27);
            passwordLoginTextBox.TabIndex = 9;
            passwordLoginTextBox.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(710, 477);
            Controls.Add(passwordLoginTextBox);
            Controls.Add(ssnLoginTextBox);
            Controls.Add(goBackToMainLabel);
            Controls.Add(clearFieldsLabel);
            Controls.Add(loginConfirmButton);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(avatarPictureBox);
            Controls.Add(loginPictureBox);
            Controls.Add(loginLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private PictureBox loginPictureBox;
        private PictureBox avatarPictureBox;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button loginConfirmButton;
        private Label clearFieldsLabel;
        private Label goBackToMainLabel;
        private TextBox ssnLoginTextBox;
        private TextBox passwordLoginTextBox;
    }
}
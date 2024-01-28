﻿namespace hello_world
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            idNumberField = new TextBox();
            passTextField = new TextBox();
            logo = new PictureBox();
            loginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 35);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "BanPortal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 172);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = "ID Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 237);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // idNumberField
            // 
            idNumberField.CharacterCasing = CharacterCasing.Lower;
            idNumberField.Location = new Point(324, 172);
            idNumberField.Name = "idNumberField";
            idNumberField.Size = new Size(242, 31);
            idNumberField.TabIndex = 3;
            idNumberField.TextAlign = HorizontalAlignment.Center;
            idNumberField.KeyPress += idKeyPress;
            // 
            // passTextField
            // 
            passTextField.Location = new Point(324, 237);
            passTextField.Name = "passTextField";
            passTextField.Size = new Size(242, 31);
            passTextField.TabIndex = 4;
            passTextField.TextAlign = HorizontalAlignment.Center;
            passTextField.UseSystemPasswordChar = true;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(187, 12);
            logo.Name = "logo";
            logo.Size = new Size(161, 86);
            logo.TabIndex = 5;
            logo.TabStop = false;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(344, 325);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(112, 34);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login\r\n";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(logo);
            Controls.Add(passTextField);
            Controls.Add(idNumberField);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "UCB";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idNumberField;
        private TextBox passTextField;
        private PictureBox logo;
        private Button loginButton;
    }
}

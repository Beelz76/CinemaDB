namespace CinemaDB
{
    partial class Login
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.passwordCheckbox = new System.Windows.Forms.CheckBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.loginTextBox.Location = new System.Drawing.Point(411, 235);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.loginTextBox.MaxLength = 45;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(379, 30);
            this.loginTextBox.TabIndex = 1;
            this.loginTextBox.Tag = "loginTextBox.Text";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(411, 315);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.MaxLength = 45;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(379, 30);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(625, 413);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(165, 52);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registrationButton.Location = new System.Drawing.Point(411, 413);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(165, 52);
            this.registrationButton.TabIndex = 10;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // passwordCheckbox
            // 
            this.passwordCheckbox.AutoSize = true;
            this.passwordCheckbox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordCheckbox.Location = new System.Drawing.Point(411, 353);
            this.passwordCheckbox.Name = "passwordCheckbox";
            this.passwordCheckbox.Size = new System.Drawing.Size(163, 27);
            this.passwordCheckbox.TabIndex = 11;
            this.passwordCheckbox.Text = "Показать пароль";
            this.passwordCheckbox.UseVisualStyleBackColor = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(509, 132);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(179, 37);
            this.loginLabel.TabIndex = 12;
            this.loginLabel.Text = "Авторизация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(411, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(411, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Логин";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordCheckbox);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.loginLabel);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button registrationButton;
        private CheckBox passwordCheckbox;
        private Label loginLabel;
        private Label label3;
        private Label label2;
    }
}
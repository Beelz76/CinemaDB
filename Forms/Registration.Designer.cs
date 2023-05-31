namespace CinemaDB
{
    partial class Registration
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newLoginTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.Label();
            this.passwordCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTextBox.Location = new System.Drawing.Point(420, 426);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(379, 30);
            this.emailTextBox.TabIndex = 15;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPasswordTextBox.Location = new System.Drawing.Point(420, 314);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(379, 30);
            this.newPasswordTextBox.TabIndex = 14;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newLoginTextBox
            // 
            this.newLoginTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newLoginTextBox.Location = new System.Drawing.Point(420, 232);
            this.newLoginTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.newLoginTextBox.Name = "newLoginTextBox";
            this.newLoginTextBox.Size = new System.Drawing.Size(379, 30);
            this.newLoginTextBox.TabIndex = 13;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullNameTextBox.Location = new System.Drawing.Point(420, 156);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(379, 30);
            this.fullNameTextBox.TabIndex = 12;
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(655, 488);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(144, 52);
            this.loginButton.TabIndex = 17;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Location = new System.Drawing.Point(420, 488);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(207, 52);
            this.registerButton.TabIndex = 18;
            this.registerButton.Text = "Зарегистрироваться";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerLabel.Location = new System.Drawing.Point(531, 70);
            this.registerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(171, 37);
            this.registerLabel.TabIndex = 20;
            this.registerLabel.Text = "Регистрация";
            // 
            // passwordCheckbox
            // 
            this.passwordCheckbox.AutoSize = true;
            this.passwordCheckbox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordCheckbox.Location = new System.Drawing.Point(420, 354);
            this.passwordCheckbox.Name = "passwordCheckbox";
            this.passwordCheckbox.Size = new System.Drawing.Size(163, 27);
            this.passwordCheckbox.TabIndex = 21;
            this.passwordCheckbox.Text = "Показать пароль";
            this.passwordCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(420, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "ФИО*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(420, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(420, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Пароль*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(420, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Логин*";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordCheckbox);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newLoginTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox emailTextBox;
        private TextBox newPasswordTextBox;
        private TextBox newLoginTextBox;
        private TextBox fullNameTextBox;
        private Button loginButton;
        private Button registerButton;
        private Label registerLabel;
        private CheckBox passwordCheckbox;
        private Label label1;
        private Label label7;
        private Label label3;
        private Label label2;
    }
}
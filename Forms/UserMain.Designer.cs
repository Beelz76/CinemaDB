namespace CinemaDB.Forms
{
    partial class UserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.settingsStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.movieToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ticketToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.userLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.buyTicketButton = new System.Windows.Forms.Button();
            this.returnTicketButton = new System.Windows.Forms.Button();
            this.userTicketDataGridView = new System.Windows.Forms.DataGridView();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.hallSchemeButton = new System.Windows.Forms.Button();
            this.mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTicketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.BackColor = System.Drawing.Color.White;
            this.mainToolStrip.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsStripButton,
            this.toolStripSeparator1,
            this.movieToolStripButton,
            this.toolStripSeparator2,
            this.ticketToolStripButton2});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.mainToolStrip.Size = new System.Drawing.Size(1144, 33);
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // settingsStripButton
            // 
            this.settingsStripButton.AutoSize = false;
            this.settingsStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingsStripButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsStripButton.Image")));
            this.settingsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsStripButton.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.settingsStripButton.Name = "settingsStripButton";
            this.settingsStripButton.Padding = new System.Windows.Forms.Padding(2);
            this.settingsStripButton.RightToLeftAutoMirrorImage = true;
            this.settingsStripButton.ShowDropDownArrow = false;
            this.settingsStripButton.Size = new System.Drawing.Size(150, 30);
            this.settingsStripButton.Text = "Профиль";
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.changeToolStripMenuItem.Text = "Изменить данные";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.exitToolStripMenuItem.Text = "Выйти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // movieToolStripButton
            // 
            this.movieToolStripButton.AutoSize = false;
            this.movieToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.movieToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("movieToolStripButton.Image")));
            this.movieToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.movieToolStripButton.Name = "movieToolStripButton";
            this.movieToolStripButton.Padding = new System.Windows.Forms.Padding(2);
            this.movieToolStripButton.Size = new System.Drawing.Size(150, 30);
            this.movieToolStripButton.Text = "Фильмы";
            this.movieToolStripButton.Click += new System.EventHandler(this.movieToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // ticketToolStripButton2
            // 
            this.ticketToolStripButton2.AutoSize = false;
            this.ticketToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ticketToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("ticketToolStripButton2.Image")));
            this.ticketToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ticketToolStripButton2.Name = "ticketToolStripButton2";
            this.ticketToolStripButton2.Padding = new System.Windows.Forms.Padding(2);
            this.ticketToolStripButton2.Size = new System.Drawing.Size(150, 30);
            this.ticketToolStripButton2.Text = "Мои билеты";
            this.ticketToolStripButton2.Click += new System.EventHandler(this.ticketToolStripButton2_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(12, 51);
            this.userLabel.Name = "userLabel";
            this.userLabel.Padding = new System.Windows.Forms.Padding(2);
            this.userLabel.Size = new System.Drawing.Size(133, 27);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Пользователь: ";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(12, 631);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(0, 21);
            this.loginLabel.TabIndex = 4;
            // 
            // buyTicketButton
            // 
            this.buyTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicketButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buyTicketButton.Location = new System.Drawing.Point(946, 47);
            this.buyTicketButton.Name = "buyTicketButton";
            this.buyTicketButton.Size = new System.Drawing.Size(183, 52);
            this.buyTicketButton.TabIndex = 7;
            this.buyTicketButton.Text = "Расписание сеансов";
            this.buyTicketButton.UseVisualStyleBackColor = true;
            this.buyTicketButton.Click += new System.EventHandler(this.buyTicketButton_Click);
            // 
            // returnTicketButton
            // 
            this.returnTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnTicketButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnTicketButton.Location = new System.Drawing.Point(964, 47);
            this.returnTicketButton.Name = "returnTicketButton";
            this.returnTicketButton.Size = new System.Drawing.Size(165, 52);
            this.returnTicketButton.TabIndex = 10;
            this.returnTicketButton.Text = "Вернуть билет";
            this.returnTicketButton.UseVisualStyleBackColor = true;
            this.returnTicketButton.Click += new System.EventHandler(this.returnTicketButton_Click);
            // 
            // userTicketDataGridView
            // 
            this.userTicketDataGridView.AllowUserToAddRows = false;
            this.userTicketDataGridView.AllowUserToDeleteRows = false;
            this.userTicketDataGridView.AllowUserToResizeColumns = false;
            this.userTicketDataGridView.AllowUserToResizeRows = false;
            this.userTicketDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userTicketDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.userTicketDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTicketDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userTicketDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTicketDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userTicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userTicketDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.userTicketDataGridView.EnableHeadersVisualStyles = false;
            this.userTicketDataGridView.Location = new System.Drawing.Point(12, 105);
            this.userTicketDataGridView.MultiSelect = false;
            this.userTicketDataGridView.Name = "userTicketDataGridView";
            this.userTicketDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTicketDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userTicketDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.userTicketDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.userTicketDataGridView.RowTemplate.Height = 45;
            this.userTicketDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.userTicketDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userTicketDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userTicketDataGridView.Size = new System.Drawing.Size(1117, 479);
            this.userTicketDataGridView.TabIndex = 11;
            this.userTicketDataGridView.SelectionChanged += new System.EventHandler(this.userTicketDataGridView_SelectionChanged);
            this.userTicketDataGridView.Sorted += new System.EventHandler(this.userTicketDataGridView_Sorted);
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.AllowUserToAddRows = false;
            this.movieDataGridView.AllowUserToDeleteRows = false;
            this.movieDataGridView.AllowUserToResizeColumns = false;
            this.movieDataGridView.AllowUserToResizeRows = false;
            this.movieDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.movieDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.movieDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.movieDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movieDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.EnableHeadersVisualStyles = false;
            this.movieDataGridView.Location = new System.Drawing.Point(12, 105);
            this.movieDataGridView.MultiSelect = false;
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movieDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.movieDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            this.movieDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.movieDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.movieDataGridView.RowTemplate.Height = 45;
            this.movieDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.movieDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.movieDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movieDataGridView.Size = new System.Drawing.Size(1117, 479);
            this.movieDataGridView.TabIndex = 12;
            this.movieDataGridView.SelectionChanged += new System.EventHandler(this.movieDataGridView_SelectionChanged);
            this.movieDataGridView.Sorted += new System.EventHandler(this.movieDataGridView_Sorted);
            // 
            // hallSchemeButton
            // 
            this.hallSchemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hallSchemeButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hallSchemeButton.Location = new System.Drawing.Point(764, 47);
            this.hallSchemeButton.Name = "hallSchemeButton";
            this.hallSchemeButton.Size = new System.Drawing.Size(165, 52);
            this.hallSchemeButton.TabIndex = 14;
            this.hallSchemeButton.Text = "Схема зала";
            this.hallSchemeButton.UseVisualStyleBackColor = true;
            this.hallSchemeButton.Click += new System.EventHandler(this.hallSchemeButton_Click);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 661);
            this.Controls.Add(this.hallSchemeButton);
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(this.userTicketDataGridView);
            this.Controls.Add(this.returnTicketButton);
            this.Controls.Add(this.buyTicketButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.mainToolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1160, 700);
            this.MinimumSize = new System.Drawing.Size(1160, 700);
            this.Name = "UserMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMain_FormClosing);
            this.Load += new System.EventHandler(this.UserMain_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTicketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip mainToolStrip;
        private ToolStripDropDownButton settingsStripButton;
        private ToolStripMenuItem changeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Label userLabel;
        private Label loginLabel;
        private Button buyTicketButton;
        private ToolStripButton movieToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton ticketToolStripButton2;
        private Button returnTicketButton;
        private DataGridView userTicketDataGridView;
        private DataGridView movieDataGridView;
        private Button hallSchemeButton;
    }
}
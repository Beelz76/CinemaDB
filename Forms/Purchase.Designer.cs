namespace CinemaDB
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.screeningTabPage = new System.Windows.Forms.TabPage();
            this.choseSeatButton = new System.Windows.Forms.Button();
            this.screeningDataGridView = new System.Windows.Forms.DataGridView();
            this.hallTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.seatTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hallTitleLabel = new System.Windows.Forms.Label();
            this.ticketTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketTitleLabel = new System.Windows.Forms.Label();
            this.ticketPriceLabel = new System.Windows.Forms.Label();
            this.ticketSeatRowNumberLabel = new System.Windows.Forms.Label();
            this.ticketHallNameLabel = new System.Windows.Forms.Label();
            this.ticketScreeningStartLabel = new System.Windows.Forms.Label();
            this.ticketMovieTitleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.buyTicketButton = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.tabControl1.SuspendLayout();
            this.screeningTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screeningDataGridView)).BeginInit();
            this.hallTabPage.SuspendLayout();
            this.ticketTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(8, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(361, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Расписание сеансов на фильм: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.screeningTabPage);
            this.tabControl1.Controls.Add(this.hallTabPage);
            this.tabControl1.Controls.Add(this.ticketTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 661);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // screeningTabPage
            // 
            this.screeningTabPage.Controls.Add(this.choseSeatButton);
            this.screeningTabPage.Controls.Add(this.screeningDataGridView);
            this.screeningTabPage.Controls.Add(this.titleLabel);
            this.screeningTabPage.Location = new System.Drawing.Point(4, 32);
            this.screeningTabPage.Name = "screeningTabPage";
            this.screeningTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.screeningTabPage.Size = new System.Drawing.Size(908, 625);
            this.screeningTabPage.TabIndex = 0;
            this.screeningTabPage.Text = "Сеансы";
            this.screeningTabPage.UseVisualStyleBackColor = true;
            // 
            // choseSeatButton
            // 
            this.choseSeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choseSeatButton.Location = new System.Drawing.Point(735, 21);
            this.choseSeatButton.Name = "choseSeatButton";
            this.choseSeatButton.Size = new System.Drawing.Size(165, 52);
            this.choseSeatButton.TabIndex = 14;
            this.choseSeatButton.Text = "Выбрать место";
            this.choseSeatButton.UseVisualStyleBackColor = true;
            this.choseSeatButton.Click += new System.EventHandler(this.choseSeatButton_Click);
            // 
            // screeningDataGridView
            // 
            this.screeningDataGridView.AllowUserToAddRows = false;
            this.screeningDataGridView.AllowUserToDeleteRows = false;
            this.screeningDataGridView.AllowUserToResizeColumns = false;
            this.screeningDataGridView.AllowUserToResizeRows = false;
            this.screeningDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.screeningDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.screeningDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.screeningDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.screeningDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.screeningDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.screeningDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.screeningDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.screeningDataGridView.EnableHeadersVisualStyles = false;
            this.screeningDataGridView.Location = new System.Drawing.Point(8, 80);
            this.screeningDataGridView.MultiSelect = false;
            this.screeningDataGridView.Name = "screeningDataGridView";
            this.screeningDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.screeningDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.screeningDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.screeningDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.screeningDataGridView.RowTemplate.Height = 50;
            this.screeningDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.screeningDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.screeningDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.screeningDataGridView.Size = new System.Drawing.Size(892, 503);
            this.screeningDataGridView.TabIndex = 13;
            this.screeningDataGridView.SelectionChanged += new System.EventHandler(this.screeningDataGridView_SelectionChanged);
            this.screeningDataGridView.Sorted += new System.EventHandler(this.screeningDataGridView_Sorted);
            // 
            // hallTabPage
            // 
            this.hallTabPage.Controls.Add(this.label1);
            this.hallTabPage.Controls.Add(this.seatTableLayoutPanel);
            this.hallTabPage.Controls.Add(this.nextButton);
            this.hallTabPage.Controls.Add(this.prevButton);
            this.hallTabPage.Controls.Add(this.button1);
            this.hallTabPage.Controls.Add(this.hallTitleLabel);
            this.hallTabPage.Location = new System.Drawing.Point(4, 32);
            this.hallTabPage.Name = "hallTabPage";
            this.hallTabPage.Size = new System.Drawing.Size(908, 625);
            this.hallTabPage.TabIndex = 2;
            this.hallTabPage.Text = "Зал";
            this.hallTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(356, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Выберите сеанс!";
            // 
            // seatTableLayoutPanel
            // 
            this.seatTableLayoutPanel.ColumnCount = 1;
            this.seatTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.seatTableLayoutPanel.Location = new System.Drawing.Point(167, 172);
            this.seatTableLayoutPanel.Name = "seatTableLayoutPanel";
            this.seatTableLayoutPanel.RowCount = 1;
            this.seatTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.seatTableLayoutPanel.Size = new System.Drawing.Size(610, 305);
            this.seatTableLayoutPanel.TabIndex = 18;
            // 
            // nextButton
            // 
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(612, 506);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(165, 52);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevButton.Location = new System.Drawing.Point(167, 506);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(165, 52);
            this.prevButton.TabIndex = 15;
            this.prevButton.Text = "Назад";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(246, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Экран";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // hallTitleLabel
            // 
            this.hallTitleLabel.AutoSize = true;
            this.hallTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hallTitleLabel.Location = new System.Drawing.Point(403, 14);
            this.hallTitleLabel.Name = "hallTitleLabel";
            this.hallTitleLabel.Size = new System.Drawing.Size(175, 32);
            this.hallTitleLabel.TabIndex = 0;
            this.hallTitleLabel.Text = "Название зала";
            // 
            // ticketTabPage
            // 
            this.ticketTabPage.Controls.Add(this.label2);
            this.ticketTabPage.Controls.Add(this.ticketTitleLabel);
            this.ticketTabPage.Controls.Add(this.ticketPriceLabel);
            this.ticketTabPage.Controls.Add(this.ticketSeatRowNumberLabel);
            this.ticketTabPage.Controls.Add(this.ticketHallNameLabel);
            this.ticketTabPage.Controls.Add(this.ticketScreeningStartLabel);
            this.ticketTabPage.Controls.Add(this.ticketMovieTitleLabel);
            this.ticketTabPage.Controls.Add(this.backButton);
            this.ticketTabPage.Controls.Add(this.buyTicketButton);
            this.ticketTabPage.Location = new System.Drawing.Point(4, 32);
            this.ticketTabPage.Name = "ticketTabPage";
            this.ticketTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ticketTabPage.Size = new System.Drawing.Size(908, 625);
            this.ticketTabPage.TabIndex = 1;
            this.ticketTabPage.Text = "Итоговый билет";
            this.ticketTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(354, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Выберите место!";
            // 
            // ticketTitleLabel
            // 
            this.ticketTitleLabel.AutoSize = true;
            this.ticketTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketTitleLabel.Location = new System.Drawing.Point(384, 37);
            this.ticketTitleLabel.Name = "ticketTitleLabel";
            this.ticketTitleLabel.Size = new System.Drawing.Size(130, 32);
            this.ticketTitleLabel.TabIndex = 8;
            this.ticketTitleLabel.Text = "Ваш билет";
            // 
            // ticketPriceLabel
            // 
            this.ticketPriceLabel.AutoSize = true;
            this.ticketPriceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketPriceLabel.Location = new System.Drawing.Point(202, 321);
            this.ticketPriceLabel.Name = "ticketPriceLabel";
            this.ticketPriceLabel.Size = new System.Drawing.Size(76, 32);
            this.ticketPriceLabel.TabIndex = 7;
            this.ticketPriceLabel.Text = "Цена:";
            // 
            // ticketSeatRowNumberLabel
            // 
            this.ticketSeatRowNumberLabel.AutoSize = true;
            this.ticketSeatRowNumberLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketSeatRowNumberLabel.Location = new System.Drawing.Point(202, 265);
            this.ticketSeatRowNumberLabel.Name = "ticketSeatRowNumberLabel";
            this.ticketSeatRowNumberLabel.Size = new System.Drawing.Size(150, 32);
            this.ticketSeatRowNumberLabel.TabIndex = 5;
            this.ticketSeatRowNumberLabel.Text = "Ряд и место:";
            // 
            // ticketHallNameLabel
            // 
            this.ticketHallNameLabel.AutoSize = true;
            this.ticketHallNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketHallNameLabel.Location = new System.Drawing.Point(202, 212);
            this.ticketHallNameLabel.Name = "ticketHallNameLabel";
            this.ticketHallNameLabel.Size = new System.Drawing.Size(57, 32);
            this.ticketHallNameLabel.TabIndex = 4;
            this.ticketHallNameLabel.Text = "Зал:";
            // 
            // ticketScreeningStartLabel
            // 
            this.ticketScreeningStartLabel.AutoSize = true;
            this.ticketScreeningStartLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketScreeningStartLabel.Location = new System.Drawing.Point(202, 158);
            this.ticketScreeningStartLabel.Name = "ticketScreeningStartLabel";
            this.ticketScreeningStartLabel.Size = new System.Drawing.Size(181, 32);
            this.ticketScreeningStartLabel.TabIndex = 3;
            this.ticketScreeningStartLabel.Text = "Начало сеанса:";
            // 
            // ticketMovieTitleLabel
            // 
            this.ticketMovieTitleLabel.AutoSize = true;
            this.ticketMovieTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketMovieTitleLabel.Location = new System.Drawing.Point(202, 105);
            this.ticketMovieTitleLabel.Name = "ticketMovieTitleLabel";
            this.ticketMovieTitleLabel.Size = new System.Drawing.Size(99, 32);
            this.ticketMovieTitleLabel.TabIndex = 2;
            this.ticketMovieTitleLabel.Text = "Фильм: ";
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(202, 403);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(165, 52);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // buyTicketButton
            // 
            this.buyTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicketButton.Location = new System.Drawing.Point(524, 403);
            this.buyTicketButton.Name = "buyTicketButton";
            this.buyTicketButton.Size = new System.Drawing.Size(165, 52);
            this.buyTicketButton.TabIndex = 0;
            this.buyTicketButton.Text = "Купить билет";
            this.buyTicketButton.UseVisualStyleBackColor = true;
            this.buyTicketButton.Click += new System.EventHandler(this.buyTicketButton_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 661);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(932, 700);
            this.MinimumSize = new System.Drawing.Size(932, 700);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупка билета";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Purchase_FormClosing);
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.tabControl1.ResumeLayout(false);
            this.screeningTabPage.ResumeLayout(false);
            this.screeningTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screeningDataGridView)).EndInit();
            this.hallTabPage.ResumeLayout(false);
            this.hallTabPage.PerformLayout();
            this.ticketTabPage.ResumeLayout(false);
            this.ticketTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label titleLabel;
        private TabControl tabControl1;
        private TabPage screeningTabPage;
        private TabPage ticketTabPage;
        private DataGridView screeningDataGridView;
        private Button choseSeatButton;
        private TabPage hallTabPage;
        private Button button1;
        private Label hallTitleLabel;
        private Button nextButton;
        private Button prevButton;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private TableLayoutPanel seatTableLayoutPanel;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private Button buyTicketButton;
        private Label label1;
        private Button backButton;
        private Label ticketPriceLabel;
        private Label ticketSeatRowNumberLabel;
        private Label ticketHallNameLabel;
        private Label ticketScreeningStartLabel;
        private Label ticketMovieTitleLabel;
        private Label ticketTitleLabel;
        private Label label2;
    }
}
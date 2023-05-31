namespace CinemaDB
{
    partial class HallScheme
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
            this.seatTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.hallTitleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // seatTableLayoutPanel
            // 
            this.seatTableLayoutPanel.ColumnCount = 1;
            this.seatTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.seatTableLayoutPanel.Enabled = false;
            this.seatTableLayoutPanel.Location = new System.Drawing.Point(182, 212);
            this.seatTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.seatTableLayoutPanel.Name = "seatTableLayoutPanel";
            this.seatTableLayoutPanel.RowCount = 1;
            this.seatTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.seatTableLayoutPanel.Size = new System.Drawing.Size(571, 273);
            this.seatTableLayoutPanel.TabIndex = 21;
            // 
            // hallTitleLabel
            // 
            this.hallTitleLabel.AutoSize = true;
            this.hallTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hallTitleLabel.Location = new System.Drawing.Point(395, 38);
            this.hallTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hallTitleLabel.Name = "hallTitleLabel";
            this.hallTitleLabel.Size = new System.Drawing.Size(175, 32);
            this.hallTitleLabel.TabIndex = 19;
            this.hallTitleLabel.Text = "Название зала";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(238, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(445, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Экран";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Enabled = false;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HallScheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seatTableLayoutPanel);
            this.Controls.Add(this.hallTitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(932, 575);
            this.MinimumSize = new System.Drawing.Size(932, 575);
            this.Name = "HallScheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Схема зала";
            this.Load += new System.EventHandler(this.HallScheme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel seatTableLayoutPanel;
        private Label hallTitleLabel;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
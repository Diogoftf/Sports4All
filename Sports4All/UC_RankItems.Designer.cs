namespace Sports4All
{
    partial class UC_RankItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lbUserRank = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblPoints, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGamesPlayed, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbUserRank, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 60);
            this.tableLayoutPanel1.TabIndex = 33;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPoints.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPoints.Location = new System.Drawing.Point(558, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(180, 60);
            this.lblPoints.TabIndex = 37;
            this.lblPoints.Text = "45555";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGamesPlayed.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblGamesPlayed.Location = new System.Drawing.Point(373, 0);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(179, 60);
            this.lblGamesPlayed.TabIndex = 36;
            this.lblGamesPlayed.Text = "3222";
            this.lblGamesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblUsername.Location = new System.Drawing.Point(188, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(179, 60);
            this.lblUsername.TabIndex = 35;
            this.lblUsername.Text = "Ramenaca";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserRank
            // 
            this.lbUserRank.AutoSize = true;
            this.lbUserRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUserRank.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbUserRank.Location = new System.Drawing.Point(3, 0);
            this.lbUserRank.Name = "lbUserRank";
            this.lbUserRank.Size = new System.Drawing.Size(179, 60);
            this.lbUserRank.TabIndex = 34;
            this.lbUserRank.Text = "#1";
            this.lbUserRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_RankItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_RankItems";
            this.Size = new System.Drawing.Size(748, 65);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbUserRank;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Label lblUsername;
    }
}

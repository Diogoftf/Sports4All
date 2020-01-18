namespace Sports4All
{
    partial class UC_Rank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Rank));
            this.btnTop10 = new System.Windows.Forms.Button();
            this.btnGlobalRank = new System.Windows.Forms.Button();
            this.flpRank = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstart_Hour = new System.Windows.Forms.Label();
            this.lblEventOwnerValue = new System.Windows.Forms.Label();
            this.lblSportsGround = new System.Windows.Forms.Label();
            this.btnTopRecintos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTop10
            // 
            this.btnTop10.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnTop10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTop10.Image = ((System.Drawing.Image)(resources.GetObject("btnTop10.Image")));
            this.btnTop10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTop10.Location = new System.Drawing.Point(210, 18);
            this.btnTop10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(192, 55);
            this.btnTop10.TabIndex = 1;
            this.btnTop10.Text = "Top 10 Jogadores";
            this.btnTop10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTop10.UseVisualStyleBackColor = true;
            this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
            // 
            // btnGlobalRank
            // 
            this.btnGlobalRank.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnGlobalRank.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGlobalRank.Image = ((System.Drawing.Image)(resources.GetObject("btnGlobalRank.Image")));
            this.btnGlobalRank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGlobalRank.Location = new System.Drawing.Point(484, 18);
            this.btnGlobalRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGlobalRank.Name = "btnGlobalRank";
            this.btnGlobalRank.Size = new System.Drawing.Size(262, 55);
            this.btnGlobalRank.TabIndex = 2;
            this.btnGlobalRank.Text = "Ranking Global Jogadores";
            this.btnGlobalRank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGlobalRank.UseVisualStyleBackColor = true;
            this.btnGlobalRank.Click += new System.EventHandler(this.btnGlobalRank_Click);
            // 
            // flpRank
            // 
            this.flpRank.AutoScroll = true;
            this.flpRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flpRank.Location = new System.Drawing.Point(45, 168);
            this.flpRank.Margin = new System.Windows.Forms.Padding(0);
            this.flpRank.Name = "flpRank";
            this.flpRank.Size = new System.Drawing.Size(1130, 593);
            this.flpRank.TabIndex = 80;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblstart_Hour, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEventOwnerValue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSportsGround, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1130, 63);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(850, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 61);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pontos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblstart_Hour
            // 
            this.lblstart_Hour.AutoSize = true;
            this.lblstart_Hour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblstart_Hour.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblstart_Hour.Location = new System.Drawing.Point(286, 1);
            this.lblstart_Hour.Name = "lblstart_Hour";
            this.lblstart_Hour.Size = new System.Drawing.Size(275, 61);
            this.lblstart_Hour.TabIndex = 30;
            this.lblstart_Hour.Text = "Utilizador";
            this.lblstart_Hour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEventOwnerValue
            // 
            this.lblEventOwnerValue.AutoSize = true;
            this.lblEventOwnerValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEventOwnerValue.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEventOwnerValue.Location = new System.Drawing.Point(4, 1);
            this.lblEventOwnerValue.Name = "lblEventOwnerValue";
            this.lblEventOwnerValue.Size = new System.Drawing.Size(275, 61);
            this.lblEventOwnerValue.TabIndex = 29;
            this.lblEventOwnerValue.Text = "Classificação";
            this.lblEventOwnerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEventOwnerValue.Click += new System.EventHandler(this.lblEventOwnerValue_Click);
            // 
            // lblSportsGround
            // 
            this.lblSportsGround.AutoSize = true;
            this.lblSportsGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSportsGround.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblSportsGround.Location = new System.Drawing.Point(568, 1);
            this.lblSportsGround.Name = "lblSportsGround";
            this.lblSportsGround.Size = new System.Drawing.Size(275, 61);
            this.lblSportsGround.TabIndex = 15;
            this.lblSportsGround.Text = "Partidas";
            this.lblSportsGround.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTopRecintos
            // 
            this.btnTopRecintos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnTopRecintos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTopRecintos.Image = ((System.Drawing.Image)(resources.GetObject("btnTopRecintos.Image")));
            this.btnTopRecintos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopRecintos.Location = new System.Drawing.Point(790, 18);
            this.btnTopRecintos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTopRecintos.Name = "btnTopRecintos";
            this.btnTopRecintos.Size = new System.Drawing.Size(177, 55);
            this.btnTopRecintos.TabIndex = 81;
            this.btnTopRecintos.Text = "Top Recintos";
            this.btnTopRecintos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTopRecintos.UseVisualStyleBackColor = true;
            this.btnTopRecintos.Click += new System.EventHandler(this.btnTopRecintos_Click);
            // 
            // UC_Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTopRecintos);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flpRank);
            this.Controls.Add(this.btnGlobalRank);
            this.Controls.Add(this.btnTop10);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_Rank";
            this.Size = new System.Drawing.Size(1226, 778);
            this.Load += new System.EventHandler(this.UC_Rank_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Button btnGlobalRank;
        private System.Windows.Forms.FlowLayoutPanel flpRank;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblstart_Hour;
        private System.Windows.Forms.Label lblEventOwnerValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSportsGround;
        private System.Windows.Forms.Button btnTopRecintos;
    }
}

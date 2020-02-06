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
            this.tbpClassification = new System.Windows.Forms.TableLayoutPanel();
            this.lblName3 = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblClassification = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.btnTopParks = new System.Windows.Forms.Button();
            this.tbpClassification.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTop10
            // 
            this.btnTop10.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnTop10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTop10.Image = ((System.Drawing.Image)(resources.GetObject("btnTop10.Image")));
            this.btnTop10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTop10.Location = new System.Drawing.Point(185, 18);
            this.btnTop10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(212, 55);
            this.btnTop10.TabIndex = 1;
            this.btnTop10.Text = "Top Jogadores";
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
            this.btnGlobalRank.Size = new System.Drawing.Size(223, 55);
            this.btnGlobalRank.TabIndex = 2;
            this.btnGlobalRank.Text = "Ranking Global";
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
            // tbpClassification
            // 
            this.tbpClassification.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbpClassification.ColumnCount = 4;
            this.tbpClassification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbpClassification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbpClassification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbpClassification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbpClassification.Controls.Add(this.lblName3, 3, 0);
            this.tbpClassification.Controls.Add(this.lblName1, 0, 0);
            this.tbpClassification.Controls.Add(this.lblClassification, 0, 0);
            this.tbpClassification.Controls.Add(this.lblName2, 1, 0);
            this.tbpClassification.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbpClassification.Location = new System.Drawing.Point(45, 103);
            this.tbpClassification.Name = "tbpClassification";
            this.tbpClassification.RowCount = 1;
            this.tbpClassification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpClassification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tbpClassification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tbpClassification.Size = new System.Drawing.Size(1130, 63);
            this.tbpClassification.TabIndex = 34;
            // 
            // lblName3
            // 
            this.lblName3.AutoSize = true;
            this.lblName3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblName3.Location = new System.Drawing.Point(850, 1);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(276, 61);
            this.lblName3.TabIndex = 31;
            this.lblName3.Text = "Pontos";
            this.lblName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblName1.Location = new System.Drawing.Point(286, 1);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(275, 61);
            this.lblName1.TabIndex = 30;
            this.lblName1.Text = "Utilizador";
            this.lblName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClassification.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblClassification.Location = new System.Drawing.Point(4, 1);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(275, 61);
            this.lblClassification.TabIndex = 29;
            this.lblClassification.Text = "Classificação";
            this.lblClassification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblName2.Location = new System.Drawing.Point(568, 1);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(275, 61);
            this.lblName2.TabIndex = 15;
            this.lblName2.Text = "Partidas";
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTopGrounds
            // 
            this.btnTopParks.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnTopParks.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTopParks.Image = ((System.Drawing.Image)(resources.GetObject("btnTopRecintos.Image")));
            this.btnTopParks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopParks.Location = new System.Drawing.Point(798, 18);
            this.btnTopParks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTopParks.Name = "btnTopRecintos";
            this.btnTopParks.Size = new System.Drawing.Size(182, 55);
            this.btnTopParks.TabIndex = 81;
            this.btnTopParks.Text = "Top Recintos";
            this.btnTopParks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTopParks.UseVisualStyleBackColor = true;
            this.btnTopParks.Click += new System.EventHandler(this.btnTopGrounds_Click);
            // 
            // UC_Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTopParks);
            this.Controls.Add(this.tbpClassification);
            this.Controls.Add(this.flpRank);
            this.Controls.Add(this.btnGlobalRank);
            this.Controls.Add(this.btnTop10);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_Rank";
            this.Size = new System.Drawing.Size(1226, 778);
            this.Load += new System.EventHandler(this.UC_Rank_Load);
            this.tbpClassification.ResumeLayout(false);
            this.tbpClassification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Button btnGlobalRank;
        private System.Windows.Forms.FlowLayoutPanel flpRank;
        private System.Windows.Forms.TableLayoutPanel tbpClassification;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Button btnTopParks;
    }
}

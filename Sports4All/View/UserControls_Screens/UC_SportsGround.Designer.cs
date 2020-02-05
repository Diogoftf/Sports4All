namespace Sports4All
{
    partial class UC_SportsGround
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
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblEvaluation = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.cbScore = new System.Windows.Forms.ComboBox();
            this.flpSportsGround = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(270, 12);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(161, 19);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Filtrar por localização:";
            // 
            // lblEvaluation
            // 
            this.lblEvaluation.AutoSize = true;
            this.lblEvaluation.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluation.Location = new System.Drawing.Point(708, 12);
            this.lblEvaluation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvaluation.Name = "lblEvaluation";
            this.lblEvaluation.Size = new System.Drawing.Size(151, 19);
            this.lblEvaluation.TabIndex = 1;
            this.lblEvaluation.Text = "Filtrar por Avaliação:";
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(442, 7);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(215, 27);
            this.cbLocation.TabIndex = 2;
            this.cbLocation.SelectionChangeCommitted += new System.EventHandler(this.SortItemChanged);
            // 
            // cbScore
            // 
            this.cbScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScore.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbScore.FormattingEnabled = true;
            this.cbScore.Location = new System.Drawing.Point(871, 7);
            this.cbScore.Margin = new System.Windows.Forms.Padding(4);
            this.cbScore.Name = "cbScore";
            this.cbScore.Size = new System.Drawing.Size(173, 27);
            this.cbScore.TabIndex = 3;
            this.cbScore.SelectionChangeCommitted += new System.EventHandler(this.SortItemChanged);
            // 
            // flpSportsGround
            // 
            this.flpSportsGround.AutoScroll = true;
            this.flpSportsGround.Location = new System.Drawing.Point(12, 50);
            this.flpSportsGround.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpSportsGround.Name = "flpSportsGround";
            this.flpSportsGround.Size = new System.Drawing.Size(1031, 503);
            this.flpSportsGround.TabIndex = 4;
            // 
            // UC_SportsGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpSportsGround);
            this.Controls.Add(this.cbScore);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.lblEvaluation);
            this.Controls.Add(this.lblLocation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_SportsGround";
            this.Size = new System.Drawing.Size(1089, 622);
            this.Load += new System.EventHandler(this.UC_SportsGround_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEvaluation;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.ComboBox cbScore;
        private System.Windows.Forms.FlowLayoutPanel flpSportsGround;
    }
}

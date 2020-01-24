namespace Sports4All
{
    partial class UC_UserinEventItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UserinEventItem));
            this.plPlayerEvaluation = new System.Windows.Forms.Panel();
            this.cpbPlayer = new Sports4All.CircularPictureBox();
            this.lblUserRankingValue = new System.Windows.Forms.Label();
            this.lblRanking = new System.Windows.Forms.Label();
            this.lbUserAge = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.plPlayerEvaluation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // plPlayerEvaluation
            // 
            this.plPlayerEvaluation.Controls.Add(this.cpbPlayer);
            this.plPlayerEvaluation.Controls.Add(this.lblUserRankingValue);
            this.plPlayerEvaluation.Controls.Add(this.lblRanking);
            this.plPlayerEvaluation.Controls.Add(this.lbUserAge);
            this.plPlayerEvaluation.Controls.Add(this.lblLine);
            this.plPlayerEvaluation.Controls.Add(this.lblUsername);
            this.plPlayerEvaluation.Location = new System.Drawing.Point(0, 3);
            this.plPlayerEvaluation.Name = "plPlayerEvaluation";
            this.plPlayerEvaluation.Size = new System.Drawing.Size(325, 56);
            this.plPlayerEvaluation.TabIndex = 1;
            // 
            // cpbPlayer
            // 
            this.cpbPlayer.BackColor = System.Drawing.Color.LightGray;
            this.cpbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("cpbPlayer.Image")));
            this.cpbPlayer.Location = new System.Drawing.Point(8, 3);
            this.cpbPlayer.Name = "cpbPlayer";
            this.cpbPlayer.Size = new System.Drawing.Size(41, 48);
            this.cpbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpbPlayer.TabIndex = 18;
            this.cpbPlayer.TabStop = false;
            // 
            // lblUserRankingValue
            // 
            this.lblUserRankingValue.AutoSize = true;
            this.lblUserRankingValue.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRankingValue.Location = new System.Drawing.Point(270, 22);
            this.lblUserRankingValue.Name = "lblUserRankingValue";
            this.lblUserRankingValue.Size = new System.Drawing.Size(49, 21);
            this.lblUserRankingValue.TabIndex = 17;
            this.lblUserRankingValue.Text = "#005";
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRanking.Location = new System.Drawing.Point(186, 22);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(80, 19);
            this.lblRanking.TabIndex = 16;
            this.lblRanking.Text = "Ranking:";
            // 
            // lbUserAge
            // 
            this.lbUserAge.AutoSize = true;
            this.lbUserAge.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lbUserAge.Location = new System.Drawing.Point(81, 32);
            this.lbUserAge.Name = "lbUserAge";
            this.lbUserAge.Size = new System.Drawing.Size(64, 18);
            this.lbUserAge.TabIndex = 3;
            this.lbUserAge.Text = "34 Anos";
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(0, 94);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(650, 1);
            this.lblLine.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(69, 10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // UC_UserinEventItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plPlayerEvaluation);
            this.Name = "UC_UserinEventItem";
            this.Size = new System.Drawing.Size(330, 64);
            this.plPlayerEvaluation.ResumeLayout(false);
            this.plPlayerEvaluation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plPlayerEvaluation;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lbUserAge;
        private System.Windows.Forms.Label lblUserRankingValue;
        private System.Windows.Forms.Label lblRanking;
        private CircularPictureBox cpbPlayer;
    }
}


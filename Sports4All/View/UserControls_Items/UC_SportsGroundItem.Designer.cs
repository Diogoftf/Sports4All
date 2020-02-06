namespace Sports4All.UserControls_Items
{
    partial class UC_SportsGroundItem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSportsGround = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSportsGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // pbSportsGround
            // 
            this.pbSportsGround.Location = new System.Drawing.Point(32, 70);
            this.pbSportsGround.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSportsGround.Name = "pbSportsGround";
            this.pbSportsGround.Size = new System.Drawing.Size(206, 199);
            this.pbSportsGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSportsGround.TabIndex = 1;
            this.pbSportsGround.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(4, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 45);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQuality
            // 
            this.lblQuality.AutoEllipsis = true;
            this.lblQuality.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblQuality.Location = new System.Drawing.Point(0, 271);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(267, 29);
            this.lblQuality.TabIndex = 3;
            this.lblQuality.Text = "Qualidade: 0";
            this.lblQuality.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoEllipsis = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblPrice.Location = new System.Drawing.Point(-1, 300);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(267, 29);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Preço: 0";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UC_SportsGroundItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbSportsGround);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_SportsGroundItem";
            this.Size = new System.Drawing.Size(270, 334);
            this.DoubleClick += new System.EventHandler(this.UC_SportsGroundItem_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSportsGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSportsGround;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Label lblPrice;
    }
}

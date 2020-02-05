namespace Sports4All.View.UserControls_Items
{
    partial class PreviousScreenButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviousScreenButton));
            this.pbPrevious = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPrevious
            // 
            this.pbPrevious.Image = ((System.Drawing.Image)(resources.GetObject("pbPrevious.Image")));
            this.pbPrevious.Location = new System.Drawing.Point(5, 5);
            this.pbPrevious.Name = "pbPrevious";
            this.pbPrevious.Size = new System.Drawing.Size(50, 50);
            this.pbPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrevious.TabIndex = 4;
            this.pbPrevious.TabStop = false;
            this.pbPrevious.Click += new System.EventHandler(this.pbPrevious_Click);
            // 
            // PreviousScreenButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pbPrevious);
            this.Name = "PreviousScreenButton";
            this.Size = new System.Drawing.Size(60, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPrevious;
    }
}

namespace Sports4All.Patterns.State
{
    partial class SelectLocationState
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
            this.cbSelectLocation = new System.Windows.Forms.ComboBox();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.nextScreenButton = new Sports4All.View.UserControls_Items.NextScreenButton();
            this.previousScreenButton = new Sports4All.View.UserControls_Items.PreviousScreenButton();
            this.SuspendLayout();
            // 
            // cbSelectLocation
            // 
            this.cbSelectLocation.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.cbSelectLocation.FormattingEnabled = true;
            this.cbSelectLocation.Location = new System.Drawing.Point(393, 268);
            this.cbSelectLocation.Name = "cbSelectLocation";
            this.cbSelectLocation.Size = new System.Drawing.Size(295, 33);
            this.cbSelectLocation.TabIndex = 6;
            this.cbSelectLocation.SelectionChangeCommitted += new System.EventHandler(this.cbSelectLocation_SelectionChangeCommitted);
            // 
            // lblLocationName
            // 
            this.lblLocationName.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblLocationName.Location = new System.Drawing.Point(-2, 203);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(1084, 46);
            this.lblLocationName.TabIndex = 5;
            this.lblLocationName.Text = "Indique a localidade:";
            this.lblLocationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextScreenButton
            // 
            this.nextScreenButton.Location = new System.Drawing.Point(1024, 556);
            this.nextScreenButton.Name = "nextScreenButton";
            this.nextScreenButton.ReserveNoviceForm = null;
            this.nextScreenButton.Size = new System.Drawing.Size(63, 63);
            this.nextScreenButton.TabIndex = 8;
            // 
            // previousScreenButton
            // 
            this.previousScreenButton.Location = new System.Drawing.Point(3, 556);
            this.previousScreenButton.Name = "previousScreenButton";
            this.previousScreenButton.ReserveNoviceForm = null;
            this.previousScreenButton.Size = new System.Drawing.Size(63, 63);
            this.previousScreenButton.TabIndex = 7;
            // 
            // SelectLocationState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.nextScreenButton);
            this.Controls.Add(this.previousScreenButton);
            this.Controls.Add(this.cbSelectLocation);
            this.Controls.Add(this.lblLocationName);
            this.Name = "SelectLocationState";
            this.Size = new System.Drawing.Size(1090, 622);
            this.Load += new System.EventHandler(this.SelectLocationState_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private View.UserControls_Items.NextScreenButton nextScreenButton;
        private View.UserControls_Items.PreviousScreenButton previousScreenButton;
        private System.Windows.Forms.ComboBox cbSelectLocation;
        private System.Windows.Forms.Label lblLocationName;
    }
}

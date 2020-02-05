namespace Sports4All.Patterns.State
{
    partial class SelectSportState
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
            this.lblSportName = new System.Windows.Forms.Label();
            this.cbSelectSport = new System.Windows.Forms.ComboBox();
            this.nextScreenButton = new Sports4All.View.UserControls_Items.NextScreenButton();
            this.previousScreenButton = new Sports4All.View.UserControls_Items.PreviousScreenButton();
            this.SuspendLayout();
            // 
            // lblSportName
            // 
            this.lblSportName.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblSportName.Location = new System.Drawing.Point(3, 203);
            this.lblSportName.Name = "lblSportName";
            this.lblSportName.Size = new System.Drawing.Size(1084, 46);
            this.lblSportName.TabIndex = 1;
            this.lblSportName.Text = "Indique o desporto:";
            this.lblSportName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSelectSport
            // 
            this.cbSelectSport.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.cbSelectSport.FormattingEnabled = true;
            this.cbSelectSport.Location = new System.Drawing.Point(398, 268);
            this.cbSelectSport.Name = "cbSelectSport";
            this.cbSelectSport.Size = new System.Drawing.Size(295, 33);
            this.cbSelectSport.TabIndex = 2;
            this.cbSelectSport.SelectionChangeCommitted += new System.EventHandler(this.cbSelectSport_SelectedValueChanged);
            // 
            // nextScreenButton
            // 
            this.nextScreenButton.Location = new System.Drawing.Point(1024, 556);
            this.nextScreenButton.Name = "nextScreenButton";
            this.nextScreenButton.ReserveNoviceForm = null;
            this.nextScreenButton.Size = new System.Drawing.Size(63, 63);
            this.nextScreenButton.TabIndex = 4;
            // 
            // previousScreenButton
            // 
            this.previousScreenButton.Location = new System.Drawing.Point(3, 556);
            this.previousScreenButton.Name = "previousScreenButton";
            this.previousScreenButton.ReserveNoviceForm = null;
            this.previousScreenButton.Size = new System.Drawing.Size(63, 63);
            this.previousScreenButton.TabIndex = 3;
            // 
            // SelectSportState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.nextScreenButton);
            this.Controls.Add(this.previousScreenButton);
            this.Controls.Add(this.cbSelectSport);
            this.Controls.Add(this.lblSportName);
            this.Name = "SelectSportState";
            this.Size = new System.Drawing.Size(1090, 622);
            this.Load += new System.EventHandler(this.SelectSportState_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSportName;
        private System.Windows.Forms.ComboBox cbSelectSport;
        private View.UserControls_Items.PreviousScreenButton previousScreenButton;
        private View.UserControls_Items.NextScreenButton nextScreenButton;
    }
}

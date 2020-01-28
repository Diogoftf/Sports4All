namespace Sports4All
{
    partial class UC_Events
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
            this.flpEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpEvents
            // 
            this.flpEvents.AutoScroll = true;
            this.flpEvents.Location = new System.Drawing.Point(8, 2);
            this.flpEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpEvents.Name = "flpEvents";
            this.flpEvents.Size = new System.Drawing.Size(1043, 547);
            this.flpEvents.TabIndex = 0;
            // 
            // UC_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpEvents);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Events";
            this.Size = new System.Drawing.Size(1089, 622);
            this.Load += new System.EventHandler(this.UC_Events_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEvents;
    }
}

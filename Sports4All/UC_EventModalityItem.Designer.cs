namespace Sports4All
{
    partial class UC_EventModalityItem
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
            this.SuspendLayout();
            // 
            // UC_EventModalityItem
            // 
            this.Name = "UC_EventModalityItem";
            this.Load += new System.EventHandler(this.UC_EventModalityItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDay_Event;
        private System.Windows.Forms.Label lblMonth_Event;
        private System.Windows.Forms.Panel plEventDate;
        private System.Windows.Forms.Panel plEventData;
        private System.Windows.Forms.Label lblSportsGround;
        private System.Windows.Forms.Label lblEventHour;
        private System.Windows.Forms.Label lblEventHourValue;
        private System.Windows.Forms.Panel plLine;
        private System.Windows.Forms.Label lblSpaceAvailable;
        private System.Windows.Forms.Label lblEventOwnerValue;
        private System.Windows.Forms.Label lblEventOwner;
        private System.Windows.Forms.Button btnJoinEvent;
        private System.Windows.Forms.Label lblSpaceAvailableValue;
        private UC_UnregisterButton uC_UnregisterButton1;
    }
}

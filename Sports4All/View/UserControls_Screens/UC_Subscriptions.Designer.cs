namespace Sports4All.UserControls_Screens
{
    partial class UC_Subscriptions
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
            this.flpSubscriptions = new System.Windows.Forms.FlowLayoutPanel();
            this.tabSubscriptions = new System.Windows.Forms.TabControl();
            this.tabPageSports = new System.Windows.Forms.TabPage();
            this.pnlSports = new System.Windows.Forms.Panel();
            this.tabPageFriends = new System.Windows.Forms.TabPage();
            this.pnlFriends = new System.Windows.Forms.Panel();
            this.tabPageParks = new System.Windows.Forms.TabPage();
            this.pnlParks = new System.Windows.Forms.Panel();
            this.tabSubscriptions.SuspendLayout();
            this.tabPageSports.SuspendLayout();
            this.tabPageFriends.SuspendLayout();
            this.tabPageParks.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSubscriptions
            // 
            this.flpSubscriptions.AutoScroll = true;
            this.flpSubscriptions.Location = new System.Drawing.Point(897, 47);
            this.flpSubscriptions.Name = "flpSubscriptions";
            this.flpSubscriptions.Size = new System.Drawing.Size(1160, 629);
            this.flpSubscriptions.TabIndex = 5;
            // 
            // tabSubscriptions
            // 
            this.tabSubscriptions.Controls.Add(this.tabPageSports);
            this.tabSubscriptions.Controls.Add(this.tabPageFriends);
            this.tabSubscriptions.Controls.Add(this.tabPageParks);
            this.tabSubscriptions.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tabSubscriptions.Location = new System.Drawing.Point(15, 17);
            this.tabSubscriptions.Name = "tabSubscriptions";
            this.tabSubscriptions.SelectedIndex = 0;
            this.tabSubscriptions.Size = new System.Drawing.Size(1193, 743);
            this.tabSubscriptions.TabIndex = 10;
            this.tabSubscriptions.SelectedIndexChanged += new System.EventHandler(this.tabSubscriptions_SelectedIndexChanged);
            // 
            // tabPageSports
            // 
            this.tabPageSports.Controls.Add(this.pnlSports);
            this.tabPageSports.Location = new System.Drawing.Point(4, 32);
            this.tabPageSports.Name = "tabPageSports";
            this.tabPageSports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSports.Size = new System.Drawing.Size(1185, 707);
            this.tabPageSports.TabIndex = 0;
            this.tabPageSports.Text = "Desportos";
            this.tabPageSports.UseVisualStyleBackColor = true;
            this.tabPageSports.UseWaitCursor = true;
            // 
            // pnlSports
            // 
            this.pnlSports.Location = new System.Drawing.Point(6, 6);
            this.pnlSports.Name = "pnlSports";
            this.pnlSports.Size = new System.Drawing.Size(1173, 685);
            this.pnlSports.TabIndex = 0;
            // 
            // tabPageFriends
            // 
            this.tabPageFriends.Controls.Add(this.pnlFriends);
            this.tabPageFriends.Location = new System.Drawing.Point(4, 32);
            this.tabPageFriends.Name = "tabPageFriends";
            this.tabPageFriends.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFriends.Size = new System.Drawing.Size(1185, 707);
            this.tabPageFriends.TabIndex = 1;
            this.tabPageFriends.Text = "Amigos";
            this.tabPageFriends.UseVisualStyleBackColor = true;
            // 
            // pnlFriends
            // 
            this.pnlFriends.Location = new System.Drawing.Point(6, 6);
            this.pnlFriends.Name = "pnlFriends";
            this.pnlFriends.Size = new System.Drawing.Size(1173, 685);
            this.pnlFriends.TabIndex = 1;
            // 
            // tabPageParks
            // 
            this.tabPageParks.Controls.Add(this.pnlParks);
            this.tabPageParks.Location = new System.Drawing.Point(4, 32);
            this.tabPageParks.Name = "tabPageParks";
            this.tabPageParks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParks.Size = new System.Drawing.Size(1185, 707);
            this.tabPageParks.TabIndex = 2;
            this.tabPageParks.Text = "Parques";
            this.tabPageParks.UseVisualStyleBackColor = true;
            // 
            // pnlParks
            // 
            this.pnlParks.Location = new System.Drawing.Point(6, 6);
            this.pnlParks.Name = "pnlParks";
            this.pnlParks.Size = new System.Drawing.Size(1173, 685);
            this.pnlParks.TabIndex = 1;
            // 
            // UC_Subscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabSubscriptions);
            this.Controls.Add(this.flpSubscriptions);
            this.Name = "UC_Subscriptions";
            this.Size = new System.Drawing.Size(1225, 778);
            this.Load += new System.EventHandler(this.UC_Subscriptions_Load);
            this.tabSubscriptions.ResumeLayout(false);
            this.tabPageSports.ResumeLayout(false);
            this.tabPageFriends.ResumeLayout(false);
            this.tabPageParks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSubscriptions;
        private System.Windows.Forms.TabControl tabSubscriptions;
        private System.Windows.Forms.TabPage tabPageSports;
        private System.Windows.Forms.Panel pnlSports;
        private System.Windows.Forms.TabPage tabPageFriends;
        private System.Windows.Forms.Panel pnlFriends;
        private System.Windows.Forms.TabPage tabPageParks;
        private System.Windows.Forms.Panel pnlParks;
    }
}

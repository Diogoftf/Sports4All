namespace Sports4All
{
    partial class UC_EventsModality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EventsModality));
            this.tbModalityName = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.tbSubNotification = new System.Windows.Forms.TextBox();
            this.plTopContentModality = new System.Windows.Forms.Panel();
            this.plEventsFilterModality = new System.Windows.Forms.Panel();
            this.lblTitleFilter = new System.Windows.Forms.Label();
            this.cbLocationFilter = new System.Windows.Forms.ComboBox();
            this.tbEvents_title = new System.Windows.Forms.TextBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.flpEventListModality = new System.Windows.Forms.FlowLayoutPanel();
            this.plTopContentModality.SuspendLayout();
            this.plEventsFilterModality.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbModalityName
            // 
            this.tbModalityName.BackColor = System.Drawing.SystemColors.Control;
            this.tbModalityName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbModalityName.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.tbModalityName.Location = new System.Drawing.Point(46, 7);
            this.tbModalityName.Name = "tbModalityName";
            this.tbModalityName.Size = new System.Drawing.Size(936, 35);
            this.tbModalityName.TabIndex = 7;
            this.tbModalityName.Text = "Futebol";
            // 
            // btnSub
            // 
            this.btnSub.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Image = ((System.Drawing.Image)(resources.GetObject("btnSub.Image")));
            this.btnSub.Location = new System.Drawing.Point(0, 0);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(51, 47);
            this.btnSub.TabIndex = 10;
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.subButton_Click);
            this.btnSub.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.btnSub.MouseHover += new System.EventHandler(this.mouseHover);
            // 
            // tbSubNotification
            // 
            this.tbSubNotification.Location = new System.Drawing.Point(3, 47);
            this.tbSubNotification.Name = "tbSubNotification";
            this.tbSubNotification.ReadOnly = true;
            this.tbSubNotification.Size = new System.Drawing.Size(184, 22);
            this.tbSubNotification.TabIndex = 11;
            this.tbSubNotification.Text = "Subscreva esta Modalidade!";
            this.tbSubNotification.Visible = false;
            // 
            // plTopContentModality
            // 
            this.plTopContentModality.Controls.Add(this.tbModalityName);
            this.plTopContentModality.Controls.Add(this.btnSub);
            this.plTopContentModality.Controls.Add(this.tbSubNotification);
            this.plTopContentModality.Location = new System.Drawing.Point(38, 6);
            this.plTopContentModality.Name = "plTopContentModality";
            this.plTopContentModality.Size = new System.Drawing.Size(996, 68);
            this.plTopContentModality.TabIndex = 13;
            // 
            // plEventsFilterModality
            // 
            this.plEventsFilterModality.Controls.Add(this.lblTitleFilter);
            this.plEventsFilterModality.Controls.Add(this.cbLocationFilter);
            this.plEventsFilterModality.Controls.Add(this.tbEvents_title);
            this.plEventsFilterModality.Location = new System.Drawing.Point(38, 71);
            this.plEventsFilterModality.Name = "plEventsFilterModality";
            this.plEventsFilterModality.Size = new System.Drawing.Size(999, 62);
            this.plEventsFilterModality.TabIndex = 17;
            // 
            // lblTitleFilter
            // 
            this.lblTitleFilter.AutoSize = true;
            this.lblTitleFilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleFilter.Location = new System.Drawing.Point(820, 0);
            this.lblTitleFilter.Name = "lblTitleFilter";
            this.lblTitleFilter.Size = new System.Drawing.Size(129, 23);
            this.lblTitleFilter.TabIndex = 7;
            this.lblTitleFilter.Text = "Localização";
            // 
            // cbLocationFilter
            // 
            this.cbLocationFilter.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbLocationFilter.FormattingEnabled = true;
            this.cbLocationFilter.Items.AddRange(new object[] {
            "Machico",
            "Santa Cruz",
            "Funchal",
            "Ribeira Brava"});
            this.cbLocationFilter.Location = new System.Drawing.Point(825, 26);
            this.cbLocationFilter.Name = "cbLocationFilter";
            this.cbLocationFilter.Size = new System.Drawing.Size(158, 31);
            this.cbLocationFilter.TabIndex = 8;
            this.cbLocationFilter.SelectionChangeCommitted += new System.EventHandler(this.SortItemChanged);
            // 
            // tbEvents_title
            // 
            this.tbEvents_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEvents_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEvents_title.Location = new System.Drawing.Point(3, 3);
            this.tbEvents_title.Name = "tbEvents_title";
            this.tbEvents_title.ReadOnly = true;
            this.tbEvents_title.Size = new System.Drawing.Size(205, 25);
            this.tbEvents_title.TabIndex = 4;
            this.tbEvents_title.Text = "Eventos Disponíveis:";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddEvent.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.Location = new System.Drawing.Point(463, 571);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(103, 72);
            this.btnAddEvent.TabIndex = 16;
            this.btnAddEvent.UseVisualStyleBackColor = false;
            // 
            // flpEventListModality
            // 
            this.flpEventListModality.AutoScroll = true;
            this.flpEventListModality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpEventListModality.Location = new System.Drawing.Point(38, 140);
            this.flpEventListModality.Name = "flpEventListModality";
            this.flpEventListModality.Size = new System.Drawing.Size(1010, 432);
            this.flpEventListModality.TabIndex = 19;
            // 
            // UC_EventsModality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpEventListModality);
            this.Controls.Add(this.plEventsFilterModality);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.plTopContentModality);
            this.Name = "UC_EventsModality";
            this.Size = new System.Drawing.Size(1089, 646);
            this.Load += new System.EventHandler(this.onLoad);
            this.plTopContentModality.ResumeLayout(false);
            this.plTopContentModality.PerformLayout();
            this.plEventsFilterModality.ResumeLayout(false);
            this.plEventsFilterModality.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.TextBox tbModalityName;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.TextBox tbSubNotification;
        private System.Windows.Forms.Panel plTopContentModality;
        private System.Windows.Forms.Panel plEventsFilterModality;
        private System.Windows.Forms.TextBox tbEvents_title;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.FlowLayoutPanel flpEventListModality;
        private System.Windows.Forms.ComboBox cbLocationFilter;
        private System.Windows.Forms.Label lblTitleFilter;
    }
}

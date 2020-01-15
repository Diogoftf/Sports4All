namespace Sports4All
{
    partial class UC_EventSportsGroundItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EventSportsGroundItem));
            this.lblDay_Event = new System.Windows.Forms.Label();
            this.lblMonth_Event = new System.Windows.Forms.Label();
            this.plEventDate = new System.Windows.Forms.Panel();
            this.plEventData = new System.Windows.Forms.Panel();
            this.btnJoinEvent = new System.Windows.Forms.Button();
            this.lblSpaceAvailableValue = new System.Windows.Forms.Label();
            this.lblSpaceAvailable = new System.Windows.Forms.Label();
            this.lblEventOwnerValue = new System.Windows.Forms.Label();
            this.lblEventOwner = new System.Windows.Forms.Label();
            this.lblEventHour = new System.Windows.Forms.Label();
            this.lblEventHourValue = new System.Windows.Forms.Label();
            this.plLine = new System.Windows.Forms.Panel();
            this.lblModalityName = new System.Windows.Forms.Label();
            this.plEventDate.SuspendLayout();
            this.plEventData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDay_Event
            // 
            this.lblDay_Event.AutoSize = true;
            this.lblDay_Event.Font = new System.Drawing.Font("Century Gothic", 31F, System.Drawing.FontStyle.Bold);
            this.lblDay_Event.Location = new System.Drawing.Point(50, 4);
            this.lblDay_Event.Name = "lblDay_Event";
            this.lblDay_Event.Size = new System.Drawing.Size(85, 62);
            this.lblDay_Event.TabIndex = 0;
            this.lblDay_Event.Text = "04";
            this.lblDay_Event.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMonth_Event
            // 
            this.lblMonth_Event.AutoSize = true;
            this.lblMonth_Event.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold);
            this.lblMonth_Event.Location = new System.Drawing.Point(45, 60);
            this.lblMonth_Event.Name = "lblMonth_Event";
            this.lblMonth_Event.Size = new System.Drawing.Size(87, 41);
            this.lblMonth_Event.TabIndex = 1;
            this.lblMonth_Event.Text = "JAN";
            this.lblMonth_Event.Click += new System.EventHandler(this.lblMonth_Event_Click);
            // 
            // plEventDate
            // 
            this.plEventDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.plEventDate.Controls.Add(this.lblMonth_Event);
            this.plEventDate.Controls.Add(this.lblDay_Event);
            this.plEventDate.Location = new System.Drawing.Point(0, 0);
            this.plEventDate.Name = "plEventDate";
            this.plEventDate.Size = new System.Drawing.Size(177, 106);
            this.plEventDate.TabIndex = 2;
            this.plEventDate.Paint += new System.Windows.Forms.PaintEventHandler(this.plEventDate_Paint);
            // 
            // plEventData
            // 
            this.plEventData.Controls.Add(this.btnJoinEvent);
            this.plEventData.Controls.Add(this.lblSpaceAvailableValue);
            this.plEventData.Controls.Add(this.lblSpaceAvailable);
            this.plEventData.Controls.Add(this.lblEventOwnerValue);
            this.plEventData.Controls.Add(this.lblEventOwner);
            this.plEventData.Controls.Add(this.lblEventHour);
            this.plEventData.Controls.Add(this.lblEventHourValue);
            this.plEventData.Controls.Add(this.plLine);
            this.plEventData.Controls.Add(this.lblModalityName);
            this.plEventData.Location = new System.Drawing.Point(183, 0);
            this.plEventData.Name = "plEventData";
            this.plEventData.Size = new System.Drawing.Size(817, 103);
            this.plEventData.TabIndex = 3;
            this.plEventData.Paint += new System.Windows.Forms.PaintEventHandler(this.plEventData_Paint);
            // 
            // btnJoinEvent
            // 
            this.btnJoinEvent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnJoinEvent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnJoinEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnJoinEvent.Image")));
            this.btnJoinEvent.Location = new System.Drawing.Point(666, 20);
            this.btnJoinEvent.Name = "btnJoinEvent";
            this.btnJoinEvent.Size = new System.Drawing.Size(79, 55);
            this.btnJoinEvent.TabIndex = 8;
            this.btnJoinEvent.UseVisualStyleBackColor = false;
            this.btnJoinEvent.Click += new System.EventHandler(this.btnJoinEvent_Click);
            // 
            // lblSpaceAvailableValue
            // 
            this.lblSpaceAvailableValue.AutoSize = true;
            this.lblSpaceAvailableValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceAvailableValue.Location = new System.Drawing.Point(581, 36);
            this.lblSpaceAvailableValue.Name = "lblSpaceAvailableValue";
            this.lblSpaceAvailableValue.Size = new System.Drawing.Size(52, 23);
            this.lblSpaceAvailableValue.TabIndex = 7;
            this.lblSpaceAvailableValue.Text = "2/10";
            this.lblSpaceAvailableValue.Click += new System.EventHandler(this.lblSpaceAvailableValue_Click);
            // 
            // lblSpaceAvailable
            // 
            this.lblSpaceAvailable.AutoSize = true;
            this.lblSpaceAvailable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceAvailable.Location = new System.Drawing.Point(479, 36);
            this.lblSpaceAvailable.Name = "lblSpaceAvailable";
            this.lblSpaceAvailable.Size = new System.Drawing.Size(96, 23);
            this.lblSpaceAvailable.TabIndex = 6;
            this.lblSpaceAvailable.Text = "Lotação:";
            this.lblSpaceAvailable.Click += new System.EventHandler(this.lblSpaceAvailable_Click);
            // 
            // lblEventOwnerValue
            // 
            this.lblEventOwnerValue.AutoSize = true;
            this.lblEventOwnerValue.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventOwnerValue.Location = new System.Drawing.Point(74, 74);
            this.lblEventOwnerValue.Name = "lblEventOwnerValue";
            this.lblEventOwnerValue.Size = new System.Drawing.Size(137, 20);
            this.lblEventOwnerValue.TabIndex = 5;
            this.lblEventOwnerValue.Text = "Helena Rodrigues";
            this.lblEventOwnerValue.Click += new System.EventHandler(this.lblEventOwnerValue_Click);
            // 
            // lblEventOwner
            // 
            this.lblEventOwner.AutoSize = true;
            this.lblEventOwner.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventOwner.Location = new System.Drawing.Point(8, 74);
            this.lblEventOwner.Name = "lblEventOwner";
            this.lblEventOwner.Size = new System.Drawing.Size(64, 20);
            this.lblEventOwner.TabIndex = 4;
            this.lblEventOwner.Text = "Owner:";
            this.lblEventOwner.Click += new System.EventHandler(this.lblEventOwner_Click);
            // 
            // lblEventHour
            // 
            this.lblEventHour.AutoSize = true;
            this.lblEventHour.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblEventHour.Location = new System.Drawing.Point(21, 50);
            this.lblEventHour.Name = "lblEventHour";
            this.lblEventHour.Size = new System.Drawing.Size(48, 20);
            this.lblEventHour.TabIndex = 3;
            this.lblEventHour.Text = "Hora:";
            this.lblEventHour.Click += new System.EventHandler(this.lblEventHour_Click);
            // 
            // lblEventHourValue
            // 
            this.lblEventHourValue.AutoSize = true;
            this.lblEventHourValue.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventHourValue.Location = new System.Drawing.Point(72, 51);
            this.lblEventHourValue.Name = "lblEventHourValue";
            this.lblEventHourValue.Size = new System.Drawing.Size(35, 20);
            this.lblEventHourValue.TabIndex = 2;
            this.lblEventHourValue.Text = "16H";
            this.lblEventHourValue.Click += new System.EventHandler(this.lblEventHourValue_Click);
            // 
            // plLine
            // 
            this.plLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.plLine.Location = new System.Drawing.Point(6, 35);
            this.plLine.Name = "plLine";
            this.plLine.Size = new System.Drawing.Size(324, 5);
            this.plLine.TabIndex = 1;
            this.plLine.Paint += new System.Windows.Forms.PaintEventHandler(this.plLine_Paint);
            // 
            // lblModalityName
            // 
            this.lblModalityName.AutoSize = true;
            this.lblModalityName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblModalityName.Location = new System.Drawing.Point(12, 9);
            this.lblModalityName.Name = "lblModalityName";
            this.lblModalityName.Size = new System.Drawing.Size(82, 23);
            this.lblModalityName.TabIndex = 0;
            this.lblModalityName.Text = "Futebol";
            this.lblModalityName.Click += new System.EventHandler(this.label3_Click);
            // 
            // UC_EventSportsGroundItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.plEventData);
            this.Controls.Add(this.plEventDate);
            this.Name = "UC_EventSportsGroundItem";
            this.Size = new System.Drawing.Size(1003, 106);
            this.plEventDate.ResumeLayout(false);
            this.plEventDate.PerformLayout();
            this.plEventData.ResumeLayout(false);
            this.plEventData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDay_Event;
        private System.Windows.Forms.Label lblMonth_Event;
        private System.Windows.Forms.Panel plEventDate;
        private System.Windows.Forms.Panel plEventData;
        private System.Windows.Forms.Label lblModalityName;
        private System.Windows.Forms.Label lblEventHour;
        private System.Windows.Forms.Label lblEventHourValue;
        private System.Windows.Forms.Panel plLine;
        private System.Windows.Forms.Label lblSpaceAvailable;
        private System.Windows.Forms.Label lblEventOwnerValue;
        private System.Windows.Forms.Label lblEventOwner;
        private System.Windows.Forms.Button btnJoinEvent;
        private System.Windows.Forms.Label lblSpaceAvailableValue;
    }
}

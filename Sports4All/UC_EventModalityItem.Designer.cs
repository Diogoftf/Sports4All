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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EventModalityItem));
            this.lblDay_Event = new System.Windows.Forms.Label();
            this.lblMonth_Event = new System.Windows.Forms.Label();
            this.plEventDate = new System.Windows.Forms.Panel();
            this.plEventData = new System.Windows.Forms.Panel();
            this.uC_UnregisterButton1 = new Sports4All.UC_UnregisterButton();
            this.btnJoinEvent = new System.Windows.Forms.Button();
            this.lblSpaceAvailableValue = new System.Windows.Forms.Label();
            this.lblSpaceAvailable = new System.Windows.Forms.Label();
            this.lblEventOwnerValue = new System.Windows.Forms.Label();
            this.lblEventOwner = new System.Windows.Forms.Label();
            this.lblEventHour = new System.Windows.Forms.Label();
            this.lblEventHourValue = new System.Windows.Forms.Label();
            this.plLine = new System.Windows.Forms.Panel();
            this.lblSportsGround = new System.Windows.Forms.Label();
            this.plEventDate.SuspendLayout();
            this.plEventData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDay_Event
            // 
            this.lblDay_Event.AutoSize = true;
            this.lblDay_Event.Font = new System.Drawing.Font("Century Gothic", 31F, System.Drawing.FontStyle.Bold);
            this.lblDay_Event.Location = new System.Drawing.Point(56, 5);
            this.lblDay_Event.Name = "lblDay_Event";
            this.lblDay_Event.Size = new System.Drawing.Size(102, 73);
            this.lblDay_Event.TabIndex = 0;
            this.lblDay_Event.Text = "04";
            // 
            // lblMonth_Event
            // 
            this.lblMonth_Event.AutoSize = true;
            this.lblMonth_Event.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold);
            this.lblMonth_Event.Location = new System.Drawing.Point(51, 75);
            this.lblMonth_Event.Name = "lblMonth_Event";
            this.lblMonth_Event.Size = new System.Drawing.Size(104, 49);
            this.lblMonth_Event.TabIndex = 1;
            this.lblMonth_Event.Text = "JAN";
            // 
            // plEventDate
            // 
            this.plEventDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.plEventDate.Controls.Add(this.lblMonth_Event);
            this.plEventDate.Controls.Add(this.lblDay_Event);
            this.plEventDate.Location = new System.Drawing.Point(0, 0);
            this.plEventDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plEventDate.Name = "plEventDate";
            this.plEventDate.Size = new System.Drawing.Size(199, 132);
            this.plEventDate.TabIndex = 2;
            // 
            // plEventData
            // 
            this.plEventData.Controls.Add(this.uC_UnregisterButton1);
            this.plEventData.Controls.Add(this.btnJoinEvent);
            this.plEventData.Controls.Add(this.lblSpaceAvailableValue);
            this.plEventData.Controls.Add(this.lblSpaceAvailable);
            this.plEventData.Controls.Add(this.lblEventOwnerValue);
            this.plEventData.Controls.Add(this.lblEventOwner);
            this.plEventData.Controls.Add(this.lblEventHour);
            this.plEventData.Controls.Add(this.lblEventHourValue);
            this.plEventData.Controls.Add(this.plLine);
            this.plEventData.Controls.Add(this.lblSportsGround);
            this.plEventData.Location = new System.Drawing.Point(206, 0);
            this.plEventData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plEventData.Name = "plEventData";
            this.plEventData.Size = new System.Drawing.Size(919, 129);
            this.plEventData.TabIndex = 3;
            // 
            // uC_UnregisterButton1
            // 
            this.uC_UnregisterButton1.Eventid = 0;
            this.uC_UnregisterButton1.Location = new System.Drawing.Point(803, 32);
            this.uC_UnregisterButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uC_UnregisterButton1.Name = "uC_UnregisterButton1";
            this.uC_UnregisterButton1.Size = new System.Drawing.Size(55, 55);
            this.uC_UnregisterButton1.TabIndex = 9;
            this.uC_UnregisterButton1.Username = null;
            this.uC_UnregisterButton1.Visible = false;
            // 
            // btnJoinEvent
            // 
            this.btnJoinEvent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnJoinEvent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnJoinEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnJoinEvent.Image")));
            this.btnJoinEvent.Location = new System.Drawing.Point(729, 25);
            this.btnJoinEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnJoinEvent.Name = "btnJoinEvent";
            this.btnJoinEvent.Size = new System.Drawing.Size(89, 69);
            this.btnJoinEvent.TabIndex = 8;
            this.btnJoinEvent.UseVisualStyleBackColor = false;
            this.btnJoinEvent.Click += new System.EventHandler(this.btnJoinEvent_Click);
            // 
            // lblSpaceAvailableValue
            // 
            this.lblSpaceAvailableValue.AutoSize = true;
            this.lblSpaceAvailableValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceAvailableValue.Location = new System.Drawing.Point(654, 45);
            this.lblSpaceAvailableValue.Name = "lblSpaceAvailableValue";
            this.lblSpaceAvailableValue.Size = new System.Drawing.Size(62, 28);
            this.lblSpaceAvailableValue.TabIndex = 7;
            this.lblSpaceAvailableValue.Text = "8/10";
            // 
            // lblSpaceAvailable
            // 
            this.lblSpaceAvailable.AutoSize = true;
            this.lblSpaceAvailable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceAvailable.Location = new System.Drawing.Point(543, 45);
            this.lblSpaceAvailable.Name = "lblSpaceAvailable";
            this.lblSpaceAvailable.Size = new System.Drawing.Size(114, 28);
            this.lblSpaceAvailable.TabIndex = 6;
            this.lblSpaceAvailable.Text = "Lotação:";
            // 
            // lblEventOwnerValue
            // 
            this.lblEventOwnerValue.AutoSize = true;
            this.lblEventOwnerValue.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventOwnerValue.Location = new System.Drawing.Point(83, 92);
            this.lblEventOwnerValue.Name = "lblEventOwnerValue";
            this.lblEventOwnerValue.Size = new System.Drawing.Size(91, 21);
            this.lblEventOwnerValue.TabIndex = 5;
            this.lblEventOwnerValue.Text = "Rui Sousa";
            // 
            // lblEventOwner
            // 
            this.lblEventOwner.AutoSize = true;
            this.lblEventOwner.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventOwner.Location = new System.Drawing.Point(9, 92);
            this.lblEventOwner.Name = "lblEventOwner";
            this.lblEventOwner.Size = new System.Drawing.Size(73, 21);
            this.lblEventOwner.TabIndex = 4;
            this.lblEventOwner.Text = "Owner:";
            // 
            // lblEventHour
            // 
            this.lblEventHour.AutoSize = true;
            this.lblEventHour.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblEventHour.Location = new System.Drawing.Point(24, 62);
            this.lblEventHour.Name = "lblEventHour";
            this.lblEventHour.Size = new System.Drawing.Size(56, 21);
            this.lblEventHour.TabIndex = 3;
            this.lblEventHour.Text = "Hora:";
            // 
            // lblEventHourValue
            // 
            this.lblEventHourValue.AutoSize = true;
            this.lblEventHourValue.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventHourValue.Location = new System.Drawing.Point(81, 64);
            this.lblEventHourValue.Name = "lblEventHourValue";
            this.lblEventHourValue.Size = new System.Drawing.Size(42, 21);
            this.lblEventHourValue.TabIndex = 2;
            this.lblEventHourValue.Text = "19H";
            // 
            // plLine
            // 
            this.plLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.plLine.Location = new System.Drawing.Point(7, 35);
            this.plLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plLine.Name = "plLine";
            this.plLine.Size = new System.Drawing.Size(364, 6);
            this.plLine.TabIndex = 1;
            // 
            // lblSportsGround
            // 
            this.lblSportsGround.AutoSize = true;
            this.lblSportsGround.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportsGround.Location = new System.Drawing.Point(14, 9);
            this.lblSportsGround.Name = "lblSportsGround";
            this.lblSportsGround.Size = new System.Drawing.Size(385, 25);
            this.lblSportsGround.TabIndex = 0;
            this.lblSportsGround.Text = "Parque Desportivo de Água de Pena";
            // 
            // UC_EventModalityItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.plEventData);
            this.Controls.Add(this.plEventDate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_EventModalityItem";
            this.Size = new System.Drawing.Size(1128, 132);
            this.Load += new System.EventHandler(this.UC_EventModalityItem_Load);
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
        private System.Windows.Forms.Button btnCancel;
    }
}

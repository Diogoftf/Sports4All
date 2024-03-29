﻿namespace Sports4All
{
    partial class UC_NextEventsandReserveItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NextEventsandReserveItem));
            this.lblDay_Event = new System.Windows.Forms.Label();
            this.lblMonth_Event = new System.Windows.Forms.Label();
            this.plEventDate = new System.Windows.Forms.Panel();
            this.plEventData = new System.Windows.Forms.Panel();
            this.uC_UnregisterButton1 = new Sports4All.UC_UnregisterButton();
            this.lbEventID = new System.Windows.Forms.Label();
            this.lbEvent = new System.Windows.Forms.Label();
            this.lblSportsGround = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSpaceAvailableValue = new System.Windows.Forms.Label();
            this.lblSpaceAvailable = new System.Windows.Forms.Label();
            this.lblEventOwnerValue = new System.Windows.Forms.Label();
            this.lblEventOwner = new System.Windows.Forms.Label();
            this.lblEventHour = new System.Windows.Forms.Label();
            this.lblEventHourValue = new System.Windows.Forms.Label();
            this.plLine = new System.Windows.Forms.Panel();
            this.lblModalityName = new System.Windows.Forms.Label();
            this.btnJoinEvent = new System.Windows.Forms.Button();
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
            // 
            // plEventData
            // 
            this.plEventData.Controls.Add(this.btnJoinEvent);
            this.plEventData.Controls.Add(this.uC_UnregisterButton1);
            this.plEventData.Controls.Add(this.lbEventID);
            this.plEventData.Controls.Add(this.lbEvent);
            this.plEventData.Controls.Add(this.lblSportsGround);
            this.plEventData.Controls.Add(this.btnCancel);
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
            // 
            // uC_UnregisterButton1
            // 
            this.uC_UnregisterButton1.Eventid = 0;
            this.uC_UnregisterButton1.Location = new System.Drawing.Point(681, 30);
            this.uC_UnregisterButton1.Name = "uC_UnregisterButton1";
            this.uC_UnregisterButton1.Size = new System.Drawing.Size(53, 36);
            this.uC_UnregisterButton1.TabIndex = 16;
            this.uC_UnregisterButton1.Username = null;
            this.uC_UnregisterButton1.Visible = false;
            // 
            // lbEventID
            // 
            this.lbEventID.AutoSize = true;
            this.lbEventID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventID.Location = new System.Drawing.Point(83, 5);
            this.lbEventID.Name = "lbEventID";
            this.lbEventID.Size = new System.Drawing.Size(77, 23);
            this.lbEventID.TabIndex = 15;
            this.lbEventID.Text = "#23342";
            // 
            // lbEvent
            // 
            this.lbEvent.AutoSize = true;
            this.lbEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvent.Location = new System.Drawing.Point(8, 4);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(81, 23);
            this.lbEvent.TabIndex = 14;
            this.lbEvent.Text = "Evento:";
            // 
            // lblSportsGround
            // 
            this.lblSportsGround.AutoSize = true;
            this.lblSportsGround.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportsGround.Location = new System.Drawing.Point(231, 43);
            this.lblSportsGround.Name = "lblSportsGround";
            this.lblSportsGround.Size = new System.Drawing.Size(310, 19);
            this.lblSportsGround.TabIndex = 9;
            this.lblSportsGround.Text = "Parque Desportivo de Água de Pena";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(691, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(33, 38);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btn_CancelEvent);
            // 
            // lblSpaceAvailableValue
            // 
            this.lblSpaceAvailableValue.AutoSize = true;
            this.lblSpaceAvailableValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceAvailableValue.Location = new System.Drawing.Point(306, 4);
            this.lblSpaceAvailableValue.Name = "lblSpaceAvailableValue";
            this.lblSpaceAvailableValue.Size = new System.Drawing.Size(52, 23);
            this.lblSpaceAvailableValue.TabIndex = 7;
            this.lblSpaceAvailableValue.Text = "2/10";
            // 
            // lblSpaceAvailable
            // 
            this.lblSpaceAvailable.AutoSize = true;
            this.lblSpaceAvailable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceAvailable.Location = new System.Drawing.Point(204, 4);
            this.lblSpaceAvailable.Name = "lblSpaceAvailable";
            this.lblSpaceAvailable.Size = new System.Drawing.Size(96, 23);
            this.lblSpaceAvailable.TabIndex = 6;
            this.lblSpaceAvailable.Text = "Lotação:";
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
            // 
            // plLine
            // 
            this.plLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.plLine.Location = new System.Drawing.Point(6, 35);
            this.plLine.Name = "plLine";
            this.plLine.Size = new System.Drawing.Size(548, 5);
            this.plLine.TabIndex = 1;
            // 
            // lblModalityName
            // 
            this.lblModalityName.AutoSize = true;
            this.lblModalityName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblModalityName.Location = new System.Drawing.Point(334, 71);
            this.lblModalityName.Name = "lblModalityName";
            this.lblModalityName.Size = new System.Drawing.Size(82, 23);
            this.lblModalityName.TabIndex = 0;
            this.lblModalityName.Text = "Futebol";
            // 
            // btnJoinEvent
            // 
            this.btnJoinEvent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnJoinEvent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnJoinEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnJoinEvent.Image")));
            this.btnJoinEvent.Location = new System.Drawing.Point(681, 24);
            this.btnJoinEvent.Name = "btnJoinEvent";
            this.btnJoinEvent.Size = new System.Drawing.Size(79, 55);
            this.btnJoinEvent.TabIndex = 17;
            this.btnJoinEvent.UseVisualStyleBackColor = false;
            this.btnJoinEvent.Click += new System.EventHandler(this.btnJoinEvent_Click);
            // 
            // UC_NextEventsandReserveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.plEventData);
            this.Controls.Add(this.plEventDate);
            this.Name = "UC_NextEventsandReserveItem";
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSpaceAvailableValue;
        private System.Windows.Forms.Label lblSportsGround;
        private System.Windows.Forms.Label lbEventID;
        private System.Windows.Forms.Label lbEvent;
        private UC_UnregisterButton uC_UnregisterButton1;
        private System.Windows.Forms.Button btnJoinEvent;
    }
}

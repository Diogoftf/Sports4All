namespace Sports4All
{
    partial class UC_EventMyEventsItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EventMyEventsItem));
            this.plEventEvaluation = new System.Windows.Forms.Panel();
            this.lblRemainingTimeEvaluation = new System.Windows.Forms.Label();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.plEventData = new System.Windows.Forms.Panel();
            this.pbModality = new System.Windows.Forms.PictureBox();
            this.lbEventID = new System.Windows.Forms.Label();
            this.lbEvent = new System.Windows.Forms.Label();
            this.lblModalityName = new System.Windows.Forms.Label();
            this.lblEventOwnerValue = new System.Windows.Forms.Label();
            this.lblEventOwner = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblstart_Hour = new System.Windows.Forms.Label();
            this.lblSportsGround = new System.Windows.Forms.Label();
            this.plEventEvaluation.SuspendLayout();
            this.plEventData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModality)).BeginInit();
            this.SuspendLayout();
            // 
            // plEventEvaluation
            // 
            this.plEventEvaluation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.plEventEvaluation.Controls.Add(this.lblRemainingTimeEvaluation);
            this.plEventEvaluation.Controls.Add(this.btnEvaluate);
            this.plEventEvaluation.Location = new System.Drawing.Point(0, 0);
            this.plEventEvaluation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plEventEvaluation.Name = "plEventEvaluation";
            this.plEventEvaluation.Size = new System.Drawing.Size(208, 132);
            this.plEventEvaluation.TabIndex = 2;
            // 
            // lblRemainingTimeEvaluation
            // 
            this.lblRemainingTimeEvaluation.AutoSize = true;
            this.lblRemainingTimeEvaluation.Location = new System.Drawing.Point(3, 104);
            this.lblRemainingTimeEvaluation.Name = "lblRemainingTimeEvaluation";
            this.lblRemainingTimeEvaluation.Size = new System.Drawing.Size(198, 20);
            this.lblRemainingTimeEvaluation.TabIndex = 1;
            this.lblRemainingTimeEvaluation.Text = "Restam 5 dias para Avaliar";
            this.lblRemainingTimeEvaluation.Click += new System.EventHandler(this.lbRemainingTimeEvaluation_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnEvaluate.Location = new System.Drawing.Point(7, 36);
            this.btnEvaluate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(197, 59);
            this.btnEvaluate.TabIndex = 0;
            this.btnEvaluate.Text = "Avaliar";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // plEventData
            // 
            this.plEventData.Controls.Add(this.pbModality);
            this.plEventData.Controls.Add(this.lbEventID);
            this.plEventData.Controls.Add(this.lbEvent);
            this.plEventData.Controls.Add(this.lblModalityName);
            this.plEventData.Controls.Add(this.lblEventOwnerValue);
            this.plEventData.Controls.Add(this.lblEventOwner);
            this.plEventData.Controls.Add(this.lblDate);
            this.plEventData.Controls.Add(this.lblstart_Hour);
            this.plEventData.Controls.Add(this.lblSportsGround);
            this.plEventData.Location = new System.Drawing.Point(210, 4);
            this.plEventData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plEventData.Name = "plEventData";
            this.plEventData.Size = new System.Drawing.Size(942, 129);
            this.plEventData.TabIndex = 3;
            this.plEventData.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pbModality
            // 
            this.pbModality.Image = ((System.Drawing.Image)(resources.GetObject("pbModality.Image")));
            this.pbModality.Location = new System.Drawing.Point(776, 39);
            this.pbModality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbModality.Name = "pbModality";
            this.pbModality.Size = new System.Drawing.Size(65, 72);
            this.pbModality.TabIndex = 14;
            this.pbModality.TabStop = false;
            // 
            // lbEventID
            // 
            this.lbEventID.AutoSize = true;
            this.lbEventID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventID.Location = new System.Drawing.Point(88, 9);
            this.lbEventID.Name = "lbEventID";
            this.lbEventID.Size = new System.Drawing.Size(64, 19);
            this.lbEventID.TabIndex = 13;
            this.lbEventID.Text = "#23342";
            // 
            // lbEvent
            // 
            this.lbEvent.AutoSize = true;
            this.lbEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvent.Location = new System.Drawing.Point(3, 8);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(64, 19);
            this.lbEvent.TabIndex = 11;
            this.lbEvent.Text = "Evento:";
            // 
            // lblModalityName
            // 
            this.lblModalityName.AutoSize = true;
            this.lblModalityName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblModalityName.Location = new System.Drawing.Point(759, 4);
            this.lblModalityName.Name = "lblModalityName";
            this.lblModalityName.Size = new System.Drawing.Size(62, 18);
            this.lblModalityName.TabIndex = 10;
            this.lblModalityName.Text = "Futebol";
            // 
            // lblEventOwnerValue
            // 
            this.lblEventOwnerValue.AutoSize = true;
            this.lblEventOwnerValue.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventOwnerValue.Location = new System.Drawing.Point(83, 92);
            this.lblEventOwnerValue.Name = "lblEventOwnerValue";
            this.lblEventOwnerValue.Size = new System.Drawing.Size(63, 17);
            this.lblEventOwnerValue.TabIndex = 5;
            this.lblEventOwnerValue.Text = "Rui Sousa";
            // 
            // lblEventOwner
            // 
            this.lblEventOwner.AutoSize = true;
            this.lblEventOwner.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventOwner.Location = new System.Drawing.Point(9, 92);
            this.lblEventOwner.Name = "lblEventOwner";
            this.lblEventOwner.Size = new System.Drawing.Size(50, 17);
            this.lblEventOwner.TabIndex = 4;
            this.lblEventOwner.Text = "Owner:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblDate.Location = new System.Drawing.Point(19, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Data:";
            // 
            // lblstart_Hour
            // 
            this.lblstart_Hour.AutoSize = true;
            this.lblstart_Hour.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstart_Hour.Location = new System.Drawing.Point(83, 60);
            this.lblstart_Hour.Name = "lblstart_Hour";
            this.lblstart_Hour.Size = new System.Drawing.Size(109, 17);
            this.lblstart_Hour.TabIndex = 2;
            this.lblstart_Hour.Text = "22/05/2020 | 19h";
            // 
            // lblSportsGround
            // 
            this.lblSportsGround.AutoSize = true;
            this.lblSportsGround.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblSportsGround.Location = new System.Drawing.Point(312, 51);
            this.lblSportsGround.Name = "lblSportsGround";
            this.lblSportsGround.Size = new System.Drawing.Size(275, 18);
            this.lblSportsGround.TabIndex = 0;
            this.lblSportsGround.Text = "Parque Desportivo de Água de Pena";
            // 
            // UC_EventMyEventsItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.plEventData);
            this.Controls.Add(this.plEventEvaluation);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_EventMyEventsItem";
            this.Size = new System.Drawing.Size(1156, 135);
            this.plEventEvaluation.ResumeLayout(false);
            this.plEventEvaluation.PerformLayout();
            this.plEventData.ResumeLayout(false);
            this.plEventData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plEventEvaluation;
        private System.Windows.Forms.Panel plEventData;
        private System.Windows.Forms.Label lblSportsGround;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblstart_Hour;
        private System.Windows.Forms.Label lblEventOwnerValue;
        private System.Windows.Forms.Label lblEventOwner;
        private System.Windows.Forms.Label lblModalityName;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Label lblRemainingTimeEvaluation;
        private System.Windows.Forms.Label lbEvent;
        private System.Windows.Forms.PictureBox pbModality;
        private System.Windows.Forms.Label lbEventID;
    }
}

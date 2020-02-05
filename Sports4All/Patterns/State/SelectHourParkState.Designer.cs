namespace Sports4All.Patterns.State
{
    partial class SelectHourParkState
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
            this.nextScreenButton = new Sports4All.View.UserControls_Items.NextScreenButton();
            this.previousScreenButton = new Sports4All.View.UserControls_Items.PreviousScreenButton();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpEventStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEventStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEventEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEventEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblPark = new System.Windows.Forms.Label();
            this.cbSelectPark = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nextScreenButton
            // 
            this.nextScreenButton.Location = new System.Drawing.Point(1024, 559);
            this.nextScreenButton.Name = "nextScreenButton";
            this.nextScreenButton.ReserveNoviceForm = null;
            this.nextScreenButton.Size = new System.Drawing.Size(63, 63);
            this.nextScreenButton.TabIndex = 6;
            // 
            // previousScreenButton
            // 
            this.previousScreenButton.Location = new System.Drawing.Point(3, 556);
            this.previousScreenButton.Name = "previousScreenButton";
            this.previousScreenButton.ReserveNoviceForm = null;
            this.previousScreenButton.Size = new System.Drawing.Size(63, 63);
            this.previousScreenButton.TabIndex = 5;
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblStart.Location = new System.Drawing.Point(3, 99);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(1084, 46);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Selecione a data e hora de início:";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnd
            // 
            this.lblEnd.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblEnd.Location = new System.Drawing.Point(3, 241);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(1084, 46);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "Selecione a data e hora de fim:";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEventStartDate
            // 
            this.dtpEventStartDate.CalendarFont = new System.Drawing.Font("Century Gothic", 13F);
            this.dtpEventStartDate.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.dtpEventStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventStartDate.Location = new System.Drawing.Point(379, 153);
            this.dtpEventStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEventStartDate.Name = "dtpEventStartDate";
            this.dtpEventStartDate.Size = new System.Drawing.Size(176, 34);
            this.dtpEventStartDate.TabIndex = 14;
            // 
            // dtpEventStartTime
            // 
            this.dtpEventStartTime.CalendarFont = new System.Drawing.Font("Century Gothic", 13F);
            this.dtpEventStartTime.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.dtpEventStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEventStartTime.Location = new System.Drawing.Point(575, 153);
            this.dtpEventStartTime.Margin = new System.Windows.Forms.Padding(3, 7, 3, 2);
            this.dtpEventStartTime.Name = "dtpEventStartTime";
            this.dtpEventStartTime.Size = new System.Drawing.Size(135, 34);
            this.dtpEventStartTime.TabIndex = 15;
            // 
            // dtpEventEndTime
            // 
            this.dtpEventEndTime.CalendarFont = new System.Drawing.Font("Century Gothic", 13F);
            this.dtpEventEndTime.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.dtpEventEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEventEndTime.Location = new System.Drawing.Point(575, 297);
            this.dtpEventEndTime.Margin = new System.Windows.Forms.Padding(3, 7, 3, 2);
            this.dtpEventEndTime.Name = "dtpEventEndTime";
            this.dtpEventEndTime.Size = new System.Drawing.Size(135, 34);
            this.dtpEventEndTime.TabIndex = 17;
            // 
            // dtpEventEndDate
            // 
            this.dtpEventEndDate.CalendarFont = new System.Drawing.Font("Century Gothic", 13F);
            this.dtpEventEndDate.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.dtpEventEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventEndDate.Location = new System.Drawing.Point(379, 297);
            this.dtpEventEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEventEndDate.Name = "dtpEventEndDate";
            this.dtpEventEndDate.Size = new System.Drawing.Size(176, 34);
            this.dtpEventEndDate.TabIndex = 16;
            // 
            // lblPark
            // 
            this.lblPark.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblPark.Location = new System.Drawing.Point(3, 378);
            this.lblPark.Name = "lblPark";
            this.lblPark.Size = new System.Drawing.Size(1084, 46);
            this.lblPark.TabIndex = 18;
            this.lblPark.Text = "Selecione o parque desportivo:";
            this.lblPark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSelectPark
            // 
            this.cbSelectPark.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.cbSelectPark.FormattingEnabled = true;
            this.cbSelectPark.Location = new System.Drawing.Point(274, 430);
            this.cbSelectPark.Name = "cbSelectPark";
            this.cbSelectPark.Size = new System.Drawing.Size(541, 33);
            this.cbSelectPark.TabIndex = 19;
            // 
            // SelectHourParkState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.cbSelectPark);
            this.Controls.Add(this.lblPark);
            this.Controls.Add(this.dtpEventEndTime);
            this.Controls.Add(this.dtpEventEndDate);
            this.Controls.Add(this.dtpEventStartTime);
            this.Controls.Add(this.dtpEventStartDate);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.nextScreenButton);
            this.Controls.Add(this.previousScreenButton);
            this.Name = "SelectHourParkState";
            this.Size = new System.Drawing.Size(1090, 622);
            this.Load += new System.EventHandler(this.SelectHourParkState_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private View.UserControls_Items.NextScreenButton nextScreenButton;
        private View.UserControls_Items.PreviousScreenButton previousScreenButton;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEventStartDate;
        private System.Windows.Forms.DateTimePicker dtpEventStartTime;
        private System.Windows.Forms.DateTimePicker dtpEventEndTime;
        private System.Windows.Forms.DateTimePicker dtpEventEndDate;
        private System.Windows.Forms.Label lblPark;
        private System.Windows.Forms.ComboBox cbSelectPark;
    }
}

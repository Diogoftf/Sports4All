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
            this.lblStart = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpEventStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEventStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEventEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblPark = new System.Windows.Forms.Label();
            this.cbSelectPark = new System.Windows.Forms.ComboBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.nextScreenButton = new Sports4All.View.UserControls_Items.NextScreenButton();
            this.previousScreenButton = new Sports4All.View.UserControls_Items.PreviousScreenButton();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblStart.Location = new System.Drawing.Point(3, 99);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(1084, 46);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Selecione a data:";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartTime
            // 
            this.lblStartTime.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblStartTime.Location = new System.Drawing.Point(394, 238);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(135, 46);
            this.lblStartTime.TabIndex = 9;
            this.lblStartTime.Text = "Início";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEventStartDate
            // 
            this.dtpEventStartDate.CalendarFont = new System.Drawing.Font("Century Gothic", 13F);
            this.dtpEventStartDate.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.dtpEventStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventStartDate.Location = new System.Drawing.Point(454, 150);
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
            this.dtpEventStartTime.Location = new System.Drawing.Point(394, 290);
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
            this.dtpEventEndTime.Location = new System.Drawing.Point(566, 290);
            this.dtpEventEndTime.Margin = new System.Windows.Forms.Padding(3, 7, 3, 2);
            this.dtpEventEndTime.Name = "dtpEventEndTime";
            this.dtpEventEndTime.Size = new System.Drawing.Size(135, 34);
            this.dtpEventEndTime.TabIndex = 17;
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
            this.cbSelectPark.Location = new System.Drawing.Point(297, 431);
            this.cbSelectPark.Name = "cbSelectPark";
            this.cbSelectPark.Size = new System.Drawing.Size(511, 33);
            this.cbSelectPark.TabIndex = 19;
            this.cbSelectPark.SelectedIndexChanged += new System.EventHandler(this.cbSelectPark_SelectedIndexChanged);
            // 
            // lblEndTime
            // 
            this.lblEndTime.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblEndTime.Location = new System.Drawing.Point(566, 238);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(135, 46);
            this.lblEndTime.TabIndex = 20;
            this.lblEndTime.Text = "Fim";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // SelectHourParkState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.cbSelectPark);
            this.Controls.Add(this.lblPark);
            this.Controls.Add(this.dtpEventEndTime);
            this.Controls.Add(this.dtpEventStartTime);
            this.Controls.Add(this.dtpEventStartDate);
            this.Controls.Add(this.lblStartTime);
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
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpEventStartDate;
        private System.Windows.Forms.DateTimePicker dtpEventStartTime;
        private System.Windows.Forms.DateTimePicker dtpEventEndTime;
        private System.Windows.Forms.Label lblPark;
        private System.Windows.Forms.ComboBox cbSelectPark;
        private System.Windows.Forms.Label lblEndTime;
    }
}

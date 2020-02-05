namespace Sports4All.Patterns.State
{
    partial class EventNameState
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
            this.lblEventName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.nextScreenButton = new Sports4All.View.UserControls_Items.NextScreenButton();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblEventName.Location = new System.Drawing.Point(3, 215);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(1084, 46);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Indique o nome do evento a criar:";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.textBoxName.Location = new System.Drawing.Point(306, 268);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(480, 34);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nextScreenButton
            // 
            this.nextScreenButton.Location = new System.Drawing.Point(1024, 556);
            this.nextScreenButton.Name = "nextScreenButton";
            this.nextScreenButton.ReserveNoviceForm = null;
            this.nextScreenButton.Size = new System.Drawing.Size(63, 63);
            this.nextScreenButton.TabIndex = 2;
            // 
            // EventNameState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.nextScreenButton);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblEventName);
            this.Name = "EventNameState";
            this.Size = new System.Drawing.Size(1090, 622);
            this.Load += new System.EventHandler(this.EventNameState_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox textBoxName;
        private View.UserControls_Items.NextScreenButton nextScreenButton;
    }
}

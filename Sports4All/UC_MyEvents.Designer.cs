namespace Sports4All
{
    partial class UC_MyEvents
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFinishedEvents = new System.Windows.Forms.Button();
            this.btnNextEvents = new System.Windows.Forms.Button();
            this.flpListMyEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnFinishedEvents);
            this.flowLayoutPanel1.Controls.Add(this.btnNextEvents);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(295, 56);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 82);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnFinishedEvents
            // 
            this.btnFinishedEvents.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnFinishedEvents.Location = new System.Drawing.Point(3, 4);
            this.btnFinishedEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinishedEvents.Name = "btnFinishedEvents";
            this.btnFinishedEvents.Size = new System.Drawing.Size(271, 79);
            this.btnFinishedEvents.TabIndex = 1;
            this.btnFinishedEvents.Text = "Eventos Terminados";
            this.btnFinishedEvents.UseVisualStyleBackColor = true;
            this.btnFinishedEvents.Click += new System.EventHandler(this.button_ProximosEventos_Click);
            // 
            // btnNextEvents
            // 
            this.btnNextEvents.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnNextEvents.Location = new System.Drawing.Point(280, 4);
            this.btnNextEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextEvents.Name = "btnNextEvents";
            this.btnNextEvents.Size = new System.Drawing.Size(271, 79);
            this.btnNextEvents.TabIndex = 2;
            this.btnNextEvents.Text = "Próximos Eventos";
            this.btnNextEvents.UseVisualStyleBackColor = true;
            // 
            // flpListMyEvents
            // 
            this.flpListMyEvents.AutoScroll = true;
            this.flpListMyEvents.Location = new System.Drawing.Point(3, 146);
            this.flpListMyEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpListMyEvents.Name = "flpListMyEvents";
            this.flpListMyEvents.Size = new System.Drawing.Size(1156, 662);
            this.flpListMyEvents.TabIndex = 10;
            this.flpListMyEvents.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // UC_MyEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpListMyEvents);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_MyEvents";
            this.Size = new System.Drawing.Size(SizeProperties.UCWidth, SizeProperties.UCHeight);
            this.Load += new System.EventHandler(this.Minhas_Partidas_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFinishedEvents;
        private System.Windows.Forms.FlowLayoutPanel flpListMyEvents;
        private System.Windows.Forms.Button btnNextEvents;
    }
}

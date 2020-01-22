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
            this.btnMinhasReservas = new System.Windows.Forms.Button();
            this.flpListMyEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnFinishedEvents);
            this.flowLayoutPanel1.Controls.Add(this.btnNextEvents);
            this.flowLayoutPanel1.Controls.Add(this.btnMinhasReservas);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(157, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 66);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnFinishedEvents
            // 
            this.btnFinishedEvents.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnFinishedEvents.Location = new System.Drawing.Point(3, 3);
            this.btnFinishedEvents.Name = "btnFinishedEvents";
            this.btnFinishedEvents.Size = new System.Drawing.Size(241, 63);
            this.btnFinishedEvents.TabIndex = 1;
            this.btnFinishedEvents.Text = "Eventos Terminados";
            this.btnFinishedEvents.UseVisualStyleBackColor = true;
            this.btnFinishedEvents.Click += new System.EventHandler(this.btnFinishedEvents_Click);
            // 
            // btnNextEvents
            // 
            this.btnNextEvents.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnNextEvents.Location = new System.Drawing.Point(250, 3);
            this.btnNextEvents.Name = "btnNextEvents";
            this.btnNextEvents.Size = new System.Drawing.Size(241, 63);
            this.btnNextEvents.TabIndex = 2;
            this.btnNextEvents.Text = "Próximos Eventos";
            this.btnNextEvents.UseVisualStyleBackColor = true;
            this.btnNextEvents.Click += new System.EventHandler(this.btnNextEvents_Click);
            // 
            // btnMinhasReservas
            // 
            this.btnMinhasReservas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMinhasReservas.Location = new System.Drawing.Point(497, 3);
            this.btnMinhasReservas.Name = "btnMinhasReservas";
            this.btnMinhasReservas.Size = new System.Drawing.Size(241, 63);
            this.btnMinhasReservas.TabIndex = 3;
            this.btnMinhasReservas.Text = "Minhas Reservas";
            this.btnMinhasReservas.UseVisualStyleBackColor = true;
            this.btnMinhasReservas.Click += new System.EventHandler(this.btnMinhasReservas_Click);
            // 
            // flpListMyEvents
            // 
            this.flpListMyEvents.AutoScroll = true;
            this.flpListMyEvents.Location = new System.Drawing.Point(3, 117);
            this.flpListMyEvents.Name = "flpListMyEvents";
            this.flpListMyEvents.Size = new System.Drawing.Size(1028, 530);
            this.flpListMyEvents.TabIndex = 10;
            this.flpListMyEvents.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // UC_MyEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpListMyEvents);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_MyEvents";
            this.Size = new System.Drawing.Size(1077, 622);
            this.Load += new System.EventHandler(this.UC_MyEvents_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFinishedEvents;
        private System.Windows.Forms.FlowLayoutPanel flpListMyEvents;
        private System.Windows.Forms.Button btnNextEvents;
        private System.Windows.Forms.Button btnMinhasReservas;
    }
}

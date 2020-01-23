namespace Sports4All
{
    partial class UC_EventEvaluation
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
            this.gpEventEvaluation = new System.Windows.Forms.GroupBox();
            this.plSportsgroundEvaluation = new System.Windows.Forms.Panel();
            this.UC_SportsgroundEvItem1 = new Sports4All.UC_SportsgroundEvItem();
            this.flpPlayersEvaluation = new System.Windows.Forms.FlowLayoutPanel();
            this.cbtnConfirmar = new Sports4All.CircularButton();
            this.gpEventEvaluation.SuspendLayout();
            this.plSportsgroundEvaluation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpEventEvaluation
            // 
            this.gpEventEvaluation.Controls.Add(this.plSportsgroundEvaluation);
            this.gpEventEvaluation.Controls.Add(this.flpPlayersEvaluation);
            this.gpEventEvaluation.Controls.Add(this.cbtnConfirmar);
            this.gpEventEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpEventEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpEventEvaluation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEventEvaluation.Location = new System.Drawing.Point(0, 0);
            this.gpEventEvaluation.Name = "gpEventEvaluation";
            this.gpEventEvaluation.Size = new System.Drawing.Size(1089, 622);
            this.gpEventEvaluation.TabIndex = 0;
            this.gpEventEvaluation.TabStop = false;
            this.gpEventEvaluation.Text = "Event Evaluation #5431";
            // 
            // plSportsgroundEvaluation
            // 
            this.plSportsgroundEvaluation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSportsgroundEvaluation.Controls.Add(this.UC_SportsgroundEvItem1);
            this.plSportsgroundEvaluation.Location = new System.Drawing.Point(6, 31);
            this.plSportsgroundEvaluation.Name = "plSportsgroundEvaluation";
            this.plSportsgroundEvaluation.Size = new System.Drawing.Size(1031, 224);
            this.plSportsgroundEvaluation.TabIndex = 4;
            // 
            // UC_SportsgroundEvItem1
            // 
            this.UC_SportsgroundEvItem1.Location = new System.Drawing.Point(4, 1);
            this.UC_SportsgroundEvItem1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UC_SportsgroundEvItem1.Name = "UC_SportsgroundEvItem1";
            this.UC_SportsgroundEvItem1.Size = new System.Drawing.Size(1021, 221);
            this.UC_SportsgroundEvItem1.TabIndex = 0;
            // 
            // flpPlayersEvaluation
            // 
            this.flpPlayersEvaluation.AutoScroll = true;
            this.flpPlayersEvaluation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpPlayersEvaluation.Location = new System.Drawing.Point(6, 261);
            this.flpPlayersEvaluation.Name = "flpPlayersEvaluation";
            this.flpPlayersEvaluation.Size = new System.Drawing.Size(1031, 271);
            this.flpPlayersEvaluation.TabIndex = 3;
            // 
            // cbtnConfirmar
            // 
            this.cbtnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbtnConfirmar.BackColor = System.Drawing.Color.LightGray;
            this.cbtnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnConfirmar.FlatAppearance.BorderSize = 0;
            this.cbtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnConfirmar.Location = new System.Drawing.Point(435, 538);
            this.cbtnConfirmar.Name = "cbtnConfirmar";
            this.cbtnConfirmar.Size = new System.Drawing.Size(200, 78);
            this.cbtnConfirmar.TabIndex = 2;
            this.cbtnConfirmar.Text = "Confirmar!";
            this.cbtnConfirmar.UseVisualStyleBackColor = false;
            this.cbtnConfirmar.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // UC_EventEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpEventEvaluation);
            this.Name = "UC_EventEvaluation";
            this.Size = new System.Drawing.Size(1089, 622);
            this.Load += new System.EventHandler(this.UCEventEvaluation_Load);
            this.gpEventEvaluation.ResumeLayout(false);
            this.plSportsgroundEvaluation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEventEvaluation;
        private CircularButton cbtnConfirmar;
        private System.Windows.Forms.FlowLayoutPanel flpPlayersEvaluation;
        private System.Windows.Forms.Panel plSportsgroundEvaluation;
        private UC_SportsgroundEvItem UC_SportsgroundEvItem1;
    }
}

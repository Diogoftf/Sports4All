namespace Sports4All.UserControls_Screens
{
    partial class UC_Subscriptions
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
            this.flpSubscriptions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSports = new System.Windows.Forms.Button();
            this.btnSportsGround = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpSubscriptions
            // 
            this.flpSubscriptions.AutoScroll = true;
            this.flpSubscriptions.Location = new System.Drawing.Point(15, 69);
            this.flpSubscriptions.Name = "flpSubscriptions";
            this.flpSubscriptions.Size = new System.Drawing.Size(1160, 629);
            this.flpSubscriptions.TabIndex = 5;
            // 
            // btnSports
            // 
            this.btnSports.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSports.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSports.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSports.Location = new System.Drawing.Point(15, 11);
            this.btnSports.Name = "btnSports";
            this.btnSports.Size = new System.Drawing.Size(117, 43);
            this.btnSports.TabIndex = 6;
            this.btnSports.Text = "Desportos";
            this.btnSports.UseVisualStyleBackColor = false;
            this.btnSports.Click += new System.EventHandler(this.btnSports_Click);
            // 
            // btnSportsGround
            // 
            this.btnSportsGround.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSportsGround.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSportsGround.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSportsGround.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSportsGround.Location = new System.Drawing.Point(1058, 11);
            this.btnSportsGround.Name = "btnSportsGround";
            this.btnSportsGround.Size = new System.Drawing.Size(117, 43);
            this.btnSportsGround.TabIndex = 8;
            this.btnSportsGround.Text = "Recintos";
            this.btnSportsGround.UseVisualStyleBackColor = false;
            this.btnSportsGround.Click += new System.EventHandler(this.btnSportsGround_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFriends.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFriends.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriends.Location = new System.Drawing.Point(523, 11);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(117, 43);
            this.btnFriends.TabIndex = 9;
            this.btnFriends.Text = "Amigos";
            this.btnFriends.UseVisualStyleBackColor = false;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // UC_Subscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFriends);
            this.Controls.Add(this.btnSportsGround);
            this.Controls.Add(this.btnSports);
            this.Controls.Add(this.flpSubscriptions);
            this.Name = "UC_Subscriptions";
            this.Size = new System.Drawing.Size(SizeProperties.UCWidth, SizeProperties.UCHeight);
            this.Load += new System.EventHandler(this.UC_Subscriptions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSubscriptions;
        private System.Windows.Forms.Button btnSports;
        private System.Windows.Forms.Button btnSportsGround;
        private System.Windows.Forms.Button btnFriends;
    }
}

namespace Sports4All.Patterns.State
{
    partial class DefineUsersState
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
            this.lblMaxPlayers = new System.Windows.Forms.Label();
            this.cbPlayersNumber = new System.Windows.Forms.ComboBox();
            this.cbMaxPlayersAge = new System.Windows.Forms.ComboBox();
            this.lblMinAge = new System.Windows.Forms.Label();
            this.cbMinPlayersAge = new System.Windows.Forms.ComboBox();
            this.lblMaxAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextScreenButton
            // 
            this.nextScreenButton.Location = new System.Drawing.Point(1024, 556);
            this.nextScreenButton.Name = "nextScreenButton";
            this.nextScreenButton.ReserveNoviceForm = null;
            this.nextScreenButton.Size = new System.Drawing.Size(63, 63);
            this.nextScreenButton.TabIndex = 12;
            // 
            // previousScreenButton
            // 
            this.previousScreenButton.Location = new System.Drawing.Point(3, 556);
            this.previousScreenButton.Name = "previousScreenButton";
            this.previousScreenButton.ReserveNoviceForm = null;
            this.previousScreenButton.Size = new System.Drawing.Size(63, 63);
            this.previousScreenButton.TabIndex = 11;
            // 
            // lblMaxPlayers
            // 
            this.lblMaxPlayers.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblMaxPlayers.Location = new System.Drawing.Point(3, 73);
            this.lblMaxPlayers.Name = "lblMaxPlayers";
            this.lblMaxPlayers.Size = new System.Drawing.Size(1084, 46);
            this.lblMaxPlayers.TabIndex = 13;
            this.lblMaxPlayers.Text = "Quantidade (máxima) de jogadores:";
            this.lblMaxPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPlayersNumber
            // 
            this.cbPlayersNumber.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.cbPlayersNumber.FormattingEnabled = true;
            this.cbPlayersNumber.Location = new System.Drawing.Point(493, 132);
            this.cbPlayersNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPlayersNumber.Name = "cbPlayersNumber";
            this.cbPlayersNumber.Size = new System.Drawing.Size(96, 33);
            this.cbPlayersNumber.TabIndex = 14;
            this.cbPlayersNumber.SelectionChangeCommitted += new System.EventHandler(this.cbPlayersNumber_SelectionChangeCommitted);
            // 
            // cbMaxPlayersAge
            // 
            this.cbMaxPlayersAge.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.cbMaxPlayersAge.FormattingEnabled = true;
            this.cbMaxPlayersAge.Location = new System.Drawing.Point(493, 279);
            this.cbMaxPlayersAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaxPlayersAge.Name = "cbMaxPlayersAge";
            this.cbMaxPlayersAge.Size = new System.Drawing.Size(96, 33);
            this.cbMaxPlayersAge.TabIndex = 16;
            this.cbMaxPlayersAge.SelectedIndexChanged += new System.EventHandler(this.cbMaxPlayersAge_SelectedIndexChanged);
            // 
            // lblMinAge
            // 
            this.lblMinAge.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblMinAge.Location = new System.Drawing.Point(-2, 222);
            this.lblMinAge.Name = "lblMinAge";
            this.lblMinAge.Size = new System.Drawing.Size(1084, 46);
            this.lblMinAge.TabIndex = 15;
            this.lblMinAge.Text = "Idade mínima dos jogadores:";
            this.lblMinAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMinPlayersAge
            // 
            this.cbMinPlayersAge.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.cbMinPlayersAge.FormattingEnabled = true;
            this.cbMinPlayersAge.Location = new System.Drawing.Point(493, 423);
            this.cbMinPlayersAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMinPlayersAge.Name = "cbMinPlayersAge";
            this.cbMinPlayersAge.Size = new System.Drawing.Size(96, 33);
            this.cbMinPlayersAge.TabIndex = 18;
            this.cbMinPlayersAge.SelectedIndexChanged += new System.EventHandler(this.cbMinPlayersAge_SelectedIndexChanged);
            // 
            // lblMaxAge
            // 
            this.lblMaxAge.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblMaxAge.Location = new System.Drawing.Point(3, 362);
            this.lblMaxAge.Name = "lblMaxAge";
            this.lblMaxAge.Size = new System.Drawing.Size(1084, 46);
            this.lblMaxAge.TabIndex = 17;
            this.lblMaxAge.Text = "Idade máxima dos jogadores:";
            this.lblMaxAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DefineUsersState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.cbMinPlayersAge);
            this.Controls.Add(this.lblMaxAge);
            this.Controls.Add(this.cbMaxPlayersAge);
            this.Controls.Add(this.lblMinAge);
            this.Controls.Add(this.cbPlayersNumber);
            this.Controls.Add(this.lblMaxPlayers);
            this.Controls.Add(this.nextScreenButton);
            this.Controls.Add(this.previousScreenButton);
            this.Name = "DefineUsersState";
            this.Size = new System.Drawing.Size(1090, 622);
            this.Load += new System.EventHandler(this.DefineUsersState_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private View.UserControls_Items.NextScreenButton nextScreenButton;
        private View.UserControls_Items.PreviousScreenButton previousScreenButton;
        private System.Windows.Forms.Label lblMaxPlayers;
        private System.Windows.Forms.ComboBox cbPlayersNumber;
        private System.Windows.Forms.ComboBox cbMaxPlayersAge;
        private System.Windows.Forms.Label lblMinAge;
        private System.Windows.Forms.ComboBox cbMinPlayersAge;
        private System.Windows.Forms.Label lblMaxAge;
    }
}

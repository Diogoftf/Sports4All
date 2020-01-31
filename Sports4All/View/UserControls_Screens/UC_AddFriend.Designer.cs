namespace Sports4All
{
    partial class UC_AddFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddFriend));
            this.tbFindFriends = new System.Windows.Forms.TextBox();
            this.lbFindFriends = new System.Windows.Forms.Label();
            this.pbFriends = new System.Windows.Forms.PictureBox();
            this.btnFindFriends = new System.Windows.Forms.Button();
            this.lvFindFriends = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbFriends)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFindFriends
            // 
            this.tbFindFriends.Location = new System.Drawing.Point(292, 138);
            this.tbFindFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFindFriends.Name = "tbFindFriends";
            this.tbFindFriends.Size = new System.Drawing.Size(227, 22);
            this.tbFindFriends.TabIndex = 1;
            // 
            // lbFindFriends
            // 
            this.lbFindFriends.AutoSize = true;
            this.lbFindFriends.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFindFriends.Location = new System.Drawing.Point(232, 79);
            this.lbFindFriends.Name = "lbFindFriends";
            this.lbFindFriends.Size = new System.Drawing.Size(247, 23);
            this.lbFindFriends.TabIndex = 3;
            this.lbFindFriends.Text = "Encontra os teus amigos";
            // 
            // pbFriends
            // 
            this.pbFriends.Image = ((System.Drawing.Image)(resources.GetObject("pbFriends.Image")));
            this.pbFriends.Location = new System.Drawing.Point(92, 10);
            this.pbFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFriends.Name = "pbFriends";
            this.pbFriends.Size = new System.Drawing.Size(134, 122);
            this.pbFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFriends.TabIndex = 4;
            this.pbFriends.TabStop = false;
            // 
            // btnFindFriends
            // 
            this.btnFindFriends.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnFindFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindFriends.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnFindFriends.Image = ((System.Drawing.Image)(resources.GetObject("btnFindFriends.Image")));
            this.btnFindFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindFriends.Location = new System.Drawing.Point(524, 120);
            this.btnFindFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindFriends.Name = "btnFindFriends";
            this.btnFindFriends.Size = new System.Drawing.Size(136, 55);
            this.btnFindFriends.TabIndex = 2;
            this.btnFindFriends.Text = "Procurar";
            this.btnFindFriends.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindFriends.UseVisualStyleBackColor = true;
            // 
            // lvFindFriends
            // 
            this.lvFindFriends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lvFindFriends.HideSelection = false;
            this.lvFindFriends.Location = new System.Drawing.Point(221, 172);
            this.lvFindFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvFindFriends.Name = "lvFindFriends";
            this.lvFindFriends.Size = new System.Drawing.Size(531, 290);
            this.lvFindFriends.TabIndex = 5;
            this.lvFindFriends.UseCompatibleStateImageBehavior = false;
            this.lvFindFriends.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 151;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Utilizador";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 248;
            // 
            // UC_AddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvFindFriends);
            this.Controls.Add(this.pbFriends);
            this.Controls.Add(this.lbFindFriends);
            this.Controls.Add(this.btnFindFriends);
            this.Controls.Add(this.tbFindFriends);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_AddFriend";
            this.Size = new System.Drawing.Size(1089, 622);
            ((System.ComponentModel.ISupportInitialize)(this.pbFriends)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFindFriends;
        private System.Windows.Forms.Button btnFindFriends;
        private System.Windows.Forms.Label lbFindFriends;
        private System.Windows.Forms.PictureBox pbFriends;
        private System.Windows.Forms.ListView lvFindFriends;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

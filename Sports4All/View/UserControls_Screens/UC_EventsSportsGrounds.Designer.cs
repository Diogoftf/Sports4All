namespace Sports4All
{
    partial class UC_EventsSportsGrounds
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
            this.flpEventListSportsground = new System.Windows.Forms.FlowLayoutPanel();
            this.plSportsgroundMenuSelect = new System.Windows.Forms.Panel();
            this.tbEvents_title = new System.Windows.Forms.TextBox();
            this.btnAllSports = new System.Windows.Forms.Button();
            this.btnHandball = new System.Windows.Forms.Button();
            this.btnTenis = new System.Windows.Forms.Button();
            this.btnFootball = new System.Windows.Forms.Button();
            this.plTopContent = new System.Windows.Forms.Panel();
            this.tbSportsgroundName = new System.Windows.Forms.TextBox();
            this.plSportsgroundMenuSelect.SuspendLayout();
            this.plTopContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpEventListSportsground
            // 
            this.flpEventListSportsground.AutoScroll = true;
            this.flpEventListSportsground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpEventListSportsground.Location = new System.Drawing.Point(41, 217);
            this.flpEventListSportsground.Name = "flpEventListSportsground";
            this.flpEventListSportsground.Size = new System.Drawing.Size(1010, 356);
            this.flpEventListSportsground.TabIndex = 22;
            // 
            // plSportsgroundMenuSelect
            // 
            this.plSportsgroundMenuSelect.Controls.Add(this.tbEvents_title);
            this.plSportsgroundMenuSelect.Controls.Add(this.btnAllSports);
            this.plSportsgroundMenuSelect.Controls.Add(this.btnHandball);
            this.plSportsgroundMenuSelect.Controls.Add(this.btnTenis);
            this.plSportsgroundMenuSelect.Controls.Add(this.btnFootball);
            this.plSportsgroundMenuSelect.Location = new System.Drawing.Point(41, 103);
            this.plSportsgroundMenuSelect.Name = "plSportsgroundMenuSelect";
            this.plSportsgroundMenuSelect.Size = new System.Drawing.Size(1010, 107);
            this.plSportsgroundMenuSelect.TabIndex = 21;
            // 
            // tbEvents_title
            // 
            this.tbEvents_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEvents_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEvents_title.Location = new System.Drawing.Point(3, 19);
            this.tbEvents_title.Name = "tbEvents_title";
            this.tbEvents_title.ReadOnly = true;
            this.tbEvents_title.Size = new System.Drawing.Size(205, 25);
            this.tbEvents_title.TabIndex = 4;
            this.tbEvents_title.Text = "Eventos Disponíveis:";
            // 
            // btnAllSports
            // 
            this.btnAllSports.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAllSports.Location = new System.Drawing.Point(210, 60);
            this.btnAllSports.Name = "btnAllSports";
            this.btnAllSports.Size = new System.Drawing.Size(113, 33);
            this.btnAllSports.TabIndex = 3;
            this.btnAllSports.Text = "Todos";
            this.btnAllSports.UseVisualStyleBackColor = true;
            this.btnAllSports.Click += new System.EventHandler(this.btnAllSports_Click);
            // 
            // btnHandball
            // 
            this.btnHandball.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnHandball.Location = new System.Drawing.Point(567, 60);
            this.btnHandball.Name = "btnHandball";
            this.btnHandball.Size = new System.Drawing.Size(113, 33);
            this.btnHandball.TabIndex = 2;
            this.btnHandball.Text = "Andebol";
            this.btnHandball.UseVisualStyleBackColor = true;
            this.btnHandball.Click += new System.EventHandler(this.btnHandball_Click);
            // 
            // btnTenis
            // 
            this.btnTenis.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnTenis.Location = new System.Drawing.Point(448, 60);
            this.btnTenis.Name = "btnTenis";
            this.btnTenis.Size = new System.Drawing.Size(113, 33);
            this.btnTenis.TabIndex = 1;
            this.btnTenis.Text = "Ténis";
            this.btnTenis.UseVisualStyleBackColor = true;
            this.btnTenis.Click += new System.EventHandler(this.btnTenis_Click);
            // 
            // btnFootball
            // 
            this.btnFootball.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnFootball.Location = new System.Drawing.Point(329, 60);
            this.btnFootball.Name = "btnFootball";
            this.btnFootball.Size = new System.Drawing.Size(113, 33);
            this.btnFootball.TabIndex = 0;
            this.btnFootball.Text = "Futebol";
            this.btnFootball.UseVisualStyleBackColor = true;
            this.btnFootball.Click += new System.EventHandler(this.btnFootball_Click);
            // 
            // plTopContent
            // 
            this.plTopContent.Controls.Add(this.tbSportsgroundName);
            this.plTopContent.Location = new System.Drawing.Point(41, 7);
            this.plTopContent.Name = "plTopContent";
            this.plTopContent.Size = new System.Drawing.Size(722, 93);
            this.plTopContent.TabIndex = 14;
            // 
            // tbSportsgroundName
            // 
            this.tbSportsgroundName.BackColor = System.Drawing.SystemColors.Control;
            this.tbSportsgroundName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSportsgroundName.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.tbSportsgroundName.Location = new System.Drawing.Point(3, 15);
            this.tbSportsgroundName.Name = "tbSportsgroundName";
            this.tbSportsgroundName.Size = new System.Drawing.Size(630, 35);
            this.tbSportsgroundName.TabIndex = 7;
            this.tbSportsgroundName.Text = "Complexo Desportivo Água de pena";
            // 
            // UC_EventsSportsGrounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plTopContent);
            this.Controls.Add(this.flpEventListSportsground);
            this.Controls.Add(this.plSportsgroundMenuSelect);
            this.Name = "UC_EventsSportsGrounds";
            this.Size = new System.Drawing.Size(1089, 622);
            this.Load += new System.EventHandler(this.UC_EventsSportsGrounds_Load);
            this.plSportsgroundMenuSelect.ResumeLayout(false);
            this.plSportsgroundMenuSelect.PerformLayout();
            this.plTopContent.ResumeLayout(false);
            this.plTopContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpEventListSportsground;
        private System.Windows.Forms.Panel plSportsgroundMenuSelect;
        private System.Windows.Forms.TextBox tbEvents_title;
        private System.Windows.Forms.Button btnAllSports;
        private System.Windows.Forms.Button btnHandball;
        private System.Windows.Forms.Button btnTenis;
        private System.Windows.Forms.Button btnFootball;
        private System.Windows.Forms.Panel plTopContent;
        private System.Windows.Forms.TextBox tbSportsgroundName;
    }
}
